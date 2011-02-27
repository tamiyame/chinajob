using System;
using System.Collections;
using System.Configuration;
using System.Data;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;


using Com.Framework.Data;
using Com.Framework.Cookie;
using Com.Library.Cookie;
using Com.Library.DB.Company;
using Com.Library.DB.User;
using Site.Web.WebException;

public partial class Login_LoginProc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string UserID = Request.Form["UserID"];
        string UserPWD = Request.Form["UserPWD"];
        string CodeType = Request.Form["CodeType"];
        string Redirect = Server.UrlDecode(Request.Form["Redirect"]);

        CookieParam param = new CookieParam();
        if (CodeType == "1")
        {
            CompanyEntity Entity = null;
            CompanyLoginArguments arg = new CompanyLoginArguments();
            arg.CompanyID = UserID;
            arg.Password = UserPWD;
            try
            {
                CompanyLogin login = new CompanyLogin();
                login.SetArguments(arg);
                login.ExecuteNonQuery();
                Entity = login.GetOutput();
            }
            catch (SPException spEx)
            {
                if (spEx.ErrorCode == 1)
                    throw new UserIDNotFoundException("Userid not found", spEx);
                else if (spEx.ErrorCode == 2)
                    throw new UserPWDException("password incorrect", spEx);
            }

            CompanyDetailGetInfoArguments infoArg = new CompanyDetailGetInfoArguments();
            infoArg.CompanyNo = Entity.CompanyNo;
            CompanyDetailGetInfo info = new CompanyDetailGetInfo();
            info.SetArguments(infoArg);
            info.ExecuteNonQuery();
            CompanyDetailEntity InfoEntity = info.GetOutput();

            param.Add("LoginType", "1");
            param.Add("IsAdmin", "0");
            param.Add("UserNo", Entity.CompanyNo.ToString());
            param.Add("UserID", UserID);
            param.Add("CountryNo", Entity.CountryNo.ToString());
            param.Add("UserName", InfoEntity.KRName + "|" + InfoEntity.CNName + "|" + InfoEntity.ENGName);
            param.Add("Email", InfoEntity.Email);
            WebCookie cookie = new WebCookie();
            cookie.SetEncCookie(param);
            
        }
        else
        {
            UserEntity Entity = null;
            UserLoginArguments arg = new UserLoginArguments();
            arg.UserID = UserID;
            arg.UserPWD = UserPWD;
            try
            {
                UserLogin login = new UserLogin();
                login.SetArguments(arg);
                login.ExecuteNonQuery();
                Entity = login.GetOutput();
            }
            catch (SPException spEx)
            {
                if (spEx.ErrorCode == 1)
                    throw new UserIDNotFoundException("Userid not found", spEx);
                else if (spEx.ErrorCode == 2)
                    throw new UserPWDException("password match error", spEx);
            }

            param.Add("LoginType", "2");
            param.Add("IsAdmin", Entity.IsAdmin.ToString());
            param.Add("UserNo", Entity.UserNo.ToString());
            param.Add("UserID", UserID);
            param.Add("CountryNo", "1");
            param.Add("UserName", Entity.KRName + "|" + Entity.CNName + "|" + Entity.ENGName);
            param.Add("Email", Entity.Email);
            WebCookie cookie = new WebCookie();
            cookie.SetEncCookie(param);
        }

        Response.Write("<script language='javascript'>location.href='" + Redirect + "'</script>");
    }
}

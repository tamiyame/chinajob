using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using Site.Web.Page;
using Site.Web.Util;
using Com.Library.DB.User;
using Com.Framework.File;

public partial class KR_User_human_modify : SitePage
{
    public UserEntity UserInfo = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Form.Enctype = "multipart/form-data";
        if (!this.WebCookies.IsLogin)
        {
            Response.Clear();
            Response.Write("<script language='javascript'>;location.href='" + GetURL("/home") + "'; alert('" + Message.Msg(this.WebMaster.CountryCode, k_MsgType.User_Login) + "');</script>");
            Response.End();
        }

        if (this.WebCookies.isCompany)
        {
            Response.Clear();
            Response.Write("<script language='javascript'>;location.href='" + GetURL("/home") + "'; alert('" + Message.Msg(this.WebMaster.CountryCode, k_MsgType.User) + "');</script>");
            Response.End();
        }
    }

    protected override void OnPreRender(EventArgs e)
    {
        UserGetInfoArguments infoArg = new UserGetInfoArguments();
        infoArg.UserNo = this.WebCookies.UserNo;
        UserGetInfo info = new UserGetInfo();
        info.SetArguments(infoArg);
        info.ExecuteNonQuery();
        UserInfo = info.GetOutput();
        base.OnPreRender(e);

        if (this.IsPostBack)
        {
            string KRName, CNName, ENGName, Birthday_Year, Birthday_Month, Birthday_Day;
            string UserID, UserPWD, Email, KRPhoneNo, CNPhoneNo, HomepageUrl;
            byte Gender, ResidanceCountry;

            KRName = Request.Form["KRName"];
            CNName = Request.Form["CNName"];
            ENGName = Request.Form["ENGName"];
            Birthday_Year = Request.Form["Birthday_Year"];
            Birthday_Month = Request.Form["Birthday_Month"];
            Birthday_Day = Request.Form["Birthday_Day"];
            UserID = Request.Form["UserID"];
            UserPWD = Request.Form["UserPWD"];
            Email = Request.Form["Email"];
            KRPhoneNo = Request.Form["KRPhoneNo"];
            CNPhoneNo = Request.Form["CNPhoneNo"];
            HomepageUrl = Request.Form["HomepageUrl"];
            string fileNameLog = string.Empty;

            Gender = Request.Form["Gender"] == null ? (byte)1 : Convert.ToByte(Request.Form["Gender"]);
            ResidanceCountry = Request.Form["ResidanceCountry"] == null ? (byte)1 : Convert.ToByte(Request.Form["ResidanceCountry"]);

            if (Request.Files["UserImage"] != null)
            {
                if (Request.Files["UserImage"].ContentLength > 0)
                {
                    fileNameLog = FileManager.Upload(Request.Files["UserImage"], WebCookies.UserNo, FileType.User);
                }
            }

            UserModifyArguments modifyArg = new UserModifyArguments();
            modifyArg.UserNo = WebCookies.UserNo;
            modifyArg.KRName = KRName;
            modifyArg.CNName = CNName;
            modifyArg.ENGName = ENGName;
            modifyArg.Birthday = Convert.ToDateTime(Birthday_Year + "-" + Birthday_Month + "-" + Birthday_Day);
            if (UserPWD != string.Empty)
            {
                modifyArg.UserPWD = UserPWD;
            }
            modifyArg.Email = Email;
            modifyArg.Gender = Gender;
            modifyArg.KRPhoneNo = KRPhoneNo;
            modifyArg.CNPhoneNo = CNPhoneNo;
            modifyArg.HomepageUrl = HomepageUrl;
            modifyArg.ResidanceCountry = ResidanceCountry;
            if (fileNameLog != string.Empty)
            {
                modifyArg.ImageUrl = fileNameLog;
            }
            UserModify modify = new UserModify();
            UserCreate create = new UserCreate();
            modify.SetArguments(modifyArg);
            modify.ExecuteNonQuery();

            

            Response.Clear();
            Response.Write("<script language='javascript'>location.href='" + this.GetURL("/home/") + "';alert('" + Message.Msg(this.WebMaster.CountryCode, k_MsgType.Modify_Confirm) + "');</script>");
        }
    }
}

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

public partial class KR_User_human_join : SitePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.WebCookies.IsLogin)
        {
            Response.Redirect(GetURL("/home/"));
        }

        if (!isUserCreate)
        {
            Response.Clear();
            Response.Write("<script language='javascript'>location.href='" + this.GetURL("/home/") + "';alert('" + Message.Msg(this.WebMaster.CountryCode, k_MsgType.UserJoinType) + "');</script>");
            Response.End();
        }

        this.Form.Enctype = "multipart/form-data";
    }

    protected override void OnPreRender(EventArgs e)
    {
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


            Gender = Request.Form["Gender"] == null ? (byte)1 : Convert.ToByte(Request.Form["Gender"]);
            ResidanceCountry = Request.Form["ResidanceCountry"] == null ? (byte)1 : Convert.ToByte(Request.Form["ResidanceCountry"]);

            UserCreateArguments createArg = new UserCreateArguments();
            createArg.KRName = KRName;
            createArg.CNName = CNName;
            createArg.ENGName = ENGName;
            createArg.Birthday = Convert.ToDateTime(Birthday_Year + "-" + Birthday_Month + "-" + Birthday_Day);
            createArg.UserID = UserID;
            createArg.UserPWD = UserPWD;
            createArg.Email = Email;
            createArg.Gender = Gender;
            createArg.KRPhoneNo = KRPhoneNo;
            createArg.CNPhoneNo = CNPhoneNo;
            createArg.HomepageUrl = HomepageUrl;
            createArg.ResidanceCountry = ResidanceCountry;
            createArg.ImageUrl = "/imgsrv/kr/images/base/human-photo.png";
            UserCreate create = new UserCreate();
            create.SetArguments(createArg);
            create.ExecuteNonQuery();
            UserEntity info = create.GetOutput();

            if (Request.Files["UserImage"] != null)
            {
                if (Request.Files["UserImage"].ContentLength > 0)
                {
                    string fileNameLog = FileManager.Upload(Request.Files["UserImage"], info.UserNo, FileType.User);
                    UserModifyArguments modifyArg = new UserModifyArguments();
                    modifyArg.UserNo = info.UserNo;
                    modifyArg.ImageUrl = fileNameLog;
                    UserModify modify = new UserModify();
                    modify.SetArguments(modifyArg);
                    modify.ExecuteNonQuery();
                }
            }

            Response.Clear();
            Response.Write("<script language='javascript'>location.href='" + this.GetURL("/home/") + "';alert('" + Message.Msg(this.WebMaster.CountryCode, k_MsgType.Write_Confirm) + "');</script>");
        }
    }
}

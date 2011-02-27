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
using Com.Framework.File;
using Com.Library.DB.Banner;
using Site.Web.Page;

using Com.Library.DB.Schedule;

public partial class Backoffice_Setting_Logo : SitePage
{
    public PageSettingEntity PageEntity = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Form.Enctype = "multipart/form-data";
    }

    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);
        if (this.IsPostBack)
        {
            string KRLogo = string.Empty;
            string CNLogo = string.Empty;
            string ENGLogo = string.Empty;
            string KRTitle = Request.Form["KRTitle"].ToString();
            string CNTitle = Request.Form["CNTitle"].ToString();
            string ENGTitle = Request.Form["ENGTitle"].ToString();
            if (Request.Files.Count > 0)
            {
                if (Request.Files["fiKRLogo"].ContentLength > 0)
                {
                    KRLogo = FileManager.UploadFor(Request.Files["fiKRLogo"], FileType.Title);
                }

                if (Request.Files["fiCNLogo"].ContentLength > 0)
                {
                    CNLogo = FileManager.UploadFor(Request.Files["fiCNLogo"], FileType.Title);
                }

                if (Request.Files["fiENGLogo"].ContentLength > 0)
                {
                    ENGLogo = FileManager.UploadFor(Request.Files["fiENGLogo"], FileType.Title);
                }
            }

            PageSettingSetArguments arg = new PageSettingSetArguments();
            if (KRLogo != string.Empty)
                arg.KRLogo = KRLogo;
            if (CNLogo != string.Empty)
                arg.CNLogo = CNLogo;
            if (ENGLogo != string.Empty)
                arg.ENGLogo = ENGLogo;
            arg.KRTitle = KRTitle;
            arg.CNTitle = CNTitle;
            arg.ENGTitle = ENGTitle;
            PageSettingSet set = new PageSettingSet();
            set.SetArguments(arg);
            set.ExecuteNonQuery();
        }

        PageSettingGetInfo info = new PageSettingGetInfo();
        info.ExecuteNonQuery();
        PageEntity = info.GetOutput();
    }
}

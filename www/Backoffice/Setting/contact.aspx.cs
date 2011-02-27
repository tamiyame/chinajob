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

using System.Web.Services;
using Com.Library.DB.Schedule;
public partial class Backoffice_Setting_contact : SitePage
{
    public PageSettingEntity PageEntity = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        PageSettingGetInfo info = new PageSettingGetInfo();
        info.ExecuteNonQuery();
        PageEntity = info.GetOutput();
    }

    [WebMethod]
    public static void PageSetting(string phoneNo, string FaxNo, string Email)
    {
        PageSettingSetArguments arg = new PageSettingSetArguments();
        arg.PhoneNo = phoneNo;
        arg.FaxNo = FaxNo;
        arg.Email = Email;
        PageSettingSet set = new PageSettingSet();
        set.SetArguments(arg);
        set.ExecuteNonQuery();
        
    }
}

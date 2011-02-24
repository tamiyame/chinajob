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
using Com.Library.DB.Menu;
public partial class CN_Info_Info : SitePage
{
    public SubMenuEntity SubMenuInfo = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        short TopMenuNo = Request.QueryString["TopMenuNo"] == null ? (short)1 : Convert.ToInt16(Request.QueryString["TopMenuNo"]);
        short SubMenuNo = Request.QueryString["SubMenuNo"] == null ? (short)1 : Convert.ToInt16(Request.QueryString["SubMenuNo"]);
        SubMenuGetInfoArguments arg = new SubMenuGetInfoArguments();
        arg.TopMenuNo = TopMenuNo;
        arg.SubMenuNo = SubMenuNo;
        arg.CountryNo = this.WebMaster.CountryCode;

        SubMenuGetInfo info = new SubMenuGetInfo();
        info.SetArguments(arg);
        info.ExecuteNonQuery();
        SubMenuInfo = info.GetOutput();
    }
}

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
using Com.Library.DB.Banner;

public partial class Backoffice_Banner_banner_delete : System.Web.UI.Page
{   
    public int BannerType = 0;
    public int Country = 0;
    public int Banner = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        BannerType = Request["BannerType"] == null ? 1 : Convert.ToInt32(Request["BannerType"]);
        Country = Request["Country"] == null ? 1 : Convert.ToInt32(Request["Country"]);
        Banner = Request.QueryString["BannerNo"] == null ? 0 : Convert.ToInt32(Request.QueryString["BannerNo"]);

        BannerRemove remove = new BannerRemove();
        remove.SetArguments(
            new BannerRemoveArguments()
            {
                BannerNo = Banner
            });
        remove.ExecuteNonQuery();
        Response.Write(string.Format("<script>window.location.replace('./banner_list.aspx?BannerType={0}&Country{1}')</script>",BannerType,Country));
    }
}

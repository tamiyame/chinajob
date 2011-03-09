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

using Site.Web.Page;

public partial class KR_Login_join_select : SitePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.WebCookies.IsLogin)
        {
            Response.Redirect(GetURL("/home/"));
        }
    }
}

using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;



using Com.Library.Page;
using Com.Library.Cookie;
namespace Site.Web.Page
{
    public class CNSiteMaster : SiteMaster
    {

         protected override void OnInit(EventArgs e)
        {
            this.CountryLink = "/CN";
            this.CountryCode = 2;
            base.OnInit(e);
        }
    }
}

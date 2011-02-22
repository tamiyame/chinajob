using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

using Com.Library.Page;
namespace Site.Web.Page
{
    public class SiteUserControl : WebUserControl
    {
        public new SitePage WebPage
        {
            get
            {
                if (this.Page != null)
                {
                    if (this.Page is SitePage)
                        return (SitePage)this.Page;
                    else
                        return null;
                }
                return null;
            }
        }

        public new SiteMaster WebMaster
        {
            get
            {
                if (this.Page.Master != null)
                {
                    if (this.Page.Master is SiteMaster)
                        return (SiteMaster)this.Page.Master;
                    else
                        return null;
                }
                return null;
            }
        }

        public string GetURL(string url)
        {
            return this.WebMaster.GetURL(url);
        }
    }
}
using System;
using System.Collections.Generic;

using System.Text;

using Com.Framework.Page;
using Com.Library.Cookie;

namespace Com.Library.Page
{
    public class WebUserControl :BaseUserControl
    {
        public WebPage WebPage
        {
            get
            {
                if (this.Page != null)
                {
                    if (this.Page is WebPage)
                        return (WebPage)this.Page;
                    else
                        return null;
                }
                return null;
            }
        }

        public WebMasterPage WebMaster
        {
            get
            {
                if (this.Page.Master != null)
                {
                    if (this.Page.Master is WebMasterPage)
                        return (WebMasterPage)this.Page.Master;
                    else
                        return null;
                }
                return null;
            }
        }

        private WebCookie m_WebCookie = null;
        public WebCookie WebCookies
        {
            get
            {
                return WebMaster.WebCookies;
            }
        }
    }
}

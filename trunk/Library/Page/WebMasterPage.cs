using System;
using System.Collections.Generic;

using System.Text;

using Com.Framework.Page;
using Com.Library.Cookie;

namespace Com.Library.Page
{
    public class WebMasterPage : BaseMasterPage
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

        private WebCookie m_WebCookie = null;
        public WebCookie WebCookies
        {
            get
            {
                if (m_WebCookie == null)
                {
                    m_WebCookie = new WebCookie();
                }

                return m_WebCookie;
            }
        }
    }
}

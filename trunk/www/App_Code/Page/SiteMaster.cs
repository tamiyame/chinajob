using System;
using System.Web;
using System.Data;
using System.Collections.Generic;

using Com.Library.Page;
using Com.Library.Cookie;

namespace Site.Web.Page
{
    public class SiteMaster : WebMasterPage
    {
        private int m_PageCategory = 0;
        public int PageCategory
        {
            get { return m_PageCategory; }
            set { this.m_PageCategory = value; }
        }

        private string m_CountryLink = string.Empty;
        public string CountryLink
        {
            get { return m_CountryLink; }
            set { this.m_CountryLink = value; }
        }

        private int m_CountryCode = 0;
        public int CountryCode
        {
            get { return m_CountryCode; }
            set { this.m_CountryCode = value; }
        }

        public string GetURL(string url)
        {
            return this.CountryLink + url;
        }

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
    }
}
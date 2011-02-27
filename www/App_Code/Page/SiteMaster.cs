using System;
using System.Web;
using System.Data;
using System.Collections.Generic;

using Com.Library.Page;
using Com.Library.Cookie;
using Com.Library.Translate;
using Com.Library.DB.Schedule;

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

		private TranslateHelper.ContryCode m_countryCode2 = TranslateHelper.ContryCode.KR;
		public TranslateHelper.ContryCode CountryCode2
		{
			get { return m_countryCode2; }
			set { m_countryCode2 = value; }
		}

        private PageSettingEntity m_PageEntity = null;
        public PageSettingEntity PageEntity
        {
            get { return m_PageEntity; }
            set { m_PageEntity = value; }
        }

        public string GetURL(string url)
        {
            return this.CountryLink + url;
        }

		public string GetText(string transCode)
		{
			return TranslateHelper.GetText(CountryCode2, transCode);
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

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            PageSettingGetInfo info = new PageSettingGetInfo();
            info.ExecuteNonQuery();
            m_PageEntity = info.GetOutput();
        }
    }
}
using System;
using System.Collections.Generic;

using System.Text;

using Com.Framework.Page;
using Com.Library.Cookie;
using Com.Framework.Error;

namespace Com.Library.Page
{
    public class WebPage : BasePage
    {
        private WebCookie m_WebCookie = null;
        public WebCookie WebCookies
        {
            get
            {
                if (WebMaster == null)
                {
                    if (m_WebCookie == null)
                    {
                        m_WebCookie = new WebCookie();
                    }
                }
                else
                {
                    this.m_WebCookie = this.WebMaster.WebCookies;
                }

                return m_WebCookie;
            }
        }

        public WebMasterPage WebMaster
        {
            get
            {
                if (this.Master != null)
                {
                    if (base.Master is WebMasterPage)
                        return (WebMasterPage)base.Master;
                    else
                        return null;
                }
                return null;
            }
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            if (!(this.Master is WebMasterPage))
            {
                throw new BaseException("마스터 페이지를 사용하지 않았습니다.", null);
            }
        }
    }
}

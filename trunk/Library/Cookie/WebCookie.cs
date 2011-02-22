using System;
using System.Collections.Generic;

using System.Text;
using System.Web;

using Com.Framework.Cookie;
using Com.Library.Util;

namespace Com.Library.Cookie
{
    public class WebCookie : BaseCookie
    {
        private string m_SC = string.Empty;
        public WebCookie()
            : base("chinajobgo.com")
        {
            GetCookie();
        }

        private bool m_isCompany = false;
        public bool isCompany
        {
            get { return m_isCompany; }
        }

        private bool m_IsAdmin = false;
        public bool IsAdmin
        {
            get { return m_IsAdmin; }
        }

        public bool IsLogin
        {
            get {
                if (UserID == string.Empty)
                    return false;
                return true;
            }
        }

        private int m_LoginType = 0;
        public int LoginType
        {
            get { return m_LoginType; }
        }

        private int m_UserNo = 0;
        public int UserNo
        {
            get { return m_UserNo; }
        }

        private string m_UserID = string.Empty;
        public string UserID
        {
            get { return m_UserID; }
        }

        private string m_UserName = string.Empty;
        public string UserName
        {
            get { return m_UserName; }
        }

        private string m_Email = string.Empty;
        public string Email
        {
            get { return m_Email; }
        }

        private int m_CountryNo = 0;
        public int CountryNo
        {
            get { return m_CountryNo; }
        }
        
        private void GetCookie()
        {
            if (m_SC == string.Empty)
            {
                m_SC = GetEncCookie("SC");
            }
            this.m_LoginType = GetData(m_SC, "LoginType") == string.Empty ? 0 : Convert.ToInt32(GetData(m_SC, "LoginType"));
            this.m_UserNo = GetData(m_SC, "UserNo") == string.Empty ? 0 : Convert.ToInt32(GetData(m_SC, "UserNo"));
            this.m_UserID = GetData(m_SC, "UserID");
            this.m_UserName = GetData(m_SC, "UserName");
            this.m_CountryNo = GetData(m_SC, "CountryNo") == string.Empty ? 0 : Convert.ToInt32(GetData(m_SC, "CountryNo"));
            this.m_Email = GetData(m_SC, "Email");
            this.m_IsAdmin = GetData(m_SC, "IsAdmin") == "0" ? false : true;

            if (m_LoginType == 1)
            {
                m_isCompany = true;
            }

            
        }

        public void ResetCookie()
        {
            GetCookie();
        }
    }
}

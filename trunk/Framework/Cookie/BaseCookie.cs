using System;
using System.Collections;
using System.Web;

namespace Com.Framework.Cookie
{
    public class BaseCookie : object
    {
        private string m_Domain = "";
        public BaseCookie(string domain)
        {
            m_Domain = domain;
        }

        public void SetCookie(string name, string value)
        {
            HttpResponse res = HttpContext.Current.Response;

            HttpCookie cookie = new HttpCookie(name, value);
            cookie.Domain = m_Domain;
            cookie.Path = "/";
            res.AppendCookie(cookie);
        }

        public string GetCookie(string name)
        {
            string retValue = string.Empty;
            HttpRequest req = HttpContext.Current.Request;
            HttpCookie cookie = req.Cookies[name];
            return cookie.Value;
        }

        public void SetEncCookie(string name, string value)
        {
            HttpResponse res = HttpContext.Current.Response;
            HttpCookie cookie = new HttpCookie(name, BaseCookieUtil.Encoding(value));
            cookie.Path = "/";
            cookie.Domain = m_Domain;
            res.AppendCookie(cookie);
        }

        public void SetEncCookie(CookieParam param)
        {
            Hashtable ht = param.GetParam();
            string sc = string.Empty;
            foreach (string key in ht.Keys)
            {
                if (sc != string.Empty)
                {
                    sc += ",";
                }
                sc += key.ToString() + "=" + ht[key].ToString();
            }
            //SetEncCookie(key.ToString(), ht[key].ToString());
            if (sc != string.Empty)
            {
                SetEncCookie("SC", sc);
            }
        }

        public string GetEncCookie(string name)
        {
            HttpRequest req = HttpContext.Current.Request;
            HttpCookie cookie = req.Cookies[name];
            if (cookie == null)
            {
                return string.Empty;
            }
            return BaseCookieUtil.Decoding(cookie.Value);
        }

        public virtual void Clear()
        {
            HttpResponse res = HttpContext.Current.Response;
            HttpRequest req = HttpContext.Current.Request;
            int cnt = req.Cookies.Count;
            for (int i = 0; i < cnt; i++)
            {
                HttpCookie cookie = req.Cookies[i];
                cookie.Value = "";
                cookie.Domain = m_Domain;
                cookie.Path = "/";
                cookie.Expires = DateTime.Now.AddMinutes(-1);
                res.Cookies.Add(cookie);
            }
        }

        public string GetData(string source, string key)
        {
            string[] arrSource = source.Split(',');
            foreach (string data in arrSource)
            {
                string[] arrData = data.Split('=');
                if (arrData.Length > 1)
                {
                    if (arrData[0].ToUpper() == key.ToUpper())
                    {
                        return arrData[1];
                    }
                }
            }

            return string.Empty;
        }
    }
}

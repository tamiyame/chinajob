using System;
using System.Collections;

using System.Text;

namespace Com.Framework.Cookie
{
    public class CookieParam
    {
        private Hashtable m_htParam = null;
        public CookieParam()
        {
            m_htParam = new Hashtable();
        }

        public void Add(string name, string value)
        {
            if (m_htParam.Contains(name))
                m_htParam[name] = value;
            else
                m_htParam.Add(name, value);
        }

        public Hashtable GetParam()
        {
            return m_htParam;
        }
    }
}

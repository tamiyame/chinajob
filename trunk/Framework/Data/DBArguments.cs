using System;
using System.Collections;
using System.Collections.Generic;

using System.Text;

namespace Com.Framework.Data
{
    public class DBArguments : Object, IArguments
    {
        private Hashtable m_HT = null; 
        public DBArguments()
        {
            m_HT = new Hashtable();
        }

        public void SetValue(string key, object value)
        {
            if (m_HT.Contains(key))
            {
                m_HT[key] = value;
            }
            else
            {
                m_HT.Add(key, value);
            }
        }

        public object GetValue(string key, object defaultValue)
        {
            if (m_HT.Contains(key))
            {
                return m_HT[key];
            }

            return defaultValue;
        }

        public Hashtable GetData()
        {
            return m_HT;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

using System.Text;

using System.Data;

namespace Com.Framework.Data
{
    [Serializable]
    public class DataEntity : object
    {
        private Hashtable m_ht = null;
        public DataEntity()
        {
            m_ht = new Hashtable();
        }

        public void SetData(string name, object value)
        {
            m_ht[name.ToLower()] = value;
        }

        public object GetData(string name, object defaultValue)
        {
            object retValue = null;

            if (m_ht != null)
            {
                try
                {
                    retValue = m_ht[name.ToLower()];
                    if (retValue == DBNull.Value || retValue == null)
                    {
                        retValue = defaultValue;
                    }
                }
                catch (Exception)
                {
                    retValue = defaultValue;
                }
            }
            return retValue;
        }
    }
}

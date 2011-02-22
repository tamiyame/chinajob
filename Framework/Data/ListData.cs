using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Framework.Data
{
    [Serializable]
    public class ListData<R, P> : object
        where R : DataEntity, new()
        where P : DataEntity, new()
    {
        private List<R> m_Records = null;
        private P m_Output = null;
        public ListData(List<R> record, P outputData)
        {
            m_Records = record;
            m_Output = outputData;
        }

        public List<R> Record
        {
            get { return m_Records; }
        }

        public P Output
        {
            get { return m_Output; }
        }
    }
}

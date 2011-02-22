using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Framework.Data
{
    public class OutputEntity : DataEntity
    {
        public int CntRow
        {
            get { return Convert.ToInt32(GetData("CntRow", 0)); }
        }

        public int CntTotal
        {
            get { return Convert.ToInt32(GetData("CntTotal", 0)); }
        }
    }
}

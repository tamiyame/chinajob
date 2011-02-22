using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Menu
{
    public class TopMenuEntity : DataEntity
    {
        public int CountryNo { get { return Convert.ToInt32(GetData("CountryNo", (int)0)); } }
        public short TopMenuNo { get { return Convert.ToInt16(GetData("TopMenuNo", (short)0)); } }
        public string TopMenuName { get { return Convert.ToString(GetData("TopMenuName", string.Empty)); } }
        public string TopImageUrl { get { return Convert.ToString(GetData("TopImageUrl", string.Empty)); } }
    }
}
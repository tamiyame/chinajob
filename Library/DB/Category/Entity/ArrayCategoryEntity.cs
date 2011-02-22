using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Category
{
    public class ArrayCategoryEntity : DataEntity
    {
        public int CityNo { get { return Convert.ToInt32(GetData("CityNo", (int)0)); } }
        public int ArrayNo { get { return Convert.ToInt32(GetData("ArrayNo", (int)0)); } }
        public string ArrayName { get { return Convert.ToString(GetData("ArrayName", string.Empty)); } }
    }
}
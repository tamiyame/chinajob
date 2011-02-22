using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Category
{
    public class CityCategoryEntity : DataEntity
    {
        public int CityNo { get { return Convert.ToInt32(GetData("CityNo", (int)0)); } }
        public int CountryNo { get { return Convert.ToInt32(GetData("CountryNo", (int)0)); } }
        public string CityName { get { return Convert.ToString(GetData("CityName", string.Empty)); } }
    }
}
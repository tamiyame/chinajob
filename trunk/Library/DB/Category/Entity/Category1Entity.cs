using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Category
{
    public class Category1Entity : DataEntity
    {
        public int Category1No { get { return Convert.ToInt32(GetData("Category1No", (int)0)); } }
        public int CountryNo { get { return Convert.ToInt32(GetData("CountryNo", (int)0)); } }
        public string Category1Name { get { return Convert.ToString(GetData("Category1Name", string.Empty)); } }
    }
}
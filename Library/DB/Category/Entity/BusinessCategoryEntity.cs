using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Category
{
    public class BusinessCategoryEntity : DataEntity
    {
        public int BusinessCategoryNo { get { return Convert.ToInt32(GetData("BusinessCategoryNo", (int)0)); } }
        public int CountryNo { get { return Convert.ToInt32(GetData("CountryNo", (int)0)); } }
        public string CategoryName { get { return Convert.ToString(GetData("CategoryName", string.Empty)); } }
    }
}
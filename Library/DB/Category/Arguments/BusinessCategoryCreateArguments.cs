using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Category
{
    public class BusinessCategoryCreateArguments : DBArguments
    {
        public int CountryNo
        {
            get { return Convert.ToInt32(GetValue("CountryNo", 0)); }
            set { SetValue("CountryNo", value); }
        }

        public string CategoryName
        {
            get { return Convert.ToString(GetValue("CategoryName", string.Empty)); }
            set { SetValue("CategoryName", value); }
        }
    }
}
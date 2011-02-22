using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Category
{
    public class Category1CreateArguments : DBArguments
    {
        public int CountryNo
        {
            get { return Convert.ToInt32(GetValue("CountryNo", 0)); }
            set { SetValue("CountryNo", value); }
        }

        public string Category1Name
        {
            get { return Convert.ToString(GetValue("Category1Name", string.Empty)); }
            set { SetValue("Category1Name", value); }
        }
    }
}
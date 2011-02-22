using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Category
{
    public class CityCategoryCreateArguments : DBArguments
    {
        public int CountryNo
        {
            get { return Convert.ToInt32(GetValue("CountryNo", 0)); }
            set { SetValue("CountryNo", value); }
        }

        public string CityName
        {
            get { return Convert.ToString(GetValue("CityName", string.Empty)); }
            set { SetValue("CityName", value); }
        }
    }
}
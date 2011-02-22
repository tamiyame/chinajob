using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Company
{
    public class CityCategoryModifyArguments : DBArguments
    {
        public int CityNo
        {
            get { return Convert.ToInt32(GetValue("CityNo", 0)); }
            set { SetValue("CityNo", value); }
        }

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
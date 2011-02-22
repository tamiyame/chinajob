using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Category
{
    public class CityCategoryGetInfoArguments : DBArguments
    {
        public int CityNo
        {
            get { return Convert.ToInt32(GetValue("CityNo", 0)); }
            set { SetValue("CityNo", value); }
        }
    }
}
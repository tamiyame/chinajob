using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Category
{
    public class ArrayCategoryModifyArguments : DBArguments
    {
        public int CityNo
        {
            get { return Convert.ToInt32(GetValue("CityNo", 0)); }
            set { SetValue("CityNo", value); }
        }

        public int ArrayNo
        {
            get { return Convert.ToInt32(GetValue("ArrayNo", 0)); }
            set { SetValue("ArrayNo", value); }
        }

        public string ArrayName
        {
            get { return Convert.ToString(GetValue("ArrayName", string.Empty)); }
            set { SetValue("ArrayName", value); }
        }
    }
}
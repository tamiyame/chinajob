using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Category
{
    public class ArrayCategoryGetListArguments : DBArguments
    {
        public int CityNo
        {
            get { return Convert.ToInt32(GetValue("CityNo", 0)); }
            set { SetValue("CityNo", value); }
        }

        public int PageNo
        {
            get { return Convert.ToInt32(GetValue("PageNo", 0)); }
            set { SetValue("PageNo", value); }
        }

        public byte PageSize
        {
            get { return Convert.ToByte(GetValue("PageSize", (byte)0)); }
            set { SetValue("PageSize", value); }
        }
    }
}
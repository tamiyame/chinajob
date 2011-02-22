using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Banner
{
    public class BannerGetListArguments : DBArguments
    {
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

        public int CountryNo
        {
            get { return Convert.ToInt32(GetValue("CountryNo", 0)); }
            set { SetValue("CountryNo", value); }
        }

        public byte BannerType
        {
            get { return Convert.ToByte(GetValue("BannerType", (byte)0)); }
            set { SetValue("BannerType", value); }
        }

        public int IsOperation
        {
            get { return Convert.ToInt32(GetValue("IsOperation", 0)); }
            set { SetValue("IsOperation", value); }
        }
    }
}
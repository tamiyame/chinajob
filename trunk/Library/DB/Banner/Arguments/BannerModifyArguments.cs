using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Banner
{
    public class BannerModifyArguments : DBArguments
    {
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

        public int BannerNo
        {
            get { return Convert.ToInt32(GetValue("BannerNo", 0)); }
            set { SetValue("BannerNo", value); }
        }

        public string LargeImageURL
        {
            get { return Convert.ToString(GetValue("LargeImageURL", string.Empty)); }
            set { SetValue("LargeImageURL", value); }
        }

        public string SmallImageUrl
        {
            get { return Convert.ToString(GetValue("SmallImageUrl", string.Empty)); }
            set { SetValue("SmallImageUrl", value); }
        }

        public string Link
        {
            get { return Convert.ToString(GetValue("Link", string.Empty)); }
            set { SetValue("Link", value); }
        }

        public int OrderNo
        {
            get { return Convert.ToInt32(GetValue("OrderNo", 0)); }
            set { SetValue("OrderNo", value); }
        }

        public int IsView
        {
            get { return Convert.ToInt32(GetValue("IsView", 0)); }
            set { SetValue("IsView", value); }
        }
    }
}
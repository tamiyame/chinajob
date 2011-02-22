using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Banner
{
    public class BannerCreateArguments : DBArguments
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

        public DateTime DateCreated
        {
            get { return Convert.ToDateTime(GetValue("DateCreated",DateTime.MinValue )); }
            set { SetValue("DateCreated", value); }
        }

        public int OrderNo
        {
            get { return Convert.ToInt32(GetValue("OrderNo", 0)); }
            set { SetValue("OrderNo", value); }
        }
    }
}
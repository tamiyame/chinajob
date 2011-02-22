using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Banner
{
    public class BannerEntity : DataEntity
    {
        public int CountryNo { get { return Convert.ToInt32(GetData("CountryNo", (int)0)); } }
        public byte BannerType { get { return Convert.ToByte(GetData("BannerType", (byte)0)); } }
        public int BannerNo { get { return Convert.ToInt32(GetData("BannerNo", (int)0)); } }
        public string LargeImageURL { get { return Convert.ToString(GetData("LargeImageURL", string.Empty)); } }
        public string SmallImageUrl { get { return Convert.ToString(GetData("SmallImageUrl", string.Empty)); } }
        public string Link { get { return Convert.ToString(GetData("Link", string.Empty)); } }
        public DateTime DateCreated { get { return Convert.ToDateTime(GetData("DateCreated", DateTime.MinValue)); } }
        public int OrderNo { get { return Convert.ToInt32(GetData("OrderNo", (int)0)); } }
        public int IsView { get { return Convert.ToInt32(GetData("IsView", (int)0)); } }
    }
}
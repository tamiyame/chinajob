using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Banner
{
    public class BannerGetInfoArguments : DBArguments
    {
        public  int BannerNo
        {
            get { return Convert.ToInt32(GetValue("BannerNo",0 )); }
            set { SetValue("BannerNo", value); }
        }
    }
}
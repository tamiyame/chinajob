using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Menu
{
    public class TopMenuModifyArguments : DBArguments
    {
        public int CountryNo
        {
            get { return Convert.ToInt32(GetValue("CountryNo", 0)); }
            set { SetValue("CountryNo", value); }
        }

        public short TopMenuNo
        {
            get { return Convert.ToInt16(GetValue("TopMenuNo", (short)0)); }
            set { SetValue("TopMenuNo", value); }
        }

        public string TopMenuName
        {
            get { return Convert.ToString(GetValue("TopMenuName", string.Empty)); }
            set { SetValue("TopMenuName", value); }
        }

        public string TopImageUrl
        {
            get { return Convert.ToString(GetValue("TopImageUrl", string.Empty)); }
            set { SetValue("TopImageUrl", value); }
        }
    }
}
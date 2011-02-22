using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Menu
{
    public class SubMenuGetListArguments : DBArguments
    {
        public short TopMenuNo
        {
            get { return Convert.ToInt16(GetValue("TopMenuNo", (short)0)); }
            set { SetValue("TopMenuNo", value); }
        }
    }
}
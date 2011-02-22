using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Board
{
    public class BoardGetListArguments : DBArguments
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

        public byte Status
        {
            get { return Convert.ToByte(GetValue("Status", (byte)0)); }
            set { SetValue("Status", value); }
        }
    }
}
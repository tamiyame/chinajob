using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Board
{
    public class BoardCreateArguments : DBArguments
    {
        public string BoardName
        {
            get { return Convert.ToString(GetValue("BoardName", string.Empty)); }
            set { SetValue("BoardName", value); }
        }

        public byte PageSize
        {
            get { return Convert.ToByte(GetValue("PageSize", (byte)0)); }
            set { SetValue("PageSize", value); }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Board
{
    public class BoardModifyArguments : DBArguments
    {
        public int BoardNo
        {
            get { return Convert.ToInt32(GetValue("BoardNo", 0)); }
            set { SetValue("BoardNo", value); }
        }

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
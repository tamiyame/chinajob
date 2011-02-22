using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Board
{
    public class ArticleGetInfoArguments : DBArguments
    {
        public int BoardNo
        {
            get { return Convert.ToInt32(GetValue("BoardNo", 0)); }
            set { SetValue("BoardNo", value); }
        }

        public int ArticleNo
        {
            get { return Convert.ToInt32(GetValue("ArticleNo", 0)); }
            set { SetValue("ArticleNo", value); }
        }

        public byte _AddReadCount
        {
            get { return Convert.ToByte(GetValue("_AddReadCount", (byte)0)); }
            set { SetValue("_AddReadCount", value); }
        }
    }
}
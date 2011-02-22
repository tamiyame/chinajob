﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Board
{
    public class BoardCategoryRemoveArguments : DBArguments
    {
        public int BoardNo
        {
            get { return Convert.ToInt32(GetValue("BoardNo", 0)); }
            set { SetValue("BoardNo", value); }
        }

        public int BoardCategoryNo
        {
            get { return Convert.ToInt32(GetValue("BoardCategoryNo", 0)); }
            set { SetValue("BoardCategoryNo", value); }
        }
    }
}
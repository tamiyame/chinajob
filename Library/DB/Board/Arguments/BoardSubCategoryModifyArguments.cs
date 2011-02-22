using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Board
{
    public class BoardSubCategoryModifyArguments : DBArguments
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

        public int BoardSubCategoryNo
        {
            get { return Convert.ToInt32(GetValue("BoardSubCategoryNo", 0)); }
            set { SetValue("BoardSubCategoryNo", value); }
        }

        public string SubCategoryName
        {
            get { return Convert.ToString(GetValue("SubCategoryName", string.Empty)); }
            set { SetValue("SubCategoryName", value); }
        }
    }
}
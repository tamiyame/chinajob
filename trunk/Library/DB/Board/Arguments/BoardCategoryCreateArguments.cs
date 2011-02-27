using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Board
{
    public class BoardCategoryCreateArguments : DBArguments
    {
        public int BoardNo
        {
            get { return Convert.ToInt32(GetValue("BoardNo", 0)); }
            set { SetValue("BoardNo", value); }
        }

        public string CategoryName
        {
            get { return Convert.ToString(GetValue("CategoryName", string.Empty)); }
            set { SetValue("CategoryName", value); }
        }

        public string CategoryCNName
        {
            get { return Convert.ToString(GetValue("CategoryCNName", string.Empty)); }
            set { SetValue("CategoryCNName", value); }
        }

        public string CategoryENGName
        {
            get { return Convert.ToString(GetValue("CategoryENGName", string.Empty)); }
            set { SetValue("CategoryENGName", value); }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Category
{
    public class SubCategoryRemoveArguments : DBArguments
    {
        public int SubCategoryNo
        {
            get { return Convert.ToInt32(GetValue("SubCategoryNo", 0)); }
            set { SetValue("SubCategoryNo", value); }
        }
    }
}
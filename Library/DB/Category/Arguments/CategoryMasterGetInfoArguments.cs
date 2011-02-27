using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Category
{
    public class CategoryMasterGetInfoArguments : DBArguments
    {
        public int CategoryMasterNo
        {
            get { return Convert.ToInt32(GetValue("CategoryMasterNo", 0)); }
            set { SetValue("CategoryMasterNo", value); }
        }
    }
}
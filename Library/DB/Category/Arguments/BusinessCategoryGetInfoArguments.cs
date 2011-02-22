using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Category
{
    public class BusinessCategoryGetInfoArguments : DBArguments
    {
        public int BusinessCategoryNo
        {
            get { return Convert.ToInt32(GetValue("BusinessCategoryNo", 0)); }
            set { SetValue("BusinessCategoryNo", value); }
        }
    }
}
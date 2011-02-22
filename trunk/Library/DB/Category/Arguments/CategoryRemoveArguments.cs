using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Category
{
    public class CategoryRemoveArguments : DBArguments
    {
        public int CategoryNo
        {
            get { return Convert.ToInt32(GetValue("CategoryNo", 0)); }
            set { SetValue("CategoryNo", value); }
        }
    }
}
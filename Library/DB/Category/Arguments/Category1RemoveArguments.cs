using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Category
{
    public class Category1RemoveArguments : DBArguments
    {
        public int Category1No
        {
            get { return Convert.ToInt32(GetValue("Category1No", 0)); }
            set { SetValue("Category1No", value); }
        }
    }
}
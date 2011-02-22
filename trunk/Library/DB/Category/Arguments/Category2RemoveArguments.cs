using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Category
{
    public class Category2RemoveArguments : DBArguments
    {
        public int Category2No
        {
            get { return Convert.ToInt32(GetValue("Category2No", 0)); }
            set { SetValue("Category2No", value); }
        }
    }
}
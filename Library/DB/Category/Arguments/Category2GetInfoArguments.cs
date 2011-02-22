using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Company
{
    public class Category2GetInfoArguments : DBArguments
    {
        public int Category2No
        {
            get { return Convert.ToInt32(GetValue("Category2No", 0)); }
            set { SetValue("Category2No", value); }
        }

        public int Category1No
        {
            get { return Convert.ToInt32(GetValue("Category1No", 0)); }
            set { SetValue("Category1No", value); }
        }
    }
}
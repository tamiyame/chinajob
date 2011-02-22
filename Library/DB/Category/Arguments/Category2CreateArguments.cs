using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Company
{
    public class Category2CreateArguments : DBArguments
    {
        public int Category1No
        {
            get { return Convert.ToInt32(GetValue("Category1No", 0)); }
            set { SetValue("Category1No", value); }
        }

        public string Category2Name
        {
            get { return Convert.ToString(GetValue("Category2Name", string.Empty)); }
            set { SetValue("Category2Name", value); }
        }
    }
}
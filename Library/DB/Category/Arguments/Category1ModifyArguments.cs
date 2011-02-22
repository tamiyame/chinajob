using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Category
{
    public class Category1ModifyArguments : DBArguments
    {
        public int Category1No
        {
            get { return Convert.ToInt32(GetValue("Category1No", 0)); }
            set { SetValue("Category1No", value); }
        }

        public string Category1Name
        {
            get { return Convert.ToString(GetValue("Category1Name", string.Empty)); }
            set { SetValue("Category1Name", value); }
        }
    }
}
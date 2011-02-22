using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Category
{
    public class Category2Entity : DataEntity
    {
        public int Category2No { get { return Convert.ToInt32(GetData("Category2No", (int)0)); } }
        public int Category1No { get { return Convert.ToInt32(GetData("Category1No", (int)0)); } }
        public string Category2Name { get { return Convert.ToString(GetData("Category2Name", string.Empty)); } }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Category
{
    public class CategoryMasterEntity : DataEntity
    {
        public int CategoryMasterNo { get { return Convert.ToInt32(GetData("CategoryMasterNo", (int)0)); } }
        public string CategoryMasterName { get { return Convert.ToString(GetData("CategoryMasterName", string.Empty)); } }
        public byte IsSubCategory { get { return Convert.ToByte(GetData("IsSubCategory", (byte)0)); } }
        public byte Status { get { return Convert.ToByte(GetData("Status", (byte)0)); } }
    }
}
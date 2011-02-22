using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Category
{
    public class CategoryEntity : DataEntity
    {
        public int CategoryMasterNo { get { return Convert.ToInt32(GetData("CategoryMasterNo", (int)0)); } }
        public int CategoryNo { get { return Convert.ToInt32(GetData("CategoryNo", (int)0)); } }
        public string CategoryKRName { get { return Convert.ToString(GetData("CategoryKRName", string.Empty)); } }
        public string CategoryCNName { get { return Convert.ToString(GetData("CategoryCNName", string.Empty)); } }
        public string CategoryENGName { get { return Convert.ToString(GetData("CategoryENGName", string.Empty)); } }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Category
{
    public class SubCategoryEntity : DataEntity
    {
        public int CategoryNo { get { return Convert.ToInt32(GetData("CategoryNo", (int)0)); } }
        public int SubCategoryNo { get { return Convert.ToInt32(GetData("SubCategoryNo", (int)0)); } }
        public string SubCategoryKRName { get { return Convert.ToString(GetData("SubCategoryKRName", string.Empty)); } }
        public string SubCategoryCNName { get { return Convert.ToString(GetData("SubCategoryCNName", string.Empty)); } }
        public string SubCategoryENGName { get { return Convert.ToString(GetData("SubCategoryENGName", string.Empty)); } }
    }
}
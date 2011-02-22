using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Category
{
    public class SubCategoryCreateArguments : DBArguments
    {
        public int CategoryNo
        {
            get { return Convert.ToInt32(GetValue("CategoryNo", 0)); }
            set { SetValue("CategoryNo", value); }
        }

        public string SubCategoryKRName
        {
            get { return Convert.ToString(GetValue("SubCategoryKRName", string.Empty)); }
            set { SetValue("SubCategoryKRName", value); }
        }

        public string SubCategoryCNName
        {
            get { return Convert.ToString(GetValue("SubCategoryCNName", string.Empty)); }
            set { SetValue("SubCategoryCNName", value); }
        }

        public string SubCategoryENGName
        {
            get { return Convert.ToString(GetValue("SubCategoryENGName", string.Empty)); }
            set { SetValue("SubCategoryENGName", value); }
        }
    }
}
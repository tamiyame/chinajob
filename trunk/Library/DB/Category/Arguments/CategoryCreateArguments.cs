using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Category
{
    public class CategoryCreateArguments : DBArguments
    {
        public int CategoryMasterNo
        {
            get { return Convert.ToInt32(GetValue("CategoryMasterNo", 0)); }
            set { SetValue("CategoryMasterNo", value); }
        }

        public string CategoryKRName
        {
            get { return Convert.ToString(GetValue("CategoryKRName", string.Empty)); }
            set { SetValue("CategoryKRName", value); }
        }

        public string CategoryCNName
        {
            get { return Convert.ToString(GetValue("CategoryCNName", string.Empty)); }
            set { SetValue("CategoryCNName", value); }
        }

        public string CategoryENGName
        {
            get { return Convert.ToString(GetValue("CategoryENGName", string.Empty)); }
            set { SetValue("CategoryENGName", value); }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Category
{
    public class SubCategoryModifyArguments : DBArguments
    {
        public int CategoryNo
        {
            get { return Convert.ToInt32(GetValue("CategoryNo", 0)); }
            set { SetValue("CategoryNo", value); }
        }

        public int SubCategoryNo
        {
            get { return Convert.ToInt32(GetValue("SubCategoryNo", 0)); }
            set { SetValue("SubCategoryNo", value); }
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

        public int RecruitCount
        {
            get { return Convert.ToInt32(GetValue("RecruitCount", 0)); }
            set { SetValue("RecruitCount", value); }
        }
    }
}
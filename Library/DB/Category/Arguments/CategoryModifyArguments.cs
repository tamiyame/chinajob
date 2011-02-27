using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Category
{
    public class CategoryModifyArguments : DBArguments
    {
        public int CategoryMasterNo
        {
            get { return Convert.ToInt32(GetValue("CategoryMasterNo", 0)); }
            set { SetValue("CategoryMasterNo", value); }
        }

        public int CategoryNo
        {
            get { return Convert.ToInt32(GetValue("CategoryNo", 0)); }
            set { SetValue("CategoryNo", value); }
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

        public int RecruitCount
        {
            get { return Convert.ToInt32(GetValue("RecruitCount", 0)); }
            set { SetValue("RecruitCount", value); }
        }
    }
}
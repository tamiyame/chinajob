using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Company
{
    public class RecruitMasterGetInfoArguments : DBArguments
    {
        public int CompanyNo
        {
            get { return Convert.ToInt32(GetValue("CompanyNo", 0)); }
            set { SetValue("CompanyNo", value); }
        }

        public int RecruitNo
        {
            get { return Convert.ToInt32(GetValue("RecruitNo", 0)); }
            set { SetValue("RecruitNo", value); }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Company
{
    public class RecruitMasterCreateArguments : DBArguments
    {
        public int CompanyNo
        {
            get { return Convert.ToInt32(GetValue("CompanyNo", 0)); }
            set { SetValue("CompanyNo", value); }
        }

        public string RecruitTitle
        {
            get { return Convert.ToString(GetValue("RecruitTitle", string.Empty)); }
            set { SetValue("RecruitTitle", value); }
        }
    }
}
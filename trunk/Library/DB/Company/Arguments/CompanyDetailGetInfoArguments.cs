using System;
using System.Collections.Generic;

using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Company
{
    public class CompanyDetailGetInfoArguments : DBArguments
    {
        public int CompanyNo
        {
            get { return Convert.ToInt32(GetValue("CompanyNo", 0)); }
            set { SetValue("CompanyNo", value); }
        }

        public string PermitNo
        {
            get { return Convert.ToString(GetValue("PermitNo", string.Empty)); }
            set { SetValue("PermitNo", value); }
        }

        public string Email
        {
            get { return Convert.ToString(GetValue("Email", string.Empty)); }
            set { SetValue("Email", value); }
        }
    }
}
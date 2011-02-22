using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Company
{
    public class CompanyModifyArguments : DBArguments
    {
        public int CompanyNo
        {
            get { return Convert.ToInt32(GetValue("CompanyNo", 0)); }
            set { SetValue("CompanyNo", value); }
        }

        public string CompanyID
        {
            get { return Convert.ToString(GetValue("CompanyID", string.Empty)); }
            set { SetValue("CompanyID", value); }
        }

        public string Password
        {
            get { return Convert.ToString(GetValue("Password", string.Empty)); }
            set { SetValue("Password", value); }
        }

        public int CountryNo
        {
            get { return Convert.ToInt32(GetValue("CountryNo", 0)); }
            set { SetValue("CountryNo", value); }
        }

        public byte Status
        {
            get { return Convert.ToByte(GetValue("Status", (byte)0)); }
            set { SetValue("Status", value); }
        }

        public byte Approval
        {
            get { return Convert.ToByte(GetValue("Approval", (byte)0)); }
            set { SetValue("Approval", value); }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.User
{
    public class ResumeLicenseCreateArguments : DBArguments
    {

        public int ResumeNo
        {
            get { return Convert.ToInt32(GetValue("ResumeNo", 0)); }
            set { SetValue("ResumeNo", value); }
        }

        public DateTime LicensedDate
        {
            get { return Convert.ToDateTime(GetValue("LicensedDate",DateTime.MinValue )); }
            set { SetValue("LicensedDate", value); }
        }

        public string LicenseName
        {
            get { return Convert.ToString(GetValue("LicenseName", string.Empty)); }
            set { SetValue("LicenseName", value); }
        }

        public string Organization
        {
            get { return Convert.ToString(GetValue("Organization", string.Empty)); }
            set { SetValue("Organization", value); }
        }
    }
}
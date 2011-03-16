using System;

using Com.Framework.Data;

namespace Com.Library.DB.User
{
    public class ResumeLicenseCreateArguments : DBArguments
    {

        public int UserNo
        {
			get { return Convert.ToInt32(GetValue("UserNo", 0)); }
			set { SetValue("UserNo", value); }
        }

		public int CountryNo
		{
			get { return Convert.ToInt32(GetValue("CountryNo", 0)); }
			set { SetValue("CountryNo", value); }
		}

        public string LicensedDate
        {
            get { return Convert.ToString(GetValue("LicensedDate",string.Empty )); }
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
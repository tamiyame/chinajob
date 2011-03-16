using System;
using Com.Framework.Data;

namespace Com.Library.DB.User
{
	public class ResumeLicenseEntity : DataEntity
	{
        public int UserNo { get { return Convert.ToInt32(GetData("UserNo", (int)0)); } set { SetData("UserNo", value); } }
        public int CountryNo { get { return Convert.ToInt32(GetData("CountryNo", (int)0)); } set { SetData("CountryNo", value); } }
        public int ResumeLicenseNo { get { return Convert.ToInt32(GetData("ResumeLicenseNo", (int)0)); } set { SetData("ResumeLicenseNo", value); } }
		public string LicensedDate { get { return Convert.ToString(GetData("LicensedDate", string.Empty)); } set { SetData("LicensedDate", value); } }
        public string LicenseName { get { return Convert.ToString(GetData("LicenseName", string.Empty)); } set { SetData("LicenseName", value); } }
        public string Organization { get { return Convert.ToString(GetData("Organization", string.Empty)); } set { SetData("Organization", value); } }
	}
}

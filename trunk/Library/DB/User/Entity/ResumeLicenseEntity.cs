using System;
using Com.Framework.Data;

namespace Com.Library.DB.User
{
	public class ResumeLicenseEntity : DataEntity
	{
		public int UserNo { get { return Convert.ToInt32(GetData("UserNo", (int)0)); } }
		public int CountryNo { get { return Convert.ToInt32(GetData("CountryNo", (int)0)); } }
		public int ResumeLicenseNo { get { return Convert.ToInt32(GetData("ResumeLicenseNo", (int)0)); } }
		public DateTime LicensedDate { get { return Convert.ToDateTime(GetData("LicensedDate", DateTime.MinValue)); } }
		public string LicenseName { get { return Convert.ToString(GetData("LicenseName", string.Empty)); } }
		public string Organization { get { return Convert.ToString(GetData("Organization", string.Empty)); } }
	}
}

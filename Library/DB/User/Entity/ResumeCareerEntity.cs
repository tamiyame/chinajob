using System;
using Com.Framework.Data;

namespace Com.Library.DB.User
{
	public class ResumeCareerEntity : DataEntity
	{
		public int UserNo { get { return Convert.ToInt32(GetData("UserNo", (int)0)); } }
		public int CountryNo { get { return Convert.ToInt32(GetData("CountryNo", (int)0)); } }
		public int ResumeCareerNo { get { return Convert.ToInt32(GetData("ResumeCareerNo", (int)0)); } }
		public string CareerCompanyName { get { return Convert.ToString(GetData("CareerCompanyName", string.Empty)); } }
		public DateTime CareerStartDate { get { return Convert.ToDateTime(GetData("CareerStartDate", DateTime.MinValue)); } }
		public DateTime CareerEndDate { get { return Convert.ToDateTime(GetData("CareerEndDate", DateTime.MaxValue)); } }
		public string CareerJobs { get { return Convert.ToString(GetData("CareerJobs", string.Empty)); } }
		public string CareerPosition { get { return Convert.ToString(GetData("CareerPosition", string.Empty)); } }
	}
}

using System;
using Com.Framework.Data;

namespace Com.Library.DB.User
{
	public class ResumeCareerEntity : DataEntity
	{
        public int UserNo { get { return Convert.ToInt32(GetData("UserNo", (int)0)); } set { SetData("UserNo", value); } }
        public int CountryNo { get { return Convert.ToInt32(GetData("CountryNo", (int)0)); } set { SetData("CountryNo", value); } }
        public int ResumeCareerNo { get { return Convert.ToInt32(GetData("ResumeCareerNo", (int)0)); } set { SetData("ResumeCareerNo", value); } }
        public string CareerCompanyName { get { return Convert.ToString(GetData("CareerCompanyName", string.Empty)); } set { SetData("CareerCompanyName", value); } }
		public string CareerStartDate { get { return Convert.ToString(GetData("CareerStartDate", string.Empty)); } set { SetData("CareerStartDate", value); } }
		public string CareerEndDate { get { return Convert.ToString(GetData("CareerEndDate", string.Empty)); } set { SetData("CareerEndDate", value); } }
        public string CareerJobs { get { return Convert.ToString(GetData("CareerJobs", string.Empty)); } set { SetData("CareerJobs", value); } }
        public string CareerPosition { get { return Convert.ToString(GetData("CareerPosition", string.Empty)); } set { SetData("CareerPosition", value); } }
		public string CareerLocation { get { return Convert.ToString(GetData("CareerLocation", string.Empty)); } set { SetData("CareerLocation", value); } }
	}
}

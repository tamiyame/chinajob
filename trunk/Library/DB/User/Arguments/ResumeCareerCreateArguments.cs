using System;

using Com.Framework.Data;

namespace Com.Library.DB.User
{
    public class ResumeCareerCreateArguments : DBArguments
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

		public string CareerCompanyName
        {
            get { return Convert.ToString(GetValue("CareerCompanyName", string.Empty)); }
            set { SetValue("CareerCompanyName", value); }
        }

        public string CareerStartDate
        {
			get { return Convert.ToString(GetValue("CareerStartDate", string.Empty)); }
            set { SetValue("CareerStartDate", value); }
        }

		public string CareerEndDate
        {
			get { return Convert.ToString(GetValue("CareerEndDate", string.Empty)); }
            set { SetValue("CareerEndDate", value); }
        }

        public string CareerJobs
        {
            get { return Convert.ToString(GetValue("CareerJobs", string.Empty)); }
            set { SetValue("CareerJobs", value); }
        }

        public string CareerPosition
        {
            get { return Convert.ToString(GetValue("CareerPosition", string.Empty)); }
            set { SetValue("CareerPosition", value); }
        }

		public string CareerLocation
		{
			get { return Convert.ToString(GetValue("CareerLocation", string.Empty)); }
			set { SetValue("CareerLocation", value); }
		}
	}
}
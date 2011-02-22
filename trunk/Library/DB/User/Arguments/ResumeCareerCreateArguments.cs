using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.User
{
    public class ResumeCareerCreateArguments : DBArguments
    {

        public int ResumeNo
        {
            get { return Convert.ToInt32(GetValue("ResumeNo", 0)); }
            set { SetValue("ResumeNo", value); }
        }

        public string CareerCompanyName
        {
            get { return Convert.ToString(GetValue("CareerCompanyName", string.Empty)); }
            set { SetValue("CareerCompanyName", value); }
        }

        public DateTime CareerStartDate
        {
            get { return Convert.ToDateTime(GetValue("CareerStartDate",DateTime.MinValue )); }
            set { SetValue("CareerStartDate", value); }
        }

        public DateTime CareerEndDate
        {
            get { return Convert.ToDateTime(GetValue("CareerEndDate",DateTime.MinValue )); }
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
    }
}
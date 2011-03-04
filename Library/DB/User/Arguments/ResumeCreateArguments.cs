using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.User
{
    public class ResumeCreateArguments : DBArguments
    {
		public int UserNo
		{
			get { return Convert.ToInt32(GetValue("UserNo", 0)); }
			set { SetValue("UserNo", value); }
		}

        public int CompanyNo1
        {
            get { return Convert.ToInt32(GetValue("CompanyNo1", 0)); }
            set { SetValue("CompanyNo1", value); }
        }

        public int CompanyNo2
        {
            get { return Convert.ToInt32(GetValue("CompanyNo2", 0)); }
            set { SetValue("CompanyNo2", value); }
        }

        public int CompanyNo3
        {
            get { return Convert.ToInt32(GetValue("CompanyNo3", 0)); }
            set { SetValue("CompanyNo3", value); }
        }

        public string HopeSalary
        {
            get { return Convert.ToString(GetValue("HopeSalary", string.Empty)); }
            set { SetValue("HopeSalary", value); }
        }

        public int CityNo1
        {
            get { return Convert.ToInt32(GetValue("CityNo1", 0)); }
            set { SetValue("CityNo1", value); }
        }

        public int ArrayNo1
        {
            get { return Convert.ToInt32(GetValue("ArrayNo1", 0)); }
            set { SetValue("ArrayNo1", value); }
        }

        public int CityNo2
        {
            get { return Convert.ToInt32(GetValue("CityNo2", 0)); }
            set { SetValue("CityNo2", value); }
        }

        public int ArrayNo2
        {
            get { return Convert.ToInt32(GetValue("ArrayNo2", 0)); }
            set { SetValue("ArrayNo2", value); }
        }

        public DateTime HopeRecruitDate
        {
            get { return Convert.ToDateTime(GetValue("HopeRecruitDate",DateTime.MinValue )); }
            set { SetValue("HopeRecruitDate", value); }
        }

        public int BusinessCategoryNo
        {
            get { return Convert.ToInt32(GetValue("BusinessCategoryNo", 0)); }
            set { SetValue("BusinessCategoryNo", value); }
        }

        public int Category1No
        {
            get { return Convert.ToInt32(GetValue("Category1No", 0)); }
            set { SetValue("Category1No", value); }
        }

        public int Category2No
        {
            get { return Convert.ToInt32(GetValue("Category2No", 0)); }
            set { SetValue("Category2No", value); }
        }

		public byte JoinType
		{
			get { return Convert.ToByte(GetValue("JoinType", 0)); }
			set { SetValue("JoinType", value); }
		}
    }
}
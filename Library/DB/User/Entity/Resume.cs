using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.User
{
    public class ResumeEntity : DataEntity
    {
        public int UserNo { get { return Convert.ToInt32(GetData("UserNo", (int)0)); } }
        public int CompanyNo1 { get { return Convert.ToInt32(GetData("CompanyNo1", (int)0)); } }
        public int CompanyNo2 { get { return Convert.ToInt32(GetData("CompanyNo2", (int)0)); } }
        public int CompanyNo3 { get { return Convert.ToInt32(GetData("CompanyNo3", (int)0)); } }
        public string HopeSalary { get { return Convert.ToString(GetData("HopeSalary", string.Empty)); } }
        public int CityNo1 { get { return Convert.ToInt32(GetData("CityNo1", (int)0)); } }
        public int ArrayNo1 { get { return Convert.ToInt32(GetData("ArrayNo1", (int)0)); } }
        public int CityNo2 { get { return Convert.ToInt32(GetData("CityNo2", (int)0)); } }
        public int ArrayNo2 { get { return Convert.ToInt32(GetData("ArrayNo2", (int)0)); } }
        public DateTime HopeRecruitDate { get { return Convert.ToDateTime(GetData("HopeRecruitDate", DateTime.MinValue)); } }
        public int BusinessCategoryNo { get { return Convert.ToInt32(GetData("BusinessCategoryNo", (int)0)); } }
        public int Category1No { get { return Convert.ToInt32(GetData("Category1No", (int)0)); } }
        public int Category2No { get { return Convert.ToInt32(GetData("Category2No", (int)0)); } }
		public byte JoinType { get { return Convert.ToByte(GetData("JoinType", (byte)0)); } }
        public DateTime RegistryTime { get { return Convert.ToDateTime(GetData("RegistryTime", DateTime.MinValue)); } }
        public byte Status { get { return Convert.ToByte(GetData("Status", (byte)0)); } }
    }
}
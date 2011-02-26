using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Company
{
    public class RecruitSearchEntity : DataEntity
    {
        public int CompanyNo { get { return Convert.ToInt32(GetData("CompanyNo", (int)0)); } }
        public int CountryNo { get { return Convert.ToInt32(GetData("CountryNo", (int)0)); } }
        public int RecruitNo { get { return Convert.ToInt32(GetData("RecruitNo", (int)0)); } }
        public string KRName { get { return Convert.ToString(GetData("KRName", string.Empty)); } }
        public string CNName { get { return Convert.ToString(GetData("CNName", string.Empty)); } }
        public string ENGName { get { return Convert.ToString(GetData("ENGName", string.Empty)); } }
        public string CompanyImage { get { return Convert.ToString(GetData("CompanyImage", string.Empty)); } }
        public byte CapitalType { get { return Convert.ToByte(GetData("CapitalType", (byte)0)); } }
        public byte JoinType { get { return Convert.ToByte(GetData("JoinType", (byte)0)); } }
        public byte JobFairValue { get { return Convert.ToByte(GetData("JobFairValue", (byte)0)); } }
        public int RecruitDateDiff { get { return Convert.ToInt32(GetData("RecruitDateDiff", (int)0)); } }
        public int Category1No { get { return Convert.ToInt32(GetData("Category1No", (int)0)); } }
        public int Category2No { get { return Convert.ToInt32(GetData("Category2No", (int)0)); } }
        public int CityCategory { get { return Convert.ToInt32(GetData("CityCategory", (int)0)); } }
        public int AreaCategory { get { return Convert.ToInt32(GetData("AreaCategory", (int)0)); } }
        public byte Career { get { return Convert.ToByte(GetData("Career", (byte)0)); } }
        public byte Gender { get { return Convert.ToByte(GetData("Gender", (byte)0)); } }
        public int AgeCategory { get { return Convert.ToInt32(GetData("AgeCategory", (int)0)); } }
        public DateTime RecruitDate { get { return Convert.ToDateTime(GetData("RecruitDate", DateTime.MinValue)); } }
    }
}
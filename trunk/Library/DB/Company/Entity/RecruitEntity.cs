using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Company
{
    public class RecruitEntity : DataEntity
    {
        public int RecruitNo { get { return Convert.ToInt32(GetData("RecruitNo", (int)0)); } }
        public byte CountryNo { get { return Convert.ToByte(GetData("CountryNo", (byte)0)); } }
        public int CompanyNo { get { return Convert.ToInt32(GetData("CompanyNo", (int)0)); } }
        public byte JoinType { get { return Convert.ToByte(GetData("JoinType", (byte)0)); } }
        public byte JobFairValue { get { return Convert.ToByte(GetData("JobFairValue", (byte)0)); } }
        public string JobFairRecruiter { get { return Convert.ToString(GetData("JobFairRecruiter", string.Empty)); } }
        public int Category1No { get { return Convert.ToInt32(GetData("Category1No", (int)0)); } }
        public int Category2No { get { return Convert.ToInt32(GetData("Category2No", (int)0)); } }
        public string CategoryEtcValue { get { return Convert.ToString(GetData("CategoryEtcValue", string.Empty)); } }
        public byte Career { get { return Convert.ToByte(GetData("Career", (byte)0)); } }
        public int RecruitCount { get { return Convert.ToInt32(GetData("RecruitCount", 0)); } }
        public byte Gender { get { return Convert.ToByte(GetData("Gender", (byte)0)); } }
        public byte AgeType { get { return Convert.ToByte(GetData("AgeType", (byte)0)); } }
        public int AgeCategory { get { return Convert.ToInt32(GetData("AgeCategory", 0)); } }
        public string AgeEtcValue { get { return Convert.ToString(GetData("AgeEtcValue", string.Empty)); } }
        public byte AcademicAbility { get { return Convert.ToByte(GetData("AcademicAbility", (byte)0)); } }
        public byte Major { get { return Convert.ToByte(GetData("Major", (byte)0)); } }
        public string MajorEtcValue { get { return Convert.ToString(GetData("MajorEtcValue", string.Empty)); } }
        public byte ChineseLevel { get { return Convert.ToByte(GetData("ChineseLevel", (byte)0)); } }
        public byte EnglishLevel { get { return Convert.ToByte(GetData("EnglishLevel", (byte)0)); } }
        public byte JapanessLevel { get { return Convert.ToByte(GetData("JapanessLevel", (byte)0)); } }
        public string ETCLanguageName { get { return Convert.ToString(GetData("ETCLanguageName", string.Empty)); } }
        public byte ETCLanguageLevel { get { return Convert.ToByte(GetData("ETCLanguageLevel", (byte)0)); } }
        public string MainWork { get { return Convert.ToString(GetData("MainWork", string.Empty)); } }
        public int CityCategory { get { return Convert.ToInt32(GetData("CityCategory", 0)); } }
        public int AreaCategory { get { return Convert.ToInt32(GetData("AreaCategory", 0)); } }
        public string RecruitAddressDetail { get { return Convert.ToString(GetData("RecruitAddressDetail", string.Empty)); } }
        public DateTime RecruitDate { get { return Convert.ToDateTime(GetData("RecruitDate", DateTime.MinValue)); } }
        public string EtcEligibilityRule { get { return Convert.ToString(GetData("EtcEligibilityRule", string.Empty)); } }
        public int PayCategory { get { return Convert.ToInt32(GetData("PayCategory", 0)); } }
        public byte ContactPeriod { get { return Convert.ToByte(GetData("ContactPeriod", (byte)0)); } }
        public byte WorkingHoursType { get { return Convert.ToByte(GetData("WorkingHoursType", (byte)0)); } }
        public string WorkingHours { get { return Convert.ToString(GetData("WorkingHours", string.Empty)); } }
        public byte BenefitsInsurance { get { return Convert.ToByte(GetData("BenefitsInsurance", (byte)0)); } }
        public string BenefitsInsuranceEtcValue { get { return Convert.ToString(GetData("BenefitsInsuranceEtcValue", string.Empty)); } }
        public byte BenefitsRoomAndBoard { get { return Convert.ToByte(GetData("BenefitsRoomAndBoard", (byte)0)); } }
        public string BenefitsRoomAndBoardEtcValue { get { return Convert.ToString(GetData("BenefitsRoomAndBoardEtcValue", string.Empty)); } }
        public byte BenefitsSeverancePay { get { return Convert.ToByte(GetData("BenefitsSeverancePay", (byte)0)); } }
        public string BenefitsSeverancePayEtcValue { get { return Convert.ToString(GetData("BenefitsSeverancePayEtcValue", string.Empty)); } }
        public byte BenefitsVacation { get { return Convert.ToByte(GetData("BenefitsVacation", (byte)0)); } }
        public string BenefitsVacationEtcValue { get { return Convert.ToString(GetData("BenefitsVacationEtcValue", string.Empty)); } }
        public string BenefitsETC { get { return Convert.ToString(GetData("BenefitsETC", string.Empty)); } }
        public DateTime RegistryTime { get { return Convert.ToDateTime(GetData("RegistryTime", DateTime.MinValue)); } }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Company
{
    public class RecruitCreateArguments : DBArguments
    {
        public int RecruitNo
        {
            get { return Convert.ToByte(GetValue("RecruitNo", 0)); }
            set { SetValue("RecruitNo", value); }
        }

        public int CountryNo
        {
            get { return Convert.ToByte(GetValue("CountryNo", 0)); }
            set { SetValue("CountryNo", value); }
        }

        public int CompanyNo
        {
            get { return Convert.ToInt32(GetValue("CompanyNo", 0)); }
            set { SetValue("CompanyNo", value); }
        }

        public byte JoinType
        {
            get { return Convert.ToByte(GetValue("JoinType", (byte)0)); }
            set { SetValue("JoinType", value); }
        }

        public byte JobFairValue
        {
            get { return Convert.ToByte(GetValue("JobFairValue", (byte)0)); }
            set { SetValue("JobFairValue", value); }
        }

        public string JobFairRecruiter
        {
            get { return Convert.ToString(GetValue("JobFairRecruiter", string.Empty)); }
            set { SetValue("JobFairRecruiter", value); }
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

        public string CategoryEtcValue
        {
            get { return Convert.ToString(GetValue("CategoryEtcValue", string.Empty)); }
            set { SetValue("CategoryEtcValue", value); }
        }

        public byte Career
        {
            get { return Convert.ToByte(GetValue("Career", (byte)0)); }
            set { SetValue("Career", value); }
        }

        public int RecruitCount
        {
            get { return Convert.ToInt32(GetValue("RecruitCount", 0)); }
            set { SetValue("RecruitCount", value); }
        }

        public byte Gender
        {
            get { return Convert.ToByte(GetValue("Gender", (byte)0)); }
            set { SetValue("Gender", value); }
        }

        public byte AgeType
        {
            get { return Convert.ToByte(GetValue("AgeType", (byte)0)); }
            set { SetValue("AgeType", value); }
        }

        public int AgeCategory
        {
            get { return Convert.ToByte(GetValue("AgeCategory", 0)); }
            set { SetValue("AgeCategory", value); }
        }

        public string AgeEtcValue
        {
            get { return Convert.ToString(GetValue("AgeEtcValue", string.Empty)); }
            set { SetValue("AgeEtcValue", value); }
        }

        public byte AcademicAbility
        {
            get { return Convert.ToByte(GetValue("AcademicAbility", (byte)0)); }
            set { SetValue("AcademicAbility", value); }
        }

        public byte Major
        {
            get { return Convert.ToByte(GetValue("Major", (byte)0)); }
            set { SetValue("Major", value); }
        }

        public string MajorEtcValue
        {
            get { return Convert.ToString(GetValue("MajorEtcValue", string.Empty)); }
            set { SetValue("MajorEtcValue", value); }
        }

        public byte ChineseLevel
        {
            get { return Convert.ToByte(GetValue("ChineseLevel", (byte)0)); }
            set { SetValue("ChineseLevel", value); }
        }

        public byte EnglishLevel
        {
            get { return Convert.ToByte(GetValue("EnglishLevel", (byte)0)); }
            set { SetValue("EnglishLevel", value); }
        }

        public byte JapanessLevel
        {
            get { return Convert.ToByte(GetValue("JapanessLevel", (byte)0)); }
            set { SetValue("JapanessLevel", value); }
        }

        public string ETCLanguageName
        {
            get { return Convert.ToString(GetValue("ETCLanguageName", string.Empty)); }
            set { SetValue("ETCLanguageName", value); }
        }

        public byte ETCLanguageLevel
        {
            get { return Convert.ToByte(GetValue("ETCLanguageLevel", (byte)0)); }
            set { SetValue("ETCLanguageLevel", value); }
        }

        public string MainWork
        {
            get { return Convert.ToString(GetValue("MainWork", string.Empty)); }
            set { SetValue("MainWork", value); }
        }

        public int CityCategory
        {
            get { return Convert.ToInt32(GetValue("CityCategory", 0)); }
            set { SetValue("CityCategory", value); }
        }

        public int AreaCategory
        {
            get { return Convert.ToInt32(GetValue("AreaCategory", 0)); }
            set { SetValue("AreaCategory", value); }
        }

        public string RecruitAddressDetail
        {
            get { return Convert.ToString(GetValue("RecruitAddressDetail", string.Empty)); }
            set { SetValue("RecruitAddressDetail", value); }
        }

        public DateTime RecruitDate
        {
            get { return (DateTime)(GetValue("RecruitDate", DateTime.MinValue)); }
            set { SetValue("RecruitDate", value); }
        }

        public string EtcEligibilityRule
        {
            get { return Convert.ToString(GetValue("EtcEligibilityRule", string.Empty)); }
            set { SetValue("EtcEligibilityRule", value); }
        }

        public int PayCategory
        {
            get { return Convert.ToInt32(GetValue("PayCategory", 0)); }
            set { SetValue("PayCategory", value); }
        }

        public byte ContactPeriod
        {
            get { return Convert.ToByte(GetValue("ContactPeriod", (byte)0)); }
            set { SetValue("ContactPeriod", value); }
        }

        public byte WorkingHoursType
        {
            get { return Convert.ToByte(GetValue("WorkingHoursType", (byte)0)); }
            set { SetValue("WorkingHoursType", value); }
        }

        public string WorkingHours
        {
            get { return Convert.ToString(GetValue("WorkingHours", string.Empty)); }
            set { SetValue("WorkingHours", value); }
        }

        public byte BenefitsInsurance
        {
            get { return Convert.ToByte(GetValue("BenefitsInsurance", (byte)0)); }
            set { SetValue("BenefitsInsurance", value); }
        }

        public string BenefitsInsuranceEtcValue
        {
            get { return Convert.ToString(GetValue("BenefitsInsuranceEtcValue", string.Empty)); }
            set { SetValue("BenefitsInsuranceEtcValue", value); }
        }

        public byte BenefitsRoomAndBoard
        {
            get { return Convert.ToByte(GetValue("BenefitsRoomAndBoard", (byte)0)); }
            set { SetValue("BenefitsRoomAndBoard", value); }
        }

        public string BenefitsRoomAndBoardEtcValue
        {
            get { return Convert.ToString(GetValue("BenefitsRoomAndBoardEtcValue", string.Empty)); }
            set { SetValue("BenefitsRoomAndBoardEtcValue", value); }
        }

        public byte BenefitsSeverancePay
        {
            get { return Convert.ToByte(GetValue("BenefitsSeverancePay", (byte)0)); }
            set { SetValue("BenefitsSeverancePay", value); }
        }

        public string BenefitsSeverancePayEtcValue
        {
            get { return Convert.ToString(GetValue("BenefitsSeverancePayEtcValue", string.Empty)); }
            set { SetValue("BenefitsSeverancePayEtcValue", value); }
        }

        public byte BenefitsVacation
        {
            get { return Convert.ToByte(GetValue("BenefitsVacation", (byte)0)); }
            set { SetValue("BenefitsVacation", value); }
        }

        public string BenefitsVacationEtcValue
        {
            get { return Convert.ToString(GetValue("BenefitsVacationEtcValue", string.Empty)); }
            set { SetValue("BenefitsVacationEtcValue", value); }
        }

        public string BenefitsETC
        {
            get { return Convert.ToString(GetValue("BenefitsETC", string.Empty)); }
            set { SetValue("BenefitsETC", value); }
        }

        public DateTime RegistryTime
        {
            get { return (DateTime)(GetValue("RegistryTime", DateTime.MinValue)); }
            set { SetValue("RegistryTime", value); }
        }
    }
}
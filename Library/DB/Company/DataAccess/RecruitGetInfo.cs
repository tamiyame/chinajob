using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Company
{
    public class RecruitGetInfo : DBDataReader<DataEntity, RecruitEntity>
    {
        public RecruitGetInfo()
            : base(new ConnectionString(), "TSP_RecruitGetInfo")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("RecruitNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CountryNo", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("CompanyNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("JoinType", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("JobFairValue", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("JobFairRecruiter", SqlDbType.NVarChar, 2000, SqlDataInOut.Output);
            AddParameter("Category1No", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("Category2No", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("CategoryEtcValue", SqlDbType.NVarChar, 40, SqlDataInOut.Output);
            AddParameter("Career", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("RecruitCount", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("Gender", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("AgeType", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("AgeCategory", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("AgeEtcValue", SqlDbType.NVarChar, 20, SqlDataInOut.Output);
            AddParameter("AcademicAbility", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("Major", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("MajorEtcValue", SqlDbType.NVarChar, 40, SqlDataInOut.Output);
            AddParameter("ChineseLevel", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("EnglishLevel", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("JapanessLevel", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("ETCLanguageName", SqlDbType.NVarChar, 40, SqlDataInOut.Output);
            AddParameter("ETCLanguageLevel", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("MainWork", SqlDbType.NVarChar, 200, SqlDataInOut.Output);
            AddParameter("CityCategory", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("AreaCategory", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("RecruitDate", SqlDbType.SmallDateTime, 4, SqlDataInOut.Output);
            AddParameter("RecruitAddressDetail", SqlDbType.NVarChar, 600, SqlDataInOut.Output);
            AddParameter("EtcEligibilityRule", SqlDbType.NVarChar, -1, SqlDataInOut.Output);
            AddParameter("PayCategory", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("ContactPeriod", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("WorkingHoursType", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("WorkingHours", SqlDbType.NVarChar, 40, SqlDataInOut.Output);
            AddParameter("BenefitsInsurance", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("BenefitsInsuranceEtcValue", SqlDbType.NVarChar, 40, SqlDataInOut.Output);
            AddParameter("BenefitsRoomAndBoard", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("BenefitsRoomAndBoardEtcValue", SqlDbType.NVarChar, 40, SqlDataInOut.Output);
            AddParameter("BenefitsSeverancePay", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("BenefitsSeverancePayEtcValue", SqlDbType.NVarChar, 40, SqlDataInOut.Output);
            AddParameter("BenefitsVacation", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("BenefitsVacationEtcValue", SqlDbType.NVarChar, 40, SqlDataInOut.Output);
            AddParameter("BenefitsETC", SqlDbType.NVarChar, 400, SqlDataInOut.Output);
            AddParameter("RegistryTime", SqlDbType.DateTime, 8, SqlDataInOut.Output);
            AddParameter("ParticipateCount", SqlDbType.Int, 4, SqlDataInOut.Output);
        }
    }
}
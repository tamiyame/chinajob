using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Company
{
    public class RecruitCreate : DBDataReader<DataEntity, DataEntity>
    {
        public RecruitCreate()
            : base(new ConnectionString(), "TSP_RecruitCreate")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("RecruitNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CompanyNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("JoinType", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("JobFairValue", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("JobFairRecruiter", SqlDbType.NVarChar, 2000, SqlDataInOut.Input);
            AddParameter("Category1No", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("Category2No", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CategoryEtcValue", SqlDbType.NVarChar, 40, SqlDataInOut.Input);
            AddParameter("Career", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("RecruitCount", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("Gender", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("AgeType", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("AgeCategory", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("AgeEtcValue", SqlDbType.NVarChar, 20, SqlDataInOut.Input);
            AddParameter("AcademicAbility", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("Major", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("MajorEtcValue", SqlDbType.NVarChar, 40, SqlDataInOut.Input);
            AddParameter("ChineseLevel", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("EnglishLevel", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("JapanessLevel", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("ETCLanguageName", SqlDbType.NVarChar, 40, SqlDataInOut.Input);
            AddParameter("ETCLanguageLevel", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("MainWork", SqlDbType.NVarChar, 200, SqlDataInOut.Input);
            AddParameter("CityCategory", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("AreaCategory", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("RecruitAddressDetail", SqlDbType.NVarChar, 600, SqlDataInOut.Input);
            AddParameter("RecruitDate", SqlDbType.SmallDateTime, 4 , SqlDataInOut.Input);
            AddParameter("EtcEligibilityRule", SqlDbType.NVarChar, -1, SqlDataInOut.Input);
            AddParameter("PayCategory", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("ContactPeriod", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("WorkingHoursType", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("WorkingHours", SqlDbType.NVarChar, 40, SqlDataInOut.Input);
            AddParameter("BenefitsInsurance", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("BenefitsInsuranceEtcValue", SqlDbType.NVarChar, 40, SqlDataInOut.Input);
            AddParameter("BenefitsRoomAndBoard", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("BenefitsRoomAndBoardEtcValue", SqlDbType.NVarChar, 40, SqlDataInOut.Input);
            AddParameter("BenefitsSeverancePay", SqlDbType.NVarChar, 40, SqlDataInOut.Input);
            AddParameter("BenefitsVacation", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("BenefitsVacationEtcValue", SqlDbType.NVarChar, 40, SqlDataInOut.Input);
            AddParameter("BenefitsETC", SqlDbType.NVarChar, 400, SqlDataInOut.Input);
            AddParameter("RegistryTime", SqlDbType.DateTime, 8, SqlDataInOut.Input);
        }
    }
}
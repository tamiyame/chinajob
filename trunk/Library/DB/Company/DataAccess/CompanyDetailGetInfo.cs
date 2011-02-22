using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Company
{
    public class CompanyDetailGetInfo : DBDataReader<DataEntity, CompanyDetailEntity>
    {
        public CompanyDetailGetInfo()
            : base(new ConnectionString(), "TSP_CompanyDetailGetInfo")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CompanyNo", SqlDbType.Int, 4, SqlDataInOut.InputOutput);
            AddParameter("BusinessCategoryNo", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("BusinessCategoryEtc", SqlDbType.NVarChar, 50, SqlDataInOut.Output);
            AddParameter("KRName", SqlDbType.NVarChar, 100, SqlDataInOut.Output);
            AddParameter("CNName", SqlDbType.NVarChar, 100, SqlDataInOut.Output);
            AddParameter("ENGName", SqlDbType.NVarChar, 100, SqlDataInOut.Output);
            AddParameter("CompanyImage", SqlDbType.VarChar, 200, SqlDataInOut.Output);
            AddParameter("PermitNo", SqlDbType.NVarChar, 100, SqlDataInOut.InputOutput);
            AddParameter("Email", SqlDbType.NVarChar, 100, SqlDataInOut.InputOutput);
            AddParameter("PresidentName", SqlDbType.NVarChar, 60, SqlDataInOut.Output);
            AddParameter("CapitalType", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("FoundYear", SqlDbType.NVarChar, 16, SqlDataInOut.Output);
            AddParameter("EmployeeCount", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("Capital", SqlDbType.BigInt, 8, SqlDataInOut.Output);
            AddParameter("CapitalCurrencyNo", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("Turnover", SqlDbType.BigInt, 8, SqlDataInOut.Output);
            AddParameter("TurnoverCurrencyNo", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("CompanyDescrition", SqlDbType.NVarChar, -1, SqlDataInOut.Output);
            AddParameter("RecruiterName", SqlDbType.NVarChar, 60, SqlDataInOut.Output);
            AddParameter("PhoneNo", SqlDbType.VarChar, 30, SqlDataInOut.Output);
            AddParameter("FaxNo", SqlDbType.VarChar, 30, SqlDataInOut.Output);
            AddParameter("HeadAddress", SqlDbType.NVarChar, 400, SqlDataInOut.Output);
            AddParameter("EmploymentAddress", SqlDbType.NVarChar, 400, SqlDataInOut.Output);
            AddParameter("HomepageURL", SqlDbType.VarChar, 100, SqlDataInOut.Output);
            AddParameter("RegistyTime", SqlDbType.DateTime, 8, SqlDataInOut.Output);
        }
    }
}
using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Company
{
    public class CompanyDetailModify : DBDataReader<DataEntity, DataEntity>
    {
        public CompanyDetailModify()
            : base(new ConnectionString(), "TSP_CompanyDetailModify")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CompanyNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("KRName", SqlDbType.NVarChar, 100, SqlDataInOut.Input);
            AddParameter("CNName", SqlDbType.NVarChar, 100, SqlDataInOut.Input);
            AddParameter("ENGName", SqlDbType.NVarChar, 100, SqlDataInOut.Input);
            AddParameter("CompanyImage", SqlDbType.VarChar, 200, SqlDataInOut.Input);
            AddParameter("PermitNo", SqlDbType.NVarChar, 100, SqlDataInOut.Input);
            AddParameter("PermitImage", SqlDbType.VarChar, 200, SqlDataInOut.Input);
            AddParameter("Email", SqlDbType.NVarChar, 100, SqlDataInOut.Input);
            AddParameter("BusinessCategoryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("BusinessCategoryEtc", SqlDbType.NVarChar, 50, SqlDataInOut.Input);
            AddParameter("PresidentName", SqlDbType.NVarChar, 60, SqlDataInOut.Input);
            AddParameter("CapitalType", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("FoundYear", SqlDbType.NVarChar, 16, SqlDataInOut.Input);
            AddParameter("EmployeeCount", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("Capital", SqlDbType.BigInt, 8, SqlDataInOut.Input);
            AddParameter("CapitalCurrencyNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("Turnover", SqlDbType.BigInt, 8, SqlDataInOut.Input);
            AddParameter("TurnoverCurrencyNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CompanyDescrition", SqlDbType.NVarChar, -1, SqlDataInOut.Input);
            AddParameter("RecruiterName", SqlDbType.NVarChar, 60, SqlDataInOut.Input);
            AddParameter("PhoneNo", SqlDbType.VarChar, 30, SqlDataInOut.Input);
            AddParameter("FaxNo", SqlDbType.VarChar, 30, SqlDataInOut.Input);
            AddParameter("HeadAddress", SqlDbType.NVarChar, 400, SqlDataInOut.Input);
            AddParameter("EmploymentAddress", SqlDbType.NVarChar, 400, SqlDataInOut.Input);
            AddParameter("HomepageURL", SqlDbType.VarChar, 100, SqlDataInOut.Input);
        }
    }
}
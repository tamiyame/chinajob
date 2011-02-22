using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Company
{
    public class CompanyLogin : DBDataReader<DataEntity, CompanyEntity>
    {
        public CompanyLogin()
            : base(new ConnectionString(), "TSP_CompanyLogin")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CompanyID", SqlDbType.NVarChar, 60, SqlDataInOut.Input);
            AddParameter("Password", SqlDbType.VarChar, 20, SqlDataInOut.Input);
            AddParameter("CompanyNo", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("RegistyTime", SqlDbType.DateTime, 8, SqlDataInOut.Output);
            AddParameter("Status", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
        }
    }
}
using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Company
{
    public class CompanyModify : DBDataReader<DataEntity, DataEntity>
    {
        public CompanyModify()
            : base(new ConnectionString(), "TSP_CompanyModify")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CompanyNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CompanyID", SqlDbType.VarChar, 24, SqlDataInOut.Input);
            AddParameter("Password", SqlDbType.VarChar, 20, SqlDataInOut.Input);
            AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("Status", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("Approval", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
        }
    }
}
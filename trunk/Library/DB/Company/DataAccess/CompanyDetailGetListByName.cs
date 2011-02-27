using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Company
{
    public class CompanyDetailGetListByName : DBDataReader<CompanyDetailEntity, OutputEntity>
    {
        public CompanyDetailGetListByName()
            : base(new ConnectionString(), "TSP_CompanyDetailGetListByName")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("Name", SqlDbType.NVarChar, 100, SqlDataInOut.Input);
        }
    }
}
using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Company
{
    public class RecruitMasterRemove : DBDataReader<DataEntity, DataEntity>
    {
        public RecruitMasterRemove()
            : base(new ConnectionString(), "TSP_RecruitMasterRemove")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CompanyNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("RecruitNo", SqlDbType.Int, 4, SqlDataInOut.Input);
        }
    }
}
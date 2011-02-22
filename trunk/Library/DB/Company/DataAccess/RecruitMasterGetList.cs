using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Company
{
    public class RecruitMasterGetList : DBDataReader<RecruitMasterEntity, DataEntity>
    {
        public RecruitMasterGetList()
            : base(new ConnectionString(), "TSP_RecruitMasterGetList")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CompanyNo", SqlDbType.Int, 4, SqlDataInOut.Input);
        }
    }
}
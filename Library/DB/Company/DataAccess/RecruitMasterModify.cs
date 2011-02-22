using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Company
{
    public class RecruitMasterModify : DBDataReader<DataEntity, DataEntity>
    {
        public RecruitMasterModify()
            : base(new ConnectionString(), "TSP_RecruitMasterModify")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CompanyNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("RecruitNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("RecruitTitle", SqlDbType.NVarChar, 200, SqlDataInOut.Input);
            AddParameter("ParticipateTotalCount", SqlDbType.Int, 4, SqlDataInOut.Input);
        }
    }
}
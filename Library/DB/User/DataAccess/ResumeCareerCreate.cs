using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.User
{
    public class ResumeCareerCreate : DBDataReader<DataEntity, DataEntity>
    {
        public ResumeCareerCreate()
            : base(new ConnectionString(), "TSP_ResumeCareerCreate")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("ResumeNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CareerCompanyName", SqlDbType.NVarChar, 200, SqlDataInOut.Input);
            AddParameter("CareerStartDate", SqlDbType.DateTime, 8, SqlDataInOut.Input);
            AddParameter("CareerEndDate", SqlDbType.DateTime, 8, SqlDataInOut.Input);
            AddParameter("CareerJobs", SqlDbType.NVarChar, 100, SqlDataInOut.Input);
            AddParameter("CareerPosition", SqlDbType.NVarChar, 200, SqlDataInOut.Input);
            AddParameter("ResumeCareerNo", SqlDbType.Int, 4, SqlDataInOut.Output);
        }
    }
}
using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.User
{
    public class ResumeLicenseCreate : DBDataReader<DataEntity, DataEntity>
    {
        public ResumeLicenseCreate()
            : base(new ConnectionString(), "TSP_ResumeLicenseCreate")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("ResumeNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("LicensedDate", SqlDbType.DateTime, 8, SqlDataInOut.Input);
            AddParameter("LicenseName", SqlDbType.NVarChar, 200, SqlDataInOut.Input);
            AddParameter("Organization", SqlDbType.NVarChar, 200, SqlDataInOut.Input);

            AddParameter("ResumeLicenseNo", SqlDbType.Int, 4, SqlDataInOut.Output);
        }
    }
}
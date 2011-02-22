using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Company
{
    public class CompanyGetInfo : DBDataReader<DataEntity, CompanyEntity>
    {
        public CompanyGetInfo()
            : base(new ConnectionString(), "TSP_CompanyGetInfo")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CompanyNo", SqlDbType.Int, 4, SqlDataInOut.InputOutput);
            AddParameter("CompanyID", SqlDbType.VarChar, 24, SqlDataInOut.InputOutput);
            AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("RegistyTime", SqlDbType.DateTime, 8, SqlDataInOut.Output);
            AddParameter("Status", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("Approval", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("RecruitCount", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("ParticipateCount", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("DateLastLogin", SqlDbType.DateTime, 8, SqlDataInOut.Output);
            AddParameter("DatePrevLogin", SqlDbType.DateTime, 8, SqlDataInOut.Output);
        }
    }
}
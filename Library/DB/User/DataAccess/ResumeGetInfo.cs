using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.User
{
    public class ResumeGetInfo : DBDataReader<DataEntity, ResumeEntity>
    {
        public ResumeGetInfo()
            : base(new ConnectionString(), "TSP_ResumeGetInfo")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("UserNo", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("CompanyNo1", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("CompanyNo2", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("CompanyNo3", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("HopeSalary", SqlDbType.VarChar, 20, SqlDataInOut.Output);
            AddParameter("CityNo1", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("ArrayNo1", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("CityNo2", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("ArrayNo2", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("HopeRecruitDate", SqlDbType.DateTime, 8, SqlDataInOut.Output);
            AddParameter("BusinessCategoryNo", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("Category1No", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("Category2No", SqlDbType.Int, 4, SqlDataInOut.Output);
			AddParameter("JoinType", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("RegistryTime", SqlDbType.DateTime, 8, SqlDataInOut.Output);
            AddParameter("Status", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
        }
    }
}
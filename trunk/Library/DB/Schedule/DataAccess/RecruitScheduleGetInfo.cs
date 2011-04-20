using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Schedule
{
    public class RecruitScheduleGetInfo : DBDataReader<DataEntity, RecruitScheduleEntity>
    {
        public RecruitScheduleGetInfo()
            : base(new ConnectionString(), "TSP_RecruitScheduleGetInfo")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("ImageUrl", SqlDbType.VarChar, 200, SqlDataInOut.Output);
            AddParameter("Title", SqlDbType.NVarChar, 100, SqlDataInOut.Output);
            AddParameter("CompanyJoinType", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("CompanyJoin_Start", SqlDbType.DateTime, 8, SqlDataInOut.Output);
            AddParameter("CompanyJoin_End", SqlDbType.DateTime, 8, SqlDataInOut.Output);
            AddParameter("UserJoinType", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("UserJoin_Start", SqlDbType.DateTime, 8, SqlDataInOut.Output);
            AddParameter("UserJoin_End", SqlDbType.DateTime, 8, SqlDataInOut.Output);
            AddParameter("RecruitType", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("Recruit_Start", SqlDbType.DateTime, 8, SqlDataInOut.Output);
            AddParameter("Recruit_End", SqlDbType.DateTime, 8, SqlDataInOut.Output);
            AddParameter("ParticipateType", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("Participate_Start", SqlDbType.DateTime, 8, SqlDataInOut.Output);
            AddParameter("Participate_End", SqlDbType.DateTime, 8, SqlDataInOut.Output);
            AddParameter("UserViewType", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("UserView_Start", SqlDbType.DateTime, 8, SqlDataInOut.Output);
            AddParameter("UserView_End", SqlDbType.DateTime, 8, SqlDataInOut.Output);
        }
    }
}
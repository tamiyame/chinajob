using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Schedule
{
    public class RecruitScheduleSet : DBDataReader<DataEntity, DataEntity>
    {
        public RecruitScheduleSet()
            : base(new ConnectionString(), "TSP_RecruitScheduleSet")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("ImageUrl", SqlDbType.VarChar, 200, SqlDataInOut.Input);
            AddParameter("Title", SqlDbType.NVarChar, 100, SqlDataInOut.Input);
            AddParameter("CompanyJoinType", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("CompanyJoin_Start", SqlDbType.DateTime, 8, SqlDataInOut.Input);
            AddParameter("CompanyJoin_End", SqlDbType.DateTime, 8, SqlDataInOut.Input);
            AddParameter("UserJoinType", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("UserJoin_Start", SqlDbType.DateTime, 8, SqlDataInOut.Input);
            AddParameter("UserJoin_End", SqlDbType.DateTime, 8, SqlDataInOut.Input);
            AddParameter("RecruitType", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("Recruit_Start", SqlDbType.DateTime, 8, SqlDataInOut.Input);
            AddParameter("Recruit_End", SqlDbType.DateTime, 8, SqlDataInOut.Input);
            AddParameter("ParticipateType", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("Participate_Start", SqlDbType.DateTime, 8, SqlDataInOut.Input);
            AddParameter("Participate_End", SqlDbType.DateTime, 8, SqlDataInOut.Input);
            AddParameter("UserViewType", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("UserView_Start", SqlDbType.DateTime, 8, SqlDataInOut.Input);
            AddParameter("UserView_End", SqlDbType.DateTime, 8, SqlDataInOut.Input);
        }
    }
}
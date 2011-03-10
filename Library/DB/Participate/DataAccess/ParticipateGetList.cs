using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Participate
{
    public class ParticipateGetList : DBDataReader<ParticipateEntity, DataEntity>
    {
        public ParticipateGetList()
            : base(new ConnectionString(), "TSP_ParticipateGetList")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CompanyNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("RecruitNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("UserNo", SqlDbType.Int, 4, SqlDataInOut.Input);
        }
    }
}
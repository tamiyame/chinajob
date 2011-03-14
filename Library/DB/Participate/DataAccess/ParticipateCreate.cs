using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Participate
{
    public class ParticipateCreate : DBDataReader<DataEntity, DataEntity>
    {
        public ParticipateCreate()
            : base(new ConnectionString(), "TSP_ParticipateCreate")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CompanyNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("RecruitNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("Category1No", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("Category2No", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("UserNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("RecruitType", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
        }
    }
}
using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Participate
{
    public class ParticipateSet : DBDataReader<DataEntity, DataEntity>
    {
        public ParticipateSet()
            : base(new ConnectionString(), "TSP_ParticipateSet")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("SeqNo", SqlDbType.BigInt, 8, SqlDataInOut.Input);
            AddParameter("CompanyNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("RecruitNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("UserNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("UserIDX", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("Category1No", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("Category2No", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("RecruitType", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
        }
    }
}
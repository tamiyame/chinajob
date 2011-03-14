using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Participate
{
    public class ParticipateModify : DBDataReader<DataEntity, DataEntity>
    {
        public ParticipateModify()
            : base(new ConnectionString(), "TSP_ParticipateModify")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("SeqNo", SqlDbType.BigInt, 8, SqlDataInOut.Input);
            AddParameter("ConfirmType", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("Status", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
        }
    }
}
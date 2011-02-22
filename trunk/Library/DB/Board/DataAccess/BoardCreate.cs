using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Board
{
    public class BoardCreate : DBDataReader<DataEntity, DataEntity>
    {
        public BoardCreate()
            : base(new ConnectionString(), "TSP_BoardCreate")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("BoardName", SqlDbType.NVarChar, 50, SqlDataInOut.Input);
            AddParameter("PageSize", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
        }
    }
}
using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Board
{
    public class BoardCategoryRemove : DBDataReader<DataEntity, DataEntity>
    {
        public BoardCategoryRemove()
            : base(new ConnectionString(), "TSP_BoardCategoryRemove")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("BoardNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("BoardCategoryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
        }
    }
}
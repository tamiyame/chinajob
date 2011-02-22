using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Board
{
    public class BoardCategoryGetList : DBDataReader<BoardCategoryEntity, DataEntity>
    {
        public BoardCategoryGetList()
            : base(new ConnectionString(), "TSP_BoardCategoryGetList")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("BoardNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("Status", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
        }
    }
}
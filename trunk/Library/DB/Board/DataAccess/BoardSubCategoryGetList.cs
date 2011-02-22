using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Board
{
    public class BoardSubCategoryGetList : DBDataReader<BoardSubCategoryEntity, OutputEntity>
    {
        public BoardSubCategoryGetList()
            : base(new ConnectionString(), "TSP_BoardSubCategoryGetList")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("BoardNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("BoardCategoryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("Status", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
        }
    }
}
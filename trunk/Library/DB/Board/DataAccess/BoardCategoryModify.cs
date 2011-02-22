using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Board
{
    public class BoardCategoryModify : DBDataReader<DataEntity, DataEntity>
    {
        public BoardCategoryModify()
            : base(new ConnectionString(), "TSP_BoardCategoryModify")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("BoardNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("BoardCategoryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CategoryName", SqlDbType.NVarChar, 50, SqlDataInOut.Input);
        }
    }
}
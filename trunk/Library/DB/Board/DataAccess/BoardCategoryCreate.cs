using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Board
{
    public class BoardCategoryCreate : DBDataReader<DataEntity, DataEntity>
    {
        public BoardCategoryCreate()
            : base(new ConnectionString(), "TSP_BoardCategoryCreate")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("BoardNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CategoryName", SqlDbType.NVarChar, 50, SqlDataInOut.Input);
        }
    }
}
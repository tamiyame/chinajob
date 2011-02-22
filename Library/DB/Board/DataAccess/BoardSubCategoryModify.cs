using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Board
{
    public class BoardSubCategoryModify : DBDataReader<DataEntity, DataEntity>
    {
        public BoardSubCategoryModify()
            : base(new ConnectionString(), "TSP_BoardSubCategoryModify")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("BoardNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("BoardCategoryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("BoardSubCategoryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("SubCategoryName", SqlDbType.NVarChar, 50, SqlDataInOut.Input);
        }
    }
}
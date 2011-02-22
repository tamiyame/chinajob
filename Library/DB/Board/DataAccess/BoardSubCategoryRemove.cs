using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Board
{
    public class BoardSubCategoryRemove : DBDataReader<DataEntity, DataEntity>
    {
        public BoardSubCategoryRemove()
            : base(new ConnectionString(), "TSP_BoardSubCategoryRemove")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("BoardNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("BoardCategoryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("BoardSubCategoryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
        }
    }
}
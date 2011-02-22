using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Board
{
    public class BoardSubCategoryCreate : DBDataReader<DataEntity, DataEntity>
    {
        public BoardSubCategoryCreate()
            : base(new ConnectionString(), "TSP_BoardSubCategoryCreate")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("BoardNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("BoardCategoryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("SubCategoryName", SqlDbType.NVarChar, 50, SqlDataInOut.Input);
        }
    }
}
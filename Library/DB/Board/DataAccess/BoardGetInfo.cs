using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Board
{
    public class BoardGetInfo : DBDataReader<DataEntity, BoardEntity>
    {
        public BoardGetInfo()
            : base(new ConnectionString(), "TSP_BoardGetInfo")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("BoardNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("BoardName", SqlDbType.NVarChar, 50, SqlDataInOut.Output);
            AddParameter("DateCreated", SqlDbType.DateTime, 8, SqlDataInOut.Output);
            AddParameter("PageSize", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("ArticleCreate", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("ArticleRemove", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("MaxArticleNo", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("MaxArticleGroupNo", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("MaxBoardCategoryNo", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("Status", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
        }
    }
}
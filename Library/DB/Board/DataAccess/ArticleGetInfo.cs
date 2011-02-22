using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Board
{
    public class ArticleGetInfo : DBDataReader<DataEntity, ArticleEntity>
    {
        public ArticleGetInfo()
            : base(new ConnectionString(), "TSP_ArticleGetInfo")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("BoardNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("ArticleNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("ArticleNo_parent", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("ArticleGroupNo", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("OrderNo", SqlDbType.SmallInt, 2, SqlDataInOut.Output);
            AddParameter("LevelNo", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("BoardCategoryNo", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("BoardSubCategoryNo", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("UserNo", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("UserID", SqlDbType.VarChar, 24, SqlDataInOut.Output);
            AddParameter("UserName", SqlDbType.NVarChar, 50, SqlDataInOut.Output);
            AddParameter("UserIP", SqlDbType.VarChar, 20, SqlDataInOut.Output);
            AddParameter("ArticleTitle", SqlDbType.NVarChar, 500, SqlDataInOut.Output);
            AddParameter("SomeContent", SqlDbType.NVarChar, 2000, SqlDataInOut.Output);
            AddParameter("ArticleContent", SqlDbType.NVarChar, -1, SqlDataInOut.Output);
            AddParameter("ReadCount", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("DateCreated", SqlDbType.DateTime, 8, SqlDataInOut.Output);
            AddParameter("CommentCreate", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("CommentRemove", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("MaxCommentNo", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("Status", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("_AddReadCount", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
        }
    }
}
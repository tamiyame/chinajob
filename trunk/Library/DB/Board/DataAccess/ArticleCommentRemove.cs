using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Board
{
    public class ArticleCommentRemove : DBDataReader<DataEntity, DataEntity>
    {
        public ArticleCommentRemove()
            : base(new ConnectionString(), "TSP_ArticleCommentRemove")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("BoardNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("ArticleNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CommentNo", SqlDbType.Int, 4, SqlDataInOut.Input);
        }
    }
}
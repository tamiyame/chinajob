using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Board
{
    public class ArticleCommentCreate : DBDataReader<DataEntity, DataEntity>
    {
        public ArticleCommentCreate()
            : base(new ConnectionString(), "TSP_ArticleCommentCreate")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("BoardNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("ArticleNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CommentContent", SqlDbType.NVarChar, 2000, SqlDataInOut.Input);
            AddParameter("UserNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("UserID", SqlDbType.VarChar, 24, SqlDataInOut.Input);
            AddParameter("UserName", SqlDbType.NVarChar, 50, SqlDataInOut.Input);
            AddParameter("UserIP", SqlDbType.VarChar, 20, SqlDataInOut.Input);
        }
    }
}
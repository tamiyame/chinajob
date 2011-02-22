using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Board
{
    public class ArticleCommentGetList : DBDataReader<ArticleCommentEntity, OutputEntity>
    {
        public ArticleCommentGetList()
            : base(new ConnectionString(), "TSP_ArticleCommentGetList")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("BoardNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("ArticleNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("Status", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("PageNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("PageSize", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("CntRow", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("CntTotal", SqlDbType.Int, 4, SqlDataInOut.Output);
        }
    }
}
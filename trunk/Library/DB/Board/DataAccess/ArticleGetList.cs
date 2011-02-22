using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Board
{
    public class ArticleGetList : DBDataReader<ArticleEntity, OutputEntity>
    {
        public ArticleGetList()
            : base(new ConnectionString(), "TSP_ArticleGetList")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("BoardNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("Status", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("BoardCategoryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("BoardSubCategoryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("UserName_Search", SqlDbType.NVarChar, 50, SqlDataInOut.Input);
            AddParameter("UserNo_Search", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("ArticleTitle_Search", SqlDbType.NVarChar, 50, SqlDataInOut.Input);
            AddParameter("PageNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("PageSize", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("CntRow", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("CntTotal", SqlDbType.Int, 4, SqlDataInOut.Output);
        }
    }
}
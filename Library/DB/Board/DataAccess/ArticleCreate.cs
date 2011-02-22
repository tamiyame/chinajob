using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Board
{
    public class ArticleCreate : DBDataReader<DataEntity, DataEntity>
    {
        public ArticleCreate()
            : base(new ConnectionString(), "TSP_ArticleCreate")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("BoardNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("ArticleNo_parent", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("BoardCategoryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("BoardSubCategoryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("UserNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("UserID", SqlDbType.VarChar, 24, SqlDataInOut.Input);
            AddParameter("UserName", SqlDbType.NVarChar, 50, SqlDataInOut.Input);
            AddParameter("UserIP", SqlDbType.VarChar, 20, SqlDataInOut.Input);
            AddParameter("ArticleTitle", SqlDbType.NVarChar, 500, SqlDataInOut.Input);
            AddParameter("SomeContent", SqlDbType.NVarChar, 2000, SqlDataInOut.Input);
            AddParameter("ArticleContent", SqlDbType.NVarChar, -1, SqlDataInOut.Input);
            AddParameter("ArticleNo", SqlDbType.Int, 4, SqlDataInOut.Output);
        }
    }
}
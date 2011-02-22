using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Board
{
    public class ArticleModify : DBDataReader<DataEntity, DataEntity>
    {
        public ArticleModify()
            : base(new ConnectionString(), "TSP_ArticleModify")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("BoardNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("ArticleNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("ArticleTitle", SqlDbType.NVarChar, 500, SqlDataInOut.Input);
            AddParameter("SomeContent", SqlDbType.NVarChar, 2000, SqlDataInOut.Input);
            AddParameter("ArticleContent", SqlDbType.NVarChar, -1, SqlDataInOut.Input);
            AddParameter("BoardCategoryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("BoardSubCategoryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
        }
    }
}
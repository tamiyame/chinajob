using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Board
{
    public class ArticleRemove : DBDataReader<DataEntity, DataEntity>
    {
        public ArticleRemove()
            : base(new ConnectionString(), "TSP_ArticleRemove")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("BoardNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("ArticleNo", SqlDbType.Int, 4, SqlDataInOut.Input);
        }
    }
}
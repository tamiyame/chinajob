using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Category
{
    public class SubCategoryCreate : DBDataReader<DataEntity, DataEntity>
    {
        public SubCategoryCreate()
            : base(new ConnectionString(), "TSP_SubCategoryCreate")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CategoryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("SubCategoryKRName", SqlDbType.NVarChar, 800, SqlDataInOut.Input);
            AddParameter("SubCategoryCNName", SqlDbType.NVarChar, 800, SqlDataInOut.Input);
            AddParameter("SubCategoryENGName", SqlDbType.NVarChar, 800, SqlDataInOut.Input);
        }
    }
}
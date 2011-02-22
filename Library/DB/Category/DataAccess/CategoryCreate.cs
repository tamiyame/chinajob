using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Category
{
    public class CategoryCreate : DBDataReader<DataEntity, DataEntity>
    {
        public CategoryCreate()
            : base(new ConnectionString(), "TSP_CategoryCreate")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CategoryMasterNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CategoryKRName", SqlDbType.NVarChar, 400, SqlDataInOut.Input);
            AddParameter("CategoryCNName", SqlDbType.NVarChar, 400, SqlDataInOut.Input);
            AddParameter("CategoryENGName", SqlDbType.NVarChar, 400, SqlDataInOut.Input);
        }
    }
}
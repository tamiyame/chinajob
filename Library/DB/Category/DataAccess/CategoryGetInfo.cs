using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Category
{
    public class CategoryGetInfo : DBDataReader<DataEntity, CategoryEntity>
    {
        public CategoryGetInfo()
            : base(new ConnectionString(), "TSP_CategoryGetInfo")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CategoryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CategoryKRName", SqlDbType.NVarChar, 400, SqlDataInOut.Output);
            AddParameter("CategoryCNName", SqlDbType.NVarChar, 400, SqlDataInOut.Output);
            AddParameter("CategoryENGName", SqlDbType.NVarChar, 400, SqlDataInOut.Output);
        }
    }
}
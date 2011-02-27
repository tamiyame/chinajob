using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Category
{
    public class CategoryMasterGetInfo : DBDataReader<CategoryMasterEntity, CategoryMasterEntity>
    {
        public CategoryMasterGetInfo()
            : base(new ConnectionString(), "TSP_CategoryMasterGetInfo")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CategoryMasterNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CategoryMasterName", SqlDbType.NVarChar, 100, SqlDataInOut.Output);
            AddParameter("IsSubCategory", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("Status", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
        }
    }
}
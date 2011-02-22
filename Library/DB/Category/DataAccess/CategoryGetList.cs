using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Category
{
    public class CategoryGetList : DBDataReader<CategoryEntity, DataEntity>
    {
        public CategoryGetList()
            : base(new ConnectionString(), "TSP_CategoryGetList")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CategoryMasterNo", SqlDbType.Int, 4, SqlDataInOut.Input);
        }
    }
}
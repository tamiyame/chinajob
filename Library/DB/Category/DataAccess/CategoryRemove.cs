using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Category
{
    public class CategoryRemove : DBDataReader<DataEntity, DataEntity>
    {
        public CategoryRemove()
            : base(new ConnectionString(), "TSP_CategoryRemove")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CategoryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
        }
    }
}
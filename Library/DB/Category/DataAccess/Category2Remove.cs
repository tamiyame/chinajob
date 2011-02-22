using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Category
{
    public class Category2Remove : DBDataReader<DataEntity, DataEntity>
    {
        public Category2Remove()
            : base(new ConnectionString(), "TSP_Category2Remove")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("Category2No", SqlDbType.Int, 4, SqlDataInOut.Input);
        }
    }
}
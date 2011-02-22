using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Category
{
    public class Category1Remove : DBDataReader<DataEntity, DataEntity>
    {
        public Category1Remove()
            : base(new ConnectionString(), "TSP_Category1Remove")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("Category1No", SqlDbType.Int, 4, SqlDataInOut.Input);
        }
    }
}
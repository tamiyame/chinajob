using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Category
{
    public class Category2Create : DBDataReader<DataEntity, DataEntity>
    {
        public Category2Create()
            : base(new ConnectionString(), "TSP_Category2Create")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("Category1No", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("Category2Name", SqlDbType.NVarChar, 100, SqlDataInOut.Input);
        }
    }
}
using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Category
{
    public class Category2Modify : DBDataReader<DataEntity, DataEntity>
    {
        public Category2Modify()
            : base(new ConnectionString(), "TSP_Category2Modify")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("Category2No", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("Category1No", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("Category2Name", SqlDbType.NVarChar, 100, SqlDataInOut.Input);
        }
    }
}
using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Category
{
    public class Category1Modify : DBDataReader<DataEntity, DataEntity>
    {
        public Category1Modify()
            : base(new ConnectionString(), "TSP_Category1Modify")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("Category1No", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("Category1Name", SqlDbType.NVarChar, 100, SqlDataInOut.Input);
        }
    }
}
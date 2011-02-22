using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Category
{
    public class Category1Create : DBDataReader<DataEntity, DataEntity>
    {
        public Category1Create()
            : base(new ConnectionString(), "TSP_Category1Create")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("Category1Name", SqlDbType.NVarChar, 100, SqlDataInOut.Input);
        }
    }
}
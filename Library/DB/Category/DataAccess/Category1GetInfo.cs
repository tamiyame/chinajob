using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Category
{
    public class Category1GetInfo : DBDataReader<DataEntity, Category1Entity>
    {
        public Category1GetInfo()
            : base(new ConnectionString(), "TSP_Category1GetInfo")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("Category1No", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("Category1Name", SqlDbType.NVarChar, 100, SqlDataInOut.Output);
        }
    }
}
using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Category
{
    public class BusinessCategoryCreate : DBDataReader<DataEntity, DataEntity>
    {
        public BusinessCategoryCreate()
            : base(new ConnectionString(), "TSP_BusinessCategoryCreate")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CategoryName", SqlDbType.NVarChar, 200, SqlDataInOut.Input);
        }
    }
}
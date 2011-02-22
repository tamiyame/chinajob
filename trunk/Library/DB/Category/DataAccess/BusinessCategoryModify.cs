using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Category
{
    public class BusinessCategoryModify : DBDataReader<DataEntity, DataEntity>
    {
        public BusinessCategoryModify()
            : base(new ConnectionString(), "TSP_BusinessCategoryModify")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("BusinessCategoryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CategoryName", SqlDbType.NVarChar, 200, SqlDataInOut.Input);
        }
    }
}
using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Category
{
    public class BusinessCategoryGetInfo : DBDataReader<DataEntity, BusinessCategoryEntity>
    {
        public BusinessCategoryGetInfo()
            : base(new ConnectionString(), "TSP_BusinessCategoryGetInfo")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("BusinessCategoryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("CategoryName", SqlDbType.NVarChar, 200, SqlDataInOut.Output);
        }
    }
}
using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Category
{
    public class BusinessCategoryRemove : DBDataReader<DataEntity, DataEntity>
    {
        public BusinessCategoryRemove()
            : base(new ConnectionString(), "TSP_BusinessCategoryRemove")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("BusinessCategoryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
        }
    }
}
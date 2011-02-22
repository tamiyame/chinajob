using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Category
{
    public class SubCategoryRemove : DBDataReader<DataEntity, DataEntity>
    {
        public SubCategoryRemove()
            : base(new ConnectionString(), "TSP_SubCategoryRemove")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("SubCategoryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
        }
    }
}
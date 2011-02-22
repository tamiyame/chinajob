using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Category
{
    public class ArrayCategoryModify : DBDataReader<DataEntity, DataEntity>
    {
        public ArrayCategoryModify()
            : base(new ConnectionString(), "TSP_ArrayCategoryModify")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CityNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("ArrayNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("ArrayName", SqlDbType.NVarChar, 200, SqlDataInOut.Input);
        }
    }
}
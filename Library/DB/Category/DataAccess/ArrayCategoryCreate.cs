using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Company
{
    public class ArrayCategoryCreate : DBDataReader<DataEntity, DataEntity>
    {
        public ArrayCategoryCreate()
            : base(new ConnectionString(), "TSP_ArrayCategoryCreate")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CityNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("ArrayName", SqlDbType.NVarChar, 200, SqlDataInOut.Input);
        }
    }
}
using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Category
{
    public class ArrayCategoryGetList : DBDataReader<ArrayCategoryEntity, OutputEntity>
    {
        public ArrayCategoryGetList()
            : base(new ConnectionString(), "TSP_ArrayCategoryGetList")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CityNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("PageNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("PageSize", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("CntRow", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("CntTotal", SqlDbType.Int, 4, SqlDataInOut.Output);
        }
    }
}
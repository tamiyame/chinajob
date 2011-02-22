using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Category
{
    public class BusinessCategoryGetList : DBDataReader<BusinessCategoryEntity, OutputEntity>
    {
        public BusinessCategoryGetList()
            : base(new ConnectionString(), "TSP_BusinessCategoryGetList")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("PageNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("PageSize", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("CntRow", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("CntTotal", SqlDbType.Int, 4, SqlDataInOut.Output);
        }
    }
}
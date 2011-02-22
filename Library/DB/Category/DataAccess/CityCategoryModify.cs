using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Category
{
    public class CityCategoryModify : DBDataReader<DataEntity, DataEntity>
    {
        public CityCategoryModify()
            : base(new ConnectionString(), "TSP_CityCategoryModify")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CityNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CityName", SqlDbType.NVarChar, 200, SqlDataInOut.Input);
        }
    }
}
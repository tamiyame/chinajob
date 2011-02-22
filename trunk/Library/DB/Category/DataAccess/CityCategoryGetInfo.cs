using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Category
{
    public class CityCategoryGetInfo : DBDataReader<DataEntity, CityCategoryEntity>
    {
        public CityCategoryGetInfo()
            : base(new ConnectionString(), "TSP_CityCategoryGetInfo")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CityNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("CityName", SqlDbType.NVarChar, 200, SqlDataInOut.Output);
        }
    }
}
using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Category
{
    public class CityCategoryCreate : DBDataReader<DataEntity, DataEntity>
    {
        public CityCategoryCreate()
            : base(new ConnectionString(), "TSP_CityCategoryCreate")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CityName", SqlDbType.NVarChar, 200, SqlDataInOut.Input);
        }
    }
}
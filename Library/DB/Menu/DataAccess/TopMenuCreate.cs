using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Menu
{
    public class TopMenuCreate : DBDataReader<DataEntity, DataEntity>
    {
        public TopMenuCreate()
            : base(new ConnectionString(), "TSP_TopMenuCreate")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("TopMenuName", SqlDbType.NVarChar, 100, SqlDataInOut.Input);
            AddParameter("TopImageUrl", SqlDbType.VarChar, 200, SqlDataInOut.Input);
        }
    }
}
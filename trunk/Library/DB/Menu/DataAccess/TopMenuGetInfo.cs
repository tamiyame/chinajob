using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Menu
{
    public class TopMenuGetInfo : DBDataReader<DataEntity, TopMenuEntity>
    {
        public TopMenuGetInfo()
            : base(new ConnectionString(), "TSP_TopMenuGetInfo")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("TopMenuNo", SqlDbType.SmallInt, 2, SqlDataInOut.Input);
            AddParameter("TopMenuName", SqlDbType.NVarChar, 100, SqlDataInOut.Output);
            AddParameter("TopImageUrl", SqlDbType.VarChar, 200, SqlDataInOut.Output);
        }
    }
}
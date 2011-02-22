using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Menu
{
    public class TopMenuGetList : DBDataReader<TopMenuEntity, DataEntity>
    {
        public TopMenuGetList()
            : base(new ConnectionString(), "TSP_TopMenuGetList")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
        }
    }
}
using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Menu
{
    public class TopMenuRemove : DBDataReader<DataEntity, DataEntity>
    {
        public TopMenuRemove()
            : base(new ConnectionString(), "TSP_TopMenuRemove")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("TopMenuNo", SqlDbType.SmallInt, 2, SqlDataInOut.Input);
        }
    }
}
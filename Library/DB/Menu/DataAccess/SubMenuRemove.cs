using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Menu
{
    public class SubMenuRemove : DBDataReader<DataEntity, DataEntity>
    {
        public SubMenuRemove()
            : base(new ConnectionString(), "TSP_SubMenuRemove")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("TopMenuNo", SqlDbType.SmallInt, 2, SqlDataInOut.Input);
            AddParameter("SubMenuNo", SqlDbType.SmallInt, 2, SqlDataInOut.Input);
        }
    }
}
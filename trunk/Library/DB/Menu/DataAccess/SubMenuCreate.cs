using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Menu
{
    public class SubMenuCreate : DBDataReader<DataEntity, DataEntity>
    {
        public SubMenuCreate()
            : base(new ConnectionString(), "TSP_SubMenuCreate")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("TopMenuNo", SqlDbType.SmallInt, 2, SqlDataInOut.Input);
            AddParameter("OrderNo", SqlDbType.SmallInt, 2, SqlDataInOut.Input);
            AddParameter("SubMenuName", SqlDbType.NVarChar, 100, SqlDataInOut.Input);
            AddParameter("SubImageUrl", SqlDbType.VarChar, 200, SqlDataInOut.Input);
            AddParameter("CenterContent", SqlDbType.NVarChar, -1, SqlDataInOut.Input);
            AddParameter("Status", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
        }
    }
}
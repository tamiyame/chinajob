using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Menu
{
    public class SubMenuGetInfo : DBDataReader<DataEntity, SubMenuEntity>
    {
        public SubMenuGetInfo()
            : base(new ConnectionString(), "TSP_SubMenuGetInfo")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("TopMenuNo", SqlDbType.SmallInt, 2, SqlDataInOut.Input);
            AddParameter("SubMenuNo", SqlDbType.SmallInt, 2, SqlDataInOut.Input);
            AddParameter("OrderNo", SqlDbType.SmallInt, 2, SqlDataInOut.Output);
            AddParameter("SubMenuName", SqlDbType.NVarChar, 100, SqlDataInOut.Output);
            AddParameter("SubImageUrl", SqlDbType.VarChar, 200, SqlDataInOut.Output);
            AddParameter("CenterContent", SqlDbType.NVarChar, -1, SqlDataInOut.Output);
            AddParameter("Status", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
        }
    }
}
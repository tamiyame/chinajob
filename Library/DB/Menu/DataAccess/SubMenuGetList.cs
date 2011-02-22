using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Menu
{
    public class SubMenuGetList : DBDataReader<SubMenuEntity, DataEntity>
    {
        public SubMenuGetList()
            : base(new ConnectionString(), "TSP_SubMenuGetList")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("TopMenuNo", SqlDbType.SmallInt, 2, SqlDataInOut.Input);
        }
    }
}
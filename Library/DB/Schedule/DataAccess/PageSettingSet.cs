using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Schedule
{
    public class PageSettingSet : DBDataReader<DataEntity, DataEntity>
    {
        public PageSettingSet()
            : base(new ConnectionString(), "TSP_PageSettingSet")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("PhoneNo", SqlDbType.VarChar, 50, SqlDataInOut.Input);
            AddParameter("FaxNo", SqlDbType.VarChar, 50, SqlDataInOut.Input);
            AddParameter("Email", SqlDbType.VarChar, 200, SqlDataInOut.Input);
            AddParameter("KRLogo", SqlDbType.VarChar, 200, SqlDataInOut.Input);
            AddParameter("CNLogo", SqlDbType.VarChar, 200, SqlDataInOut.Input);
            AddParameter("ENGLogo", SqlDbType.VarChar, 200, SqlDataInOut.Input);
            AddParameter("KRTitle", SqlDbType.NVarChar, 200, SqlDataInOut.Input);
            AddParameter("CNTitle", SqlDbType.NVarChar, 200, SqlDataInOut.Input);
            AddParameter("ENGTitle", SqlDbType.NVarChar, 200, SqlDataInOut.Input);
        }
    }
}
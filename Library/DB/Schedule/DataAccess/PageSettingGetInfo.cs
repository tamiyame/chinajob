using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Schedule
{
    public class PageSettingGetInfo : DBDataReader<DataEntity, PageSettingEntity>
    {
        public PageSettingGetInfo()
            : base(new ConnectionString(), "TSP_PageSettingGetInfo")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("PhoneNo", SqlDbType.VarChar, 50, SqlDataInOut.Output);
            AddParameter("FaxNo", SqlDbType.VarChar, 50, SqlDataInOut.Output);
            AddParameter("Email", SqlDbType.VarChar, 200, SqlDataInOut.Output);
            AddParameter("KRLogo", SqlDbType.VarChar, 200, SqlDataInOut.Output);
            AddParameter("CNLogo", SqlDbType.VarChar, 200, SqlDataInOut.Output);
            AddParameter("ENGLogo", SqlDbType.VarChar, 200, SqlDataInOut.Output);
            AddParameter("KRTitle", SqlDbType.NVarChar, 200, SqlDataInOut.Output);
            AddParameter("CNTitle", SqlDbType.NVarChar, 200, SqlDataInOut.Output);
            AddParameter("ENGTitle", SqlDbType.NVarChar, 200, SqlDataInOut.Output);
        }
    }
}
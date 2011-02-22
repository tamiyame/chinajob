using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.User
{
    public class UserGetList : DBDataReader<UserEntity, OutputEntity>
    {
        public UserGetList()
            : base(new ConnectionString(), "TSP_UserGetList")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("PageNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("PageSize", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("Status", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("CntRow", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("CntTotal", SqlDbType.Int, 4, SqlDataInOut.Output);
        }
    }
}
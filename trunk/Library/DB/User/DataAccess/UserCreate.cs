using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.User
{
    public class UserCreate : DBDataReader<DataEntity, UserEntity>
    {
        public UserCreate()
            : base(new ConnectionString(), "TSP_UserCreate")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("UserID", SqlDbType.NVarChar, 48, SqlDataInOut.Input);
            AddParameter("UserPWD", SqlDbType.VarChar, 20, SqlDataInOut.Input);
            AddParameter("ImageUrl", SqlDbType.VarChar, 200, SqlDataInOut.Input);
            AddParameter("KRName", SqlDbType.NVarChar, 100, SqlDataInOut.Input);
            AddParameter("CNName", SqlDbType.NVarChar, 100, SqlDataInOut.Input);
            AddParameter("ENGName", SqlDbType.NVarChar, 100, SqlDataInOut.Input);
            AddParameter("Gender", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("Birthday", SqlDbType.DateTime, 8, SqlDataInOut.Input);
            AddParameter("Email", SqlDbType.VarChar, 100, SqlDataInOut.Input);
            AddParameter("KRPhoneNo", SqlDbType.VarChar, 30, SqlDataInOut.Input);
            AddParameter("CNPhoneNo", SqlDbType.VarChar, 30, SqlDataInOut.Input);
            AddParameter("ResidanceCountry", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("HomepageUrl", SqlDbType.VarChar, 100, SqlDataInOut.Input);
            AddParameter("UserNo", SqlDbType.Int, 4, SqlDataInOut.Output);
        }
    }
}
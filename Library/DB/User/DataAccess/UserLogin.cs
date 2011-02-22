using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.User
{
    public class UserLogin : DBDataReader<DataEntity, UserEntity>
    {
        public UserLogin()
            : base(new ConnectionString(), "TSP_UserLogin")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("UserID", SqlDbType.VarChar, 24, SqlDataInOut.Input);
            AddParameter("UserPWD", SqlDbType.VarChar, 20, SqlDataInOut.Input);
            AddParameter("UserNo", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("Email", SqlDbType.VarChar, 100, SqlDataInOut.Output);
            AddParameter("ImageUrl", SqlDbType.VarChar, 200, SqlDataInOut.Output);
            AddParameter("KRName", SqlDbType.NVarChar, 100, SqlDataInOut.Output);
            AddParameter("CNName", SqlDbType.NVarChar, 100, SqlDataInOut.Output);
            AddParameter("ENGName", SqlDbType.NVarChar, 100, SqlDataInOut.Output);
            AddParameter("Gender", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("Birthday", SqlDbType.DateTime, 8, SqlDataInOut.Output);
            AddParameter("KRPhoneNo", SqlDbType.VarChar, 30, SqlDataInOut.Output);
            AddParameter("CNPhoneNo", SqlDbType.VarChar, 30, SqlDataInOut.Output);
            AddParameter("ResidanceCountry", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("HomepageUrl", SqlDbType.VarChar, 100, SqlDataInOut.Output);
            AddParameter("DateCreated", SqlDbType.DateTime, 8, SqlDataInOut.Output);
            AddParameter("DateLastLogin", SqlDbType.DateTime, 8, SqlDataInOut.Output);
            AddParameter("DatePrevLogin", SqlDbType.DateTime, 8, SqlDataInOut.Output);
            AddParameter("Status", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("IsAdmin", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
        }
    }
}
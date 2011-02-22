using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.User
{
    public class UserLoginArguments : DBArguments
    {
        public string UserID
        {
            get { return Convert.ToString(GetValue("UserID", string.Empty)); }
            set { SetValue("UserID", value); }
        }

        public string UserPWD
        {
            get { return Convert.ToString(GetValue("UserPWD", string.Empty)); }
            set { SetValue("UserPWD", value); }
        }
    }
}
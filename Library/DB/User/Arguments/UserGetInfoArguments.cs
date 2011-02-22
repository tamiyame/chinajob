using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.User
{
    public class UserGetInfoArguments : DBArguments
    {
        public int UserNo
        {
            get { return Convert.ToInt32(GetValue("UserNo", 0)); }
            set { SetValue("UserNo", value); }
        }

        public string UserID
        {
            get { return Convert.ToString(GetValue("UserID", string.Empty)); }
            set { SetValue("UserID", value); }
        }

        public string Email
        {
            get { return Convert.ToString(GetValue("Email", string.Empty)); }
            set { SetValue("Email", value); }
        }
    }
}
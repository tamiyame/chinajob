using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.User
{
    public class UserCreateArguments : DBArguments
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

        public string ImageUrl
        {
            get { return Convert.ToString(GetValue("ImageUrl", string.Empty)); }
            set { SetValue("ImageUrl", value); }
        }

        public string KRName
        {
            get { return Convert.ToString(GetValue("KRName", string.Empty)); }
            set { SetValue("KRName", value); }
        }

        public string CNName
        {
            get { return Convert.ToString(GetValue("CNName", string.Empty)); }
            set { SetValue("CNName", value); }
        }

        public string ENGName
        {
            get { return Convert.ToString(GetValue("ENGName", string.Empty)); }
            set { SetValue("ENGName", value); }
        }

        public byte Gender
        {
            get { return Convert.ToByte(GetValue("Gender", (byte)0)); }
            set { SetValue("Gender", value); }
        }

        public DateTime Birthday
        {
            get { return Convert.ToDateTime(GetValue("Birthday", DateTime.MinValue)); }
            set { SetValue("Birthday", value); }
        }

        public string Email
        {
            get { return Convert.ToString(GetValue("Email", string.Empty)); }
            set { SetValue("Email", value); }
        }

        public string KRPhoneNo
        {
            get { return Convert.ToString(GetValue("KRPhoneNo", string.Empty)); }
            set { SetValue("KRPhoneNo", value); }
        }

        public string CNPhoneNo
        {
            get { return Convert.ToString(GetValue("CNPhoneNo", string.Empty)); }
            set { SetValue("CNPhoneNo", value); }
        }

        public byte ResidanceCountry
        {
            get { return Convert.ToByte(GetValue("ResidanceCountry", (byte)0)); }
            set { SetValue("ResidanceCountry", value); }
        }

        public string HomepageUrl
        {
            get { return Convert.ToString(GetValue("HomepageUrl", string.Empty)); }
            set { SetValue("HomepageUrl", value); }
        }

        public DateTime DateCreated
        {
            get { return Convert.ToDateTime(GetValue("DateCreated", DateTime.MinValue)); }
            set { SetValue("DateCreated", value); }
        }

        public DateTime DateLastLogin
        {
            get { return Convert.ToDateTime(GetValue("DateLastLogin", DateTime.MinValue)); }
            set { SetValue("DateLastLogin", value); }
        }

        public DateTime DatePrevLogin
        {
            get { return Convert.ToDateTime(GetValue("DatePrevLogin", DateTime.MinValue)); }
            set { SetValue("DatePrevLogin", value); }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.User
{
    public class UserEntity : DataEntity
    {
        public int UserNo { get { return Convert.ToInt32(GetData("UserNo", (int)0)); } }
        public string UserID { get { return Convert.ToString(GetData("UserID", string.Empty)); } }
        public string UserPWD { get { return Convert.ToString(GetData("UserPWD", string.Empty)); } }
        public string ImageUrl { get { return Convert.ToString(GetData("ImageUrl", string.Empty)); } }
        public string KRName { get { return Convert.ToString(GetData("KRName", string.Empty)); } }
        public string CNName { get { return Convert.ToString(GetData("CNName", string.Empty)); } }
        public string ENGName { get { return Convert.ToString(GetData("ENGName", string.Empty)); } }
        public byte Gender { get { return Convert.ToByte(GetData("Gender", (byte)0)); } }
        public DateTime Birthday { get { return Convert.ToDateTime(GetData("Birthday", DateTime.MinValue)); } }
        public string Email { get { return Convert.ToString(GetData("Email", string.Empty)); } }
        public string KRPhoneNo { get { return Convert.ToString(GetData("KRPhoneNo", string.Empty)); } }
        public string CNPhoneNo { get { return Convert.ToString(GetData("CNPhoneNo", string.Empty)); } }
        public byte ResidanceCountry { get { return Convert.ToByte(GetData("ResidanceCountry", (byte)0)); } }
        public string HomepageUrl { get { return Convert.ToString(GetData("HomepageUrl", string.Empty)); } }
        public DateTime DateCreated { get { return Convert.ToDateTime(GetData("DateCreated", DateTime.MinValue)); } }
        public DateTime DateLastLogin { get { return Convert.ToDateTime(GetData("DateLastLogin", DateTime.MinValue)); } }
        public DateTime DatePrevLogin { get { return Convert.ToDateTime(GetData("DatePrevLogin", DateTime.MinValue)); } }
        public byte Status { get { return Convert.ToByte(GetData("Status", (byte)0)); } }
        public byte IsAdmin { get { return Convert.ToByte(GetData("IsAdmin", (byte)0)); } }
    }
}
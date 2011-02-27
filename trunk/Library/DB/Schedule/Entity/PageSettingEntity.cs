using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Schedule
{
    public class PageSettingEntity : DataEntity
    {
        public string PhoneNo { get { return Convert.ToString(GetData("PhoneNo", string.Empty)); } }
        public string FaxNo { get { return Convert.ToString(GetData("FaxNo", string.Empty)); } }
        public string Email { get { return Convert.ToString(GetData("Email", string.Empty)); } }
        public string KRLogo { get { return Convert.ToString(GetData("KRLogo", string.Empty)); } }
        public string CNLogo { get { return Convert.ToString(GetData("CNLogo", string.Empty)); } }
        public string ENGLogo { get { return Convert.ToString(GetData("ENGLogo", string.Empty)); } }
        public string KRTitle { get { return Convert.ToString(GetData("KRTitle", string.Empty)); } }
        public string CNTitle { get { return Convert.ToString(GetData("CNTitle", string.Empty)); } }
        public string ENGTitle { get { return Convert.ToString(GetData("ENGTitle", string.Empty)); } }
    }
}
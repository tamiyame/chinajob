using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Schedule
{
    public class PageSettingSetArguments : DBArguments
    {
        public string PhoneNo
        {
            get { return Convert.ToString(GetValue("PhoneNo", string.Empty)); }
            set { SetValue("PhoneNo", value); }
        }

        public string FaxNo
        {
            get { return Convert.ToString(GetValue("FaxNo", string.Empty)); }
            set { SetValue("FaxNo", value); }
        }

        public string Email
        {
            get { return Convert.ToString(GetValue("Email", string.Empty)); }
            set { SetValue("Email", value); }
        }

        public string KRLogo
        {
            get { return Convert.ToString(GetValue("KRLogo", string.Empty)); }
            set { SetValue("KRLogo", value); }
        }

        public string CNLogo
        {
            get { return Convert.ToString(GetValue("CNLogo", string.Empty)); }
            set { SetValue("CNLogo", value); }
        }

        public string ENGLogo
        {
            get { return Convert.ToString(GetValue("ENGLogo", string.Empty)); }
            set { SetValue("ENGLogo", value); }
        }

        public string KRTitle
        {
            get { return Convert.ToString(GetValue("KRTitle", string.Empty)); }
            set { SetValue("KRTitle", value); }
        }

        public string CNTitle
        {
            get { return Convert.ToString(GetValue("CNTitle", string.Empty)); }
            set { SetValue("CNTitle", value); }
        }

        public string ENGTitle
        {
            get { return Convert.ToString(GetValue("ENGTitle", string.Empty)); }
            set { SetValue("ENGTitle", value); }
        }
    }
}
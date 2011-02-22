using System;
using System.Collections.Generic;

using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Company
{
    public class CompanyLoginArguments : DBArguments
    {
        public string CompanyID
        {
            get { return (Convert.ToString(GetValue("CompanyID", ""))); }
            set { SetValue("CompanyID", value); }
        }

        public string Password
        {
            get { return (Convert.ToString(GetValue("Password", ""))); }
            set { SetValue("Password", value); }
        }
    }
}
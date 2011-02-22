using System;
using System.Collections.Generic;

using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Company
{
    public class CompanyGetInfoArguments : DBArguments
    {
        public  int CompanyNo
        {
            get { return (Convert.ToInt32(GetValue("CompanyNo", 0))); }
            set { SetValue("CompanyNo", value); }
        }

        public string CompanyID
        {
            get { return Convert.ToString(GetValue("CompanyID", string.Empty)); }
            set { SetValue("CompanyID", value); }
        }
    }
}
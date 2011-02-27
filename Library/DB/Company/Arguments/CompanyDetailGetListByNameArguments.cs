using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Company
{
    public class CompanyDetailGetListByNameArguments : DBArguments
    {
        public string Name
        {
            get { return Convert.ToString(GetValue("Name", string.Empty)); }
            set { SetValue("Name", value); }
        }
    }
}
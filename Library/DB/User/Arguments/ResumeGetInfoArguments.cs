using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.User
{
    public class ResumeGetInfoArguments : DBArguments
    {
        public int CountryNo
        {
            get { return Convert.ToInt32(GetValue("CountryNo", 0)); }
            set { SetValue("CountryNo", value); }
        }

        public int ResumeNo
        {
            get { return Convert.ToInt32(GetValue("ResumeNo", 0)); }
            set { SetValue("ResumeNo", value); }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.User
{
    public class ResumeAcademicAbilityCreateArguments : DBArguments
    {
        public int ResumeNo
        {
            get { return Convert.ToInt32(GetValue("ResumeNo", 0)); }
            set { SetValue("ResumeNo", value); }
        }

        public string SchoolName
        {
            get { return Convert.ToString(GetValue("SchoolName", string.Empty)); }
            set { SetValue("SchoolName", value); }
        }

        public DateTime SchoolStartDate
        {
            get { return Convert.ToDateTime(GetValue("SchoolStartDate", DateTime.MinValue)); }
            set { SetValue("SchoolStartDate", value); }
        }

        public DateTime SchoolEndDate
        {
            get { return Convert.ToDateTime(GetValue("SchoolEndDate", DateTime.MinValue)); }
            set { SetValue("SchoolEndDate", value); }
        }

        public byte SchoolStatus
        {
            get { return Convert.ToByte(GetValue("SchoolStatus", (byte)0)); }
            set { SetValue("SchoolStatus", value); }
        }

        public string MajorMinor
        {
            get { return Convert.ToString(GetValue("MajorMinor", string.Empty)); }
            set { SetValue("MajorMinor", value); }
        }

        public string SchoolCountryName
        {
            get { return Convert.ToString(GetValue("SchoolCountryName", string.Empty)); }
            set { SetValue("SchoolCountryName", value); }
        }
    }
}
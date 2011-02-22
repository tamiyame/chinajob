using System;
using System.Collections.Generic;

using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Company
{
    public class CompanyEntity : DataEntity
    {
        public int CompanyNo { get { return Convert.ToInt32(GetData("CompanyNo", (int)0)); } }
        public string CompanyID { get { return Convert.ToString(GetData("CompanyID", string.Empty)); } }
        public string Password { get { return Convert.ToString(GetData("Password", string.Empty)); } }
        public int CountryNo { get { return Convert.ToInt32(GetData("CountryNo", (int)0)); } }
        public DateTime RegistDatetime { get { return Convert.ToDateTime(GetData("RegistDatetime", DateTime.MinValue)); } }
        public byte Status { get { return Convert.ToByte(GetData("Status", (byte)0)); } }
        
        public byte Approval { get { return Convert.ToByte(GetData("Approval", (byte)0)); } }
        public int RecruitCount { get { return Convert.ToInt32(GetData("RecruitCount", (int)0)); } }
        public int ParticipateCount { get { return Convert.ToInt32(GetData("ParticipateCount", (int)0)); } }
        public DateTime DateLastLogin { get { return Convert.ToDateTime(GetData("DateLastLogin", DateTime.MinValue)); } }
        public DateTime DatePrevLogin { get { return Convert.ToDateTime(GetData("DatePrevLogin", DateTime.MinValue)); } }
    }
}
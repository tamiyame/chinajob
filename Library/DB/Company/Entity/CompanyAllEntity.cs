using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Library.DB.Company
{
    public class CompanyAllEntity : CompanyDetailEntity
    {
        public string CompanyID { get { return Convert.ToString(GetData("CompanyID", string.Empty)); } }
        public int CountryNo { get { return Convert.ToInt32(GetData("CountryNo", (int)0)); } }
        public string Password_tmp { get { return Convert.ToString(GetData("Password_tmp", string.Empty)); } }
        public DateTime RegistDatetime { get { return Convert.ToDateTime(GetData("RegistDatetime", DateTime.MinValue)); } }
        public byte Status { get { return Convert.ToByte(GetData("Status", (byte)0)); } }
        public byte Approval { get { return Convert.ToByte(GetData("Approval", (byte)0)); } }
    }
}

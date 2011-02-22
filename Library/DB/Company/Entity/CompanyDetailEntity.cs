using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Company
{
    public class CompanyDetailEntity : DataEntity
    {
        public int CompanyNo { get { return Convert.ToInt32(GetData("CompanyNo", (int)0)); } }
        public string KRName { get { return Convert.ToString(GetData("KRName", string.Empty)); } }
        public string CNName { get { return Convert.ToString(GetData("CNName", string.Empty)); } }
        public string ENGName { get { return Convert.ToString(GetData("ENGName", string.Empty)); } }
        public string CompanyImage { get { return Convert.ToString(GetData("CompanyImage", string.Empty)); } }
        public string PermitNo { get { return Convert.ToString(GetData("PermitNo", string.Empty)); } }
        public string PermitImage { get { return Convert.ToString(GetData("PermitImage", string.Empty)); } }
        public string Email { get { return Convert.ToString(GetData("Email", string.Empty)); } }
        public int BusinessCategoryNo { get { return Convert.ToInt32(GetData("BusinessCategoryNo", (int)0)); } }
        public string BusinessCategoryEtc { get { return Convert.ToString(GetData("BusinessCategoryEtc", string.Empty)); } }
        public string PresidentName { get { return Convert.ToString(GetData("PresidentName", string.Empty)); } }
        public byte CapitalType { get { return Convert.ToByte(GetData("CapitalType", (byte)0)); } }
        public string FoundYear { get { return Convert.ToString(GetData("FoundYear", string.Empty)); } }
        public int EmployeeCount { get { return Convert.ToInt32(GetData("EmployeeCount", (int)0)); } }
        public long Capital { get { return Convert.ToInt64(GetData("Capital", (long)0)); } }
        public int CapitalCurrencyNo { get { return Convert.ToInt32(GetData("CapitalCurrencyNo", (int)0)); } }
        public long Turnover { get { return Convert.ToInt64(GetData("Turnover", (long)0)); } }
        public int TurnoverCurrencyNo { get { return Convert.ToInt32(GetData("TurnoverCurrencyNo", (int)0)); } }
        public string CompanyDescrition { get { return Convert.ToString(GetData("CompanyDescrition", string.Empty)); } }
        public string RecruiterName { get { return Convert.ToString(GetData("RecruiterName", string.Empty)); } }
        public string PhoneNo { get { return Convert.ToString(GetData("PhoneNo", string.Empty)); } }
        public string FaxNo { get { return Convert.ToString(GetData("FaxNo", string.Empty)); } }
        public string HeadAddress { get { return Convert.ToString(GetData("HeadAddress", string.Empty)); } }
        public string EmploymentAddress { get { return Convert.ToString(GetData("EmploymentAddress", string.Empty)); } }
        public string HomepageURL { get { return Convert.ToString(GetData("HomepageURL", string.Empty)); } }
        public DateTime RegistyTime { get { return Convert.ToDateTime(GetData("RegistyTime", DateTime.MinValue)); } }
    }
}
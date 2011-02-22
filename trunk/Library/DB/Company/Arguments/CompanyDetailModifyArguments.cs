using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Company
{
    public class CompanyDetailModifyArguments : DBArguments
    {
        public int CompanyNo
        {
            get { return Convert.ToInt32(GetValue("CompanyNo", 0)); }
            set { SetValue("CompanyNo", value); }
        }

        public string KRName
        {
            get { return Convert.ToString(GetValue("KRName", string.Empty)); }
            set { SetValue("KRName", value); }
        }

        public string CNName
        {
            get { return Convert.ToString(GetValue("CNName", string.Empty)); }
            set { SetValue("CNName", value); }
        }

        public string ENGName
        {
            get { return Convert.ToString(GetValue("ENGName", string.Empty)); }
            set { SetValue("ENGName", value); }
        }

        public string CompanyImage
        {
            get { return Convert.ToString(GetValue("CompanyImage", string.Empty)); }
            set { SetValue("CompanyImage", value); }
        }

        public string PermitNo
        {
            get { return Convert.ToString(GetValue("PermitNo", string.Empty)); }
            set { SetValue("PermitNo", value); }
        }

        public string PermitImage
        {
            get { return Convert.ToString(GetValue("PermitImage", string.Empty)); }
            set { SetValue("PermitImage", value); }
        }

        public int BusinessCategoryNo
        {
            get { return Convert.ToInt32(GetValue("BusinessCategoryNo", 0)); }
            set { SetValue("BusinessCategoryNo", value); }
        }

        public string BusinessCategoryEtc
        {
            get { return Convert.ToString(GetValue("BusinessCategoryEtc", string.Empty)); }
            set { SetValue("BusinessCategoryEtc", value); }
        }

        public string Email
        {
            get { return Convert.ToString(GetValue("Email", string.Empty)); }
            set { SetValue("Email", value); }
        }

        public string PresidentName
        {
            get { return Convert.ToString(GetValue("PresidentName", string.Empty)); }
            set { SetValue("PresidentName", value); }
        }

        public byte CapitalType
        {
            get { return Convert.ToByte(GetValue("CapitalType", (byte)0)); }
            set { SetValue("CapitalType", value); }
        }

        public string FoundYear
        {
            get { return Convert.ToString(GetValue("FoundYear", string.Empty)); }
            set { SetValue("FoundYear", value); }
        }

        public int EmployeeCount
        {
            get { return Convert.ToInt32(GetValue("EmployeeCount", 0)); }
            set { SetValue("EmployeeCount", value); }
        }

        public long Capital
        {
            get { return Convert.ToInt64(GetValue("Capital", (long)0)); }
            set { SetValue("Capital", value); }
        }

        public int CapitalCurrencyNo
        {
            get { return Convert.ToInt32(GetValue("CapitalCurrencyNo", 0)); }
            set { SetValue("CapitalCurrencyNo", value); }
        }

        public long Turnover
        {
            get { return Convert.ToInt64(GetValue("Turnover", (long)0)); }
            set { SetValue("Turnover", value); }
        }

        public int TurnoverCurrencyNo
        {
            get { return Convert.ToInt32(GetValue("TurnoverCurrencyNo", 0)); }
            set { SetValue("TurnoverCurrencyNo", value); }
        }

        public string CompanyDescrition
        {
            get { return Convert.ToString(GetValue("CompanyDescrition", string.Empty)); }
            set { SetValue("CompanyDescrition", value); }
        }

        public string RecruiterName
        {
            get { return Convert.ToString(GetValue("RecruiterName", string.Empty)); }
            set { SetValue("RecruiterName", value); }
        }

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

        public string HeadAddress
        {
            get { return Convert.ToString(GetValue("HeadAddress", string.Empty)); }
            set { SetValue("HeadAddress", value); }
        }

        public string EmploymentAddress
        {
            get { return Convert.ToString(GetValue("EmploymentAddress", string.Empty)); }
            set { SetValue("EmploymentAddress", value); }
        }

        public string HomepageURL
        {
            get { return Convert.ToString(GetValue("HomepageURL", string.Empty)); }
            set { SetValue("HomepageURL", value); }
        }
    }
}
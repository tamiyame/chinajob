using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.User
{
    public class ResumeSearchArguments : DBArguments
    {
        public int CountryNo
        {
            get { return Convert.ToInt32(GetValue("CountryNo", 0)); }
            set { SetValue("CountryNo", value); }
        }

        public string UserName
        {
            get { return Convert.ToString(GetValue("UserName", string.Empty)); }
            set { SetValue("UserName", value); }
        }

        public byte JoinType
        {
            get { return Convert.ToByte(GetValue("JoinType", (byte)0)); }
            set { SetValue("JoinType", value); }
        }

        public int Category1No
        {
            get { return Convert.ToInt32(GetValue("Category1No", 0)); }
            set { SetValue("Category1No", value); }
        }

        public int Category2No
        {
            get { return Convert.ToInt32(GetValue("Category2No", 0)); }
            set { SetValue("Category2No", value); }
        }

        public int CityCategory
        {
            get { return Convert.ToInt32(GetValue("CityCategory", 0)); }
            set { SetValue("CityCategory", value); }
        }

        public int AreaCategory
        {
            get { return Convert.ToInt32(GetValue("AreaCategory", 0)); }
            set { SetValue("AreaCategory", value); }
        }

        public int Age_Start
        {
            get { return Convert.ToInt32(GetValue("Age_Start", 0)); }
            set { SetValue("Age_Start", value); }
        }

        public int Age_End
        {
            get { return Convert.ToInt32(GetValue("Age_End", 0)); }
            set { SetValue("Age_End", value); }
        }

        public int Gender
        {
            get { return Convert.ToInt32(GetValue("Gender", 0)); }
            set { SetValue("Gender", value); }
        }

        public int PageNo
        {
            get { return Convert.ToInt32(GetValue("PageNo", 0)); }
            set { SetValue("PageNo", value); }
        }

        public byte PageSize
        {
            get { return Convert.ToByte(GetValue("PageSize", (byte)0)); }
            set { SetValue("PageSize", value); }
        }
    }
}
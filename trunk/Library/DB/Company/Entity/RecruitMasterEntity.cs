using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Company
{
    public class RecruitMasterEntity : DataEntity
    {
        public int CompanyNo { get { return Convert.ToInt32(GetData("CompanyNo", (int)0)); } }
        public int RecruitNo { get { return Convert.ToInt32(GetData("RecruitNo", (int)0)); } }
        public string RecruitTitle { get { return Convert.ToString(GetData("RecruitTitle", string.Empty)); } }
        public DateTime DateCreated { get { return Convert.ToDateTime(GetData("DateCreated", DateTime.MinValue)); } }
        public int ParticipateTotalCount { get { return Convert.ToInt32(GetData("ParticipateTotalCount", (int)0)); } }

        public int CountryNo_1 { get { return Convert.ToInt32(GetData("CountryNo_1", (int)0)); } }
        public int CountryNo_2 { get { return Convert.ToInt32(GetData("CountryNo_2", (int)0)); } }
        public int CountryNo_3 { get { return Convert.ToInt32(GetData("CountryNo_3", (int)0)); } }
    }
}
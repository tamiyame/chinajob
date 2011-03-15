using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Participate
{
    public class ParticipateEntity : DataEntity
    {
        public long SeqNo { get { return Convert.ToInt64(GetData("SeqNo", (long)0)); } }
        public int CompanyNo { get { return Convert.ToInt32(GetData("CompanyNo", (int)0)); } }
        public int CountryNo { get { return Convert.ToInt32(GetData("CountryNo", (int)0)); } }
        public int Category1No { get { return Convert.ToInt32(GetData("Category1No", (int)0)); } }
        public int Category2No { get { return Convert.ToInt32(GetData("Category2No", (int)0)); } }
        public string KRCompanyName { get { return Convert.ToString(GetData("KRCompanyName", string.Empty)); } }
        public string CNCompanyName { get { return Convert.ToString(GetData("CNCompanyName", string.Empty)); } }
        public string ENGCompanyName { get { return Convert.ToString(GetData("ENGCompanyName", string.Empty)); } }
        public string KRUserName { get { return Convert.ToString(GetData("KRUserName", string.Empty)); } }
        public string CNUserName { get { return Convert.ToString(GetData("CNUserName", string.Empty)); } }
        public string ENGUserName { get { return Convert.ToString(GetData("ENGUserName", string.Empty)); } }
        public byte Age { get { return Convert.ToByte(GetData("Age", (byte)0)); } }
        public byte KoreanAge { get { return Convert.ToByte(GetData("KoreanAge", (byte)0)); } }
        public byte Gender { get { return Convert.ToByte(GetData("Gender", (byte)0)); } }
        public byte IsCareer { get { return Convert.ToByte(GetData("IsCareer", (byte)0)); } }
        public int RecruitNo { get { return Convert.ToInt32(GetData("RecruitNo", (int)0)); } }
        public int UserNo { get { return Convert.ToInt32(GetData("UserNo", (int)0)); } }
        public byte RecruitType { get { return Convert.ToByte(GetData("RecruitType", (byte)0)); } }
        public byte ConfirmType { get { return Convert.ToByte(GetData("ConfirmType", (byte)0)); } }
        public DateTime DateCreated { get { return Convert.ToDateTime(GetData("DateCreated", DateTime.MinValue)); } }
        public string StrDateCreated { get { return Convert.ToDateTime(GetData("DateCreated", DateTime.MinValue)).ToString("yyyy-MM-dd HH:mm:ss"); } }
        public DateTime DateLastUpdated { get { return Convert.ToDateTime(GetData("DateLastUpdated", DateTime.MinValue)); } }
    }
}
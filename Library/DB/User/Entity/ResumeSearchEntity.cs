using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.User
{
    public class ResumeSearchEntity : DataEntity
    {
        public int UserNo { get { return Convert.ToInt32(GetData("UserNo", (int)0)); } }
        public int CountryNo { get { return Convert.ToInt32(GetData("CountryNo", (int)0)); } }
        public string KRName { get { return Convert.ToString(GetData("KRName", string.Empty)); } }
        public string CNName { get { return Convert.ToString(GetData("CNName", string.Empty)); } }
        public string ENGName { get { return Convert.ToString(GetData("ENGName", string.Empty)); } }
        public string UserImage { get { return Convert.ToString(GetData("UserImage", string.Empty)); } }
        public byte JoinType { get { return Convert.ToByte(GetData("JoinType", (byte)0)); } }
        public int Category1No { get { return Convert.ToInt32(GetData("Category1No", (int)0)); } }
        public int Category2No { get { return Convert.ToInt32(GetData("Category2No", (int)0)); } }
        public int CityCategory { get { return Convert.ToInt32(GetData("CityCategory", (int)0)); } }
        public int AreaCategory { get { return Convert.ToInt32(GetData("AreaCategory", (int)0)); } }
        public byte KoreanAge { get { return Convert.ToByte(GetData("KoreanAge", (byte)0)); } }
        public byte Age { get { return Convert.ToByte(GetData("Age", (byte)0)); } }
        public byte Gender { get { return Convert.ToByte(GetData("Gender", (byte)0)); } }
        public byte Career { get { return Convert.ToByte(GetData("Career", (byte)0)); } }
        public DateTime RegistryTime { get { return Convert.ToDateTime(GetData("RegistryTime", DateTime.MinValue)); } }
    }
}
using System;
using Com.Framework.Data;

namespace Com.Library.DB.User
{
	public class ResumeAcademicAbilityEntity : DataEntity
	{
		public int UserNo { get { return Convert.ToInt32(GetData("UserNo", (int)0)); } set { SetData("UserNo", value); } }
        public int CountryNo { get { return Convert.ToInt32(GetData("CountryNo", (int)0)); } set { SetData("CountryNo", value); } }
        public int ResumeAcademicAbilityNo { get { return Convert.ToInt32(GetData("ResumeAcademicAbilityNo", (int)0)); } set { SetData("ResumeAcademicAbilityNo", value); } }
        public string SchoolName { get { return Convert.ToString(GetData("SchoolName", string.Empty)); } set { SetData("SchoolName", value); } }
        public string SchoolStartDate { get { return Convert.ToString(GetData("SchoolStartDate", string.Empty)); } set { SetData("SchoolStartDate", value); } }
		public string SchoolEndDate { get { return Convert.ToString(GetData("SchoolEndDate", string.Empty)); } set { SetData("SchoolEndDate", value); } }
        public byte SchoolStatus { get { return Convert.ToByte(GetData("SchoolStatus", (byte)0)); } set { SetData("SchoolStatus", value); } }
        public string MajorMinor { get { return Convert.ToString(GetData("MajorMinor", string.Empty)); } set { SetData("MajorMinor", value); } }
        public string SchoolCountryName { get { return Convert.ToString(GetData("SchoolCountryName", string.Empty)); } set { SetData("SchoolCountryName", value); } }
	}
}

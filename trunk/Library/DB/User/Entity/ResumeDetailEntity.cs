using System;
using Com.Framework.Data;

namespace Com.Library.DB.User
{
	public class ResumeDetailEntity : DataEntity
	{
		public int UserNo { get { return Convert.ToInt32(GetData("UserNo", (int)0)); } }
		public int CountryNo { get { return Convert.ToInt32(GetData("CountryNo", (int)0)); } }
		public int ResumeDetailNo { get { return Convert.ToInt32(GetData("ResumeDetailNo", (int)0)); } }
		public string SSN1 { get { return Convert.ToString(GetData("SSN1", string.Empty)); } }
		public byte KoreanAge { get { return Convert.ToByte(GetData("KoreanAge", (byte)0)); } }
		public byte Age { get { return Convert.ToByte(GetData("Age", (byte)0)); } }
		public string ChinaExp { get { return Convert.ToString(GetData("ChinaExp", string.Empty)); } }
		public byte Military { get { return Convert.ToByte(GetData("Military", (byte)0)); } }
		public byte IsCareer { get { return Convert.ToByte(GetData("IsCareer", (byte)0)); } }
		public string Address { get { return Convert.ToString(GetData("Address", string.Empty)); } }
		public string Description { get { return Convert.ToString(GetData("Description", string.Empty)); } }
		public string AboutMe { get { return Convert.ToString(GetData("AboutMe", string.Empty)); } }
		public string LastestEducation { get { return Convert.ToString(GetData("LastestEducation", string.Empty)); } }
		public string GraduationYear { get { return Convert.ToString(GetData("GraduationYear", string.Empty)); } }
		public string MilitaryService { get { return Convert.ToString(GetData("MilitaryService", string.Empty)); } }
	}
}

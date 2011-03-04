using System;
using Com.Framework.Data;

namespace Com.Library.DB.User
{
	public class ResumeLanguageEntity : DataEntity
	{
		public int UserNo { get { return Convert.ToInt32(GetData("UserNo", (int)0)); } }
		public int CountryNo { get { return Convert.ToInt32(GetData("CountryNo", (int)0)); } }
		public int ResumeLanguageNo { get { return Convert.ToInt32(GetData("ResumeLanguageNo", (int)0)); } }
		public string LanguageName { get { return Convert.ToString(GetData("LanguageName", string.Empty)); } }
		public string TestDesc { get { return Convert.ToString(GetData("TestDesc", string.Empty)); } }
		public string GradeDesc { get { return Convert.ToString(GetData("GradeDesc", string.Empty)); } }
		public byte ConversationLevel { get { return Convert.ToByte(GetData("ConversationLevel", (byte)0)); } }
	}
}

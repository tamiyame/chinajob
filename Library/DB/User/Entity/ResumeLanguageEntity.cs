using System;
using Com.Framework.Data;

namespace Com.Library.DB.User
{
	public class ResumeLanguageEntity : DataEntity
	{
        public int UserNo { get { return Convert.ToInt32(GetData("UserNo", (int)0)); } set { SetData("UserNo", value); } }
        public int CountryNo { get { return Convert.ToInt32(GetData("CountryNo", (int)0)); } set { SetData("CountryNo", value); } }
        public int ResumeLanguageNo { get { return Convert.ToInt32(GetData("ResumeLanguageNo", (int)0)); } set { SetData("ResumeLanguageNo", value); } }
        public string LanguageName { get { return Convert.ToString(GetData("LanguageName", string.Empty)); } set { SetData("LanguageName", value); } }
        public string TestDesc { get { return Convert.ToString(GetData("TestDesc", string.Empty)); } set { SetData("TestDesc", value); } }
        public string GradeDesc { get { return Convert.ToString(GetData("GradeDesc", string.Empty)); } set { SetData("GradeDesc", value); } }
        public byte ConversationLevel { get { return Convert.ToByte(GetData("ConversationLevel", (byte)0)); } set { SetData("ConversationLevel", value); } }
	}
}

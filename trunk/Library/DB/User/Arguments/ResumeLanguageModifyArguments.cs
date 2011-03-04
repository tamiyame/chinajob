using System;

using Com.Framework.Data;

namespace Com.Library.DB.User
{
	public class ResumeLanguageModifyArguments : DBArguments
	{
		public int UserNo
		{
			get { return Convert.ToInt32(GetValue("UserNo", 0)); }
			set { SetValue("UserNo", value); }
		}

		public int CountryNo
		{
			get { return Convert.ToInt32(GetValue("CountryNo", 0)); }
			set { SetValue("CountryNo", value); }
		}

		public int ResumeLanguageNo
		{
			get { return Convert.ToInt32(GetValue("ResumeLanguageNo", 0)); }
			set { SetValue("CountryNo", value); }
		}

		public string LanguageName
		{
			get { return Convert.ToString(GetValue("LanguageName", string.Empty)); }
			set { SetValue("LanguageName", value); }
		}

		public string TestDesc
		{
			get { return Convert.ToString(GetValue("TestDesc", string.Empty)); }
			set { SetValue("TestDesc", value); }
		}

		public string GradeDesc
		{
			get { return Convert.ToString(GetValue("GradeDesc", string.Empty)); }
			set { SetValue("GradeDesc", value); }
		}

		public byte ConversationLevel
		{
			get { return Convert.ToByte(GetValue("ConversationLevel", (byte)0)); }
			set { SetValue("ConversationLevel", value); }
		}
	}
}
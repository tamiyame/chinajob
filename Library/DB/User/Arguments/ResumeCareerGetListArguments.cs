using System;

using Com.Framework.Data;

namespace Com.Library.DB.User
{
	public class ResumeCareerGetListArguments : DBArguments
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

	}
}
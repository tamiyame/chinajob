using System;

using Com.Framework.Data;

namespace Com.Library.DB.User
{
    public class ResumeDetailCreateArguments : DBArguments
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

        public string SSN1
        {
            get { return Convert.ToString(GetValue("SSN1", string.Empty)); }
            set { SetValue("SSN1", value); }
        }

        public string SSN2
        {
            get { return Convert.ToString(GetValue("SSN2", string.Empty)); }
            set { SetValue("SSN2", value); }
        }

        public byte KoreanAge
        {
            get { return Convert.ToByte(GetValue("KoreanAge", (byte)0)); }
            set { SetValue("KoreanAge", value); }
        }

        public byte Age
        {
            get { return Convert.ToByte(GetValue("Age", (byte)0)); }
            set { SetValue("Age", value); }
        }

        public string ChinaExp
        {
            get { return Convert.ToString(GetValue("ChinaExp", string.Empty)); }
            set { SetValue("ChinaExp", value); }
        }

        public byte Military
        {
            get { return Convert.ToByte(GetValue("Military", (byte)0)); }
            set { SetValue("Military", value); }
        }

        public byte IsCareer
        {
            get { return Convert.ToByte(GetValue("IsCareer", (byte)0)); }
            set { SetValue("IsCareer", value); }
        }

        public string Address
        {
            get { return Convert.ToString(GetValue("Address", string.Empty)); }
            set { SetValue("Address", value); }
        }

        public string Description
        {
            get { return Convert.ToString(GetValue("Description", string.Empty)); }
            set { SetValue("Description", value); }
        }

        public string AboutMe
        {
            get { return Convert.ToString(GetValue("AboutMe", string.Empty)); }
            set { SetValue("AboutMe", value); }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.User
{
    public class ResumeLanguageCreateArguments : DBArguments
    {
        public int ResumeNo
        {
            get { return Convert.ToInt32(GetValue("ResumeNo", 0)); }
            set { SetValue("ResumeNo", value); }
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
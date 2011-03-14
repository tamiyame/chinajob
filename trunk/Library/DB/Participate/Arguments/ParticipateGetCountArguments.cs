using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Participate
{
    public class ParticipateGetCountArguments : DBArguments
    {
        public int UserNo
        {
            get { return Convert.ToInt32(GetValue("UserNo", 0)); }
            set { SetValue("UserNo", value); }
        }

        public byte IsConfirm
        {
            get { return Convert.ToByte(GetValue("IsConfirm", (byte)0)); }
            set { SetValue("IsConfirm", value); }
        }
    }
}
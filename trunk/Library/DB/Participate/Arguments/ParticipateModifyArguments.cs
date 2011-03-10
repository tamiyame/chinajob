using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Participate
{
    public class ParticipateModifyArguments : DBArguments
    {
        public long SeqNo
        {
            get { return Convert.ToInt64(GetValue("SeqNo", (long)0)); }
            set { SetValue("SeqNo", value); }
        }

        public byte ConfirmType
        {
            get { return Convert.ToByte(GetValue("ConfirmType", (byte)0)); }
            set { SetValue("ConfirmType", value); }
        }
    }
}
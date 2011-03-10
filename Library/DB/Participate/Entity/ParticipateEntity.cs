﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Participate
{
    public class ParticipateEntity : DataEntity
    {
        public long SeqNo { get { return Convert.ToInt64(GetData("SeqNo", (long)0)); } }
        public int CompanyNo { get { return Convert.ToInt32(GetData("CompanyNo", (int)0)); } }
        public int RecruitNo { get { return Convert.ToInt32(GetData("RecruitNo", (int)0)); } }
        public int UserNo { get { return Convert.ToInt32(GetData("UserNo", (int)0)); } }
        public byte RecruitType { get { return Convert.ToByte(GetData("RecruitType", (byte)0)); } }
        public byte ConfirmType { get { return Convert.ToByte(GetData("ConfirmType", (byte)0)); } }
        public DateTime DateCreated { get { return Convert.ToDateTime(GetData("DateCreated", DateTime.MinValue)); } }
        public DateTime DateLastUpdated { get { return Convert.ToDateTime(GetData("DateLastUpdated", DateTime.MinValue)); } }
    }
}
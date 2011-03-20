using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Participate
{
    public class ParticipateSetArguments : DBArguments
    {
        public long SeqNo
        {
            get { return Convert.ToInt64(GetValue("SeqNo", (long)0)); }
            set { SetValue("SeqNo", value); }
        }

        public int CompanyNo
        {
            get { return Convert.ToInt32(GetValue("CompanyNo", 0)); }
            set { SetValue("CompanyNo", value); }
        }

        public int RecruitNo
        {
            get { return Convert.ToInt32(GetValue("RecruitNo", 0)); }
            set { SetValue("RecruitNo", value); }
        }

        public int UserNo
        {
            get { return Convert.ToInt32(GetValue("UserNo", 0)); }
            set { SetValue("UserNo", value); }
        }

        public int UserIDX
        {
            get { return Convert.ToInt32(GetValue("UserIDX", 0)); }
            set { SetValue("UserIDX", value); }
        }

        public int CountryNo
        {
            get { return Convert.ToInt32(GetValue("CountryNo", 0)); }
            set { SetValue("CountryNo", value); }
        }

        public int Category1No
        {
            get { return Convert.ToInt32(GetValue("Category1No", 0)); }
            set { SetValue("Category1No", value); }
        }

        public int Category2No
        {
            get { return Convert.ToInt32(GetValue("Category2No", 0)); }
            set { SetValue("Category2No", value); }
        }

        public byte RecruitType
        {
            get { return Convert.ToByte(GetValue("RecruitType", (byte)0)); }
            set { SetValue("RecruitType", value); }
        }
    }
}
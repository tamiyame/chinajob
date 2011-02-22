using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Schedule
{
    public class RecruitScheduleSetArguments : DBArguments
    {
        public string ImageUrl
        {
            get { return Convert.ToString(GetValue("ImageUrl", string.Empty)); }
            set { SetValue("ImageUrl", value); }
        }

        public string Title
        {
            get { return Convert.ToString(GetValue("Title", string.Empty)); }
            set { SetValue("Title", value); }
        }

        public byte CompanyJoinType
        {
            get { return Convert.ToByte(GetValue("CompanyJoinType", (byte)0)); }
            set { SetValue("CompanyJoinType", value); }
        }

        public DateTime CompanyJoin_Start
        {
            get { return Convert.ToDateTime(GetValue("CompanyJoin_Start", DateTime.MinValue )); }
            set { SetValue("CompanyJoin_Start", value); }
        }

        public DateTime CompanyJoin_End
        {
            get { return Convert.ToDateTime(GetValue("CompanyJoin_End", DateTime.MinValue )); }
            set { SetValue("CompanyJoin_End", value); }
        }

        public byte UserJoinType
        {
            get { return Convert.ToByte(GetValue("UserJoinType", (byte)0)); }
            set { SetValue("UserJoinType", value); }
        }

        public DateTime UserJoin_Start
        {
            get { return Convert.ToDateTime(GetValue("UserJoin_Start", DateTime.MinValue )); }
            set { SetValue("UserJoin_Start", value); }
        }

        public DateTime UserJoin_End
        {
            get { return Convert.ToDateTime(GetValue("UserJoin_End", DateTime.MinValue )); }
            set { SetValue("UserJoin_End", value); }
        }

        public byte RecruitType
        {
            get { return Convert.ToByte(GetValue("RecruitType", (byte)0)); }
            set { SetValue("RecruitType", value); }
        }

        public DateTime Recruit_Start
        {
            get { return Convert.ToDateTime(GetValue("Recruit_Start", DateTime.MinValue )); }
            set { SetValue("Recruit_Start", value); }
        }

        public DateTime Recruit_End
        {
            get { return Convert.ToDateTime(GetValue("Recruit_End", DateTime.MinValue )); }
            set { SetValue("Recruit_End", value); }
        }

        public byte ParticipateType
        {
            get { return Convert.ToByte(GetValue("ParticipateType", (byte)0)); }
            set { SetValue("ParticipateType", value); }
        }

        public DateTime Participate_Start
        {
            get { return Convert.ToDateTime(GetValue("Participate_Start", DateTime.MinValue )); }
            set { SetValue("Participate_Start", value); }
        }

        public DateTime Participate_End
        {
            get { return Convert.ToDateTime(GetValue("Participate_End", DateTime.MinValue )); }
            set { SetValue("Participate_End", value); }
        }
    }
}
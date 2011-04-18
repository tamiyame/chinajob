using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Schedule
{
    public class RecruitScheduleEntity : DataEntity
    {
        public string ImageUrl { get { return Convert.ToString(GetData("ImageUrl", string.Empty)); } }
        public string Title { get { return Convert.ToString(GetData("Title", string.Empty)); } }
        public byte CompanyJoinType { get { return Convert.ToByte(GetData("CompanyJoinType", (byte)0)); } }
        public DateTime CompanyJoin_Start { get { return Convert.ToDateTime(GetData("CompanyJoin_Start", DateTime.MinValue)); } }
        public DateTime CompanyJoin_End { get { return Convert.ToDateTime(GetData("CompanyJoin_End", DateTime.MinValue)); } }
        public byte UserJoinType { get { return Convert.ToByte(GetData("UserJoinType", (byte)0)); } }
        public DateTime UserJoin_Start { get { return Convert.ToDateTime(GetData("UserJoin_Start", DateTime.MinValue)); } }
        public DateTime UserJoin_End { get { return Convert.ToDateTime(GetData("UserJoin_End", DateTime.MinValue)); } }
        public byte RecruitType { get { return Convert.ToByte(GetData("RecruitType", (byte)0)); } }
        public DateTime Recruit_Start { get { return Convert.ToDateTime(GetData("Recruit_Start", DateTime.MinValue)); } }
        public DateTime Recruit_End { get { return Convert.ToDateTime(GetData("Recruit_End", DateTime.MinValue)); } }
        public byte ParticipateType { get { return Convert.ToByte(GetData("ParticipateType", (byte)0)); } }
        public DateTime Participate_Start { get { return Convert.ToDateTime(GetData("Participate_Start", DateTime.MinValue)); } }
        public DateTime Participate_End { get { return Convert.ToDateTime(GetData("Participate_End", DateTime.MinValue)); } }
        public byte UserViewType { get { return Convert.ToByte(GetData("UserViewType", (byte)0)); } }
        public DateTime UserView_Start { get { return Convert.ToDateTime(GetData("UserView_Start", DateTime.MinValue)); } }
        public DateTime UserView_End { get { return Convert.ToDateTime(GetData("UserView_End", DateTime.MinValue)); } }
    }
}
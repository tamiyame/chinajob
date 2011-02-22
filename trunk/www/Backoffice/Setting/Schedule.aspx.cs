using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Site.Web.Page;

using Com.Library.DB.Schedule;

public partial class Backoffice_Setting_Schedule : SitePage
{
    public RecruitScheduleEntity ScheduleInfo = null;
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);
        if (this.IsPostBack)
        {
            byte CompanyJoinType = Request.Form["CompanyJoinType"] == null ? (byte)0 : Convert.ToByte(Request.Form["CompanyJoinType"]);
            byte UserJoinType = Request.Form["UserJoinType"] == null ? (byte)0 : Convert.ToByte(Request.Form["UserJoinType"]);
            byte RecruitType = Request.Form["RecruitType"] == null ? (byte)0 : Convert.ToByte(Request.Form["RecruitType"]);
            byte ParticipateType = Request.Form["ParticipateType"] == null ? (byte)0 : Convert.ToByte(Request.Form["ParticipateType"]);
            
            string CompanyJoin_Start_Year = Request.Form["CompanyJoin_Start_Year"];
            string CompanyJoin_Start_Month = Request.Form["CompanyJoin_Start_Month"];
            string CompanyJoin_Start_Day = Request.Form["CompanyJoin_Start_Day"];
            string CompanyJoin_End_Year = Request.Form["CompanyJoin_End_Year"];
            string CompanyJoin_End_Month = Request.Form["CompanyJoin_End_Month"];
            string CompanyJoin_End_Day = Request.Form["CompanyJoin_End_Day"];

            string UserJoin_Start_Year = Request.Form["UserJoin_Start_Year"];
            string UserJoin_Start_Month = Request.Form["UserJoin_Start_Month"];
            string UserJoin_Start_Day = Request.Form["UserJoin_Start_Day"];
            string UserJoin_End_Year = Request.Form["UserJoin_End_Year"];
            string UserJoin_End_Month = Request.Form["UserJoin_End_Month"];
            string UserJoin_End_Day = Request.Form["UserJoin_End_Day"];

            string Recruit_Start_Year = Request.Form["Recruit_Start_Year"];
            string Recruit_Start_Month = Request.Form["Recruit_Start_Month"];
            string Recruit_Start_Day = Request.Form["Recruit_Start_Day"];
            string Recruit_End_Year = Request.Form["Recruit_End_Year"];
            string Recruit_End_Month = Request.Form["Recruit_End_Month"];
            string Recruit_End_Day = Request.Form["Recruit_End_Day"];

            string Participate_Start_Year = Request.Form["Participate_Start_Year"];
            string Participate_Start_Month = Request.Form["Participate_Start_Month"];
            string Participate_Start_Day = Request.Form["Participate_Start_Day"];
            string Participate_End_Year = Request.Form["Participate_End_Year"];
            string Participate_End_Month = Request.Form["Participate_End_Month"];
            string Participate_End_Day = Request.Form["Participate_End_Day"];

            RecruitScheduleSetArguments arg = new RecruitScheduleSetArguments();
            arg.CompanyJoinType = CompanyJoinType;
            arg.CompanyJoin_Start = Convert.ToDateTime(CompanyJoin_Start_Year + "-" + CompanyJoin_Start_Month + "-" + CompanyJoin_Start_Day);
            arg.CompanyJoin_End = Convert.ToDateTime(CompanyJoin_End_Year + "-" + CompanyJoin_End_Month + "-" + CompanyJoin_End_Day);

            arg.UserJoinType = UserJoinType;
            arg.UserJoin_Start = Convert.ToDateTime(UserJoin_Start_Year + "-" + UserJoin_Start_Month + "-" + UserJoin_Start_Day);
            arg.UserJoin_End = Convert.ToDateTime(UserJoin_End_Year + "-" + UserJoin_End_Month + "-" + UserJoin_End_Day);

            arg.RecruitType = RecruitType;
            arg.Recruit_Start = Convert.ToDateTime(Recruit_Start_Year + "-" + Recruit_Start_Month + "-" + Recruit_Start_Day);
            arg.Recruit_End = Convert.ToDateTime(Recruit_End_Year + "-" + Recruit_End_Month + "-" + Recruit_End_Day);

            arg.ParticipateType = ParticipateType;
            arg.Participate_Start = Convert.ToDateTime(Participate_Start_Year + "-" + Participate_Start_Month + "-" + Participate_Start_Day);
            arg.Participate_End = Convert.ToDateTime(Participate_End_Year + "-" + Participate_End_Month + "-" + Participate_End_Day);

            RecruitScheduleSet set = new RecruitScheduleSet();
            set.SetArguments(arg);
            set.ExecuteNonQuery();
        }

        RecruitScheduleGetInfo info = new RecruitScheduleGetInfo();
        info.ExecuteNonQuery();
        ScheduleInfo = info.GetOutput();
    }
}

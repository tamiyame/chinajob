using System;

using Com.Library.Page;
using Com.Library.DB.Schedule;

namespace Site.Web.Page
{
    public class SitePage : WebPage
    {
        private RecruitScheduleEntity m_ScheduleInfo = null;
        public bool IsRecruitCreate
        {
            get {
                ScheduleInfo();
                if ( m_ScheduleInfo.CompanyJoinType == 1 )
                    return true;

                if (m_ScheduleInfo.CompanyJoin_Start < DateTime.Now.AddHours(-1) && m_ScheduleInfo.CompanyJoin_End > DateTime.Now.AddHours(-1))
                    return true;
                return false;
            }
        }

        public bool isUserCreate
        {
            get {
                ScheduleInfo();
                if (m_ScheduleInfo.UserJoinType == 1)
                    return true;

                if (m_ScheduleInfo.UserJoin_Start < DateTime.Now.AddHours(-1) && m_ScheduleInfo.UserJoin_End > DateTime.Now.AddHours(-1))
                    return true;
                return false;
            }
        }

        public bool IsRecruitApply
        {
            get
            {
                ScheduleInfo();
                if (m_ScheduleInfo.RecruitType == 1)
                    return true;

                if (m_ScheduleInfo.Recruit_Start < DateTime.Now.AddHours(-1) && m_ScheduleInfo.Recruit_End > DateTime.Now.AddHours(-1))
                    return true;
                return false;
            }
        }

        public bool IsParticipate
        {
            get
            {
                ScheduleInfo();
                if (m_ScheduleInfo.ParticipateType == 1)
                    return true;

                if (m_ScheduleInfo.Participate_Start < DateTime.Now.AddHours(-1) && m_ScheduleInfo.Participate_End > DateTime.Now.AddHours(-1))
                    return true;
                return false;
            }
        }

        public bool IsUserView
        {
            get
            {
                ScheduleInfo();
                if (m_ScheduleInfo.UserViewType == 1)
                    return true;

                if (m_ScheduleInfo.UserView_Start < DateTime.Now.AddHours(-1) && m_ScheduleInfo.UserView_End > DateTime.Now.AddHours(-1))
                    return true;
                return false;
            }
        }

        private void ScheduleInfo()
        {
            if (m_ScheduleInfo == null)
            {
                RecruitScheduleGetInfo info = new RecruitScheduleGetInfo();
                info.ExecuteNonQuery();
                m_ScheduleInfo = info.GetOutput();
            }
        }

        public new SiteMaster WebMaster
        {
            get
            {
                if (this.Master != null)
                {
                    if (base.Master is SiteMaster)
                        return (SiteMaster)base.Master;
                    else
                        return null;
                }
                return null;
            }
        }

        public string GetURL(string url)
        {
            return this.WebMaster.GetURL(url);
        }

		public string GetText(string transCode)
		{
			return WebMaster.GetText(transCode);
		}

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            if (this.Request.Url.ToString().ToLower().IndexOf("/backoffice/") != -1)
            {
                if (!this.WebCookies.IsLogin)
                {
                    Response.Redirect("/kr/home/");
                    Response.End();
                }
                if (!this.WebCookies.IsAdmin)
                {
                    Response.Redirect("/kr/home/");
                    Response.End();
                }
            }
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
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
using Com.Library.DB.Company;
using Com.Library.DB.Category;
using System.Web.Services;
using Com.Framework.Data;
using Com.Library.DB.Participate;
using Site.Web.Util;
using Com.Library.Cookie;

public partial class CN_Company_recruit_manage : SitePage
{
	private List<RecruitMasterEntity> m_RecruitList = null;
	public List<RecruitMasterEntity> RecruitList
	{
		get { return m_RecruitList; }
	}

	protected void Page_Load(object sender, EventArgs e)
    {
		if (!this.WebCookies.IsLogin)
		{
			Response.Clear();
			Response.Write("<script language='javascript'>;location.href='" + GetURL("/home") + "'; alert('" + Message.Msg(this.WebMaster.CountryCode, k_MsgType.User_Login) + "');</script>");
			Response.End();
		}

		if (!this.WebCookies.isCompany)
		{
			Response.Clear();
			Response.Write("<script language='javascript'>;location.href='" + GetURL("/home") + "'; alert('" + Message.Msg(this.WebMaster.CountryCode, k_MsgType.Company_User) + "');</script>");
			Response.End();
		}

        if (!this.IsRecruitCreate)
        {
            Response.Clear();
            Response.Write("<script language='javascript'>location.href='" + this.GetURL("/home/") + "';alert('" + Message.Msg(this.WebMaster.CountryCode, k_MsgType.CompanyJoinType) + "');</script>");
            Response.End();
        }

		RecruitMasterGetListArguments listArg = new RecruitMasterGetListArguments();
		listArg.CompanyNo = this.WebCookies.UserNo;
		RecruitMasterGetList list = new RecruitMasterGetList();
		list.SetArguments(listArg);
		list.Execute();
		m_RecruitList = list.GetRecords();
      
    }

    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);
    }

	[WebMethod]
	public static ListData<ParticipateEntity, OutputEntity> ParticipateGetList(int RecruitNo)
	{
		WebCookie cookie = new WebCookie();
		ParticipateGetListArguments arg = new ParticipateGetListArguments();
		arg.CompanyNo = cookie.UserNo;
		arg.RecruitNo = RecruitNo;
		arg.PageNo = 1;
		arg.PageSize = 0;
		ParticipateGetList list = new ParticipateGetList();
		list.SetArguments(arg);
		list.Execute();
		List<ParticipateEntity> _record = list.GetRecords();
		OutputEntity _output = list.GetOutput();
		return (new ListData<ParticipateEntity, OutputEntity>(_record, _output));
	}

	[WebMethod]
	public static void SetConfirm(long seqNo, byte ConfirmType)
	{
		ParticipateModifyArguments arg = new ParticipateModifyArguments();
		arg.SeqNo = seqNo;
		arg.ConfirmType = ConfirmType;
		ParticipateModify modify = new ParticipateModify();
		modify.SetArguments(arg);
		modify.ExecuteNonQuery();
	}

	[WebMethod]
	public static void Remove(long seqNo)
	{
		ParticipateModifyArguments arg = new ParticipateModifyArguments();
		arg.SeqNo = seqNo;
		arg.Status = 2;
		ParticipateModify modify = new ParticipateModify();
		modify.SetArguments(arg);
		modify.ExecuteNonQuery();
	}
}

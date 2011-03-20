using System;
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
using System.Web.Services;

using Site.Web.Page;
using Com.Framework.Data;
using Com.Library.DB.Company;
using Com.Library.DB.Participate;
using Com.Library.DB.Category;

public partial class KR_User_human_recruit_manage : SitePage
{
    public int PageNo { get; set; }
    public byte PageSize = 20;

    private ListData<ParticipateEntity, OutputEntity> m_ParticiapteList = null;
    public ListData<ParticipateEntity, OutputEntity> ParticiapteList
    {
        get { return m_ParticiapteList; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        PageNo = Request.QueryString["PageNo"] == null ? 1 : Convert.ToInt32(Request.QueryString["PageNo"]);

        if (!this.WebCookies.IsLogin)
        {
            Response.Clear();
            Response.Write("<script language='javascript'>alert('로그인하셔야 이용가능합니다.'); location.href='/kr/home/';</script>");
            Response.End();
        }

        if (WebCookies.isCompany)
        {
            Response.Clear();
            Response.Write("<script language='javascript'>alert('기업회원 입니다.'); location.href='/kr/home/';</script>");
            Response.End();
        }
        
    }

    protected override void OnPreRender(EventArgs e)
    {
        if (this.IsPostBack)
        {
            if ( Request.Form["SeqNo"] != null )
            {
                string[] arrSeqNo = Request.Form["SeqNo"].Split(',');
                string[] arrUserIDX = Request.Form["UserIDX"].Split(',');
                for (int i = 0; i < arrSeqNo.Length; i++)
                {
                    long SeqNo = Convert.ToInt64(arrSeqNo[i]);
                    int UserIDX = Convert.ToInt32(arrUserIDX[i]);
                    ParticipateSetArguments setArg = new ParticipateSetArguments();
                    setArg.UserIDX = UserIDX;
                    setArg.SeqNo = SeqNo;
                    ParticipateSet set = new ParticipateSet();
                    set.SetArguments(setArg);
                    set.ExecuteNonQuery();
                }
            }
        }
        base.OnPreRender(e);

        ParticipateGetListArguments arg = new ParticipateGetListArguments();
        arg.UserNo = this.WebMaster.WebCookies.UserNo;
        arg.PageNo = PageNo;
        arg.PageSize = PageSize;
        ParticipateGetList list = new ParticipateGetList();
        list.SetArguments(arg);
        list.Execute();
        List<ParticipateEntity> _record = list.GetRecords();
        OutputEntity _output = list.GetOutput();
        m_ParticiapteList = new ListData<ParticipateEntity, OutputEntity>(_record, _output);
    }

    public string GetCategoryName(int CategoryNo)
    {
        CategoryGetInfoArguments arg = new CategoryGetInfoArguments();
        arg.CategoryNo = CategoryNo;
        CategoryGetInfo info = new CategoryGetInfo();
        info.SetArguments(arg);
        info.ExecuteNonQuery();

        return info.GetOutput().CategoryKRName;
    }

    public string GetSubCategoryName(int SubCategoryNo)
    {
        SubCategoryGetInfoArguments arg = new SubCategoryGetInfoArguments();
        arg.SubCategoryNo = SubCategoryNo;
        SubCategoryGetInfo info = new SubCategoryGetInfo();
        info.SetArguments(arg);
        info.ExecuteNonQuery();

        return info.GetOutput().SubCategoryKRName;
    }

    public CompanyDetailEntity GetCompanyInfo(int companyNo)
    {
        CompanyDetailGetInfo info = new CompanyDetailGetInfo();
        CompanyDetailGetInfoArguments arg = new CompanyDetailGetInfoArguments();
        arg.CompanyNo = companyNo;
        info.SetArguments(arg);
        info.ExecuteNonQuery();
        return info.GetOutput();
    }

    public RecruitEntity GetRecruit(int companyNo, int recruitNo, int countryNo)
    {
        RecruitGetInfoArguments arg = new RecruitGetInfoArguments();
        arg.CompanyNo = companyNo;
        arg.CountryNo = countryNo;
        arg.RecruitNo = recruitNo;

        RecruitGetInfo info = new RecruitGetInfo();
        info.SetArguments(arg);
        info.ExecuteNonQuery();

        return info.GetOutput();
    }
}

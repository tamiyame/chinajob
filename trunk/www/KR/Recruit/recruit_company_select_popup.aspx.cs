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
using System.Web.Services;

using Com.Framework.Data;
using Com.Library.DB.Company;
using Com.Library.DB.Participate;
using Com.Library.DB.Category;
using Com.Library.Cookie;
using Com.Library.DB.Schedule;
using Com.Library.DB.User;

public partial class KR_Recruit_recruit_company_select_popup : System.Web.UI.Page
{
    private ListData<ParticipateEntity, OutputEntity> m_ParticipateList = null;
    public ListData<ParticipateEntity, OutputEntity> ParticipateList
    {
        get { return m_ParticipateList; }
    }

    public int RecruitNo = 0;
    public int CompanyNo = 0;
    public int CountryNo = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            RecruitNo = Convert.ToInt32(Request.QueryString["RecruitNo"]);
            CompanyNo = Convert.ToInt32(Request.QueryString["CompanyNo"]);
            CountryNo = Convert.ToInt32(Request.QueryString["CountryNo"]);
        }
        catch (Exception)
        {
            Response.Clear();
            Response.Write("<script language='javascript'>alert('잘못된 정보를 받았습니다.'); self.close();</script>");
            Response.End();
        }
        WebCookie cookie = new WebCookie();
        if (!cookie.IsLogin)
        {
            Response.Clear();
            Response.Write("<script language='javascript'>alert('로그인하셔야 이용가능합니다.'); self.close();</script>");
            Response.End();
        }

        if (!IsRecruitApply)
        {
            //Response.Clear();
            //Response.Write("<script language='javascript'>alert('채용지원 가능 기간이 아닙니다.'); self.close();</script>");
            //Response.End();
        }

        if (cookie.isCompany)
        {
            Response.Clear();
            Response.Write("<script language='javascript'>alert('기업회원 입니다.'); self.close();</script>");
            Response.End();
        }

        ResumeGetInfoArguments infoArg = new ResumeGetInfoArguments();
        infoArg.UserNo = cookie.UserNo;
        ResumeGetInfo info = new ResumeGetInfo();
        info.SetArguments(infoArg);
        info.ExecuteNonQuery();
        ResumeEntity resumeEntity = info.GetOutput();

        if (resumeEntity.RegistryTime == DateTime.MinValue)
        {
            Response.Clear();
            Response.Write("<script language='javascript'>alert('이력서 등록이 안되었습니다.\\n 이력서를 등록해주세요!!!.'); self.close();</script>");
            Response.End();
        }

        ResumeDetailGetInfoArguments detailArg_kr = new ResumeDetailGetInfoArguments();
        detailArg_kr.CountryNo = 1;
        detailArg_kr.UserNo = cookie.UserNo;
        ResumeDetailGetInfo detail_kr = new ResumeDetailGetInfo();
        detail_kr.SetArguments(detailArg_kr);
        detail_kr.ExecuteNonQuery();
        ResumeDetailEntity detailEntity_kr = detail_kr.GetOutput();
        if (detailEntity_kr.ResumeDetailNo == 0)
        {
            Response.Clear();
            Response.Write("<script language='javascript'>alert('한국어 이력서가 등록이 안되어 있습니다.\\n 이력서를 등록해주세요!!!'); self.close();</script>");
            Response.End();
        }

        ResumeDetailGetInfoArguments detailArg_cn = new ResumeDetailGetInfoArguments();
        detailArg_cn.CountryNo = 2;
        detailArg_cn.UserNo = cookie.UserNo;
        ResumeDetailGetInfo detail_cn = new ResumeDetailGetInfo();
        detail_cn.SetArguments(detailArg_cn);
        detail_cn.ExecuteNonQuery();
        ResumeDetailEntity detailEntity_cn = detail_cn.GetOutput();

        ResumeDetailGetInfoArguments detailArg_eng = new ResumeDetailGetInfoArguments();
        detailArg_eng.CountryNo = 3;
        detailArg_eng.UserNo = cookie.UserNo;
        ResumeDetailGetInfo detail_eng= new ResumeDetailGetInfo();
        detail_eng.SetArguments(detailArg_eng);
        detail_eng.ExecuteNonQuery();
        ResumeDetailEntity detailEntity_eng = detail_eng.GetOutput();

        if (detailEntity_eng.ResumeDetailNo == 0 && detailEntity_cn.ResumeDetailNo == 0)
        {
            Response.Clear();
            Response.Write("<script language='javascript'>alert('중국어 또는 영문이력서를 등록하셔야합니다\\n 이력서를 등록해주세요!!!'); self.close();</script>");
            Response.End();
        }



        ParticipateGetList list = new ParticipateGetList();
        ParticipateGetListArguments arg = new ParticipateGetListArguments();
        arg.UserNo = cookie.UserNo;
        arg.PageNo = 1;
        arg.PageSize=0;
        list.SetArguments(arg);
        list.Execute();
        OutputEntity _output = list.GetOutput();
        List<ParticipateEntity> _record = list.GetRecords();
        m_ParticipateList = new ListData<ParticipateEntity, OutputEntity>(_record, _output);
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

    [WebMethod]
    public static void SetParticiapte(int userIDX, int companyNo, int recruitNo, int countryNo)
    {
        WebCookie cookie = new WebCookie();
        CompanyDetailGetInfo info = new CompanyDetailGetInfo();
        CompanyDetailGetInfoArguments argInfo = new CompanyDetailGetInfoArguments();
        argInfo.CompanyNo = companyNo;
        info.SetArguments(argInfo);
        info.ExecuteNonQuery();
        CompanyDetailEntity detailInfo = info.GetOutput();

        RecruitGetInfoArguments argRecruit = new RecruitGetInfoArguments();
        argRecruit.CompanyNo = companyNo;
        argRecruit.CountryNo = countryNo;
        argRecruit.RecruitNo = recruitNo;
        RecruitGetInfo rInfo = new RecruitGetInfo();
        rInfo.SetArguments(argRecruit);
        rInfo.ExecuteNonQuery();
        RecruitEntity recruit = rInfo.GetOutput();

        ParticipateSet set = new ParticipateSet();
        ParticipateSetArguments arg = new ParticipateSetArguments();
        arg.Category1No = recruit.Category1No;
        arg.Category2No = recruit.Category2No;
        arg.CompanyNo = companyNo;
        arg.CountryNo = countryNo;
        arg.RecruitNo = recruitNo;
        arg.RecruitType = 1;
        arg.UserIDX = userIDX;
        arg.UserNo = cookie.UserNo;
        set.SetArguments(arg);
        set.ExecuteNonQuery();
    }

    public bool IsRecruitApply
    {
        get
        {
            ScheduleInfo();
            if (m_ScheduleInfo.RecruitType == 1)
                return true;

            if (m_ScheduleInfo.Recruit_Start < DateTime.Now && m_ScheduleInfo.Recruit_End > DateTime.Now)
                return true;
            return false;
        }
    }
    private RecruitScheduleEntity m_ScheduleInfo = null;
    private void ScheduleInfo()
    {
        if (m_ScheduleInfo == null)
        {
            RecruitScheduleGetInfo info = new RecruitScheduleGetInfo();
            info.ExecuteNonQuery();
            m_ScheduleInfo = info.GetOutput();
        }
    }
}

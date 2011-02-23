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
using Site.Web.Util;
using Com.Library.DB.Company;
using Com.Library.DB.Category;

public partial class KR_Company_recruit_regist : SitePage
{
    public List<CategoryEntity> Category1List = null;
    public List<CategoryEntity> CityCategoryList = null;
    public List<CategoryEntity> PayCategoryList = null;
    public List<CategoryEntity> AgeCategoryList = null;
    public RecruitEntity RecruitInfo = null;
    private int m_CountryNo = 0;
    public int CountryNo
    {
        get { return this.m_CountryNo; }
    }

    private int m_RecruitNo = 0;
    public int RecruitNo
    {
        get { return this.m_RecruitNo; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsRecruitCreate)
        {
            Response.Clear();
            Response.Write("<script language='javascript'>location.href='" + this.GetURL("/home/") + "';alert('" + Message.Msg(this.WebMaster.CountryCode, k_MsgType.CompanyJoinType) + "');</script>");
            Response.End();
        }

        m_CountryNo = Request.QueryString["CountryNo"] == null ? 1 : Convert.ToInt32(Request.QueryString["CountryNo"]);
        m_RecruitNo = Request.QueryString["RecruitNo"] == null ? 1 : Convert.ToInt32(Request.QueryString["RecruitNo"]);

        RecruitGetInfoArguments infoArg = new RecruitGetInfoArguments();
        infoArg.CompanyNo = this.WebCookies.UserNo;
        infoArg.CountryNo = CountryNo;
        infoArg.RecruitNo = RecruitNo;
        RecruitGetInfo recruitInfo = new RecruitGetInfo();
        recruitInfo.SetArguments(infoArg);
        recruitInfo.ExecuteNonQuery();
        RecruitInfo = recruitInfo.GetOutput();
    }

    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);
        
        if (!this.WebCookies.isCompany)
        {
            Response.Clear();
            Response.Write("<script language='javascript'>location.href='" + this.GetURL("/home/") + "';alert('" + Message.Msg(this.WebMaster.CountryCode, k_MsgType.Company_User) + "');</script>");
            Response.End();
        }

        CompanyGetInfo info = new CompanyGetInfo();
        CompanyGetInfoArguments argInfo = new CompanyGetInfoArguments();
        argInfo.CompanyID = this.WebCookies.UserID;
        info.SetArguments(argInfo);
        info.ExecuteNonQuery();
        CompanyEntity infoEntity = info.GetOutput();
        if (infoEntity.Approval != 1)
        {
            Response.Clear();
            Response.Write("<script language='javascript'>location.href='" + this.GetURL("/home/") + "';alert('" + Message.Msg(this.WebMaster.CountryCode, k_MsgType.Apply_Company) + "');</script>");
            Response.End();
        }
         

        this.Form.Enctype = "multipart/form-data";
        if (this.IsPostBack)
        {
            string join_type = Request.Form["join_type"],
            join_count = Request.Form["join_count"],
            jobType1 = Request.Form["jobType1"],
            jobType2 = Request.Form["jobType2"],
            jobType_direct = Request.Form["jobType_direct"],
            career_year = Request.Form["career_year"],
            people_count = Request.Form["people_count"],
            gender = Request.Form["gender"],
            AgeType = Request.Form["AgeType"],
            AgeCategory = Request.Form["AgeCategory"],
            AgeEtcValue = Request.Form["AgeEtcValue"],
            education = Request.Form["education"],
            major = Request.Form["major"],
            major_direct = Request.Form["major_direct"],
            china = Request.Form["china"],
            english = Request.Form["english"],
            japanese = Request.Form["japanese"],
            etc_lang = Request.Form["etc_lang"],
            etc_lang_level = Request.Form["etc_lang_level"],
            main_task = Request.Form["main_task"],
            address_1 = Request.Form["address_1"],
            address_2 = Request.Form["address_2"],
            address_3 = Request.Form["address_3"],
            recruit_day_1 = Request.Form["recruit_day_1"],
            recruit_day_2 = Request.Form["recruit_day_2"],
            recruit_day_3 = Request.Form["recruit_day_3"],
            etc_require = Request.Form["etc_require"],
            PayCategory = Request.Form["PayCategory"],
            contract = Request.Form["contract"],
            working_time_opt = Request.Form["working_time_opt"],
            working_time_etc = Request.Form["working_time_etc"],
            insurance = Request.Form["insurance"],
            insurance_etc = Request.Form["insurance_etc"],
            food = Request.Form["food"],
            food_etc = Request.Form["food_etc"],
            severance_pay = Request.Form["severance_pay"],
            severance_etc = Request.Form["severance_etc"],
            vacation = Request.Form["vacation"],
            vacation_etc = Request.Form["vacation_etc"],
            benefit_etc = Request.Form["benefit_etc"],
            interviewers = Request.Form["interviewers"],
            countryNo = Request.Form["countryNo"];


            if (RecruitInfo.RegistryTime == DateTime.MinValue)
            {
                RecruitCreateArguments arg = new RecruitCreateArguments();
                // recruit key
                arg.CompanyNo = this.WebCookies.UserNo;
                arg.CountryNo = CountryNo;
                arg.RecruitNo = RecruitNo;

                // input part
                arg.JoinType = Convert.ToByte(join_type);
                arg.AcademicAbility = Convert.ToByte(education);
                arg.AgeType = Convert.ToByte(AgeType);
                arg.AgeCategory = Convert.ToInt32(AgeCategory);
                arg.AgeEtcValue = AgeEtcValue;
                arg.BenefitsETC = benefit_etc;
                arg.BenefitsInsurance = Convert.ToByte(insurance);
                arg.BenefitsInsuranceEtcValue = insurance_etc;
                arg.BenefitsRoomAndBoard = Convert.ToByte(food);
                arg.BenefitsRoomAndBoardEtcValue = food_etc;
                arg.BenefitsSeverancePay = Convert.ToByte(severance_pay);
                arg.BenefitsSeverancePayEtcValue = severance_etc;
                arg.BenefitsVacation = Convert.ToByte(vacation);
                arg.BenefitsVacationEtcValue = vacation_etc;
                arg.Career = Convert.ToByte(career_year);
                arg.Category1No = Convert.ToInt32(jobType1);
                arg.Category2No = Convert.ToInt32(jobType2);
                arg.CategoryEtcValue = jobType_direct;
                arg.ChineseLevel = Convert.ToByte(china);

                arg.ContactPeriod = Convert.ToByte(contract);
                arg.EnglishLevel = Convert.ToByte(english);
                arg.EtcEligibilityRule = etc_require;
                arg.ETCLanguageLevel = Convert.ToByte(etc_lang_level);
                arg.ETCLanguageName = etc_lang;
                arg.Gender = Convert.ToByte(gender);

                arg.JapanessLevel = Convert.ToByte(japanese);
                arg.JobFairRecruiter = interviewers;
                arg.JobFairValue = Convert.ToByte(join_count);
                arg.MainWork = main_task;
                arg.Major = Convert.ToByte(major);
                arg.MajorEtcValue = major_direct;
                arg.CityCategory = Convert.ToInt32(address_1);
                arg.AreaCategory = Convert.ToInt32(address_2);
                arg.RecruitAddressDetail = address_3;
                arg.RecruitCount = Convert.ToInt32(people_count);
                arg.RecruitDate = new DateTime(Convert.ToInt32(recruit_day_1), Convert.ToInt32(recruit_day_2), Convert.ToInt32(recruit_day_3));
                arg.PayCategory = Convert.ToInt32(PayCategory);
                arg.WorkingHoursType = Convert.ToByte(working_time_opt);
                arg.WorkingHours = working_time_etc;


                RecruitCreate create = new RecruitCreate();
                create.SetArguments(arg);
                create.ExecuteNonQuery();
                Response.Clear();
                Response.Write("<script language='javascript'>location.href='" + this.GetURL("/company/recruit_regist_list.aspx") + "';alert('" + Message.Msg(CountryNo, k_MsgType.Write_Confirm) + ".');</script>");
            }
            else
            {
                RecruitModifyArguments arg = new RecruitModifyArguments();
                // recruit key
                arg.CompanyNo = this.WebCookies.UserNo;
                arg.CountryNo = CountryNo;
                arg.RecruitNo = RecruitNo;

                // input part
                arg.JoinType = Convert.ToByte(join_type);
                arg.AcademicAbility = Convert.ToByte(education);
                arg.AgeType = Convert.ToByte(AgeType);
                arg.AgeCategory = Convert.ToInt32(AgeCategory);
                arg.AgeEtcValue = AgeEtcValue;
                arg.BenefitsETC = benefit_etc;
                arg.BenefitsInsurance = Convert.ToByte(insurance);
                arg.BenefitsInsuranceEtcValue = insurance_etc;
                arg.BenefitsRoomAndBoard = Convert.ToByte(food);
                arg.BenefitsRoomAndBoardEtcValue = food_etc;
                arg.BenefitsSeverancePay = Convert.ToByte(severance_pay);
                arg.BenefitsSeverancePayEtcValue = severance_etc;
                arg.BenefitsVacation = Convert.ToByte(vacation);
                arg.BenefitsVacationEtcValue = vacation_etc;
                arg.Career = Convert.ToByte(career_year);
                arg.Category1No = Convert.ToInt32(jobType1);
                arg.Category2No = Convert.ToInt32(jobType2);
                arg.ChineseLevel = Convert.ToByte(china);

                arg.ContactPeriod = Convert.ToByte(contract);
                arg.EnglishLevel = Convert.ToByte(english);
                arg.EtcEligibilityRule = etc_require;
                arg.ETCLanguageLevel = Convert.ToByte(etc_lang_level);
                arg.ETCLanguageName = etc_lang;
                arg.Gender = Convert.ToByte(gender);

                arg.JapanessLevel = Convert.ToByte(japanese);
                arg.JobFairRecruiter = interviewers;
                arg.JobFairValue = Convert.ToByte(join_count);
                arg.MainWork = main_task;
                arg.Major = Convert.ToByte(major);
                arg.MajorEtcValue = major_direct;
                arg.CityCategory = Convert.ToInt32(address_1);
                arg.AreaCategory = Convert.ToInt32(address_2);
                arg.RecruitAddressDetail = address_3;
                arg.RecruitCount = Convert.ToInt32(people_count);
                arg.RecruitDate = new DateTime(Convert.ToInt32(recruit_day_1), Convert.ToInt32(recruit_day_2), Convert.ToInt32(recruit_day_3));
                arg.PayCategory = Convert.ToInt32(PayCategory);
                arg.WorkingHoursType = Convert.ToByte(working_time_opt);
                arg.WorkingHours = working_time_etc;


                RecruitModify modify = new RecruitModify();
                modify.SetArguments(arg);
                modify.ExecuteNonQuery();
                Response.Clear();
                Response.Write("<script language='javascript'>location.href='" + this.GetURL("/company/recruit_regist_list.aspx") + "';alert('" + Message.Msg(CountryNo, k_MsgType.Modify_Confirm) + "');</script>");
            }
        }
        else
        {
            CategoryGetList list = new CategoryGetList();
            CategoryGetListArguments arg = new CategoryGetListArguments();
            arg.CategoryMasterNo = 1;
            list.SetArguments(arg);
            list.Execute();
            Category1List = list.GetRecords();
        
            CategoryGetList citylist = new CategoryGetList();
            CategoryGetListArguments cityArg = new CategoryGetListArguments();
            cityArg.CategoryMasterNo = 3;
            citylist.SetArguments(cityArg);
            citylist.Execute();
            CityCategoryList = citylist.GetRecords();

            CategoryGetList paylist = new CategoryGetList();
            CategoryGetListArguments payArg = new CategoryGetListArguments();
            payArg.CategoryMasterNo = 4;
            paylist.SetArguments(payArg);
            paylist.Execute();
            PayCategoryList = paylist.GetRecords();

            CategoryGetList agelist = new CategoryGetList();
            CategoryGetListArguments ageArg = new CategoryGetListArguments();
            ageArg.CategoryMasterNo = 2;
            agelist.SetArguments(ageArg);
            agelist.Execute();
            AgeCategoryList = agelist.GetRecords();
        }
    }

    public string CategoryLangName(CategoryEntity et)
    {
        if (CountryNo == 1)
            return et.CategoryKRName;
        else if (CountryNo == 2)
            return et.CategoryCNName;
        else if (CountryNo == 3)
            return et.CategoryENGName;
        return string.Empty;

    }
}

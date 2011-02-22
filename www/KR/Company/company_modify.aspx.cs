using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

using Site.Web.Page;
using Site.Web.Util;
using Com.Library.DB.Company;
using Com.Library.DB.Category;
using Com.Framework.File;

public partial class KR_Company_company_modify : SitePage
{
    public List<CategoryEntity> BusinessCategoryList = null;
    public CompanyEntity CompanyInfo = null;
    public CompanyDetailEntity CompanyDetailInfo = null;
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

        CategoryGetList list = new CategoryGetList();
        CategoryGetListArguments arg = new CategoryGetListArguments();
        arg.CategoryMasterNo = 5;
        list.SetArguments(arg);
        list.Execute();
        BusinessCategoryList = list.GetRecords();

        CompanyGetInfoArguments infoArg = new CompanyGetInfoArguments();
        infoArg.CompanyNo = this.WebCookies.UserNo;

        CompanyDetailGetInfoArguments detailnfoArg = new CompanyDetailGetInfoArguments();
        detailnfoArg.CompanyNo = this.WebCookies.UserNo;

        CompanyGetInfo info = new CompanyGetInfo();
        info.SetArguments(infoArg);
        info.ExecuteNonQuery();

        CompanyDetailGetInfo detailInfo = new CompanyDetailGetInfo();
        detailInfo.SetArguments(detailnfoArg);
        detailInfo.ExecuteNonQuery();

        CompanyDetailInfo = detailInfo.GetOutput();
        CompanyInfo = info.GetOutput();
    }

    protected override void OnPreRender(EventArgs e)
    {
        string koreaName, chinaName, englishName;
        string CompanyNo, CompanyID, Password;
        string Email, JobType, jobType_etc, Representative, Company_type, build_date;
        string employ_count, fund, fundcurrency, investment, investment_currency;
        string business_description, recruiting_manager, phone, fax, address, homepage;
        string fileNameLog = string.Empty;
        string fileNamePermit = string.Empty;
        base.OnPreRender(e);

        this.Form.Enctype = "multipart/form-data";
        if (this.IsPostBack)
        {
            koreaName = Request.Form["koreaName"];
            chinaName = Request.Form["chinaName"];
            englishName = Request.Form["englishName"];
            Password = Request.Form["Password"];
            Email = Request.Form["Email"];
            JobType = Request.Form["JobType"];
            jobType_etc = Request.Form["jobType_etc"];
            Representative = Request.Form["Representative"];
            Company_type = Request.Form["Company_type"];
            build_date = Request.Form["build_date"];
            employ_count = Request.Form["employ_count"];
            fund = Request.Form["fund"];
            fundcurrency = Request.Form["fundcurrency"];
            investment = Request.Form["investment"];
            investment_currency = Request.Form["investment_currency"];
            business_description = Request.Form["business_description"];
            recruiting_manager = Request.Form["recruiting_manager"];
            phone = Request.Form["phone"];
            fax = Request.Form["fax"];
            address = Request.Form["address"];
            homepage = Request.Form["homepage"];



            CompanyModifyArguments companyModifyArg = new CompanyModifyArguments();
            if (Password.Trim() != "")
            {
                companyModifyArg.Password = Password;
            }
            companyModifyArg.CompanyNo = this.WebCookies.UserNo;
            CompanyModify companyModify = new CompanyModify();
            companyModify.SetArguments(companyModifyArg);
            companyModify.ExecuteNonQuery();

            CompanyDetailModifyArguments arg = new CompanyDetailModifyArguments();
            arg.CompanyNo = this.WebCookies.UserNo;
            arg.KRName = koreaName;
            arg.CNName = chinaName;
            arg.ENGName = englishName;
            arg.Email = Email;
            arg.BusinessCategoryNo = Convert.ToInt32(JobType == "" ? "0" : JobType);
            arg.BusinessCategoryEtc = jobType_etc;
            arg.PresidentName = Representative;
            arg.CapitalType = Convert.ToByte(Company_type == "" ? "0" : Company_type);
            arg.FoundYear = build_date;
            arg.EmployeeCount = Convert.ToInt32(employ_count == "" ? "0" : employ_count);
            arg.Capital = Convert.ToInt64(fund == "" ? "0" : fund);
            arg.CapitalCurrencyNo = Convert.ToInt32(fundcurrency == "" ? "0" : fundcurrency);
            arg.Turnover = Convert.ToInt64(investment == "" ? "0" : investment);
            arg.TurnoverCurrencyNo = Convert.ToInt32(investment_currency == "" ? "0" : investment_currency);
            arg.CompanyDescrition = business_description;
            arg.RecruiterName = recruiting_manager;
            arg.PhoneNo = phone;
            arg.FaxNo = fax;
            arg.HeadAddress = address;
            arg.HomepageURL = homepage;
            CompanyDetailModify companyDetailModify = new CompanyDetailModify();
            companyDetailModify.SetArguments(arg);
            companyDetailModify.ExecuteNonQuery();

            Com.Framework.File.FileManager fm = new Com.Framework.File.FileManager();
            if (Request.Files.Count > 0)
            {
                if (Request.Files["logo"].ContentLength > 0)
                {
                    fileNameLog = FileManager.Upload(Request.Files["logo"], this.WebCookies.UserNo, FileType.Company);
                }

                if (fileNameLog != string.Empty)
                {
                    CompanyDetailModifyArguments modifyArg = new CompanyDetailModifyArguments();
                    modifyArg.CompanyNo = this.WebCookies.UserNo;

                    modifyArg.CompanyImage = fileNameLog;
                    CompanyDetailModify modify = new CompanyDetailModify();
                    modify.SetArguments(modifyArg);
                    modify.ExecuteNonQuery();
                }
            }

            Response.Clear();
            Response.Write("<script language='javascript'>;location.href='company_modify.aspx'; alert('" + Message.Msg(this.WebMaster.CountryCode, k_MsgType.Modify_Confirm) + "');</script>");
        }
    }
}

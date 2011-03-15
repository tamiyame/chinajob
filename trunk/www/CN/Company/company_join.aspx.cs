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

public partial class CN_Company_company_join : SitePage
{
    public List<CategoryEntity> BusinessCategoryList = null;
    protected void Page_Load(object sender, EventArgs e)
    {

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
            CompanyNo = Request.Form["CompanyNo"];
            CompanyID = Request.Form["CompanyID"];
            Password = Request.Form["Password"];
            Email = Request.Form["Email"];
            JobType = Request.Form["JobType"];
            jobType_etc = Request.Form["jobType_etc"];
            Representative = Request.Form["Representative"];
            Company_type = Request.Form["Company_type"];
            build_date = Request.Form["build_date"];
            employ_count = Request.Form["employ_count"] == "" ? "0" : Request.Form["employ_count"].ToString();
            fund = Request.Form["fund"];
            fundcurrency = Request.Form["fundcurrency"];
            investment = Request.Form["investment"] == "" ? "0" : Request.Form["investment"];
            investment_currency = Request.Form["investment_currency"] == "" ? "0" : Request.Form["investment_currency"].ToString();
            business_description = Request.Form["business_description"];
            recruiting_manager = Request.Form["recruiting_manager"];
            phone = Request.Form["phone"];
            fax = Request.Form["fax"];
            address = Request.Form["address"];
            homepage = Request.Form["homepage"];
            fund = fund.Replace(",", "");

            CompanyCreateArguments arg = new CompanyCreateArguments();
            arg.CountryNo = 1;
            arg.KRName = koreaName;
            arg.CNName = chinaName;
            arg.ENGName = englishName;
            arg.PermitNo = CompanyNo;
            arg.CompanyID = CompanyID;
            arg.Password = Password;
            arg.Email = Email;
            arg.BusinessCategoryNo = Convert.ToInt32(JobType == "" ? "0" : JobType);
            arg.BusinessCategoryEtc = jobType_etc;
            arg.PresidentName = Representative;
            arg.CapitalType = Convert.ToByte(Company_type == "" ? "0" : Company_type);
            arg.FoundYear = build_date;
            try
            {
                arg.EmployeeCount = Convert.ToInt32(employ_count == "" ? "0" : employ_count.Replace(",", ""));
            }
            catch (Exception ex)
            {
                arg.EmployeeCount = 0;
            }
            try
            {
                arg.Capital = Convert.ToInt64(fund == "" ? "0" : fund.Replace(",", ""));
            }
            catch (Exception ex)
            {
                arg.Capital = 0;
            }
            try
            {
                arg.CapitalCurrencyNo = Convert.ToInt32(fundcurrency == "" ? "0" : fundcurrency.Replace(",", ""));
            }
            catch (Exception ex)
            {
                arg.CapitalCurrencyNo = 0;
            }
            try
            {
                arg.Turnover = Convert.ToInt64(investment == "" ? "0" : investment.Replace(",", ""));
            }
            catch (Exception ex)
            {
                arg.Turnover = 0;
            }
            try
            {
                arg.TurnoverCurrencyNo = Convert.ToInt32(investment_currency == "" ? "0" : investment_currency.Replace(",", ""));
            }
            catch (Exception ex)
            {
                arg.TurnoverCurrencyNo = 0;
            }
            arg.CompanyDescrition = business_description;
            arg.RecruiterName = recruiting_manager;
            arg.PhoneNo = phone;
            arg.FaxNo = fax;
            arg.HeadAddress = address;
            arg.HomepageURL = homepage;
            CompanyCreate create = new CompanyCreate();
            create.SetArguments(arg);
            create.ExecuteNonQuery();

            CompanyEntity info = create.GetOutput();
            Com.Framework.File.FileManager fm = new Com.Framework.File.FileManager();
            if (Request.Files.Count > 0)
            {
                if (Request.Files["logo"].ContentLength > 0)
                {
                    fileNameLog = FileManager.Upload(Request.Files["logo"], info.CompanyNo, FileType.Company);
                }

                if (Request.Files["fiPermit"].ContentLength > 0)
                {
                    fileNamePermit = FileManager.Upload(Request.Files["fiPermit"], info.CompanyNo, FileType.Permit);
                }

                CompanyDetailModifyArguments modifyArg = new CompanyDetailModifyArguments();
                modifyArg.CompanyNo = info.CompanyNo;
                modifyArg.CompanyImage = fileNameLog;
                modifyArg.PermitImage = fileNamePermit;
                CompanyDetailModify modify = new CompanyDetailModify();
                modify.SetArguments(modifyArg);
                modify.ExecuteNonQuery();
            }

            Response.Clear();
            Response.Write("<script language='javascript'>location.href='" + this.GetURL("/home/") + "';alert('" + Message.Msg(this.WebMaster.CountryCode, k_MsgType.Write_Confirm) + "');</script>");
        }
        else
        {
            CategoryGetList list = new CategoryGetList();
            CategoryGetListArguments arg = new CategoryGetListArguments();
            arg.CategoryMasterNo = 5;
            list.SetArguments(arg);
            list.Execute();
            BusinessCategoryList = list.GetRecords();
        }
    }
}

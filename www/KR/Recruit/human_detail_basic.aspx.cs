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
using Com.Library.DB.Category;
using System.Collections.Generic;
using Com.Library.DB.User;
using Site.Web.Util;
using Com.Library.DB.Company;
public partial class KR_Recruit_human_detail_basic : SitePage
{
	public ResumeEntity resumeEntity = null;
    public int CountryNo = 1;
    public byte JoinType = 3;
    public int Category1No = 0;
    public int Category2No = 0;
    public int AgeCategory = 0;
    public int CityCategory = 0;
    public int AreaCategory = 0;
    public byte Gender = 0;
    public string UserName = string.Empty;

    public int PageNo = 1;
    public byte PageSize = 10;

	public int UserNo { get; set; }
	
	protected void Page_Load(object sender, EventArgs e)
    {
		if (Request["userno"] == null || Request["userno"] == string.Empty)
		{
			Response.Write("<script type='text/javascript'>alert('userno가 들어오지 않았습니다..');location.href='" + GetURL("/recruit/human_search.aspx") + "';</script>");
			return;
		}

        Response.Redirect("/kr/home");

        PageNo = Request.QueryString["PageNo"] == null ? 1 : Convert.ToInt32(Request.QueryString["PageNo"]);
        CountryNo = Request.QueryString["Country"] == null ? 1 : Convert.ToInt32(Request.QueryString["Country"]);
        JoinType = Request.QueryString["Join"] == null ? (byte)3 : Convert.ToByte(Request.QueryString["Join"]);
        Category1No = Request.QueryString["Category1"] == null ? 0 : Convert.ToInt32(Request.QueryString["Category1"]);
        Category2No = Request.QueryString["Category2"] == null ? 0 : Convert.ToInt32(Request.QueryString["Category2"]);
        AgeCategory = Request.QueryString["Age"] == null ? 0 : Convert.ToInt32(Request.QueryString["Age"]);
        CityCategory = Request.QueryString["City"] == null ? 0 : Convert.ToInt32(Request.QueryString["City"]);
        AreaCategory = Request.QueryString["Area"] == null ? 0 : Convert.ToInt32(Request.QueryString["Area"]);
        Gender = Request.QueryString["Gender"] == null ? (byte)0 : Convert.ToByte(Request.QueryString["Gender"]);
        UserName = Request.QueryString["Name"] == null ? string.Empty : Convert.ToString(Request.QueryString["Name"]);

		UserNo = Convert.ToInt32(Request["userno"]);
		LoadResume();
	}

	protected void LoadResume()
	{
		ResumeGetInfoArguments resumeGetInfoArguments = new ResumeGetInfoArguments();
		resumeGetInfoArguments.UserNo = UserNo;

		ResumeGetInfo resumeGetInfo = new ResumeGetInfo();
		resumeGetInfo.SetArguments(resumeGetInfoArguments);
		resumeGetInfo.ExecuteNonQuery();
		resumeEntity = resumeGetInfo.GetOutput();

		if (resumeEntity.RegistryTime == DateTime.MinValue)
		{
			// 초기값 세팅
			resumeEntity = null;
		}

	}

	protected string GetResumeEntityValue(string colName)
	{
		string retVal = string.Empty;
		switch (colName)
		{
			case "CompanyNo1":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = GetCompanyName(resumeEntity.CompanyNo1); }
				break;
			case "CompanyNo2":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = GetCompanyName(resumeEntity.CompanyNo2); }
				break;
			case "CompanyNo3":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = GetCompanyName(resumeEntity.CompanyNo3); }
				break;
			case "HopeSalary":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = resumeEntity.HopeSalary; }
				break;
			case "CityNo1":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = GetCategoryName(resumeEntity.CityNo1); }
				break;
			case "ArrayNo1":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = GetSubCategoryName(resumeEntity.ArrayNo1); }
				break;
			case "CityNo2":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = GetCategoryName(resumeEntity.CityNo2); }
				break;
			case "ArrayNo2":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = GetSubCategoryName(resumeEntity.ArrayNo2); }
				break;
			case "HopeRecruitDate":
				if (resumeEntity == null) { retVal = "2011"; } else { retVal = resumeEntity.HopeRecruitDate.ToString("yyyy년 MM월 dd일"); }
				break;
			case "BusinessCategoryNo":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = GetCategoryName(resumeEntity.BusinessCategoryNo); }
				break;
			case "Category1No":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = GetCategoryName(resumeEntity.Category1No); }
				break;
			case "Category2No":
				if (resumeEntity == null) { retVal = string.Empty; } else { if (GetSubCategoryName(resumeEntity.Category2No) == "직접입력") { retVal = resumeEntity.CategoryEtc; } else { retVal = GetSubCategoryName(resumeEntity.Category2No); } }
				break;
			case "JoinType":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = resumeEntity.JoinType.ToString(); }
				break;
			default:
				throw new Exception("invalid column name");
		}
		return retVal;
	}

	protected string GetCompanyName(int companyNo)
	{
		CompanyDetailGetInfoArguments arg = new CompanyDetailGetInfoArguments();
		arg.CompanyNo = companyNo;

		CompanyDetailGetInfo getInfo = new CompanyDetailGetInfo();
		getInfo.SetArguments(arg);
		getInfo.ExecuteNonQuery();

		CompanyDetailEntity comp = getInfo.GetOutput();

		return comp.KRName;
	}

	protected string GetCategoryName(int categoryNo)
	{
		CategoryGetInfoArguments arg = new CategoryGetInfoArguments();
		arg.CategoryNo = categoryNo;

		CategoryGetInfo getInfo = new CategoryGetInfo();
		getInfo.SetArguments(arg);
		getInfo.ExecuteNonQuery();

		CategoryEntity entity = getInfo.GetOutput();

		return entity.CategoryKRName;
	}

	protected string GetSubCategoryName(int subCategoryNo)
	{
		SubCategoryGetInfoArguments arg = new SubCategoryGetInfoArguments();
		arg.SubCategoryNo = subCategoryNo;

		SubCategoryGetInfo getInfo = new SubCategoryGetInfo();
		getInfo.SetArguments(arg);
		getInfo.ExecuteNonQuery();

		SubCategoryEntity entity = getInfo.GetOutput();

		return entity.SubCategoryKRName;
	}

    public string GetSearch()
    {
        string url = "human_search.aspx?Country=" + CountryNo;
        url += "&PageNo=" + PageNo.ToString();
        if (JoinType != 3)
            url += "&join=" + JoinType.ToString();
        if (Category1No != 0)
            url += "&Category1=" + Category1No.ToString();
        if (Category2No != 0)
            url += "&Category2=" + Category2No.ToString();
        if (AgeCategory != 0)
            url += "&Age=" + AgeCategory.ToString();
        if (CityCategory != 0)
            url += "&City=" + CityCategory.ToString();
        if (AreaCategory != 0)
            url += "&Age=" + AreaCategory.ToString();
        if (Gender != 0)
            url += "&Gender=" + Gender.ToString();
        if (UserName.Trim() != "")
            url += "&Name=" + Server.UrlEncode(UserName);
        return url;
    }

    public string GetDetailViewer(string pageName, int userNo)
    {
        string url = pageName + "?Country=" + CountryNo;
        url += "&PageNo=" + PageNo.ToString();
        url += "&userNo=" + userNo.ToString();
        if (JoinType != 3)
            url += "&join=" + JoinType.ToString();
        if (Category1No != 0)
            url += "&Category1=" + Category1No.ToString();
        if (Category2No != 0)
            url += "&Category2=" + Category2No.ToString();
        if (AgeCategory != 0)
            url += "&Age=" + AgeCategory.ToString();
        if (CityCategory != 0)
            url += "&City=" + CityCategory.ToString();
        if (AreaCategory != 0)
            url += "&Age=" + AreaCategory.ToString();
        if (Gender != 0)
            url += "&Gender=" + Gender.ToString();
        if (UserName.Trim() != "")
            url += "&Name=" + Server.UrlEncode(UserName);
        return url;
    }
}

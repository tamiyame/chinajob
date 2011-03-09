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
using Com.Framework.Data;
using Com.Library.DB.Company;
using Com.Library.DB.Category;

public partial class KR_Recruit_recruit_search : SitePage
{
    public int CountryNo = 1;
    public byte JoinType = 3;
    public int Category1No = 0;
    public int Category2No = 0;
    public int AgeCategory = 0;
    public int CityCategory = 0;
    public int AreaCategory = 0;
    public byte Gender = 0;
    public string CompanyName = string.Empty;
    public byte Career = 0;
    public byte CapitalType = 0;
    public int PageNo = 1;
    public byte PageSize = 10;

    public List<CategoryEntity> AgeCategoryList = null;
    public List<CategoryEntity> CityCategoryList = null;
    public List<SubCategoryEntity> AreaSubCategoryList = null;
    public List<CategoryEntity> Category1List = null;
    public List<SubCategoryEntity> Category2List = null;
    public ListData<RecruitSearchEntity, OutputEntity> SearchList = null;

    protected void Page_Load(object sender, EventArgs e)
    {
        PageNo = Request.QueryString["PageNo"] == null ? 1 : Convert.ToInt32(Request.QueryString["PageNo"]);
        CountryNo = Request.QueryString["Country"] == null ? 1 : Convert.ToInt32(Request.QueryString["Country"]);
        JoinType = Request.QueryString["Join"] == null ? (byte)3 : Convert.ToByte(Request.QueryString["Join"]);
        Category1No = Request.QueryString["Category1"] == null ? 0 : Convert.ToInt32(Request.QueryString["Category1"]);
        Category2No = Request.QueryString["Category2"] == null ? 0 : Convert.ToInt32(Request.QueryString["Category2"]);
        AgeCategory = Request.QueryString["Age"] == null ? 0 : Convert.ToInt32(Request.QueryString["Age"]);
        CityCategory = Request.QueryString["City"] == null ? 0 : Convert.ToInt32(Request.QueryString["City"]);
        AreaCategory = Request.QueryString["Area"] == null ? 0 : Convert.ToInt32(Request.QueryString["Area"]);
        Gender = Request.QueryString["Gender"] == null ? (byte)0 : Convert.ToByte(Request.QueryString["Gender"]);
        CompanyName = Request.QueryString["Name"] == null ? string.Empty : Convert.ToString(Request.QueryString["Name"]);
        Career = Request.QueryString["Career"] == null ? (byte)0 : Convert.ToByte(Request.QueryString["Career"]);
        CapitalType = Request.QueryString["Capital"] == null ? (byte)0 : Convert.ToByte(Request.QueryString["Capital"]);

        CategoryGetList list = new CategoryGetList();
        CategoryGetListArguments arg = new CategoryGetListArguments();
        arg.CategoryMasterNo = 1;
        list.SetArguments(arg);
        list.Execute();
        Category1List = list.GetRecords();
        if (Category2No != 0)
        {
            SubCategoryGetList subList = new SubCategoryGetList();
            SubCategoryGetListArguments subArg = new SubCategoryGetListArguments();
            subArg.CategoryNo = Category1No;
            subList.SetArguments(subArg);
            subList.Execute();
            Category2List = subList.GetRecords();
        }

        if (AreaCategory != 0)
        {
            SubCategoryGetList subList = new SubCategoryGetList();
            SubCategoryGetListArguments subArg = new SubCategoryGetListArguments();
            subArg.CategoryNo = CityCategory;
            subList.SetArguments(subArg);
            subList.Execute();
            AreaSubCategoryList = subList.GetRecords();
        }

        CategoryGetList citylist = new CategoryGetList();
        CategoryGetListArguments cityArg = new CategoryGetListArguments();
        cityArg.CategoryMasterNo = 3;
        citylist.SetArguments(cityArg);
        citylist.Execute();
        CityCategoryList = citylist.GetRecords();

        CategoryGetList agelist = new CategoryGetList();
        CategoryGetListArguments ageArg = new CategoryGetListArguments();
        ageArg.CategoryMasterNo = 2;
        agelist.SetArguments(ageArg);
        agelist.Execute();
        AgeCategoryList = agelist.GetRecords();


        RecruitSearchArguments searchArg = new RecruitSearchArguments();
        searchArg.CountryNo = CountryNo;
        if ( JoinType != 3 )
            searchArg.JoinType = JoinType;
        if (Category1No != 0)
            searchArg.Category1No = Category1No;
        if (Category2No != 0)
            searchArg.Category2No = Category2No;
        if (AgeCategory != 0)
            searchArg.AgeCategory = AgeCategory;
        if (CityCategory != 0)
            searchArg.CityCategory = CityCategory;
        if (AreaCategory != 0)
            searchArg.AreaCategory = AreaCategory;
        if (Gender != 0)
            searchArg.Gender = Gender;
        if (CompanyName != string.Empty)
            searchArg.CompanyName = CompanyName;
        if (Career != 0)
            searchArg.Career = Career;
        if (CapitalType != 0)
            searchArg.CapitalType = CapitalType;
        searchArg.PageNo = PageNo;
        searchArg.PageSize = PageSize;

        RecruitSearch search = new RecruitSearch();
        search.SetArguments(searchArg);
        search.Execute();
        List<RecruitSearchEntity> record = search.Execute();
        OutputEntity outputdata = search.GetOutput();

        SearchList = new ListData<RecruitSearchEntity, OutputEntity>(record, outputdata);
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

        return info.GetOutput().SubCategoryKRName == string.Empty ? "" : "<br/>" + info.GetOutput().SubCategoryKRName;
    }

    public string GetCapitalType(byte _CapitalType)
    {
        string url = "recruit_search.aspx?Country=" + CountryNo;
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
        if (Career != 0)
            url += "&Career=" + Career.ToString();
        if (_CapitalType != 0)
            url += "&Capital=" + _CapitalType.ToString();
        if (CompanyName.Trim() != "")
            url += "&Name=" + Server.UrlEncode(CompanyName);
        return url;
    }

    public string PageMove(int pageNo)
    {
        string url = "recruit_search.aspx?Country=" + CountryNo;
        url += "&PageNo=" + pageNo.ToString();
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
        if (Career != 0)
            url += "&Career=" + Career.ToString();
        if (CapitalType != 0)
            url += "&CapitalType=" + CapitalType.ToString();
        if (CompanyName.Trim() != "")
            url += "&Name=" + Server.UrlEncode(CompanyName);
        return url;
    }

    public string DetailViewer(int companyNo, int recruitNo)
    {
        string url = "recruit_detail.aspx?Country=" + CountryNo;
        url += "&CompanyNo=" + companyNo.ToString();
        url += "&RecruitNo=" + recruitNo.ToString();
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
        if (Career != 0)
            url += "&Career=" + Career.ToString();
        if (CapitalType != 0)
            url += "&CapitalType=" + CapitalType.ToString();
        if (CompanyName.Trim() != "")
            url += "&Name=" + Server.UrlEncode(CompanyName);
        return url;
    }

}

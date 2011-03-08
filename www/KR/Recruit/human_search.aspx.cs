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
using Com.Library.DB.User;
using Com.Library.DB.Category;

public partial class KR_Recruit_human_search : SitePage
{
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

    public List<CategoryEntity> AgeCategoryList = null;
    public List<CategoryEntity> CityCategoryList = null;
    public List<SubCategoryEntity> AreaSubCategoryList = null;
    public List<CategoryEntity> Category1List = null;
    public List<SubCategoryEntity> Category2List = null;
    public ListData<ResumeSearchEntity, OutputEntity> SearchList = null;

    protected void Page_Load(object sender, EventArgs e)
    {
        PageNo = Request.QueryString["PageNo"] == null ? 1 : Convert.ToInt32(Request.QueryString["PageNo"]);
        CountryNo = Request.QueryString["Country"] == null ? 1 : Convert.ToInt32(Request.QueryString["Country"]);
        JoinType = Request.QueryString["JoinType"] == null ? (byte)3 : Convert.ToByte(Request.QueryString["Join"]);
        Category1No = Request.QueryString["Category1"] == null ? 0 : Convert.ToInt32(Request.QueryString["Category1"]);
        Category2No = Request.QueryString["Category2"] == null ? 0 : Convert.ToInt32(Request.QueryString["Category2"]);
        AgeCategory = Request.QueryString["Age"] == null ? 0 : Convert.ToInt32(Request.QueryString["Age"]);
        CityCategory = Request.QueryString["City"] == null ? 0 : Convert.ToInt32(Request.QueryString["City"]);
        AreaCategory = Request.QueryString["Area"] == null ? 0 : Convert.ToInt32(Request.QueryString["Area"]);
        Gender = Request.QueryString["Gender"] == null ? (byte)0 : Convert.ToByte(Request.QueryString["Gender"]);
        UserName = Request.QueryString["Name"] == null ? string.Empty : Convert.ToString(Request.QueryString["Name"]);

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

        ResumeSearchArguments searchArg = new ResumeSearchArguments();
        searchArg.CountryNo = CountryNo;
        if (JoinType != 3)
            searchArg.JoinType = JoinType;
        if (Category1No != 0)
            searchArg.Category1No = Category1No;
        if (Category2No != 0)
            searchArg.Category2No = Category2No;
        if (AgeCategory != 0)
        {
            switch (AgeCategory)
            {
                case 1 :    searchArg.Age_Start = 20;
                            searchArg.Age_End = 25;
                            break;
                case 2: searchArg.Age_Start = 20;
                            searchArg.Age_End = 30;
                            break;
                case 3: searchArg.Age_Start = 25;
                            searchArg.Age_End = 30;
                            break;
                case 4: searchArg.Age_Start = 25;
                            searchArg.Age_End = 35;
                            break;
                case 5: searchArg.Age_Start = 30;
                            searchArg.Age_End = 35;
                            break;
                case 6: searchArg.Age_Start = 30;
                            searchArg.Age_End = 40;
                            break;
                case 7: searchArg.Age_Start = 35;
                            searchArg.Age_End = 40;
                            break;
                case 8: searchArg.Age_Start = 35;
                            searchArg.Age_End = 45;
                            break;
                case 9: searchArg.Age_Start = 40;
                            searchArg.Age_End = 50;
                            break;
            }
            
        }
        if (CityCategory != 0)
            searchArg.CityCategory = CityCategory;
        if (AreaCategory != 0)
            searchArg.AreaCategory = AreaCategory;
        if (Gender != 0)
            searchArg.Gender = Gender;
        if (UserName != string.Empty)
            searchArg.UserName = UserName;
        searchArg.PageNo = PageNo;
        searchArg.PageSize = PageSize;

        ResumeSearch search = new ResumeSearch();
        search.SetArguments(searchArg);
        search.Execute();
        List<ResumeSearchEntity> record = search.Execute();
        OutputEntity outputdata = search.GetOutput();

        SearchList = new ListData<ResumeSearchEntity, OutputEntity>(record, outputdata);
    }

    public string GetCountryType(byte _CountryNo)
    {
        string url = "human_search.aspx?Country=" + _CountryNo;
        if (JoinType != 3)
            url += "&jointype=" + JoinType.ToString();
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

    public string PageMove(int pageNo)
    {
        string url = "human_search.aspx?Country=" + CountryNo;
        url += "&PageNo=" + pageNo.ToString();
        if (JoinType != 3)
            url += "&jointype=" + JoinType.ToString();
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

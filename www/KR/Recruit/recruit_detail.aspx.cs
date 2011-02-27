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
using Com.Library.DB.Company;
using Com.Library.DB.Category;

public partial class KR_Recruit_recruit_detail : SitePage
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

    public CompanyEntity CompanyInfo = null;
    public CompanyDetailEntity CompanyDetailInfo = null;
    public RecruitEntity RecruitInfo = null;
    public int CompanyNo = 0;
    public int RecruitNo = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            CompanyNo = Convert.ToInt32(Request.QueryString["CompanyNo"]);
            RecruitNo = Convert.ToInt32(Request.QueryString["RecruitNo"]);
            PageNo = Request.QueryString["PageNo"] == null ? 1 : Convert.ToInt32(Request.QueryString["PageNo"]);
            CountryNo = Request.QueryString["Country"] == null ? 1 : Convert.ToInt32(Request.QueryString["Country"]);
            JoinType = Request.QueryString["JoinType"] == null ? (byte)3 : Convert.ToByte(Request.QueryString["Join"]);
            Category1No = Request.QueryString["Category1"] == null ? 0 : Convert.ToInt32(Request.QueryString["Category1"]);
            Category2No = Request.QueryString["Category2"] == null ? 0 : Convert.ToInt32(Request.QueryString["Category2"]);
            AgeCategory = Request.QueryString["Age"] == null ? 0 : Convert.ToInt32(Request.QueryString["Age"]);
            CityCategory = Request.QueryString["City"] == null ? 0 : Convert.ToInt32(Request.QueryString["City"]);
            AreaCategory = Request.QueryString["Area"] == null ? 0 : Convert.ToInt32(Request.QueryString["Area"]);
            Gender = Request.QueryString["Gender"] == null ? (byte)0 : Convert.ToByte(Request.QueryString["Gender"]);
            CompanyName = Request.QueryString["Name"] == null ? string.Empty : Convert.ToString(Request.QueryString["Name"]);
            Career = Request.QueryString["Career"] == null ? (byte)0 : Convert.ToByte(Request.QueryString["Career"]);
            CapitalType = Request.QueryString["Capital"] == null ? (byte)0 : Convert.ToByte(Request.QueryString["Capital"]);
        }
        catch (Exception)
        {
            Response.Redirect( GetURL("/home/"));
        }
    }

    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);
        
        CompanyGetInfoArguments companyInfoArg = new CompanyGetInfoArguments();
        companyInfoArg.CompanyNo = CompanyNo;

        CompanyDetailGetInfoArguments companyDetailInfoArg = new CompanyDetailGetInfoArguments();
        companyDetailInfoArg.CompanyNo = CompanyNo;

        RecruitGetInfoArguments recruitInfoArg = new RecruitGetInfoArguments();
        recruitInfoArg.CompanyNo = CompanyNo;
        recruitInfoArg.CountryNo = CountryNo;
        recruitInfoArg.RecruitNo = RecruitNo;

        CompanyGetInfo companyInfo = new CompanyGetInfo();
        companyInfo.SetArguments(companyInfoArg);
        companyInfo.ExecuteNonQuery();
        CompanyInfo = companyInfo.GetOutput();

        CompanyDetailGetInfo companyDetailInfo = new CompanyDetailGetInfo();
        companyDetailInfo.SetArguments(companyDetailInfoArg);
        companyDetailInfo.ExecuteNonQuery();
        CompanyDetailInfo = companyDetailInfo.GetOutput();

        RecruitGetInfo recruitInfo = new RecruitGetInfo();
        recruitInfo.SetArguments(recruitInfoArg);
        recruitInfo.ExecuteNonQuery();
        RecruitInfo = recruitInfo.GetOutput();
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

    public string ListPage()
    {
        string url = "recruit_search.aspx?Country=" + CountryNo;
        url += "&PageNo=" + PageNo.ToString();
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
        if (Career != 0)
            url += "&Career=" + Career.ToString();
        if (CapitalType != 0)
            url += "&CapitalType=" + CapitalType.ToString();
        if (CompanyName.Trim() != "")
            url += "&Name=" + Server.UrlEncode(CompanyName);
        return url;
    }
}

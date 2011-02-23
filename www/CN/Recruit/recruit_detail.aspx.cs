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

public partial class CN_Recruit_recruit_detail : SitePage
{
    public CompanyEntity CompanyInfo = null;
    public CompanyDetailEntity CompanyDetailInfo = null;
    public RecruitEntity RecruitInfo = null;
    public int CompanyNo = 0;
    public int RecruitNo = 0;
    public int CountryNo = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            CompanyNo = Convert.ToInt32(Request.QueryString["CompanyNo"]);
            RecruitNo = Convert.ToInt32(Request.QueryString["RecruitNo"]);
            CountryNo = Request.QueryString["CountryNo"] == null ? 1 : Convert.ToInt32(Request.QueryString["CountryNo"]);
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
}

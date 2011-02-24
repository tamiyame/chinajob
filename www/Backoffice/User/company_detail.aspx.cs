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

public partial class Backoffice_User_company_detail : System.Web.UI.Page
{
    public CompanyEntity CompanyInfo = null;
    public CompanyDetailEntity CompanyDetailInfo = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        int CompanyNo = Convert.ToInt32(Request.QueryString["CompanyNo"]);
        CompanyGetInfoArguments arg = new CompanyGetInfoArguments();
        arg.CompanyNo = CompanyNo;
        CompanyDetailGetInfoArguments detailArg = new CompanyDetailGetInfoArguments();
        detailArg.CompanyNo = CompanyNo;

        CompanyGetInfo info = new CompanyGetInfo();
        info.SetArguments(arg);
        info.ExecuteNonQuery();
        CompanyInfo = info.GetOutput();

        CompanyDetailGetInfo detailInfo = new CompanyDetailGetInfo();
        detailInfo.SetArguments(detailArg);
        detailInfo.ExecuteNonQuery();
        CompanyDetailInfo = detailInfo.GetOutput();
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


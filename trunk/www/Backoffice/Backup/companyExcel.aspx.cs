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

using Com.Framework.Data;
using Com.Library.DB.Company;
using Com.Library.DB.Category;

public partial class Backoffice_Backup_companyExcel : System.Web.UI.Page
{
    public List<CompanyAllEntity> CompanyList = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        CompanyGetListArguments arg = new CompanyGetListArguments();
        arg.PageNo = 1;
        arg.PageSize = 0;
        arg.Status = 1;

        CompanyGetList list = new CompanyGetList();
        list.SetArguments(arg);
        list.Execute();
        CompanyList = list.GetRecords();
    }

    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);

        Response.Clear();
        Response.AddHeader("content-disposition", "attachment;filename=company.xls");
        Response.ContentType = "application/vnd.ms-excel";

        System.IO.StringWriter stringWrite = new System.IO.StringWriter();
        System.Web.UI.HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
        excelContent.RenderControl(htmlWrite);
        Response.Write(stringWrite.ToString());
        Response.End();
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
}

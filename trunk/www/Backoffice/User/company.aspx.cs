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
using System.Web.Services;

using Com.Framework.Data;
using Com.Library.DB.Company;

public partial class Backoffice_User_Company : SitePage
{
    public ListData<CompanyAllEntity, OutputEntity> CompanyList = null;
    public int PageNo = 1;
    public byte PageSize = 20;
    protected void Page_Load(object sender, EventArgs e)
    {
        PageNo = Request.QueryString["PageNo"] == null ? 1 : Convert.ToInt32(Request.QueryString["PageNo"]);
    }

    protected override void OnPreRender(EventArgs e)
    {
        CompanyGetListArguments arg = new CompanyGetListArguments();
        arg.PageNo = PageNo;
        arg.PageSize = PageSize;
        CompanyGetList list = new CompanyGetList();
        list.SetArguments(arg);
        list.Execute();
        List<CompanyAllEntity> _record = list.GetRecords();
        OutputEntity _output = list.GetOutput();
        CompanyList = new ListData<CompanyAllEntity, OutputEntity>(_record, _output);
    }

    [WebMethod]
    public static void ApprovalCompany(int companyNo )
    {
        CompanyModifyArguments arg = new CompanyModifyArguments();
        arg.CompanyNo = companyNo;
        arg.Approval = 1;
        CompanyModify modify = new CompanyModify();
        modify.SetArguments(arg);
        modify.ExecuteNonQuery();
    }
}


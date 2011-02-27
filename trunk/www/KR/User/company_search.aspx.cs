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
using Com.Framework.Data;
using System.Collections.Generic;
using Com.Library.DB.Company;

public partial class KR_User_company_search : System.Web.UI.Page
{
    public ListData<CompanyDetailEntity, OutputEntity> SearchList = null;
    public int no;
    protected void Page_Load(object sender, EventArgs e)
    {
        no = Request["no"] == null ? 0 : Convert.ToInt32(Request["no"]);
        if (this.IsPostBack)
        {
            CompanyDetailGetListByName nameSearch = new CompanyDetailGetListByName();
            nameSearch.SetArguments(
                    new CompanyDetailGetListByNameArguments()
                    {
                        Name = Request["searchValue"]
                    }
                );
            nameSearch.Execute();
            List<CompanyDetailEntity> record = nameSearch.Execute();
            OutputEntity outputdata = nameSearch.GetOutput();
            SearchList = new ListData<CompanyDetailEntity, OutputEntity>(record, outputdata);
        }
    }
}

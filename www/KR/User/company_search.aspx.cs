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
    public ListData<CompanyEntity, OutputEntity> companyList;
    protected void Page_Load(object sender, EventArgs e)
    {


        if (this.IsPostBack)
        {
        }
    }
}

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

public partial class Backoffice_User_User : SitePage
{
    public ListData<UserEntity, OutputEntity> UserList = null;
    public int PageNo = 1;
    public byte PageSize = 20;

    protected void Page_Load(object sender, EventArgs e)
    {
        PageNo = Request.QueryString["PageNo"] == null ? 1 : Convert.ToInt32(Request.QueryString["PageNo"]);
    }

    protected override void OnPreRender(EventArgs e)
    {
        UserGetListArguments arg = new UserGetListArguments();
        arg.PageNo = PageNo;
        arg.PageSize = PageSize;
        arg.Status = 1;
        UserGetList list = new UserGetList();
        list.SetArguments(arg);
        list.Execute();
        List<UserEntity> _record = list.GetRecords();
        OutputEntity _output = list.GetOutput();
        UserList = new ListData<UserEntity, OutputEntity>(_record, _output);
    }
}

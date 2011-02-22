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
using Com.Library.DB.Board;

public partial class Backoffice_Operation_list : ArticleListPage
{
    public override int BoardNo
    {
        get { return Request.QueryString["BoardNo"] == null ? 1 : Convert.ToInt32(Request.QueryString["BoardNo"]); }
    }

    public string boardName;
    protected void Page_Load(object sender, EventArgs e)
    {
        boardName = GetBoardName();
    }

    private string GetBoardName()
    {
        BoardGetInfoArguments arg = new BoardGetInfoArguments()
        {
            BoardNo = BoardNo
        };
        BoardGetInfo excuter = new BoardGetInfo();
        excuter.SetArguments(arg);
        excuter.Execute();
        return excuter.GetOutput().BoardName;
    }
}

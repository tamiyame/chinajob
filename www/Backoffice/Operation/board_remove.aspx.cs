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

public partial class Backoffice_Operation_board_remove : SitePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int BoardNo = Convert.ToInt32(Request.QueryString["BoardNo"]);
        int ArticleNo = Convert.ToInt32(Request.QueryString["ArticleNo"]);

        ArticleRemoveArguments arg = new ArticleRemoveArguments();
        arg.BoardNo = BoardNo;
        arg.ArticleNo = ArticleNo;
        ArticleRemove remove = new ArticleRemove();
        remove.SetArguments(arg);
        remove.ExecuteNonQuery();

        Response.Redirect("board_list.aspx?PageNo=1&BoardNo=" + BoardNo.ToString());
    }
}

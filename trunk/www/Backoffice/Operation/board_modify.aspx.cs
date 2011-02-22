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

public partial class Backoffice_Operation_board_modify : ArticleModifyPage
{
    public override int BoardNo
    {
        get { return Request.QueryString["BoardNo"] == null ? 1 : Convert.ToInt32(Request.QueryString["BoardNo"]); }
    }
    public string boardName;
    private string GetBoardName()
    {
        BoardEntity board = null;
        BoardGetInfoArguments arg = new BoardGetInfoArguments()
        {
            BoardNo = BoardNo
        };
        BoardGetInfo excuter = new BoardGetInfo();
        excuter.SetArguments(arg);
        excuter.Execute();
        return excuter.GetOutput().BoardName;
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);
        boardName = GetBoardName();

        if (this.IsPostBack)
        {
            string ArticleTitle = Request.Form["ArticleTitle"];
            string ArticleContent = Request.Form["ArticleContent"];
            string ArticleSomeContent = Request.Form["ArticleSomeContent"];
            int BoardCategoryNo = Convert.ToInt32(Request.Form["BoardCategoryNo"]);

            ArticleModifyArguments arg = new ArticleModifyArguments();
            arg.BoardNo = BoardNo;
            arg.ArticleNo = ArticleNo;
            arg.ArticleTitle = ArticleTitle;
            arg.ArticleContent = ArticleContent;
            arg.BoardCategoryNo = BoardCategoryNo;
            SetArticleModify(arg);


            Response.Write("<script language='javascript'> location.href='" + PageMove("board_list.aspx", 1, BoardNo) + "'</script>");
        }
    }
}

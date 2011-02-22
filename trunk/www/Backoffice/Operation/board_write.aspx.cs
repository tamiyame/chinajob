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

public partial class BackOffice_Operation_board_write : ArticleWritePage
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

            ArticleCreateArguments createArg = new ArticleCreateArguments();
            createArg.BoardNo = BoardNo;
            createArg.BoardCategoryNo = BoardCategoryNo;
            createArg.ArticleTitle = ArticleTitle;
            createArg.ArticleContent = ArticleContent;
            createArg.SomeContent = ArticleSomeContent;
            createArg.UserNo = this.WebCookies.UserNo;
            createArg.UserID = this.WebCookies.UserID;
            createArg.UserName = "관리자";
            createArg.UserIP = Request.UserHostAddress;
            SetArticleCreate(createArg);

            Response.Write("<script language='javascript'> location.href='" +PageMove("board_list.aspx",1,BoardNo) + "'</script>");
        }
    }
}

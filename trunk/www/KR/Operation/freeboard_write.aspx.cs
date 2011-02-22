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
using Site.Web.Util;

public partial class KR_Operation_freeboard_write : ArticleWritePage
{
    public override int BoardNo
    {
        get
        {
            return 4;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.WebCookies.IsLogin)
        {
            Response.Clear();
            Response.Redirect(this.GetURL("/operation/freeboard_list.aspx?PageNo=" + PageNo.ToString()));
        }
        if (!this.WebCookies.isCompany)
        {
            Response.Clear();
            Response.Write("<script language='javascript'>location.href='" + this.GetURL("/operation/freeboard_list.aspx?PageNo=" + PageNo.ToString()) + "';alert('" + Message.Msg(this.WebMaster.CountryCode, k_MsgType.User_Login) + "');</script>");
            return;
        }
    }

    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);
        if (this.IsPostBack)
        {
            string ArticleTitle = Request.Form["ArticleTitle"];
            string ArticleContent = Request.Form["ArticleContent"];
            string ArticleSomeContent = Request.Form["ArticleSomeContent"];
            int BoardCategoryNo = Convert.ToInt16(Request.Form["BoardCategoryNo"]);

            ArticleCreateArguments createArg = new ArticleCreateArguments();
            createArg.BoardNo = BoardNo;
            createArg.BoardCategoryNo = BoardCategoryNo;
            createArg.ArticleTitle = ArticleTitle;
            createArg.ArticleContent = ArticleContent;
            createArg.SomeContent = ArticleSomeContent;
            createArg.UserNo = this.WebCookies.UserNo;
            createArg.UserID = this.WebCookies.UserID;
            createArg.UserName = this.WebCookies.UserName;
            createArg.UserIP = Request.UserHostAddress;
            SetArticleCreate(createArg);

            Response.Write("<script language='javascript'> location.href='" + GetURL("/operation/freeboard_list.aspx") + "'</script>");
        }
    }
}

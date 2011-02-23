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

public partial class CN_Operation_freeboard_remove : SitePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int BoardNo = 4;
        int ArticleNo = Convert.ToInt32(Request.QueryString["ArticleNo"]);

        ArticleGetInfoArguments arg = new ArticleGetInfoArguments();
        arg.BoardNo = BoardNo;
        arg.ArticleNo = ArticleNo;
        arg._AddReadCount = 0;
        ArticleGetInfo info = new ArticleGetInfo();
        info.SetArguments(arg);
        info.Execute();
        ArticleEntity m_AricleInfo = info.GetOutput();

        if (m_AricleInfo.UserNo == this.WebCookies.UserNo)
        {

            ArticleRemoveArguments argRemove = new ArticleRemoveArguments();
            argRemove.BoardNo = BoardNo;
            argRemove.ArticleNo = ArticleNo;
            ArticleRemove remove = new ArticleRemove();
            remove.SetArguments(argRemove);
            remove.ExecuteNonQuery();
            Response.Redirect("freeboard_list.aspx?PageNo=1");
        }
    }
}

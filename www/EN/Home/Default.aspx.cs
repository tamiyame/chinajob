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

using Com.Framework.Data;
using Com.Library.Page;
using Com.Library.DB.Board;

using Site.Web.Page;

public partial class EN_Home_Default : SitePage
{
    public string strContents = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected override void OnPreRender(EventArgs e)
    {
        int BoardNo = 6;
        int ArticleNo = 0;
        ArticleGetListArguments arg = new ArticleGetListArguments();
        arg.PageNo = 1;
        arg.PageSize = 1;
        arg.BoardNo = BoardNo;
        ArticleGetList list = new ArticleGetList();
        list.SetArguments(arg);
        List<ArticleEntity> record = list.Execute();
        OutputEntity outputdata = list.GetOutput();

        if (record.Count > 0)
        {
            ArticleNo = record[0].ArticleNo;
            ArticleGetInfoArguments argi = new ArticleGetInfoArguments();
            argi.BoardNo = BoardNo;
            argi.ArticleNo = ArticleNo;
            argi._AddReadCount = 0;
            ArticleGetInfo info = new ArticleGetInfo();
            info.SetArguments(argi);
            info.Execute();
            ArticleEntity m_AricleInfo = info.GetOutput();
            strContents = m_AricleInfo.ArticleContent;
        }
    }
}

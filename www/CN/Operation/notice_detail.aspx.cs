﻿using System;
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

public partial class CN_Operation_notice_detail : ArticleDetailPage
{
    public override int BoardNo
    {
        get
        {
            return 2;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
}

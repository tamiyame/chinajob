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
using Com.Library.Translate;

public partial class js_translateJs : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		Request.ContentType = "application/x-javascript";
		rptTranslateData.DataSource = TranslateHelper.GetList();
		rptTranslateData.DataBind();
	}
}

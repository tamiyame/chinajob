using System;
using Com.Library.Translate;
using Site.Web.Page;

public partial class js_translateJs : SitePage
{
	protected void Page_Load(object sender, EventArgs e)
	{
		Request.ContentType = "application/x-javascript";
		rptTranslateData.DataSource = TranslateHelper.GetList();
		rptTranslateData.DataBind();
	}
}

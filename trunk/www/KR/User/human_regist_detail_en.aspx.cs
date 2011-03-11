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

public partial class KR_User_human_regist_detail_en : KR_User_human_regist_detail
{
	protected void Page_Load(object sender, EventArgs e)
	{
		CountryCode = TranslateHelper.ContryCode.EN;
	}
}

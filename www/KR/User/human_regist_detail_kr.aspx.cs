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
using Com.Library.DB.User;
using Com.Library.Translate;
using System.Collections.Generic;
using Com.Framework.Data;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;
using System.Web.Script.Serialization;

public partial class KR_User_human_regist_detail_kr : KR_User_human_regist_detail
{
	protected void Page_Load(object sender, EventArgs e)
    {
		CountryCode = TranslateHelper.ContryCode.KR;
    }

}

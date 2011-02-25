using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;


using Com.Library.Page;
using Com.Library.Cookie;
namespace Site.Web.Page
{
    public class KRSiteMaster : SiteMaster
    {
        public KRSiteMaster()
        {
            //
            // TODO: 여기에 생성자 논리를 추가합니다.
            //

        }

        protected override void OnInit(EventArgs e)
        {
            this.CountryLink = "/KR";
            this.CountryCode = 1;
			this.CountryCode2 = Com.Library.Translate.TranslateHelper.ContryCode.KR;
            base.OnInit(e);
        }
    }
}
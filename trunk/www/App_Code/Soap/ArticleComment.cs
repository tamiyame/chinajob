using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using Com.Library.DB.Company;
using Com.Library.DB.Category;
using System.Collections.Generic;

namespace Site.Web.Soap
{
    /// <summary>
    /// ArticleComment의 요약 설명입니다.
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    // ASP.NET AJAX를 사용하여 스크립트에서 이 웹 서비스를 호출하려면 다음 줄의 주석 처리를 제거합니다. 
    [System.Web.Script.Services.ScriptService]
    public class ArticleComment : System.Web.Services.WebService
    {

        public ArticleComment()
        {

            //디자인된 구성 요소를 사용하는 경우 다음 줄의 주석 처리를 제거합니다. 
            //InitializeComponent(); 
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

    }
}

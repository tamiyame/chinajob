using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;

using Com.Framework.Data;
using Com.Library.DB.Company;
using Com.Library.Cookie;

namespace Site.Web.Soap
{
    /// <summary>
    /// Summary description for Recruit
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class Recruit : System.Web.Services.WebService
    {

        public Recruit()
        {

            //Uncomment the following line if using designed components 
            //InitializeComponent(); 
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<RecruitMasterEntity> MasterGetList()
        {
            WebCookie cookie = new WebCookie();
            RecruitMasterGetListArguments listArg = new RecruitMasterGetListArguments();
            listArg.CompanyNo = cookie.UserNo;
            RecruitMasterGetList list = new RecruitMasterGetList();
            list.SetArguments(listArg);
            list.Execute();
            List<RecruitMasterEntity> _record = list.GetRecords();

            return _record;
        }

        [WebMethod]
        public void MasterCreate(string RecruitTitle)
        {
            WebCookie cookie = new WebCookie();
            RecruitMasterCreateArguments createArg = new RecruitMasterCreateArguments();
            createArg.CompanyNo = cookie.UserNo;
            createArg.RecruitTitle = RecruitTitle;
            RecruitMasterCreate create = new RecruitMasterCreate();
            create.SetArguments(createArg);
            create.ExecuteNonQuery();
        }

        [WebMethod]
        public void MasterRemove(int RecruitNo)
        {
            WebCookie cookie = new WebCookie();
            RecruitMasterRemoveArguments removeArg = new RecruitMasterRemoveArguments();
            removeArg.CompanyNo = cookie.UserNo;
            removeArg.RecruitNo = RecruitNo;
            RecruitMasterRemove remove = new RecruitMasterRemove();
            remove.SetArguments(removeArg);
            remove.ExecuteNonQuery();
        }
    }

}
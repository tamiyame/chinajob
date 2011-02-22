using System;
using System.Collections;

using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

using Com.Library.DB.Company;
using Com.Library.DB.Category;
using System.Collections.Generic;

namespace Site.Web.Soap
{
    /// <summary>
    /// Summary description for Category
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class Category : System.Web.Services.WebService
    {

        public Category()
        {

            //Uncomment the following line if using designed components 
            //InitializeComponent(); 
        }

        [WebMethod]
        public List<SubCategoryEntity> GetSubCategory(int CategoryNo)
        {
            SubCategoryGetListArguments arg = new SubCategoryGetListArguments();
            arg.CategoryNo = CategoryNo;
            SubCategoryGetList list = new SubCategoryGetList();
            list.SetArguments(arg);
            list.Execute();
            return list.GetRecords();            
        }
    }
}

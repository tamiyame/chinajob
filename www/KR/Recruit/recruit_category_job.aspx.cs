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

using Site.Web.Page;
using Com.Library.DB.Category;
public partial class KR_Recruit_recruit_category_job2 : SitePage
{
    public List<CategoryEntity> CategoryList = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        CategoryGetListArguments arg = new CategoryGetListArguments();
        arg.CategoryMasterNo = 1;
        CategoryGetList list = new CategoryGetList();
        list.SetArguments(arg);
        list.Execute();
        CategoryList = list.GetRecords();
    }

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

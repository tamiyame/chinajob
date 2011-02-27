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
public partial class KR_Recruit_recruit_category_city : SitePage
{
    public List<CategoryEntity> CategoryList = null;
    public int CountryNo = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        CountryNo = Request.QueryString["CountryNo"] == null ? 1 : Convert.ToInt32(Request.QueryString["CountryNo"]);
        CategoryGetListArguments arg = new CategoryGetListArguments();
        arg.CategoryMasterNo = 3;
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

    public string GetCategoryName(CategoryEntity entity)
    {
        if (CountryNo == 1)
            return entity.CategoryKRName;
        else if (CountryNo == 2)
            return entity.CategoryCNName;
        else if (CountryNo == 3)
            return entity.CategoryENGName;
        return entity.CategoryKRName;
    }

    public string GetSubCategoryName(SubCategoryEntity entity)
    {
        if (CountryNo == 1)
            return entity.SubCategoryKRName;
        else if (CountryNo == 2)
            return entity.SubCategoryCNName;
        else if (CountryNo == 3)
            return entity.SubCategoryENGName;
        return entity.SubCategoryKRName;
    }
}

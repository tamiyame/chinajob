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

using Com.Framework.Data;
using Com.Library.DB.User;
using Com.Library.DB.Category;

public partial class Backoffice_Backup_userExcel : System.Web.UI.Page
{
    public List<UserEntity> UserList = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.AddHeader("content-disposition", "attachment;filename=user.xls");
        Response.ContentType = "application/vnd.ms-excel";

        UserGetListArguments arg = new UserGetListArguments();
        arg.PageSize = 0;
        arg.PageNo = 1;
        arg.Status = 1;
        UserGetList list = new UserGetList();
        list.SetArguments(arg);
        list.Execute();
        UserList = list.GetRecords();
    }

    public string GetCategoryName(int CategoryNo)
    {
        CategoryGetInfoArguments arg = new CategoryGetInfoArguments();
        arg.CategoryNo = CategoryNo;
        CategoryGetInfo info = new CategoryGetInfo();
        info.SetArguments(arg);
        info.ExecuteNonQuery();

        return info.GetOutput().CategoryKRName;
    }

    public string GetSubCategoryName(int SubCategoryNo)
    {
        SubCategoryGetInfoArguments arg = new SubCategoryGetInfoArguments();
        arg.SubCategoryNo = SubCategoryNo;
        SubCategoryGetInfo info = new SubCategoryGetInfo();
        info.SetArguments(arg);
        info.ExecuteNonQuery();

        return info.GetOutput().SubCategoryKRName == string.Empty ? "" : "<br/>" + info.GetOutput().SubCategoryKRName;
    }
}

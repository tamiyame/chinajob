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
using Com.Library.DB.Category;
using Com.Framework.Data;
using System.Collections.Generic;

public partial class Backoffice_Setting_Category : SitePage
{
    public ListData<CategoryEntity, OutputEntity> CategoryLists = null;
    public CategoryMasterEntity CategoryMaster;
    protected void Page_Load(object sender, EventArgs e)
    {
        int categoryMasterNo = Request["CategoryMaster"] == null ? 0 : Convert.ToInt32(Request["CategoryMaster"]);
        if (categoryMasterNo == 0)
        {
            Response.Write("<script>alert('적합하지 않은 접근입니다.');</script>");
            return;
        }

        CategoryMasterGetInfo getInfo = new CategoryMasterGetInfo();
        getInfo.SetArguments(
                new CategoryMasterGetInfoArguments()
                {
                    CategoryMasterNo = categoryMasterNo
                }
            );
        getInfo.Execute();
        CategoryMaster = getInfo.GetOutput();
        if (CategoryMaster == null)
        {
            Response.Write("<script>alert('적합하지 않은 접근입니다.');</script>");
            return;
        }
        
        if (this.IsPostBack && Request["IsChange"] != null)
        {
            string[] IsChange = Request["IsChange"].Split(',');
            string[] CategoryNo = Request["CategoryNo"].Split(',');
            string[] IsDelete = Request["IsDelete"].Split(',');
            string[] order = Request["order"].Split(',');
            string[] categoryENName = Request["categoryENName"].Split(',');
            string[] categoryCNName = Request["categoryCNName"].Split(',');
            string[] categoryKRName = Request["categoryKRName"].Split(',');
            for (int i = 0; i < IsChange.Length; ++i)
            {
                if (IsDelete[i] == "1")
                {
                    CategoryRemove remove = new CategoryRemove();
                    remove.SetArguments(
                        new CategoryRemoveArguments()
                        {
                            CategoryNo = Convert.ToInt32(CategoryNo[i])
                        });
                    remove.ExecuteNonQuery();
                }
                else if (IsChange[i] == "1")
                {
                    if (CategoryNo[i] == "0")
                    {
                        //신규추가
                        CategoryCreate create = new CategoryCreate();
                        create.SetArguments(
                            new CategoryCreateArguments()
                            {
                                CategoryCNName = categoryCNName[i],
                                CategoryENGName = categoryENName[i],
                                CategoryKRName = categoryKRName[i],
                                CategoryMasterNo = categoryMasterNo
                            });
                        create.ExecuteNonQuery();
                    }
                    else
                    {                        
                        //업데이트
                        CategoryModify modify = new CategoryModify();
                        modify.SetArguments(
                            new CategoryModifyArguments()
                            {
                                CategoryCNName = categoryCNName[i],
                                CategoryENGName = categoryENName[i],
                                CategoryKRName = categoryKRName[i],
                                CategoryMasterNo = categoryMasterNo,
                                CategoryNo = Convert.ToInt32(CategoryNo[i])
                            });
                        modify.ExecuteNonQuery();
                    }
                }
            }
        }

        CategoryGetList list = new CategoryGetList();
        list.SetArguments(
            new CategoryGetListArguments()
            {
                CategoryMasterNo = categoryMasterNo //test
            }
        );
        List<CategoryEntity> record = list.Execute();
        OutputEntity outputdata = list.GetOutput();
        CategoryLists = new ListData<CategoryEntity, OutputEntity>(record, outputdata);
    }
}

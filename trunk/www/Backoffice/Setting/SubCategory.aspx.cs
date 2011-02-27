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

public partial class Backoffice_Setting_SubCategory : System.Web.UI.Page
{
    public ListData<SubCategoryEntity, OutputEntity> SubCategoryLists = null;
    public CategoryEntity Category = null;
    public int CategoryNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        CategoryNo = Request["CategoryNo"] == null ? 19 : Convert.ToInt32(Request["CategoryNo"]);
        if (CategoryNo == 0)
        {
            Response.Write("<script>alert('적합하지 않은 접근입니다.');window.close();</script>");
            return;
        }
        if (this.IsPostBack && Request["IsChange"] != null)
        {
            string[] IsChange = Request["IsChange"].Split(',');
            string[] SubCategoryNo = Request["SubCategoryNo"].Split(',');
            string[] IsDelete = Request["IsDelete"].Split(',');
            string[] order = Request["order"].Split(',');
            string[] categoryENName = Request["categoryENName"].Split(',');
            string[] categoryCNName = Request["categoryCNName"].Split(',');
            string[] categoryKRName = Request["categoryKRName"].Split(',');
            for (int i = 0; i < IsChange.Length; ++i)
            {
                if (IsDelete[i] == "1")
                {
                    SubCategoryRemove remove = new SubCategoryRemove();
                    remove.SetArguments(
                        new SubCategoryRemoveArguments()
                        {
                            SubCategoryNo = Convert.ToInt32(SubCategoryNo[i])
                        });
                    remove.ExecuteNonQuery();
                }
                else if (IsChange[i] == "1")
                {
                    if (SubCategoryNo[i] == "0")
                    {
                        //신규추가
                        SubCategoryCreate create = new SubCategoryCreate();
                        create.SetArguments(
                            new SubCategoryCreateArguments()
                            {   
                                SubCategoryCNName = categoryCNName[i],
                                SubCategoryENGName = categoryENName[i],
                                SubCategoryKRName = categoryKRName[i],
                                CategoryNo = CategoryNo
                            });
                        create.ExecuteNonQuery();
                    }
                    else
                    {                        
                        //업데이트
                        SubCategoryModify modify = new SubCategoryModify();
                        modify.SetArguments(
                            new SubCategoryModifyArguments()
                            {
                                SubCategoryCNName = categoryCNName[i],
                                SubCategoryENGName = categoryENName[i],
                                SubCategoryKRName = categoryKRName[i],
                                CategoryNo = CategoryNo,
                                SubCategoryNo = Convert.ToInt32(SubCategoryNo[i])
                            });
                        modify.ExecuteNonQuery();
                    }
                }
            }
        }

        SubCategoryGetList list = new SubCategoryGetList();
        list.SetArguments(
            new SubCategoryGetListArguments()
            {                
                CategoryNo = CategoryNo 
            }
        );
        List<SubCategoryEntity> record = list.Execute();
        OutputEntity outputdata = list.GetOutput();
        SubCategoryLists = new ListData<SubCategoryEntity, OutputEntity>(record, outputdata);

        CategoryGetInfo get = new CategoryGetInfo();
        get.SetArguments(
            new CategoryGetInfoArguments()
            {
                CategoryNo = CategoryNo
            }
        );
        get.Execute();
        Category = get.GetOutput();
    }
}

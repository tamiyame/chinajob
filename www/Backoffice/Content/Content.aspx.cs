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
using Com.Library.DB.Menu;

public partial class Backoffice_Content_Content : SitePage
{
    public TopMenuEntity TopMenuInfo = null;
    public List<SubMenuEntity> SubMenuList = null;
    public SubMenuEntity SubMenuInfo = null;
    public int CountryNo;
    public short TopMenuNo;
    public short SubMenuNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        CountryNo = Request.QueryString["CountryNo"] == null ? 1 : Convert.ToInt32(Request.QueryString["CountryNo"]);
        TopMenuNo = Request.QueryString["TopMenuNo"] == null ? (short)1 : Convert.ToInt16(Request.QueryString["TopMenuNo"]);
        SubMenuNo = Request.QueryString["SubMenuNo"] == null ? (short)1 : Convert.ToInt16(Request.QueryString["SubMenuNo"]);
        TopMenuGetInfoArguments topInfoArg = new TopMenuGetInfoArguments();
        topInfoArg.CountryNo = CountryNo;
        topInfoArg.TopMenuNo = TopMenuNo;

        TopMenuGetInfo topInfo = new TopMenuGetInfo();
        topInfo.SetArguments(topInfoArg);
        topInfo.ExecuteNonQuery();
        TopMenuInfo = topInfo.GetOutput();

        SubMenuGetInfoArguments subInfoArg = new SubMenuGetInfoArguments();
        subInfoArg.CountryNo = CountryNo;
        subInfoArg.TopMenuNo = TopMenuNo;
        subInfoArg.SubMenuNo = SubMenuNo;
        SubMenuGetInfo subMenuInfo = new SubMenuGetInfo();
        subMenuInfo.SetArguments(subInfoArg);
        subMenuInfo.ExecuteNonQuery();
        SubMenuInfo = subMenuInfo.GetOutput();


        SubMenuGetListArguments subListArg = new SubMenuGetListArguments();
        subListArg.TopMenuNo = TopMenuNo;
        subListArg.CountryNo = CountryNo;
        SubMenuGetList lstSubMenu = new SubMenuGetList();
        lstSubMenu.SetArguments(subListArg);
        lstSubMenu.Execute();
        SubMenuList = lstSubMenu.GetRecords();

        if (this.IsPostBack)
        {
            string ArticleContent = Request.Form["ArticleContent"];
            SubMenuModifyArguments modifyArg = new SubMenuModifyArguments();
            modifyArg.CenterContent = ArticleContent;
            modifyArg.CountryNo = CountryNo;
            modifyArg.TopMenuNo = TopMenuNo;
            modifyArg.SubMenuNo = SubMenuNo;
            SubMenuModify modify = new SubMenuModify();
            modify.SetArguments(modifyArg);
            modify.ExecuteNonQuery();
            Response.Write("<script language='javascript'>location.href='Content.aspx?CountryNo=" + CountryNo.ToString() + "&TopMenuNo=" + TopMenuNo.ToString() + "&SubMenuNo=" + SubMenuNo.ToString() + "'</script>");
            Response.End();
        }
    }
}

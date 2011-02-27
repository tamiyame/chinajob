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
using Site.Web.Util;
using Com.Library.DB.Company;
using Com.Library.DB.Category;

public partial class KR_Company_recruit_list : SitePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CompanyGetInfo info = new CompanyGetInfo();
        CompanyGetInfoArguments argInfo = new CompanyGetInfoArguments();
        argInfo.CompanyID = this.WebCookies.UserID;
        info.SetArguments(argInfo);
        info.ExecuteNonQuery();
        CompanyEntity infoEntity = info.GetOutput();
        if (infoEntity.Approval != 1)
        {
            Response.Clear();
            Response.Write("<script language='javascript'>location.href='" + this.GetURL("/home/") + "';alert('" + Message.Msg(this.WebMaster.CountryCode, k_MsgType.Apply_Company) + "');</script>");
            Response.End();
        }

        if (!this.WebCookies.isCompany)
        {
            Response.Clear();
            Response.Write("<script language='javascript'>location.href='" + this.GetURL("/home/") + "';alert('" + Message.Msg(this.WebMaster.CountryCode, k_MsgType.Company_User) + "');</script>");
            Response.End();
        }

        if (!IsRecruitCreate)
        {
            Response.Clear();
            Response.Write("<script language='javascript'>location.href='" + this.GetURL("/home/") + "';alert('" + Message.Msg(this.WebMaster.CountryCode, k_MsgType.CompanyJoinType) + "');</script>");
            Response.End();
        }
    }

    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);
    }
}

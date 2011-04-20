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
using Com.Library.Translate;
using Site.Web.Page;
using Site.Web.Util;

public partial class KR_Recruit_human_detail_korean : KR_Recruit_human_detail
{
    public int CountryNo = 1;
    public byte JoinType = 3;
    public int Category1No = 0;
    public int Category2No = 0;
    public int AgeCategory = 0;
    public int CityCategory = 0;
    public int AreaCategory = 0;
    public byte Gender = 0;
    public string UserName = string.Empty;
    public int PageNo = 1;
    public byte PageSize = 10;
	protected void Page_Load(object sender, EventArgs e)
	{
        if (!this.IsUserView)
        {
            Response.Clear();
            Response.Write("<script language='javascript'>location.href='" + this.GetURL("/home/") + "';alert('" + Message.Msg(this.WebMaster.CountryCode, k_MsgType.UserViewType) + "');</script>");
            Response.End();
        }

		CountryCode = TranslateHelper.ContryCode.KR;

        PageNo = Request.QueryString["PageNo"] == null ? 1 : Convert.ToInt32(Request.QueryString["PageNo"]);
        CountryNo = Request.QueryString["Country"] == null ? 1 : Convert.ToInt32(Request.QueryString["Country"]);
        JoinType = Request.QueryString["Join"] == null ? (byte)3 : Convert.ToByte(Request.QueryString["Join"]);
        Category1No = Request.QueryString["Category1"] == null ? 0 : Convert.ToInt32(Request.QueryString["Category1"]);
        Category2No = Request.QueryString["Category2"] == null ? 0 : Convert.ToInt32(Request.QueryString["Category2"]);
        AgeCategory = Request.QueryString["Age"] == null ? 0 : Convert.ToInt32(Request.QueryString["Age"]);
        CityCategory = Request.QueryString["City"] == null ? 0 : Convert.ToInt32(Request.QueryString["City"]);
        AreaCategory = Request.QueryString["Area"] == null ? 0 : Convert.ToInt32(Request.QueryString["Area"]);
        Gender = Request.QueryString["Gender"] == null ? (byte)0 : Convert.ToByte(Request.QueryString["Gender"]);
        UserName = Request.QueryString["Name"] == null ? string.Empty : Convert.ToString(Request.QueryString["Name"]);
	}

    public string GetSearch()
    {
        string url = "human_search.aspx?Country=" + CountryNo;
        url += "&PageNo=" + PageNo.ToString();
        if (JoinType != 3)
            url += "&join=" + JoinType.ToString();
        if (Category1No != 0)
            url += "&Category1=" + Category1No.ToString();
        if (Category2No != 0)
            url += "&Category2=" + Category2No.ToString();
        if (AgeCategory != 0)
            url += "&Age=" + AgeCategory.ToString();
        if (CityCategory != 0)
            url += "&City=" + CityCategory.ToString();
        if (AreaCategory != 0)
            url += "&Age=" + AreaCategory.ToString();
        if (Gender != 0)
            url += "&Gender=" + Gender.ToString();
        if (UserName.Trim() != "")
            url += "&Name=" + Server.UrlEncode(UserName);
        return url;
    }

    public string GetDetailViewer(string pageName, int userNo)
    {
        string url = pageName + "?Country=" + CountryNo;
        url += "&PageNo=" + PageNo.ToString();
        url += "&userNo=" + userNo.ToString();
        if (JoinType != 3)
            url += "&join=" + JoinType.ToString();
        if (Category1No != 0)
            url += "&Category1=" + Category1No.ToString();
        if (Category2No != 0)
            url += "&Category2=" + Category2No.ToString();
        if (AgeCategory != 0)
            url += "&Age=" + AgeCategory.ToString();
        if (CityCategory != 0)
            url += "&City=" + CityCategory.ToString();
        if (AreaCategory != 0)
            url += "&Age=" + AreaCategory.ToString();
        if (Gender != 0)
            url += "&Gender=" + Gender.ToString();
        if (UserName.Trim() != "")
            url += "&Name=" + Server.UrlEncode(UserName);
        return url;
    }
}

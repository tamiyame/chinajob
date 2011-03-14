using System;
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
using System.Web.Services;

using Site.Web.Page;
using Com.Framework.Data;
using Com.Library.DB.Participate;
using Com.Library.DB.Category;

public partial class KR_User_human_recruit_manage : SitePage
{
    public int PageNo { get; set; }
    public byte PageSize = 20;

    private ListData<ParticipateEntity, OutputEntity> m_ParticiapteList = null;
    public ListData<ParticipateEntity, OutputEntity> ParticiapteList
    {
        get { return m_ParticiapteList; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        PageNo = Request.QueryString["PageNo"] == null ? 1 : Convert.ToInt32(Request.QueryString["PageNo"]);
        ParticipateGetListArguments arg = new ParticipateGetListArguments();
        arg.UserNo = this.WebMaster.WebCookies.UserNo;
        arg.PageNo = PageNo;
        arg.PageSize = PageSize;
        ParticipateGetList list = new ParticipateGetList();
        list.SetArguments(arg);
        list.Execute();
        List<ParticipateEntity> _record = list.GetRecords();
        OutputEntity _output = list.GetOutput();
        m_ParticiapteList = new ListData<ParticipateEntity, OutputEntity>(_record, _output);
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

    [WebMethod]
    public static void SetConfirm(long seqNo, byte ConfirmType)
    {
        ParticipateModifyArguments arg = new ParticipateModifyArguments();
        arg.SeqNo = seqNo;
        arg.ConfirmType = ConfirmType;
        ParticipateModify modify = new ParticipateModify();
        modify.SetArguments(arg);
        modify.ExecuteNonQuery();
    }

    [WebMethod]
    public static void Remove(long seqNo)
    {
        ParticipateModifyArguments arg = new ParticipateModifyArguments();
        arg.SeqNo = seqNo;
        arg.Status = 2;
        ParticipateModify modify = new ParticipateModify();
        modify.SetArguments(arg);
        modify.ExecuteNonQuery();
    }
}

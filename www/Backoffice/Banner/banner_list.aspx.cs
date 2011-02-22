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
using Com.Framework.File;
using Com.Library.DB.Banner;
using Site.Web.Page;
using Com.Framework.Data;
using System.Collections.Generic;

public partial class Backoffice_Banner_BannerRegist : SitePage
{
    public int BannerType = 0;
    public int Country = 0;
    public ListData<BannerEntity, OutputEntity> BannerLists = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        BannerType = Request["BannerType"] == null ? 1 : Convert.ToInt32(Request["BannerType"]);
        Country = Request["Country"] == null ? 1 : Convert.ToInt32(Request["Country"]);

        if (this.IsPostBack && Request["IsChanged"] != null)
        {
            string[] IsChanged = Request["IsChanged"].Split(',');
            string[] BannerNo = Request["BannerNo"].Split(',');
            string[] LargeImageURL = Request["LargeImageURL"].Split(',');
            string[] SmallImageUrl = Request["SmallImageUrl"].Split(',');
            string[] ItemBannerType = Request["ItemBannerType"].Split(',');
            string[] ItemCountry = Request["ItemCountry"].Split(',');
            string[] Link = Request["Link"].Split(',');
            string[] IsView = Request["IsView"].Split(',');
            string[] OrderNo = Request["OrderNo"].Split(',');
            for (int i = 0; i < IsChanged.Length; ++i)
            {
                if (IsChanged[i] == "0")
                    continue;

                BannerModify modify = new BannerModify();
                modify.SetArguments(
                    new BannerModifyArguments()
                    {
                        BannerNo = Convert.ToInt32(BannerNo[i]),
                        BannerType = Convert.ToByte(BannerType),
                        CountryNo = Country,
                        IsView = Convert.ToInt32(IsView[i]),
                        LargeImageURL = LargeImageURL[i],
                        Link = Link[i],
                        OrderNo = Convert.ToInt32(OrderNo[i]),
                        SmallImageUrl = SmallImageUrl[i]
                    }
                );
                modify.ExecuteNonQuery();                
            }
        }

        BannerGetList list = new BannerGetList();
        list.SetArguments(
            new BannerGetListArguments()
            {
                BannerType = Convert.ToByte(BannerType),
                CountryNo = Country     
            }
        );
        List<BannerEntity> record = list.Execute();        
        OutputEntity outputdata = list.GetOutput();
        BannerLists = new ListData<BannerEntity, OutputEntity>(record, outputdata);
    }

    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);        
    }    
}

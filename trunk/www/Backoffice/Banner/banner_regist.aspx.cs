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

public partial class Backoffice_Banner_BannerRegist : SitePage
{
    public BannerEntity Banner = new BannerEntity();
    public int BannerNo = 0;
    public int BannerType = 0;
    public int Country = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        BannerNo = Request.QueryString["BannerNo"] == null ? 0 : Convert.ToInt32(Request.QueryString["BannerNo"]);
        BannerType = Request["BannerType"] == null ? 1 : Convert.ToInt32(Request["BannerType"]);
        Country = Request["Country"] == null ? 1 : Convert.ToInt32(Request["Country"]);       
        if (BannerNo != 0)
        {
            BannerGetInfo getInfo = new BannerGetInfo();
            getInfo.SetArguments(
                new BannerGetInfoArguments()
                {
                    BannerNo = BannerNo
                });
            getInfo.ExecuteNonQuery();
            Banner = getInfo.GetOutput();
            if (Banner.DateCreated.Equals(DateTime.MinValue))
            {
                BannerNo = 0;
                Response.Write("<script>alert('해당 번호에 해당하는 배너가 없습니다.');</script>");
            }
        }
        this.Form.Enctype = "multipart/form-data";
    }

    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);
        if (this.IsPostBack)
        {                 
            string linkUrl = Request["linkUrl"] == null ? String.Empty : Convert.ToString(Request["linkUrl"]);
            string bigImageUrl = Banner.LargeImageURL;
            string smallImageUrl = Banner.SmallImageUrl;
            if (Request.Files.Count > 0)
            {
                if (Request.Files["bigImage"].ContentLength > 0)
                {
                    bigImageUrl = FileManager.UploadFor(Request.Files["bigImage"], FileType.Banner);
                }

                if (Request.Files["smallImage"].ContentLength > 0)
                {
                    smallImageUrl = FileManager.UploadFor(Request.Files["smallImage"], FileType.Banner);
                }
            }

            if (BannerNo == 0)
            {
                BannerCreate create = new BannerCreate();
                create.SetArguments(
                    new BannerCreateArguments()
                    {
                        BannerType = Convert.ToByte(BannerType),
                        CountryNo = Country,
                        Link = linkUrl,
                        SmallImageUrl = smallImageUrl,
                        LargeImageURL = bigImageUrl,
                        DateCreated = DateTime.Now,
                        OrderNo = 1
                    });
                create.ExecuteNonQuery();
            }
            else
            {
                BannerModify modify = new BannerModify();
                modify.SetArguments(
                    new BannerModifyArguments()
                    {
                        BannerNo = BannerNo,
                        BannerType = Convert.ToByte(BannerType),
                        CountryNo = Country,
                        Link = linkUrl,
                        SmallImageUrl = smallImageUrl,
                        LargeImageURL = bigImageUrl,                        
                        OrderNo = Banner.OrderNo,
                        IsView = Banner.IsView
                    });
                modify.ExecuteNonQuery();
            }            
            Response.Write(string.Format("<script>window.location.replace('./banner_list.aspx?BannerType={0}&Country={1}')</script>",BannerType,Country));
        }
    }    
}

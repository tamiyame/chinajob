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
using Site.Web.Util;
using Com.Library.DB.User;
using Com.Library.DB.Category;
using System.Collections.Generic;
public partial class KR_User_human_regist_basic : SitePage
{
    public List<CategoryEntity> CityCategory;
    public List<CategoryEntity> BusinessCategory;
    public List<CategoryEntity> JobCategory;
    protected void Page_Load(object sender, EventArgs e)
    {
        {
            CategoryGetList list = new CategoryGetList();
            CategoryGetListArguments arg = new CategoryGetListArguments();
            arg.CategoryMasterNo = 3;
            list.SetArguments(arg);
            list.Execute();
            CityCategory = list.GetRecords();
        }

        {
            CategoryGetList list = new CategoryGetList();
            CategoryGetListArguments arg = new CategoryGetListArguments();
            arg.CategoryMasterNo = 5;
            list.SetArguments(arg);
            list.Execute();
            BusinessCategory = list.GetRecords();
        }

        {
            CategoryGetList list = new CategoryGetList();
            CategoryGetListArguments arg = new CategoryGetListArguments();
            arg.CategoryMasterNo = 1;
            list.SetArguments(arg);
            list.Execute();
            JobCategory = list.GetRecords();
        }

        if (this.IsPostBack)
        {
            string
            hopejob_1 = Request.Form["hopejob_1"] == null ? String.Empty : Request.Form["hopejob_1"],
            hopejob_2 = Request.Form["hopejob_2"] == null ? String.Empty : Request.Form["hopejob_2"],
            hopejob_3 = Request.Form["hopejob_3"] == null ? String.Empty : Request.Form["hopejob_3"],
            pay = Request.Form["pay"] == null ? String.Empty : Request.Form["pay"],
            location1_1 = Request.Form["location1_1"] == null ? String.Empty : Request.Form["location1_1"],
            location2_1 = Request.Form["location2_1"] == null ? String.Empty : Request.Form["location2_1"],
            location1_2 = Request.Form["location1_2"] == null ? String.Empty : Request.Form["location1_2"],
            location2_2 = Request.Form["location2_2"] == null ? String.Empty : Request.Form["location2_2"],
            year = Request.Form["year"] == null ? String.Empty : Request.Form["year"],
            month = Request.Form["month"] == null ? String.Empty : Request.Form["month"],
            day = Request.Form["day"] == null ? String.Empty : Request.Form["day"],
            hope_job_category1_1 = Request.Form["hope_job_category1_1"] == null ? String.Empty : Request.Form["hope_job_category2_1"],
            hope_job_category2_1 = Request.Form["hope_job_category2_1"] == null ? String.Empty : Request.Form["hope_job_category2_1"],
            hope_job_category2_2 = Request.Form["hope_job_category2_2"] == null ? String.Empty : Request.Form["hope_job_category2_2"],
            isJoin = Request.Form["isJoin"] == null ? String.Empty : Request.Form["isJoin"];

            ResumeCreate create = new ResumeCreate();
            create.SetArguments(
                new ResumeCreateArguments()
                {
                    ArrayNo1 = Convert.ToInt32(location2_1),
                    ArrayNo2 = Convert.ToInt32(location2_2),
                    BusinessCategoryNo = Convert.ToInt32(hope_job_category1_1),
                    Category1No = Convert.ToInt32(hope_job_category2_1),
                    Category2No = Convert.ToInt32(hope_job_category2_2),
                    CityNo1 = Convert.ToInt32(location1_1),
                    CityNo2 = Convert.ToInt32(location1_2),
                    CompanyNo1 = Convert.ToInt32(hopejob_1),
                    CompanyNo2 = Convert.ToInt32(hopejob_2),
                    CompanyNo3 = Convert.ToInt32(hopejob_3),
                    CountryNo = this.WebMaster.CountryCode,
                    HopeRecruitDate = new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
                    HopeSalary = pay,
                    UserNo = this.WebCookies.UserNo
                });
            create.ExecuteNonQuery();
        }
    }
}

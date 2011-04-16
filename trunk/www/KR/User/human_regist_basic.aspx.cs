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
	public ResumeEntity resumeEntity = null;
    protected void Page_Load(object sender, EventArgs e)
    {
		if (!this.WebCookies.IsLogin)
		{
			Response.Clear();
			Response.Write("<script language='javascript'>;location.href='" + GetURL("/home") + "'; alert('" + Message.Msg(this.WebMaster.CountryCode, k_MsgType.User_Login) + "');</script>");
			Response.End();
		}

		LoadResume();
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
			pay = Request.Form["pay"] == null ? String.Empty : Request.Form["pay"],
			location1_1 = Request.Form["location1_1"] == null ? String.Empty : Request.Form["location1_1"],
			location2_1 = Request.Form["location2_1"] == null ? String.Empty : Request.Form["location2_1"],
			location1_2 = Request.Form["location1_2"] == null ? String.Empty : Request.Form["location1_2"],
			location2_2 = Request.Form["location2_2"] == null ? String.Empty : Request.Form["location2_2"],
			year = Request.Form["year"] == null ? String.Empty : Request.Form["year"],
			month = Request.Form["month"] == null ? String.Empty : Request.Form["month"],
			day = Request.Form["day"] == null ? String.Empty : Request.Form["day"],
			hope_job_category1_1 = Request.Form["hope_job_category1_1"] == null ? String.Empty : Request.Form["hope_job_category1_1"],
			hope_job_category2_1 = Request.Form["hope_job_category2_1"] == null ? String.Empty : Request.Form["hope_job_category2_1"],
			hope_job_category2_2 = Request.Form["hope_job_category2_2"] == null ? String.Empty : Request.Form["hope_job_category2_2"],
			isJoin = Request.Form["isJoin"] == null ? String.Empty : Request.Form["isJoin"],
			hope_job_category_etc = string.Empty;

            if (GetCategoryName(Convert.ToInt32(hope_job_category2_1)) == "직접입력")
			{
				hope_job_category_etc = Request.Form["hope_job_category_etc"];
			}

			if (resumeEntity == null)
			{
				ResumeCreate create = new ResumeCreate();
				create.SetArguments(
					new ResumeCreateArguments()
					{
						ArrayNo1 = Convert.ToInt32(location2_1),
						ArrayNo2 = Convert.ToInt32(location2_2),
						BusinessCategoryNo = Convert.ToInt32(hope_job_category1_1),
						Category1No = Convert.ToInt32(hope_job_category2_1),
                        Category2No = Convert.ToInt32(hope_job_category2_2 == "" ? "0" : hope_job_category2_2),
						CategoryEtc = hope_job_category_etc,
						CityNo1 = Convert.ToInt32(location1_1),
						CityNo2 = Convert.ToInt32(location1_2),
						HopeRecruitDate = new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
						HopeSalary = pay,
						UserNo = this.WebCookies.UserNo,
						JoinType = Convert.ToByte(isJoin)
					});
				create.ExecuteNonQuery();
			}
			else
			{
				ResumeModify modify = new ResumeModify();
				modify.SetArguments(
					new ResumeModifyArguments()
					{
						UserNo = WebCookies.UserNo,
						ArrayNo1 = Convert.ToInt32(location2_1),
						ArrayNo2 = Convert.ToInt32(location2_2),
						BusinessCategoryNo = Convert.ToInt32(hope_job_category1_1),
						Category1No = Convert.ToInt32(hope_job_category2_1),
                        Category2No = Convert.ToInt32(hope_job_category2_2 == "" ? "0" : hope_job_category2_2),
						CategoryEtc = hope_job_category_etc,
						CityNo1 = Convert.ToInt32(location1_1),
						CityNo2 = Convert.ToInt32(location1_2),
						HopeRecruitDate = new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
						HopeSalary = pay,
						JoinType = Convert.ToByte(isJoin)
					});
				modify.ExecuteNonQuery();
			}
			LoadResume();
        }
    }

	protected void LoadResume()
	{
		ResumeGetInfoArguments resumeGetInfoArguments = new ResumeGetInfoArguments();
		resumeGetInfoArguments.UserNo = this.WebCookies.UserNo;

		ResumeGetInfo resumeGetInfo = new ResumeGetInfo();
		resumeGetInfo.SetArguments(resumeGetInfoArguments);
		resumeGetInfo.ExecuteNonQuery();
		resumeEntity = resumeGetInfo.GetOutput();

		if (resumeEntity.RegistryTime == DateTime.MinValue)
		{
			// 초기값 세팅
			resumeEntity = null;
		}

	}

	protected string GetResumeEntityValue(string colName)
	{
		string retVal = string.Empty;
		switch (colName)
		{
			case "CompanyNo1":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = resumeEntity.CompanyNo1.ToString(); }
				break;
			case "CompanyNo2":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = resumeEntity.CompanyNo2.ToString(); }
				break;
			case "CompanyNo3":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = resumeEntity.CompanyNo3.ToString(); }
				break;
			case "HopeSalary":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = resumeEntity.HopeSalary.ToString(); }
				break;
			case "CityNo1":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = resumeEntity.CityNo1.ToString(); }
				break;
			case "ArrayNo1":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = resumeEntity.ArrayNo1.ToString(); }
				break;
			case "CityNo2":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = resumeEntity.CityNo2.ToString(); }
				break;
			case "ArrayNo2":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = resumeEntity.ArrayNo2.ToString(); }
				break;
			case "HopeRecruitDateYear":
				if (resumeEntity == null) { retVal = "2011"; } else { retVal = resumeEntity.HopeRecruitDate.Year.ToString(); }
				break;
			case "HopeRecruitDateMonth":
				if (resumeEntity == null) { retVal = "1"; } else { retVal = resumeEntity.HopeRecruitDate.Month.ToString(); }
				break;
			case "HopeRecruitDateDay":
				if (resumeEntity == null) { retVal = "1"; } else { retVal = resumeEntity.HopeRecruitDate.Day.ToString(); }
				break;
			case "BusinessCategoryNo":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = resumeEntity.BusinessCategoryNo.ToString(); }
				break;
			case "Category1No":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = resumeEntity.Category1No.ToString(); }
				break;
			case "Category2No":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = resumeEntity.Category2No.ToString(); }
				break;
			case "CategoryEtc":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = resumeEntity.CategoryEtc.ToString(); }
				break;
			case "JoinType":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = resumeEntity.JoinType.ToString(); }
				break;
			default :
				throw new Exception("invalid column name");
		}
		return retVal;
	}

	protected string GetSubCategoryName(int subCategoryNo)
	{
		SubCategoryGetInfoArguments arg = new SubCategoryGetInfoArguments();
		arg.SubCategoryNo = subCategoryNo;

		SubCategoryGetInfo getInfo = new SubCategoryGetInfo();
		getInfo.SetArguments(arg);
		getInfo.ExecuteNonQuery();

		SubCategoryEntity entity = getInfo.GetOutput();

		return entity.SubCategoryKRName;
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

}

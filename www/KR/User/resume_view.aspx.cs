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

using Com.Library.DB.User;
using Com.Library.DB.Company;
using Com.Library.DB.Category;
using Com.Framework.Data;
using System.Collections.Generic;
using Com.Library.Translate;
using Com.Library.Cookie;

public partial class KR_User_resume_view : System.Web.UI.Page
{
    public ResumeEntity resumeEntity = null;
    public UserEntity UserInfo = null;
    public ResumeDetailEntity resumeDetail_KR = null;
    public ResumeDetailEntity resumeDetail_CN = null;
    public ResumeDetailEntity resumeDetail_ENG = null;
    public int UserNo { get; set; }
	public ResumeDetailEntity[] ResumeDetail { get; set; }
	public List<ResumeAcademicAbilityEntity>[] ResumeAcademicAbilities { get; set; }
	public List<ResumeCareerEntity>[] ResumeCareers { get; set; }
	public List<ResumeLanguageEntity>[] ResumeLanguages { get; set; }
	public List<ResumeLicenseEntity>[] ResumeLicenses { get; set; }
	public Repeater[] RptAcademicAbility { get; set; }
	public Repeater[] RptCareer { get; set; }
	public Repeater[] RptLanguage { get; set; }
	public Repeater[] RptLicense { get; set; }
    public WebCookie webCookie = null;
	protected void Page_Load(object sender, EventArgs e)
    {
        webCookie = new WebCookie();
        UserNo = Request.QueryString["UserNo"] == null ? 0 : Convert.ToInt32(Request.QueryString["UserNo"]);
        if (UserNo == 0)
        {
            Response.Clear();
            Response.Write("<script language='javascript'>alert('유저 정보가 정확하시 않습니다.'); self.close();</script>");
            Response.End();
        }

        ResumeGetInfoArguments resumeGetInfoArguments = new ResumeGetInfoArguments();
        resumeGetInfoArguments.UserNo = UserNo;

        ResumeGetInfo resumeGetInfo = new ResumeGetInfo();
        resumeGetInfo.SetArguments(resumeGetInfoArguments);
        resumeGetInfo.ExecuteNonQuery();
        resumeEntity = resumeGetInfo.GetOutput();
        /*
        if (resumeEntity.RegistryTime == DateTime.MinValue)
        {
            resumeEntity = null;
        }

        if (resumeEntity == null)
        {
            Response.Clear();
            Response.Write("<script language='javascript'>alert('유저 정보가 정확하시 않습니다.'); self.close();</script>");
            Response.End();
        }
        */

//        resumeDetail_KR = DetailInfo(UserNo, 1);
//        resumeDetail_CN = DetailInfo(UserNo, 2);
//        resumeDetail_ENG = DetailInfo(UserNo, 3);

        UserGetInfoArguments userArg = new UserGetInfoArguments();
        userArg.UserNo = UserNo;
        UserGetInfo userInfo = new UserGetInfo();
        userInfo.SetArguments(userArg);
        userInfo.ExecuteNonQuery();
        UserInfo = userInfo.GetOutput();

		ResumeDetail = new ResumeDetailEntity[4];
		ResumeAcademicAbilities = new List<ResumeAcademicAbilityEntity>[4];
		ResumeCareers = new List<ResumeCareerEntity>[4];
		ResumeLanguages = new List<ResumeLanguageEntity>[4];
		ResumeLicenses = new List<ResumeLicenseEntity>[4];

		RptAcademicAbility = new Repeater[4];
		RptCareer = new Repeater[4];
		RptLanguage = new Repeater[4];
		RptLicense = new Repeater[4];

		RptAcademicAbility[1] = rptAcademicAbility_kr;
		RptAcademicAbility[3] = rptAcademicAbility_en;

		RptCareer[1] = rptCareer_kr;
		RptCareer[2] = rptCareer_cn;
		RptCareer[3] = rptCareer_en;

		RptLanguage[1] = rptLanguage_kr;
		RptLanguage[2] = rptLanguage_cn;
		RptLanguage[3] = rptLanguage_en;

		RptLicense[1] = rptLicense_kr;
		RptLicense[3] = rptLicense_en;


		LoadCountryData(TranslateHelper.ContryCode.KR);
		LoadCountryData(TranslateHelper.ContryCode.CN);
		LoadCountryData(TranslateHelper.ContryCode.EN);
	}

	private void LoadCountryData(TranslateHelper.ContryCode cc)
	{
		int arrayIdx = (int)cc;
		LoadDetail(cc);

		// detailAcademy
		ResumeAcademicAbilities[arrayIdx] = SetList<ResumeAcademicAbilityEntity>(cc, delegate(IArguments arg) { ResumeAcademicAbilityGetList getlist = new ResumeAcademicAbilityGetList(); getlist.SetArguments(arg); getlist.Execute(); return getlist.GetRecords(); });
		for (int cnt = ResumeAcademicAbilities[arrayIdx].Count; cnt < 3; cnt++)
		{
			ResumeAcademicAbilities[arrayIdx].Add(new ResumeAcademicAbilityEntity());
		}
		if (RptAcademicAbility[arrayIdx] != null)
		{
			RptAcademicAbility[arrayIdx].DataSource = ResumeAcademicAbilities[arrayIdx];
			RptAcademicAbility[arrayIdx].DataBind();
		}

		// detailCareer
		ResumeCareers[arrayIdx] = SetList<ResumeCareerEntity>(cc, delegate(IArguments arg) { ResumeCareerGetList getlist = new ResumeCareerGetList(); getlist.SetArguments(arg); getlist.Execute(); return getlist.GetRecords(); });
		for (int cnt = ResumeCareers[arrayIdx].Count; cnt < 3; cnt++)
		{
			ResumeCareers[arrayIdx].Add(new ResumeCareerEntity());
		}
		if (RptCareer[arrayIdx] != null)
		{
			RptCareer[arrayIdx].DataSource = ResumeCareers[arrayIdx];
			RptCareer[arrayIdx].DataBind();
		}

		// detailLanguage
		ResumeLanguages[arrayIdx] = SetList<ResumeLanguageEntity>(cc, delegate(IArguments arg) { ResumeLanguageGetList getlist = new ResumeLanguageGetList(); getlist.SetArguments(arg); getlist.Execute(); return getlist.GetRecords(); });
		for (int cnt = ResumeLanguages[arrayIdx].Count; cnt < 3; cnt++)
		{
			ResumeLanguages[arrayIdx].Add(new ResumeLanguageEntity());
		}
		if (RptLanguage[arrayIdx] != null)
		{
			RptLanguage[arrayIdx].DataSource = ResumeLanguages[arrayIdx];
			RptLanguage[arrayIdx].DataBind();
		}

		// detailLicense
		ResumeLicenses[arrayIdx] = SetList<ResumeLicenseEntity>(cc, delegate(IArguments arg) { ResumeLicenseGetList getlist = new ResumeLicenseGetList(); getlist.SetArguments(arg); getlist.Execute(); return getlist.GetRecords(); });
		for (int cnt = ResumeLicenses[arrayIdx].Count; cnt < 3; cnt++)
		{
			ResumeLicenses[arrayIdx].Add(new ResumeLicenseEntity());
		}
		if (RptLicense[arrayIdx] != null)
		{
			RptLicense[arrayIdx].DataSource = ResumeLicenses[arrayIdx];
			RptLicense[arrayIdx].DataBind();
		}
	}

	private void LoadDetail(TranslateHelper.ContryCode cc)
	{
		int arrayIdx = (int)cc;

		ResumeDetailGetInfoArguments detailArg = new ResumeDetailGetInfoArguments();
		detailArg.UserNo = UserNo;
		detailArg.CountryNo = arrayIdx;
		ResumeDetailGetInfo detailInfo = new ResumeDetailGetInfo();
		detailInfo.SetArguments(detailArg);
		detailInfo.ExecuteNonQuery();
		ResumeDetail[arrayIdx] = detailInfo.GetOutput();
	}

	protected List<Entity> SetList<Entity>(TranslateHelper.ContryCode cc, Func<IArguments, List<Entity>> func) where Entity : DataEntity, new()
	{
		IArguments arg = null;
		Entity dummy = new Entity();
		if (dummy is ResumeAcademicAbilityEntity)
		{
			arg = new ResumeAcademicAbilityGetListArguments();
			((ResumeAcademicAbilityGetListArguments)arg).UserNo = UserNo;
			((ResumeAcademicAbilityGetListArguments)arg).CountryNo = (int)cc;
		}
		else if (dummy is ResumeCareerEntity)
		{
			arg = new ResumeCareerGetListArguments();
			((ResumeCareerGetListArguments)arg).UserNo = UserNo;
			((ResumeCareerGetListArguments)arg).CountryNo = (int)cc;
		}
		else if (dummy is ResumeLanguageEntity)
		{
			arg = new ResumeLanguageGetListArguments();
			((ResumeLanguageGetListArguments)arg).UserNo = UserNo;
			((ResumeLanguageGetListArguments)arg).CountryNo = (int)cc;
		}
		else if (dummy is ResumeLicenseEntity)
		{
			arg = new ResumeLicenseGetListArguments();
			((ResumeLicenseGetListArguments)arg).UserNo = UserNo;
			((ResumeLicenseGetListArguments)arg).CountryNo = (int)cc;
		}
		return func(arg);

	}
	
	private ResumeDetailEntity DetailInfo(int userNo, int CountryNo)
    {
        ResumeDetailGetInfoArguments detailArg = new ResumeDetailGetInfoArguments();
        detailArg.UserNo = UserNo;
        detailArg.CountryNo = CountryNo;
        ResumeDetailGetInfo detailInfo = new ResumeDetailGetInfo();
        detailInfo.SetArguments(detailArg);
        detailInfo.ExecuteNonQuery();
        return detailInfo.GetOutput();
    }

	protected string GetResumeEntityValue(string colName)
	{
		string retVal = string.Empty;
		switch (colName)
		{
			case "CompanyNo1":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = GetCompanyName(resumeEntity.CompanyNo1); }
				break;
			case "CompanyNo2":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = GetCompanyName(resumeEntity.CompanyNo2); }
				break;
			case "CompanyNo3":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = GetCompanyName(resumeEntity.CompanyNo3); }
				break;
			case "HopeSalary":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = resumeEntity.HopeSalary; }
				break;
			case "CityNo1":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = GetCategoryName(resumeEntity.CityNo1); }
				break;
			case "ArrayNo1":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = GetSubCategoryName(resumeEntity.ArrayNo1); }
				break;
			case "CityNo2":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = GetCategoryName(resumeEntity.CityNo2); }
				break;
			case "ArrayNo2":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = GetSubCategoryName(resumeEntity.ArrayNo2); }
				break;
			case "HopeRecruitDate":
				if (resumeEntity == null) { retVal = "2011"; } else { retVal = resumeEntity.HopeRecruitDate.ToString("yyyy년 MM월 dd일"); }
				break;
			case "BusinessCategoryNo":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = GetCategoryName(resumeEntity.BusinessCategoryNo); }
				break;
			case "Category1No":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = GetCategoryName(resumeEntity.Category1No); }
				break;
			case "Category2No":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = GetSubCategoryName(resumeEntity.Category2No); }
				break;
			case "JoinType":
				if (resumeEntity == null) { retVal = string.Empty; } else { retVal = resumeEntity.JoinType.ToString(); }
				break;
			default:
				throw new Exception("invalid column name");
		}
		return retVal;
	}

	protected string GetCompanyName(int companyNo)
	{
		CompanyDetailGetInfoArguments arg = new CompanyDetailGetInfoArguments();
		arg.CompanyNo = companyNo;

		CompanyDetailGetInfo getInfo = new CompanyDetailGetInfo();
		getInfo.SetArguments(arg);
		getInfo.ExecuteNonQuery();

		CompanyDetailEntity comp = getInfo.GetOutput();

		return comp.KRName;
	}

	protected string GetCategoryName(int categoryNo)
	{
		CategoryGetInfoArguments arg = new CategoryGetInfoArguments();
		arg.CategoryNo = categoryNo;

		CategoryGetInfo getInfo = new CategoryGetInfo();
		getInfo.SetArguments(arg);
		getInfo.ExecuteNonQuery();

		CategoryEntity entity = getInfo.GetOutput();

		return entity.CategoryKRName;
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

	public string GetCountryName(byte countryCode)
	{
		TranslateHelper.ContryCode cc = (TranslateHelper.ContryCode)countryCode;
		string retVal = string.Empty;
		switch (cc)
		{
			case TranslateHelper.ContryCode.KR:
				retVal = "한국";
				break;
			case TranslateHelper.ContryCode.CN:
				retVal = "중국";
				break;
			case TranslateHelper.ContryCode.EN:
				retVal = "미국";
				break;
			default:
				retVal = string.Empty;
				break;
		}

		return retVal;
	}

	/*
		public string GetMilitaryInfo(byte type)
		{
			string retValue = "무관";
			switch (type)
			{
				case 1: retValue = "필"; break;
				case 2: retValue = "미필"; break;
				case 3: retValue = "면제"; break;
				case 4: retValue = "무관"; break;
			}
			return retValue;
		}

		public string GetCompanyName(int CountryNo, int CompanyNo)
		{
			CompanyDetailGetInfoArguments arg = new CompanyDetailGetInfoArguments();
			arg.CompanyNo = CompanyNo;
			CompanyDetailGetInfo info = new CompanyDetailGetInfo();
			info.SetArguments(arg);
			info.ExecuteNonQuery();
			if (CountryNo == 1)
			{
				return info.GetOutput().KRName;
			}
			else if (CountryNo == 2)
			{
				return info.GetOutput().CNName;
			}
			else
			{
				return info.GetOutput().ENGName;
			}
		}

		public string GetCategoryName(int CountryNo, int CategoryNo)
		{
			CategoryGetInfoArguments arg = new CategoryGetInfoArguments();
			arg.CategoryNo = CategoryNo;
			CategoryGetInfo info = new CategoryGetInfo();
			info.SetArguments(arg);
			info.ExecuteNonQuery();
			if (CountryNo == 1)
			{
				return info.GetOutput().CategoryKRName;
			}
			else if (CountryNo == 2)
			{
				return info.GetOutput().CategoryCNName;
			}
			else
			{
				return info.GetOutput().CategoryENGName;
			}
		}

		public string GetSubCategoryName(int CountryNo, int SubCategoryNo)
		{
			SubCategoryGetInfoArguments arg = new SubCategoryGetInfoArguments();
			arg.SubCategoryNo = SubCategoryNo;
			SubCategoryGetInfo info = new SubCategoryGetInfo();
			info.SetArguments(arg);
			info.ExecuteNonQuery();

			if (CountryNo == 1)
			{
				return info.GetOutput().SubCategoryKRName;
			}
			else if (CountryNo == 2)
			{
				return info.GetOutput().SubCategoryCNName;
			}
			else
			{
				return info.GetOutput().SubCategoryENGName;
			}
		}

	*/
}

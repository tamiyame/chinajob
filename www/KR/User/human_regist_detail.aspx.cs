﻿using System;
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
using Com.Library.DB.User;
using Com.Library.Translate;

public partial class KR_User_human_regist_detail : SitePage
{
    public ResumeEntity Resume = null;
    public UserEntity UserInfo = null;
	public TranslateHelper.ContryCode CountryCode = TranslateHelper.ContryCode.KR;
	public ResumeDetailEntity ResumeDetail { get; set; }
    protected void Page_Load(object sender, EventArgs e)
    {
         {
                UserGetInfoArguments infoArg = new UserGetInfoArguments();
                infoArg.UserNo = this.WebCookies.UserNo;
                UserGetInfo info = new UserGetInfo();
                info.SetArguments(infoArg);
                info.ExecuteNonQuery();
                UserInfo = info.GetOutput();
        }

		ResumeGetInfoArguments resumeGetInfoArguments = new ResumeGetInfoArguments();
		resumeGetInfoArguments.UserNo = this.WebCookies.UserNo;
 
		ResumeGetInfo resumeGetInfo = new ResumeGetInfo();
		resumeGetInfo.SetArguments(resumeGetInfoArguments);
		resumeGetInfo.ExecuteNonQuery();
		ResumeEntity resumeEntity = resumeGetInfo.GetOutput();

		if ( Request["countryCode"] != null && Request["countryCode"] != string.Empty )
		{
			CountryCode = (TranslateHelper.ContryCode)Convert.ToByte(Request["CountryCode"]);
		}

		// 기본정보 등록이 되어있지 않은 경우
		if (resumeEntity == null || resumeEntity.RegistryTime == DateTime.MinValue)
		{
			Response.Write("<script type='text/javascript'>alert('잘못된 접근 입니다. 기본 정보부터 작성해주세요.');location.href='" + GetURL("/user/human_regist_basic.aspx") + "';</script>");
			return;
		}

		// detail 정보 로드
		ResumeDetailGetInfoArguments resumeDetailGetInfoArguments = new ResumeDetailGetInfoArguments();
		resumeDetailGetInfoArguments.UserNo = WebCookies.UserNo;
		resumeDetailGetInfoArguments.CountryNo = (int)CountryCode;
		ResumeDetailGetInfo resumeDetailGetInfo = new ResumeDetailGetInfo();
		resumeDetailGetInfo.SetArguments(resumeDetailGetInfoArguments);
		resumeDetailGetInfo.ExecuteNonQuery();
		ResumeDetail = resumeDetailGetInfo.GetOutput();

        if (this.IsPostBack)
        {
            //Detail 등록
            string
            ssn1 = Request["ssn1"] == null ? String.Empty : Request["ssn1"],
            ssn2 = Request["ssn2"] == null ? String.Empty : Request["ssn2"],
            age = Request["age"] == null ? String.Empty : Request["age"],
            korean_age = Request["korean_age"] == null ? String.Empty : Request["korean_age"],
            inchina_year = Request["inchina_year"] == null ? String.Empty : Request["inchina_year"],
            inchina_month = Request["inchina_month"] == null ? String.Empty : Request["inchina_month"],
            army = Request["army"] == null ? String.Empty : Request["army"],
            isCareer = Request["isCareer"] == null ? String.Empty : Request["isCareer"],
            address = Request["address"] == null ? String.Empty : Request["address"];

            {
                ResumeDetailCreate create = new ResumeDetailCreate();
                create.SetArguments(
                    new ResumeDetailCreateArguments()
                    {
						UserNo = this.WebCookies.UserNo,
						CountryNo = (int)CountryCode,
						AboutMe = "",
                        Address = address,
                        Age = Convert.ToByte(age),
                        ChinaExp = inchina_year + "-" + inchina_month,
                        Description = "",
                        IsCareer = Convert.ToByte(isCareer),
                        KoreanAge = Convert.ToByte(korean_age),
                        Military = Convert.ToByte(isCareer),
                        SSN1 = ssn1,
                        SSN2 = ssn2
                    });
                create.ExecuteNonQuery();
            }

            // Academic ability 등록
            string[]
            education_school = Request["education_school"] == null ? new string[0] : Request["education_school"].Split(','),
            education_period_start = Request["education_period_start"] == null ? new string[0] : Request["education_period_start"].Split(','),
            education_period_end = Request["education_period_end"] == null ? new string[0] : Request["education_period_end"].Split(','),
            education_state = Request["education_state"] == null ? new string[0] : Request["education_state"].Split(','),
            education_major = Request["education_major"] == null ? new string[0] : Request["education_major"].Split(','),
            education_national = Request["education_national"] == null ? new string[0] : Request["education_national"].Split(',');

            for (int i = 0; i < education_school.Length; ++i)
            {
                if (education_school[i] == "")
                    continue;
                ResumeAcademicAbilityCreate create = new ResumeAcademicAbilityCreate();
                create.SetArguments(
                    new ResumeAcademicAbilityCreateArguments()
                    {
                        MajorMinor = education_major[i],
						UserNo = this.WebCookies.UserNo,
						CountryNo = (int)CountryCode,
                        SchoolCountryName = education_national[i],
                        SchoolEndDate = Convert.ToDateTime(education_period_end[i]),
                        SchoolName = education_school[i],
                        SchoolStartDate = Convert.ToDateTime(education_period_start[i]),
                        SchoolStatus = Convert.ToByte(education_state[i])
                    });
                create.ExecuteNonQuery();
            }

            // career 등록
            string[]
            career_company = Request["career_company"] == null ? new string[0] : Request["career_company"].Split(','),
            career_period_start = Request["career_period_start"] == null ? new string[0] : Request["career_period_start"].Split(','),
            career_period_end = Request["career_period_end"] == null ? new string[0] : Request["career_period_end"].Split(','),
            career_department = Request["career_department"] == null ? new string[0] : Request["career_department"].Split(','),
            career_detail = Request["career_detail"] == null ? new string[0] : Request["career_detail"].Split(',');

            for (int i = 0; i < career_company.Length; ++i)
            {
                if (career_company[i] == "")
                    continue;
                ResumeCareerCreate create = new ResumeCareerCreate();
                create.SetArguments(
                    new ResumeCareerCreateArguments()
                    {
                        CareerCompanyName = career_company[i],
                        CareerEndDate = Convert.ToDateTime(career_period_end[i]),
                        CareerStartDate = Convert.ToDateTime(career_period_start[i]),
                        CareerJobs = career_department[i],
                        CareerPosition = career_detail[i],
						UserNo = this.WebCookies.UserNo,
						CountryNo = (int)CountryCode
					});
                create.ExecuteNonQuery();
            }

            // language 등록
            string[]
            language_type = Request["language_type"] == null ? new string[0] : Request["language_type"].Split(','),
            language_testname = Request["language_testname"] == null ? new string[0] : Request["language_testname"].Split(','),
            language_score = Request["language_score"] == null ? new string[0] : Request["language_score"].Split(',');
            //language_level = Request["language_level"] == null ? new string[0] : Request["language_level"].Split(',');

            for (int i = 0; i < language_type.Length; ++i)
            {
                if (language_type[i] == "")
                    continue;
                ResumeLanguageCreate create = new ResumeLanguageCreate();
                create.SetArguments(
                    new ResumeLanguageCreateArguments()
                    {
                        ConversationLevel = Convert.ToByte(Request["language_level_"+(i+1)]),
                        GradeDesc = language_score[i],
                        LanguageName = language_type[i],
						UserNo = this.WebCookies.UserNo,
						CountryNo = (int)CountryCode,
						TestDesc = language_testname[i]
                    });
                create.ExecuteNonQuery();
            }

            // licence 등록
            string[]
            licence_year = Request["licence_year"] == null ? new string[0] : Request["licence_year"].Split(','),
            licence_title = Request["licence_title"] == null ? new string[0] : Request["licence_title"].Split(','),
            licence_institution = Request["licence_institution"] == null ? new string[0] : Request["licence_institution"].Split(',');

            for (int i = 0; i < licence_year.Length; ++i)
            {
                if (licence_title[i] == "")
                    continue;
                ResumeLicenseCreate create = new ResumeLicenseCreate();
                create.SetArguments(
                    new ResumeLicenseCreateArguments()
                    {
                        LicensedDate = Convert.ToDateTime(licence_year[i]),
                        LicenseName = licence_title[i],
                        Organization = licence_institution[i],
						UserNo = this.WebCookies.UserNo,
						CountryNo = (int)CountryCode
					});
                create.ExecuteNonQuery();
            }
        }
    }

	protected string GetDetailValue(string colName)
	{
		string retVal = string.Empty;
		switch (colName)
		{
			case "SSN1":
				if (ResumeDetail.ResumeDetailNo == 0) { retVal = ResumeDetail.SSN1.ToString(); } else { retVal = string.Empty; }
				break;
			case "SSN2":
				if (ResumeDetail.ResumeDetailNo == 0) { retVal = "*******"; } else { retVal = string.Empty; }
				break;
			case "KoreanAge":
				if (ResumeDetail.ResumeDetailNo == 0) { retVal = ResumeDetail.KoreanAge.ToString(); } else { retVal = string.Empty; }
				break;
			case "Age":
				if (ResumeDetail.ResumeDetailNo == 0) { retVal = ResumeDetail.Age.ToString(); } else { retVal = string.Empty; }
				break;
			case "ChinaExp":
				if (ResumeDetail.ResumeDetailNo == 0) { retVal = ResumeDetail.ChinaExp.ToString(); } else { retVal = string.Empty; }
				break;
			case "Military":
				if (ResumeDetail.ResumeDetailNo == 0) { retVal = ResumeDetail.Military.ToString(); } else { retVal = string.Empty; }
				break;
			case "IsCareer":
				if (ResumeDetail.ResumeDetailNo == 0) { retVal = ResumeDetail.IsCareer.ToString(); } else { retVal = string.Empty; }
				break;
			case "Address":
				if (ResumeDetail.ResumeDetailNo == 0) { retVal = ResumeDetail.Address.ToString(); } else { retVal = string.Empty; }
				break;
			case "Description":
				if (ResumeDetail.ResumeDetailNo == 0) { retVal = ResumeDetail.Description.ToString(); } else { retVal = string.Empty; }
				break;
			case "AboutMe":
				if (ResumeDetail.ResumeDetailNo == 0) { retVal = ResumeDetail.AboutMe.ToString(); } else { retVal = string.Empty; }
				break;
			default : 
				throw new Exception("invalid column name");
		}

		return retVal;
	}
}

using System;
using System.Data;
using System.Configuration;
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
using System.Collections.Generic;
using System.Web.Script.Serialization;
using Com.Framework.Data;
using Site.Web.Util;

/// <summary>
/// KR_Recruit_human_detail의 요약 설명입니다.
/// </summary>
namespace Site.Web.Page
{
	public class KR_Recruit_human_detail : SitePage
	{
		public ResumeEntity Resume = null;
		public UserEntity UserInfo = null;
		public TranslateHelper.ContryCode CountryCode = TranslateHelper.ContryCode.KR;
		public ResumeDetailEntity ResumeDetail { get; set; }
		public List<ResumeAcademicAbilityEntity> ResumeAcademicAbilities { get; set; }
		public List<ResumeCareerEntity> ResumeCareers { get; set; }
		public List<ResumeLanguageEntity> ResumeLanguages { get; set; }
		public List<ResumeLicenseEntity> ResumeLicenses { get; set; }
		public int UserNo { get; set; }

		public KR_Recruit_human_detail()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}

		protected override void OnLoad(EventArgs e)
		{
			/*
            if (!this.WebCookies.IsLogin)
			{
				Response.Clear();
				Response.Write("<script language='javascript'>;location.href='" + GetURL("/home") + "'; alert('" + Message.Msg(this.WebMaster.CountryCode, k_MsgType.User_Login) + "');</script>");
				Response.End();
			}
            */

			if (Request["userno"] == null || Request["userno"] == string.Empty)
			{
				Response.Write("<script type='text/javascript'>alert('userno가 들어오지 않았습니다..');location.href='" + GetURL("/recruit/human_search.aspx") + "';</script>");
				return;
			}

			UserNo = Convert.ToInt32(Request["userno"]);

			base.OnLoad(e);
			{
				UserGetInfoArguments infoArg = new UserGetInfoArguments();
				infoArg.UserNo = UserNo;
				UserGetInfo info = new UserGetInfo();
				info.SetArguments(infoArg);
				info.ExecuteNonQuery();
				UserInfo = info.GetOutput();
			}

			ResumeGetInfoArguments resumeGetInfoArguments = new ResumeGetInfoArguments();
			resumeGetInfoArguments.UserNo = UserNo;

			ResumeGetInfo resumeGetInfo = new ResumeGetInfo();
			resumeGetInfo.SetArguments(resumeGetInfoArguments);
			resumeGetInfo.ExecuteNonQuery();
			ResumeEntity resumeEntity = resumeGetInfo.GetOutput();

			// 기본정보 등록이 되어있지 않은 경우
			if (resumeEntity == null || resumeEntity.RegistryTime == DateTime.MinValue)
			{
				Response.Write("<script type='text/javascript'>alert('잘못된 접근 입니다. 기본 정보부터 확인해주세요.');location.href='" + GetURL("/user/human_detail_basic.aspx?userno=" + UserNo) + "';</script>");
				return;
			}

			LoadInfo();
		}

		protected void LoadInfo()
		{
			// detail 정보 로드
			ResumeDetailGetInfoArguments resumeDetailGetInfoArguments = new ResumeDetailGetInfoArguments();
			resumeDetailGetInfoArguments.UserNo = WebCookies.UserNo;
			resumeDetailGetInfoArguments.CountryNo = (int)CountryCode;
			ResumeDetailGetInfo resumeDetailGetInfo = new ResumeDetailGetInfo();
			resumeDetailGetInfo.SetArguments(resumeDetailGetInfoArguments);
			resumeDetailGetInfo.ExecuteNonQuery();
			ResumeDetail = resumeDetailGetInfo.GetOutput();

			// detailAcademy
			ResumeAcademicAbilities = SetList<ResumeAcademicAbilityEntity>(delegate(IArguments arg) { ResumeAcademicAbilityGetList getlist = new ResumeAcademicAbilityGetList(); getlist.SetArguments(arg); getlist.Execute(); return getlist.GetRecords(); });

			// detailCareer
			ResumeCareers = SetList<ResumeCareerEntity>(delegate(IArguments arg) { ResumeCareerGetList getlist = new ResumeCareerGetList(); getlist.SetArguments(arg); getlist.Execute(); return getlist.GetRecords(); });

			// detailLanguage
			ResumeLanguages = SetList<ResumeLanguageEntity>(delegate(IArguments arg) { ResumeLanguageGetList getlist = new ResumeLanguageGetList(); getlist.SetArguments(arg); getlist.Execute(); return getlist.GetRecords(); });

			// detailLicense
			ResumeLicenses = SetList<ResumeLicenseEntity>(delegate(IArguments arg) { ResumeLicenseGetList getlist = new ResumeLicenseGetList(); getlist.SetArguments(arg); getlist.Execute(); return getlist.GetRecords(); });

		}
		protected List<Entity> SetList<Entity>(Func<IArguments, List<Entity>> func) where Entity : DataEntity, new()
		{
			IArguments arg = null;
			Entity dummy = new Entity();
			if (dummy is ResumeAcademicAbilityEntity)
			{
				arg = new ResumeAcademicAbilityGetListArguments();
				((ResumeAcademicAbilityGetListArguments)arg).UserNo = UserNo;
				((ResumeAcademicAbilityGetListArguments)arg).CountryNo = (int)CountryCode;
			}
			else if (dummy is ResumeCareerEntity)
			{
				arg = new ResumeCareerGetListArguments();
				((ResumeCareerGetListArguments)arg).UserNo = UserNo;
				((ResumeCareerGetListArguments)arg).CountryNo = (int)CountryCode;
			}
			else if (dummy is ResumeLanguageEntity)
			{
				arg = new ResumeLanguageGetListArguments();
				((ResumeLanguageGetListArguments)arg).UserNo = UserNo;
				((ResumeLanguageGetListArguments)arg).CountryNo = (int)CountryCode;
			}
			else if (dummy is ResumeLicenseEntity)
			{
				arg = new ResumeLicenseGetListArguments();
				((ResumeLicenseGetListArguments)arg).UserNo = UserNo;
				((ResumeLicenseGetListArguments)arg).CountryNo = (int)CountryCode;
			}
			return func(arg);

		}

		public string GetDetailValue(string colName)
		{
			string retVal = string.Empty;
			switch (colName)
			{
				case "SSN1":
					if (ResumeDetail.ResumeDetailNo > 0) { retVal = ResumeDetail.SSN1.ToString(); } else { retVal = string.Empty; }
					break;
				case "SSN2":
					if (ResumeDetail.ResumeDetailNo > 0) { retVal = "*******"; } else { retVal = string.Empty; }
					break;
				case "KoreanAge":
					if (ResumeDetail.ResumeDetailNo > 0) { retVal = ResumeDetail.KoreanAge.ToString(); } else { retVal = string.Empty; }
					break;
				case "Age":
					if (ResumeDetail.ResumeDetailNo > 0) { retVal = ResumeDetail.Age.ToString(); } else { retVal = string.Empty; }
					break;
				case "ChinaExp":
					if (ResumeDetail.ResumeDetailNo > 0) { retVal = ResumeDetail.ChinaExp.ToString(); } else { retVal = string.Empty; }
					break;
				case "Military":
					if (ResumeDetail.ResumeDetailNo > 0) { retVal = ResumeDetail.Military.ToString(); } else { retVal = string.Empty; }
					break;
				case "IsCareer":
					if (ResumeDetail.ResumeDetailNo > 0) { retVal = ResumeDetail.IsCareer.ToString(); } else { retVal = string.Empty; }
					break;
				case "Address":
					if (ResumeDetail.ResumeDetailNo > 0) { retVal = ResumeDetail.Address.ToString(); } else { retVal = string.Empty; }
					break;
				case "Description":
					if (ResumeDetail.ResumeDetailNo > 0) { retVal = ResumeDetail.Description.ToString(); } else { retVal = string.Empty; }
					break;
				case "AboutMe":
					if (ResumeDetail.ResumeDetailNo > 0) { retVal = ResumeDetail.AboutMe.ToString(); } else { retVal = string.Empty; }
					break;
				case "LastestEducation":
					if (ResumeDetail.ResumeDetailNo > 0) { retVal = ResumeDetail.LastestEducation.ToString(); } else { retVal = string.Empty; }
					break;
				case "GraduationYear":
					if (ResumeDetail.ResumeDetailNo > 0) { retVal = ResumeDetail.GraduationYear.ToString(); } else { retVal = string.Empty; }
					break;
				case "MilitaryService":
					if (ResumeDetail.ResumeDetailNo > 0) { retVal = ResumeDetail.MilitaryService.ToString(); } else { retVal = string.Empty; }
					break;
				default:
					throw new Exception("invalid column name");
			}

			return retVal;
		}

		public string GetAcademicAbilityJson()
		{
			return GetJson(ResumeAcademicAbilities);
		}

		public string GetCareerJson()
		{
			return GetJson(ResumeCareers);
		}

		public string GetLanguageJson()
		{
			return GetJson(ResumeLanguages);
		}

		public string GetLicensesJson()
		{
			return GetJson(ResumeLicenses);
		}

		public string GetJson(object obj)
		{
			JavaScriptSerializer ser = new JavaScriptSerializer();
			string json = ser.Serialize(obj).Replace("\"\\/Date", "new Date").Replace("\\/\"", "");

			return json;
		}

		new public string GetText(string transCode)
		{
			return TranslateHelper.GetText(CountryCode, transCode);
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
	}
}
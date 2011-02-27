using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Caching;

namespace Com.Library.Translate
{
	public class TranslateHelper
	{
		public enum ContryCode
		{
			KR = 1,
			CN = 2
		}

		private TranslateHelper()
		{
		}

		static TranslateHelper()
		{
			Initialize();
		}

		private static bool isBeingInitialize = false;
		private static Dictionary<string, TranslateEntity> translateData = null;
		private static List<TranslateEntity> translateDataList = null;

		private static void Initialize()
		{
			if (!isBeingInitialize)
			{
				isBeingInitialize = true;

				List<TranslateEntity> initData = new List<TranslateEntity>();
				// 번역코드 추가
				initData.Add(new TranslateEntity("CN_WebMaster_CNMaster.master_4", "2011 중국취업박람회", "2011 중국취업박람회_c"));
				initData.Add(new TranslateEntity("CN_WebMaster_CNMaster.master_43", "아이디/비번찾기", "아이디/비번찾기_c"));
				initData.Add(new TranslateEntity("CN_WebMaster_CNMaster.master_45", "회원가입", "회원가입_c"));
				initData.Add(new TranslateEntity("CN_WebMaster_CNMaster.master_58", "관리자", "관리자_c"));
				initData.Add(new TranslateEntity("CN_WebMaster_CNMaster.master_58_1", "님", "님_c"));
				initData.Add(new TranslateEntity("CN_WebMaster_CNMaster.master_60", "관리하기", "관리하기_c"));
				initData.Add(new TranslateEntity("CN_WebMaster_CNMaster.master_74", "님", "님_c"));
				initData.Add(new TranslateEntity("CN_WebMaster_CNMaster.master_76", "개인정보관리", "개인정보관리_c"));
				initData.Add(new TranslateEntity("CN_WebMaster_CNMaster.master_78", "이력서관리", "이력서관리_c"));
				initData.Add(new TranslateEntity("CN_WebMaster_CNMaster.master_80", "지원관리", "지원관리_c"));
				initData.Add(new TranslateEntity("CN_WebMaster_CNMaster.master_80_1", "건", "건_c"));
				initData.Add(new TranslateEntity("CN_WebMaster_CNMaster.master_102", "님", "님_c"));
				initData.Add(new TranslateEntity("CN_WebMaster_CNMaster.master_104", "기업정보관리", "기업정보관리_c"));
				initData.Add(new TranslateEntity("CN_WebMaster_CNMaster.master_106", "채용관리", "채용관리_c"));
				initData.Add(new TranslateEntity("CN_WebMaster_CNMaster.master_106_1", "건", "건_c"));
				initData.Add(new TranslateEntity("CN_WebMaster_OperationMaster.master_15", "공지사항", "공지사항_c"));
				initData.Add(new TranslateEntity("CN_WebMaster_OperationMaster.master_16", "질문답변", "질문답변_c"));
				initData.Add(new TranslateEntity("CN_WebMaster_OperationMaster.master_17", "자유게시판", "자유게시판_c"));
				initData.Add(new TranslateEntity("CN_WebMaster_ParticipationMaster.master_14", "채용면접관", "채용면접관_c"));
				initData.Add(new TranslateEntity("CN_WebMaster_ParticipationMaster.master_15", "취업정보관", "취업정보관_c"));
				initData.Add(new TranslateEntity("CN_WebMaster_ParticipationMaster.master_16", "취업설명회", "취업설명회_c"));
				initData.Add(new TranslateEntity("CN_WebMaster_RecruitMaster.master_13", "중국채용정보", "중국채용정보_c"));
				initData.Add(new TranslateEntity("CN_WebMaster_RecruitMaster.master_14", "직종별", "직종별_c"));
				initData.Add(new TranslateEntity("CN_WebMaster_RecruitMaster.master_15", "지역별", "지역별_c"));
				initData.Add(new TranslateEntity("CN_WebMaster_UserMaster.master_13", "중국인재정보", "중국인재정보_c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_19", "로고이미지", "企业标识"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_24", "로고사이즈는 325*115px이며,JPG,GIF,PNG만 가능합니다.", "标识大小为325*115p， 只能为JPG,GIF,PNG的形式"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_30", "기업명", "企业名"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_34", "국문", "韩文"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_37", "사업자등록증(영업집조)에 등록된 정규적인 회사명을 입력하는것을 추천하며,<br_>국문,중문,영문 중 반드시 하나 이상 기입하셔야 합니다.", "사업자등록증(영업집조)에 등록된 정규적인 회사명을 입력하는것을 추천하며,<br_>국문,중문,영문 중 반드시 하나 이상 기입하셔야 합니다._c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_41", "중문", "中文"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_45", "영문", "英文"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_52", "사업자등록번호", "营业执照号码"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_64", "사업자등록첨부", "사업자등록첨부_c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_74", "아이디", "用户名"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_86", "비밀번호", "密码"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_91", "영문,숫자 또는 조합 4~12자리", "英文、数字或者英文数字组合4~12位"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_97", "비밀번호확인", "确认密码"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_102", "비밀번호를 다시 한번 입력해 주세요", "请再次填写密码"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_108", "이메일", "电子邮件"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_114", "가장 자주 쓰는 이메일 하나만 입력하세요", "请填写经常使用的电子邮件"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_120", "업종", "业种"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_126", "업종선택", "选择业种"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_143", "대표자명", "法定代表人"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_153", "기업유형", "企业类型"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_161", "외자", "外资"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_167", "독자", "独资 "));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_173", "합자", "合资"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_179", "기타", "其他"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_186", "설립일", "成立日期"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_191", "년", "年"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_number_only", "숫자만 입력", "只能填写数字"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_197", "사원수", "员工数"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_202", "명", "名"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_210", "자본금", "注册资本金"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_currencyUnit", "화폐단위", "货币单位"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_currencyUnit_krw", "원화", "원화_c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_currencyUnit_rmb", "RMB", "RMB"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_currencyUnit_usd", "달러", "달러_c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_229", "매출액", "매출액_c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_248", "주요사업 내용", "主要业务内容"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_248_1", "기업소개", "企业简介"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_255", "입력 예)재중 한인업체 및 개인의 구인_구직서비스,헤드헌팅,채용대행.", "填入内容 例如）在华韩国企业及个人求人求职服务、猎头公司代理招聘"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_261", "채용담당자", "招聘负责人"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_271", "회사 전화번호", "企业电话"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_281", "회사 팩스번호", "企业传真"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_291", "기업본사주소", "企业总部住址"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_301", "홈페이지", "网站                        "));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_306", "예)http:__www.chinajobgo.com", "例如：http:__www.chinajobgo.com"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_312", "상기 기업소개 내용이 틀림없는 사실임을 확인합니다.", "确认以上企业信息属实"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_emailFormatInvalid", "이메일 형식이 아닙니다.", "이메일 형식이 아닙니다._c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_emailExist", "존재하는 이메일주소입니다.", "존재하는 이메일주소입니다._c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_emailValid", "등록가능한 이메일주소입니다.", "등록가능한 이메일주소입니다._c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_companyNoEmpty", "사업자등록번호를 입력하세요", "사업자등록번호를 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_companyNoExist", "존재하는 사업자등록번호입니다.", "존재하는 사업자등록번호입니다._c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_companyNoValid", "등록가능한 사업자등록번호입니다.", "등록가능한 사업자등록번호입니다._c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_companyIDFormatInvalid", "영문,숫자 또는 조합4~12자리,특수문자 불가", "영문,숫자 또는 조합4~12자리,특수문자 불가_c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_companyIDHasInvalidChar", "아이디에 사용할수 없는 문자가 있습니다.", "아이디에 사용할수 없는 문자가 있습니다._c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_companyIDExist", "사용중인 아이디입니다.", "사용중인 아이디입니다._c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_companyIDValid", "등록가능한 아이디입니다.", "등록가능한 아이디입니다._c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_companyNoMustCheckDupl", "사업자등록번호 중복체크를 해주세요", "사업자등록번호 중복체크를 해주세요_c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_companyIDMustCheckDupl", "아이디 중복 체크를 해주세요", "아이디 중복 체크를 해주세요_c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_emailMustCheckDupe", "이메일 중복 체크를 해주세요", "이메일 중복 체크를 해주세요_c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_companyNameEmpty", "기업명은 1개이상 입력하셔야합니다.", "기업명은 1개이상 입력하셔야합니다._c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_idEmpty", "아이디를 입력하세요", "아이디를 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_idLengthMustOver4", "아이디는 4자 이상입니다.", "아이디는 4자 이상입니다._c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_passwordEmpty", "비밀번호를 입력하세요", "비밀번호를 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_passwordCheckNotMatch", "비밀번호확인이 틀립니다.", "비밀번호확인이 틀립니다._c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_emailEmpty", "이메일을 입력하세요", "이메일을 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_jobTypeEmpty", "업종을 선택하세요", "업종을 선택하세요_c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_etcTypeEmpty", "기타 업종을 입력하세요", "기타 업종을 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_companyTypeEmpty", "기업유형을 선택하세요", "기업유형을 선택하세요_c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_buildDateEmpty", "설립일을 입력하세요", "설립일을 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_representativeEmpty", "대표자명을 입력하세요", "대표자명을 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_descriptionEmpty", "주요사업 내용을입력하세요", "주요사업 내용을입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_managerEmpty", "채용담당자를 입력하세요", "채용담당자를 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_phoneEmpty", "회사 전화번호를 입력하세요", "회사 전화번호를 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_faxEmpty", "팩스번호를 입력하세요", "팩스번호를 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_addressEmpty", "본사주소를 입력하세요", "본사주소를 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Company_company_join.aspx_agreeNotChecked", "사실확인을 하셔야합니다.", "사실확인을 하셔야합니다._c"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_19", "기업코드", "企业号码"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_25", "로고이미지", "企业标识"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_33", "로고사이즈는 325*115px이며,JPG,GIF,PNG만 가능합니다.", "标识大小为325*115p， 只能为JPG,GIF,PNG的形式"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_39", "기업명", "企业名"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_43", "국문", "韩文"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_46", "사업자등록증(영업집조)에 등록된 정규적인 회사명을 입력하는것을 추천하며,<br_>국문,중문,영문 중 반드시 하나 이상 기입하셔야 합니다.", "사업자등록증(영업집조)에 등록된 정규적인 회사명을 입력하는것을 추천하며,<br_>국문,중문,영문 중 반드시 하나 이상 기입하셔야 합니다."));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_50", "중문", "中文"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_54", "영문", "英文"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_61", "사업자등록번호", "营业执照号码"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_67", "아이디", "用户名"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_73", "비밀번호", "密码"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_78", "영문,숫자 또는 조합 4~12자리", "英文、数字或者英文数字组合4~12位"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_84", "비밀번호확인", "确认密码"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_89", "비밀번호를 다시 한번 입력해 주세요", "请再次填写密码"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_95", "이메일", "电子邮件"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_101", "가장 자주 쓰는 이메일 하나만 입력하세요", "请填写经常使用的电子邮件"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_107", "업종", "业种"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_113", "업종선택", "选择业种"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_130", "대표자명", "法定代表人"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_140", "기업유형", "企业类型"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_148", "외자", "外资"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_154", "독자", "独资 "));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_160", "합자", "合资"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_166", "기타", "其他"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_173", "설립일", "成立日期"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_178", "년", "年"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_number_only", "숫자만 입력", "只能填写数字"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_184", "사원수", "员工数"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_189", "명", "名"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_197", "자본금", "注册资本金"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_currencyUnit", "화폐단위", "货币单位"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_currencyUnit_krw", "원화", "원화_c"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_currencyUnit_rmb", "RMB", "RMB"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_currencyUnit_usd", "달러", "달러_c"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_216", "매출액", "매출액"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_235", "주요사업 내용", "主要业务内容"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_235_1", "기업소개", "企业简介"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_242", "입력 예)재중 한인업´ 및 개인의 구인_구직서비스,헤드헌팅,채용대행.", "填入内容 例如）在华韩国企业及个人求人求职服务、猎头公司代理招聘"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_248", "채용담당자", "招聘负责人"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_258", "회사 전화번호", "企业电话"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_268", "회사 팩스번호", "企业传真"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_278", "기업본사주소", "企业总部住址"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_288", "홈페이지", "网站                        "));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_293", "예)http://www.chinajobgo.com", "例如：http://www.chinajobgo.com"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_299", "상기 기업소개 내용이 틀림없는 사실임을 확인합니다.", "确认以上企业信息属实"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_emailFormatInvalid", "이메일 형식이 아닙니다.", "이메일 형식이 아닙니다._c"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_emailExist", "존재하는 이메일주소입니다.", "존재하는 이메일주소입니다._c"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_emailValid", "등록가능한 이메일주소입니다.", "등록가능한 이메일주소입니다._c"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_companyNoEmpty", "사업자등록번호를 입력하세요", "사업자등록번호를 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_companyNoExist", "존재하는 사업자등록번호입니다.", "존재하는 사업자등록번호입니다._c"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_companyNoValid", "등록가능한 사업자등록번호입니다.", "등록가능한 사업자등록번호입니다._c"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_companyIDFormatInvalid", "영문,숫자 또는 조합4~12자리,특수문자 불가", "영문,숫자 또는 조합4~12자리,특수문자 불가_c"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_companyIDHasInvalidChar", "아이디에 사용할수 없는 문자가 있습니다.", "아이디에 사용할수 없는 문자가 있습니다._c"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_companyIDExist", "사용중인 아이디입니다.", "사용중인 아이디입니다._c"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_companyIDValid", "등록가능한 아이디입니다.", "등록가능한 아이디입니다._c"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_emailMustCheckDupe", "이메일 중복 체크를 해주세요", "이메일 중복 체크를 해주세요_c"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_companyNameEmpty", "기업명은 1개이상 입력하셔야합니다.", "기업명은 1개이상 입력하셔야합니다._c"));
				//initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_companyNoEmpty", "사업자등록번호를 입력하셔야합니다.", "사업자등록번호를 입력하셔야합니다._c"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_passwordCheckNotMatch", "비밀번호확인이 틀립니다.", "비밀번호확인이 틀립니다._c"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_emailEmpty", "이메일을 입력하세요", "이메일을 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_jobTypeEmpty", "업종을 선택하세요", "업종을 선택하세요_c"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_etcTypeEmpty", "기타 업종을 입력하세요", "기타 업종을 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_companyTypeEmpty", "기업유형을 선택하세요", "기업유형을 선택하세요_c"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_representativeEmpty", "대표자명을 입력하세요", "대표자명을 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_descriptionEmpty", "주요사업 내용을입력하세요", "주요사업 내용을입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_managerEmpty", "채용담당자를 입력하세요", "채용담당자를 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_phoneEmpty", "회사 전화번호를 입력하세요", "회사 전화번호를 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_faxEmpty", "팩스번호를 입력하세요", "팩스번호를 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_addressEmpty", "본사주소를 입력하세요", "본사주소를 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Company_company_modify.aspx_agreeNotChecked", "사실확인을 하셔야합니다.", "사실확인을 하셔야합니다._c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_21", "참가여부", "참가여부_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_30", "참가", "참가_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_36", "불참", "불참_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_44", "참가정보", "참가정보_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_52", "참가인원", "참가인원_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_66", "면접관명", "면접관명_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_75", "구인직종", "구인직종_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_102", "경력", "경력_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_111", "무관", "무관_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_year", "년", "년_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_over10", "10년 이상", "10년 이상_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_159", "인원", "인원_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_166", "명", "명_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_174", "성별", "성별_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_183", "무관", "무관_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_190", "남", "남_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_197", "여", "여_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_205", "연령", "연령_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_214", "무관", "무관_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_220", "제한", "제한_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_224", "선택하세요", "선택하세요_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_231", "직접입력", "직접입력_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_243", "학력", "학력_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_252", "무관", "무관_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_259", "고졸이상", "고졸이상_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_265", "전문대졸이상", "전문대졸이상_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_272", "대졸이상", "대졸이상_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_279", "대학원이상", "대학원이상_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_287", "전공", "전공_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_296", "무관", "무관_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_302", "인문계열", "인문계열_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_309", "법계열", "법계열_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_316", "이공계열", "이공계열_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_323", "예술계열", "예술계열_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_329", "직접입력", "직접입력_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_340", "중국어", "중국어_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_349", "무관", "무관_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_356", "기본회화가능", "기본회화가능_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_363", "업무상 소통 가능", "업무상 소통 가능_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_370", "현지인 수준", "현지인 수준_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_377", "영어", "영어_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_386", "무관", "무관_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_393", "기본회화가능", "기본회화가능_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_400", "업무상 소통 가능", "업무상 소통 가능_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_407", "현지인 수준", "현지인 수준_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_414", "일본어", "일본어_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_423", "무관", "무관_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_430", "기본회화가능", "기본회화가능_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_437", "업무상 소통 가능", "업무상 소통 가능_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_444", "현지인 수준", "현지인 수준_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_451", "기타언어", "기타언어_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_457", "언어", "언어_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_467", "기본회화가능", "기본회화가능_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_474", "업무상 소통 가능", "업무상 소통 가능_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_481", "현지인 수준", "현지인 수준_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_488", "주요업무", "주요업무_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_502", "근무지역", "근무지역_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_520", "상세주소", "상세주소_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_531", "채용예정시기", "채용예정시기_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_540", "년 월 일", "년 월 일_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_565", "기타자격요건", "기타자격요건_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_577", "급여", "급여_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_596", "계약기간", "계약기간_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_605", "협의", "협의_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_612", "년", "년_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_653", "근무시간", "근무시간_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_662", "해당국가 노동법률 의거", "해당국가 노동법률 의거_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_669", "직접입력", "직접입력_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_680", "후생복리", "후생복리_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_686", "보험", "보험_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_692", "제공", "제공_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_699", "미제공", "미제공_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_706", "협의", "협의_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_713", "기타", "기타_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_724", "숙식", "숙식_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_744", "보조", "보조_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_768", "퇴직금", "퇴직금_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_755", "유", "유_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_782", "무", "무_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_795", "회사내규", "회사내규_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_813", "휴가", "휴가_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_869", "상기와 같이 구인요청 및 「2011 중국취업박람회」 참가를 신청합니다.", "상기와 같이 구인요청 및 「2011 중국취업박람회」 참가를 신청합니다._c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_1135", "참가여부를 선택해 주세요.", "참가여부를 선택해 주세요._c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_1136", "구인Á종을 선택해 주세요.", "구인직종을  택해 주세요._c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_1137", "인원을 선택해 주세요.", "인원을 선택해 주세요._c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_1138", "성별을 선택해 주세요.", "성별을 선택해 주세요._c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_1139", "연령을 입력해 주세요.", "연령을 입력해 주세요._c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_1141", "주요업무를 입력해 주세요.", "주요업무를 입력해 주세요._c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_1142", "근무지역을 선택해 주세요.", "근무지역을 선택해 주세요._c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_1143", "계약기간을 입력해주세요.", "계약기간을 입력해주세요._c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist.aspx_1144", "근무시간을 입력해주세요.", "근무시간을 입력해주세요._c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist_list.aspx_17", "채용제목", "채용제목_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist_list.aspx_18", "디자인 전략팀 매니저", "디자인 전략팀 매니저_c"));
				initData.Add(new TranslateEntity("CN_Company_recruit_regist_list.aspx_78", "정말로 삭제하시겠습니까?", "정말로 삭제하시겠습니까?_c"));
				initData.Add(new TranslateEntity("CN_Login_find_id.aspx_17", "아이디", "아이디_c"));
				initData.Add(new TranslateEntity("CN_Login_find_id.aspx_20", "비밀번호", "비밀번호_c"));
				initData.Add(new TranslateEntity("CN_Login_find_id.aspx_27", "회원형태", "회원형태_c"));
				initData.Add(new TranslateEntity("CN_Login_find_id.aspx_30", "기업", "기업_c"));
				initData.Add(new TranslateEntity("CN_Login_find_id.aspx_32", "개인", "개인_c"));
				initData.Add(new TranslateEntity("CN_Login_find_id.aspx_36", "이메일", "이메일_c"));
				initData.Add(new TranslateEntity("CN_Login_find_id.aspx_42", "회원가입시,기입한 이메일을 입력하세요", "회원가입시,기입한 이메일을 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Login_find_id.aspx_65", "회원형태를 선택하세요", "회원형태를 선택하세요_c"));
				initData.Add(new TranslateEntity("CN_Login_find_id.aspx_72", "이메일을 입력하세요", "이메일을 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Login_find_id.aspx_81", "발송하였습니다.", "발송하였습니다._c"));
				initData.Add(new TranslateEntity("CN_Login_find_id.aspx_85", "잘못된 정보를 입력하였습니다.", "잘못된 정보를 입력하였습니다._c"));
				initData.Add(new TranslateEntity("CN_Login_find_pw.aspx_17", "아이디", "아이디_c"));
				initData.Add(new TranslateEntity("CN_Login_find_pw.aspx_20", "비밀번호", "비밀번호_c"));
				initData.Add(new TranslateEntity("CN_Login_find_pw.aspx_27", "회원형태", "회원형태_c"));
				initData.Add(new TranslateEntity("CN_Login_find_pw.aspx_30", "기업", "기업_c"));
				initData.Add(new TranslateEntity("CN_Login_find_pw.aspx_32", "개인", "개인_c"));
				initData.Add(new TranslateEntity("CN_Login_find_pw.aspx_36", "아이디", "아이디_c"));
				initData.Add(new TranslateEntity("CN_Login_find_pw.aspx_41", "이메일", "이메일_c"));
				initData.Add(new TranslateEntity("CN_Login_find_pw.aspx_46", "입력하신 이메일로 비밀번호를 발송합니다", "입력하신 이메일로 비밀번호를 발송합니다_c"));
				initData.Add(new TranslateEntity("CN_Login_find_pw.aspx_70", "회원형태를 선택하세요", "회원형태를 선택하세요_c"));
				initData.Add(new TranslateEntity("CN_Login_find_pw.aspx_77", "아이디를 입력하세요", "아이디를 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Login_find_pw.aspx_83", "이메일을 입력하세요", "이메일을 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Login_find_pw.aspx_92", "발송하였습니다.", "발송하였습니다._c"));
				initData.Add(new TranslateEntity("CN_Login_find_pw.aspx_96", "잘못된 정보를 입력하였습니다.", "잘못된 정보를 입력하였습니다._c"));
				initData.Add(new TranslateEntity("CN_Login_login.aspx_12", "기업회원", "기업회원_c"));
				initData.Add(new TranslateEntity("CN_Login_login.aspx_15", "개인회원", "개인회원_c"));
				initData.Add(new TranslateEntity("CN_Login_login.aspx_22", "아이디", "아이디_c"));
				initData.Add(new TranslateEntity("CN_Login_login.aspx_27", "비밀번호", "비밀번호_c"));
				initData.Add(new TranslateEntity("CN_Login_login.aspx_32", "아이디찾기", "아이디찾기_c"));
				initData.Add(new TranslateEntity("CN_Login_login.aspx_33", "비밀번호찾기", "비밀번호찾기_c"));
				initData.Add(new TranslateEntity("CN_Login_login.aspx_50", "아이디를 입력하세요", "아이디를 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Login_login.aspx_55", "비밀번호를 입력하세요", "비밀번호를 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Login_login_user.aspx_12", "기업회원", "기업회원_c"));
				initData.Add(new TranslateEntity("CN_Login_login_user.aspx_15", "개인회원", "개인회원_c"));
				initData.Add(new TranslateEntity("CN_Login_login_user.aspx_22", "아이디", "아이디_c"));
				initData.Add(new TranslateEntity("CN_Login_login_user.aspx_27", "비밀번호", "비밀번호_c"));
				initData.Add(new TranslateEntity("CN_Login_login_user.aspx_32", "아이디찾기", "아이디찾기_c"));
				initData.Add(new TranslateEntity("CN_Login_login_user.aspx_33", "비밀번호찾기", "비밀번호찾기_c"));
				initData.Add(new TranslateEntity("CN_Login_login_user.aspx_50", "아이디를 입력하세요", "아이디를 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Login_login_user.aspx_55", "비밀번호를 입력하세요", "비밀번호를 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Operation_freeboard_detail.aspx_30", "정말로 삭제하시겠습니까?", "정말로 삭제하시겠습니까?_c"));
				initData.Add(new TranslateEntity("CN_Operation_freeboard_list.aspx_12", "분류", "분류_c"));
				initData.Add(new TranslateEntity("CN_Operation_freeboard_list.aspx_13", "제목", "제목_c"));
				initData.Add(new TranslateEntity("CN_Operation_freeboard_list.aspx_14", "작성자", "작성자_c"));
				initData.Add(new TranslateEntity("CN_Operation_freeboard_list.aspx_15", "작성일", "작성일_c"));
				initData.Add(new TranslateEntity("CN_Operation_freeboard_modify.aspx_14", "분류", "분류_c"));
				initData.Add(new TranslateEntity("CN_Operation_freeboard_modify.aspx_22", "제목", "제목_c"));
				initData.Add(new TranslateEntity("CN_Operation_freeboard_modify.aspx_33", "글꼴", "글꼴_c"));
				initData.Add(new TranslateEntity("CN_Operation_freeboard_modify.aspx_42", "크기", "크기_c"));
				initData.Add(new TranslateEntity("CN_Operation_freeboard_modify.aspx_114", "제목을 입력하세요", "제목을 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Operation_freeboard_modify.aspx_123", "내용을 입력하세요", "내용을 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Operation_freeboard_write.aspx_14", "분류", "분류_c"));
				initData.Add(new TranslateEntity("CN_Operation_freeboard_write.aspx_22", "제목", "제목_c"));
				initData.Add(new TranslateEntity("CN_Operation_freeboard_write.aspx_33", "글꼴", "글꼴_c"));
				initData.Add(new TranslateEntity("CN_Operation_freeboard_write.aspx_42", "크기", "크기_c"));
				initData.Add(new TranslateEntity("CN_Operation_freeboard_write.aspx_114", "제목을 입력하세요", "제목을 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Operation_freeboard_write.aspx_123", "내용을 입력하세요", "내용을 입력하세요_c"));
				initData.Add(new TranslateEntity("CN_Operation_notice_list.aspx_13", "분류", "분류_c"));
				initData.Add(new TranslateEntity("CN_Operation_notice_list.aspx_14", "제목", "제목_c"));
				initData.Add(new TranslateEntity("CN_Operation_notice_list.aspx_15", "작성자", "작성자_c"));
				initData.Add(new TranslateEntity("CN_Operation_notice_list.aspx_16", "작성일", "작성일_c"));
				initData.Add(new TranslateEntity("CN_Operation_qna_list.aspx_12", "분류", "분류_c"));
				initData.Add(new TranslateEntity("CN_Operation_qna_list.aspx_13", "제목", "제목_c"));
				initData.Add(new TranslateEntity("CN_Operation_qna_list.aspx_14", "작성자", "작성자_c"));
				initData.Add(new TranslateEntity("CN_Operation_qna_list.aspx_15", "작성일", "작성일_c"));
				initData.Add(new TranslateEntity("CN_Popup_fileuploader.aspx_26", "파일첨부", "파일첨부_c"));
				initData.Add(new TranslateEntity("CN_Popup_fileuploader.aspx_43", "파일첨부는 JPG,GIF,PNG만 가능합니다", "파일첨부는 JPG,GIF,PNG만 가능합니다_c"));
				initData.Add(new TranslateEntity("CN_Popup_fileuploader.aspx_55", "파일을 첨부하세요", "파일을 첨부하세요_c"));
				initData.Add(new TranslateEntity("CN_Popup_fileuploader.aspx_70", "파일을 첨부하세요", "파일을 첨부하세요_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_48", "기업명", "企业名"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_56", "기업코드", "企业号码"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_60", "업종", "业种"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_64", "대표자", "法定代表人"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_66", "기업유형", "企业类型"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_70", "홈페이지", "网站"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_74", "설립년도", "설립년도_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_76", "사원수", "员工数"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_80", "자본금", "注册资本金"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_82", "매출액", "매출액_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_86", "주소", "주소_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_102", "면접관", "면접관_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_106", "전화", "전화_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_114", "이메일", "이메일_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_118", "팩스", "팩스_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_144", "구인직종", "구인직종_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_151", "인원", "인원_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_155", "연령", "연령_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_159", "학력", "학력_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_163", "중국어", "중국어_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_167", "일본어", "일본어_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_171", "근무지역", "근무지역_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_178", "급여", "급여_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_186", "주요업무", "주요업무_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_190", "성별", "성별_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_194", "경력", "경력_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_198", "전공", "전공_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_202", "영어", "영어_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_206", "기타", "기타_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_210", "계약기간", "계약기간_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_214", "근무시간", "근무시간_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_224", "후생복리", "후생복리_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_226", "보험", "보험_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_227", "숙식", "숙식_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_228", "퇴직금", "퇴직금_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_229", "휴가", "휴가_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_230", "기타", "기타_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_234", "기타자격요건", "기타자격요건_c"));
				initData.Add(new TranslateEntity("CN_Recruit_recruit_detail.aspx_244", "상기기업의 구인정보에 틀림없음을 확인합니다.", "상기기업의 구인정보에 틀림없음을 확인합니다._c"));

				// 딕셔너리에 저장
				translateData = new Dictionary<string, TranslateEntity>();
				translateDataList = new List<TranslateEntity>();

				foreach (TranslateEntity entity in initData)
				{
					if (!translateData.Keys.Contains(entity.TransCode))
					{
						translateData.Add(entity.TransCode, entity);
						translateDataList.Add(entity);
					}
					else
					{
						throw new Exception(string.Format("TransCode is duplicate. transCode is {0}", entity.TransCode));
					}
				}

				isBeingInitialize = false;
			}
		}

		public static string GetText(ContryCode contryCode, string transCode)
		{
			TranslateEntity entity = null;
			
			if (!translateData.Keys.Contains(transCode))
			{
				throw new Exception(string.Format("transCode not found. code is {0}", transCode));
			}

			entity = translateData[transCode];

			string retVal = string.Empty;

			switch (contryCode)
			{
				case ContryCode.KR :
					retVal = entity.KrText;
					break;
				case ContryCode.CN :
					retVal = entity.CnText;
					break;
				default :
					throw new Exception("contryCode not found");
			}

			return retVal;
		}

		public static List<TranslateEntity> GetList()
		{
			return translateDataList;
		}

	}
}

 
 
(function($)
{
	$.translateHelper = {};
	$.translateHelper.countryCode_kr = 1;
	$.translateHelper.countryCode_cn = 2;
	$.translateHelper.countryCode_en = 3;
	$.translateHelper.countryCode = 2;
	$.translateHelper.translateData = new Array();
	$.translateHelper.translateData.push({"transCode":"CN_WebMaster_CNMaster.master_4","krText":"2011 중국취업박람회","cnText":"2011 韩国人才中国招聘会","enText":""});
	$.translateHelper.translateData.push({"transCode":"CN_WebMaster_CNMaster.master_43","krText":"아이디/비번찾기","cnText":"用户名/密码取回","enText":""});
	$.translateHelper.translateData.push({"transCode":"CN_WebMaster_CNMaster.master_45","krText":"회원가입","cnText":"加入会员","enText":""});
	$.translateHelper.translateData.push({"transCode":"CN_WebMaster_CNMaster.master_58","krText":"관리자","cnText":"管理员","enText":""});
	$.translateHelper.translateData.push({"transCode":"CN_WebMaster_CNMaster.master_58_1","krText":"님","cnText":"先生","enText":""});
	$.translateHelper.translateData.push({"transCode":"CN_WebMaster_CNMaster.master_60","krText":"관리하기","cnText":"管理","enText":""});
	$.translateHelper.translateData.push({"transCode":"CN_WebMaster_CNMaster.master_74","krText":"님","cnText":"先生","enText":""});
	$.translateHelper.translateData.push({"transCode":"CN_WebMaster_CNMaster.master_76","krText":"개인정보관리","cnText":"个人资料管理","enText":""});
	$.translateHelper.translateData.push({"transCode":"CN_WebMaster_CNMaster.master_78","krText":"이력서관리","cnText":"简历管理","enText":""});
	$.translateHelper.translateData.push({"transCode":"CN_WebMaster_CNMaster.master_80","krText":"지원관리","cnText":"报名管理","enText":""});
	$.translateHelper.translateData.push({"transCode":"CN_WebMaster_CNMaster.master_80_1","krText":"건","cnText":"件","enText":""});
	$.translateHelper.translateData.push({"transCode":"CN_WebMaster_CNMaster.master_102","krText":"님","cnText":"先生","enText":""});
	$.translateHelper.translateData.push({"transCode":"CN_WebMaster_CNMaster.master_104","krText":"기업정보관리","cnText":"企业信息管理","enText":""});
	$.translateHelper.translateData.push({"transCode":"CN_WebMaster_CNMaster.master_106","krText":"채용관리","cnText":"招聘管理","enText":""});
	$.translateHelper.translateData.push({"transCode":"CN_WebMaster_CNMaster.master_106_1","krText":"건","cnText":"件","enText":""});
	$.translateHelper.translateData.push({"transCode":"CN_WebMaster_OperationMaster.master_15","krText":"공지사항","cnText":"公告事项","enText":""});
	$.translateHelper.translateData.push({"transCode":"CN_WebMaster_OperationMaster.master_16","krText":"질문답변","cnText":"答疑","enText":""});
	$.translateHelper.translateData.push({"transCode":"CN_WebMaster_OperationMaster.master_17","krText":"자유게시판","cnText":"自由讨论区","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_WebMaster_ParticipationMaster.master_14","krText":"채용면접관","cnText":"招聘面试管理","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_WebMaster_ParticipationMaster.master_15","krText":"취업정보관","cnText":"就业信息管理","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_WebMaster_ParticipationMaster.master_16","krText":"취업설명회","cnText":"就业说明会","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_WebMaster_RecruitMaster.master_13","krText":"중국채용정보","cnText":"中国就业信息","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_WebMaster_RecruitMaster.master_14","krText":"직종별","cnText":"行业","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_WebMaster_RecruitMaster.master_15","krText":"지역별","cnText":"区域","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_WebMaster_UserMaster.master_13","krText":"중국인재정보","cnText":"中国人才信息","enText":""});
 	
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_19","krText":"로고이미지","cnText":"企业标识","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_24","krText":"로고사이즈는 325*115px이며,JPG,GIF,PNG만 가능합니다.","cnText":"标识大小为325*115p， 只能为JPG,GIF,PNG的形式","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_30","krText":"기업명","cnText":"企业名","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_34","krText":"국문","cnText":"韩文","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_37","krText":"사업자등록증(영업집조)에 등록된 정규적인 회사명을 입력하는것을 추천하며,<br_>국문,중문,영문 중 반드시 하나 이상 기입하셔야 합니다.","cnText":"推荐输入企业注册证（营业执照）上的正式公司名称，必须填写韩语，中文，英文中的一种以上","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_41","krText":"중문","cnText":"中文","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_45","krText":"영문","cnText":"英文","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_52","krText":"사업자등록번호","cnText":"营业执照号码","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_64","krText":"사업자등록첨부","cnText":"企业营业执照另附","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_74","krText":"아이디","cnText":"用户名","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_86","krText":"비밀번호","cnText":"密码","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_91","krText":"영문,숫자 또는 조합 4~12자리","cnText":"英文、数字或者英文数字组合4~12位","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_97","krText":"비밀번호확인","cnText":"确认密码","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_102","krText":"비밀번호를 다시 한번 입력해 주세요","cnText":"请再次填写密码","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_108","krText":"이메일","cnText":"电子邮件","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_114","krText":"가장 자주 쓰는 이메일 하나만 입력하세요","cnText":"请填写经常使用的电子邮件","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_120","krText":"업종","cnText":"业种","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_126","krText":"업종선택","cnText":"选择业种","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_143","krText":"대표자명","cnText":"法定代表人","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_153","krText":"기업유형","cnText":"企业类型","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_161","krText":"외자","cnText":"外资","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_167","krText":"독자","cnText":"独资 ","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_173","krText":"합자","cnText":"合资","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_179","krText":"기타","cnText":"其他","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_186","krText":"설립일","cnText":"成立日期","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_191","krText":"년","cnText":"年","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_number_only","krText":"숫자만 입력","cnText":"只能填写数字","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_197","krText":"사원수","cnText":"员工数","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_202","krText":"명","cnText":"名","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_210","krText":"자본금","cnText":"注册资本金","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_currencyUnit","krText":"화폐단위","cnText":"货币单位","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_currencyUnit_krw","krText":"원화","cnText":"韩元","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_currencyUnit_rmb","krText":"RMB","cnText":"人民币","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_currencyUnit_usd","krText":"달러","cnText":"美元","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_229","krText":"매출액","cnText":"销售额","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_248","krText":"주요사업 내용","cnText":"主要业务内容","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_248_1","krText":"기업소개","cnText":"企业简介","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_255","krText":"입력 예)재중 한인업체 및 개인의 구인_구직서비스,헤드헌팅,채용대행.","cnText":"填入内容 例如）在华韩国企业及个人求人求职服务、猎头公司代理招聘","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_261","krText":"채용담당자","cnText":"招聘负责人","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_271","krText":"회사 전화번호","cnText":"企业电话","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_281","krText":"회사 팩스번호","cnText":"企业传真","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_291","krText":"기업본사주소","cnText":"企业总部住址","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_301","krText":"홈페이지","cnText":"网站","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_306","krText":"예)http:__www.chinajobgo.com","cnText":"例如：http:__www.chinajobgo.com","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_312","krText":"상기 기업소개 내용이 틀림없는 사실임을 확인합니다.","cnText":"确认以上企业信息属实","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_emailFormatInvalid","krText":"이메일 형식이 아닙니다.","cnText":"邮件形式不正确","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_emailExist","krText":"존재하는 이메일주소입니다.","cnText":"本邮箱地址已存在","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_emailValid","krText":"등록가능한 이메일주소입니다.","cnText":"本邮箱地址可用","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_companyNoEmpty","krText":"사업자등록번호를 입력하세요","cnText":"请输入企业登录账号","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_companyNoExist","krText":"존재하는 사업자등록번호입니다.","cnText":"本企业登录账号已存在","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_companyNoValid","krText":"등록가능한 사업자등록번호입니다.","cnText":"本企业登录账号可用","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_companyIDFormatInvalid","krText":"영문,숫자 또는 조합4~12자리,특수문자 불가","cnText":"英文、数字或者英文数字组合4~12位，不能添加特殊符号","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_companyIDHasInvalidChar","krText":"아이디에 사용할수 없는 문자가 있습니다.","cnText":"用户名中的部分文字不可用","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_companyIDExist","krText":"사용중인 아이디입니다.","cnText":"本用户名正在使用中","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_companyIDValid","krText":"등록가능한 아이디입니다.","cnText":"本用户名可用","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_companyNoMustCheckDupl","krText":"사업자등록번호 중복체크를 해주세요","cnText":"请再一次确认企业登陆账号","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_companyIDMustCheckDupl","krText":"아이디 중복 체크를 해주세요","cnText":"请再一次确认用户名","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_emailMustCheckDupe","krText":"이메일 중복 체크를 해주세요","cnText":"请再一次确认邮箱","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_companyNameEmpty","krText":"기업명은 1개이상 입력하셔야합니다.","cnText":"必须输入至少一个公司名称","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_idEmpty","krText":"아이디를 입력하세요","cnText":"请输入用户名","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_idLengthMustOver4","krText":"아이디는 4자 이상입니다.","cnText":"用户名必须在4个字以上","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_passwordEmpty","krText":"비밀번호를 입력하세요","cnText":"请输入密码","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_passwordCheckNotMatch","krText":"비밀번호확인이 틀립니다.","cnText":"密码与上一次输入不符","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_emailEmpty","krText":"이메일을 입력하세요","cnText":"请输入邮箱","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_jobTypeEmpty","krText":"업종을 선택하세요","cnText":"请选择行业","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_etcTypeEmpty","krText":"기타 업종을 입력하세요","cnText":"请输入其他行业","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_companyTypeEmpty","krText":"기업유형을 선택하세요","cnText":"请选择企业类型","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_buildDateEmpty","krText":"설립일을 입력하세요","cnText":"请输入成立日期","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_representativeEmpty","krText":"대표자명을 입력하세요","cnText":"请输入法人代表名称","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_descriptionEmpty","krText":"주요사업 내용을입력하세요","cnText":"请输入主要业务内容","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_managerEmpty","krText":"채용담당자를 입력하세요","cnText":"请输入招聘负责人","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_phoneEmpty","krText":"회사 전화번호를 입력하세요","cnText":"请输入公司电话号码","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_faxEmpty","krText":"팩스번호를 입력하세요","cnText":"请输入传真号码","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_addressEmpty","krText":"본사주소를 입력하세요","cnText":"请输入总部地址","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_join.aspx_agreeNotChecked","krText":"사실확인을 하셔야합니다.","cnText":"请确认输入内容","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_19","krText":"기업코드","cnText":"企业号码","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_25","krText":"로고이미지","cnText":"企业标识","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_33","krText":"로고사이즈는 325*115px이며,JPG,GIF,PNG만 가능합니다.","cnText":"标识大小为325*115p， 只能为JPG,GIF,PNG的形式","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_39","krText":"기업명","cnText":"企业名","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_43","krText":"국문","cnText":"韩文","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_46","krText":"사업자등록증(영업집조)에 등록된 정규적인 회사명을 입력하는것을 추천하며,<br_>국문,중문,영문 중 반드시 하나 이상 기입하셔야 합니다.","cnText":"推荐输入企业注册证（营业执照）上的正式公司名称，必须填写韩语，中文，英文中的一种以上","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_50","krText":"중문","cnText":"中文","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_54","krText":"영문","cnText":"英文","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_61","krText":"사업자등록번호","cnText":"营业执照号码","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_67","krText":"아이디","cnText":"用户名","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_73","krText":"비밀번호","cnText":"密码","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_78","krText":"영문,숫자 또는 조합 4~12자리","cnText":"英文、数字或者英文数字组合4~12位","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_84","krText":"비밀번호확인","cnText":"确认密码","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_89","krText":"비밀번호를 다시 한번 입력해 주세요","cnText":"请再次填写密码","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_95","krText":"이메일","cnText":"电子邮件","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_101","krText":"가장 자주 쓰는 이메일 하나만 입력하세요","cnText":"请填写经常使用的电子邮件","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_107","krText":"업종","cnText":"业种","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_113","krText":"업종선택","cnText":"选择业种","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_130","krText":"대표자명","cnText":"法定代表人","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_140","krText":"기업유형","cnText":"企业类型","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_148","krText":"외자","cnText":"外资","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_154","krText":"독자","cnText":"独资 ","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_160","krText":"합자","cnText":"合资","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_166","krText":"기타","cnText":"其他","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_173","krText":"설립일","cnText":"成立日期","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_178","krText":"년","cnText":"年","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_number_only","krText":"숫자만 입력","cnText":"只能填写数字","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_184","krText":"사원수","cnText":"员工数","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_189","krText":"명","cnText":"名","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_197","krText":"자본금","cnText":"注册资本金","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_currencyUnit","krText":"화폐단위","cnText":"货币单位","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_currencyUnit_krw","krText":"원화","cnText":"韩元","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_currencyUnit_rmb","krText":"RMB","cnText":"人民币","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_currencyUnit_usd","krText":"달러","cnText":"美元","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_216","krText":"매출액","cnText":"销售额","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_235","krText":"주요사업 내용","cnText":"主要业务内容","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_235_1","krText":"기업소개","cnText":"企业简介","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_242","krText":"입력 예)재중 한인업´ 및 개인의 구인_구직서비스,헤드헌팅,채용대행.","cnText":"填入内容 例如）在华韩国企业及个人求人求职服务、猎头公司代理招聘","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_248","krText":"채용담당자","cnText":"招聘负责人","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_258","krText":"회사 전화번호","cnText":"企业电话","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_268","krText":"회사 팩스번호","cnText":"企业传真","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_278","krText":"기업본사주소","cnText":"企业总部住址","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_288","krText":"홈페이지","cnText":"网站                        ","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_293","krText":"예)http://www.chinajobgo.com","cnText":"例如：http://www.chinajobgo.com","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_299","krText":"상기 기업소개 내용이 틀림없는 사실임을 확인합니다.","cnText":"确认以上企业信息属实","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_emailFormatInvalid","krText":"이메일 형식이 아닙니다.","cnText":"邮件形式不正确","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_emailExist","krText":"존재하는 이메일주소입니다.","cnText":"本邮箱地址已存在","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_emailValid","krText":"등록가능한 이메일주소입니다.","cnText":"本邮箱地址可用","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_companyNoEmpty","krText":"사업자등록번호를 입력하세요","cnText":"请输入企业登录账号","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_companyNoExist","krText":"존재하는 사업자등록번호입니다.","cnText":"本企业登录账号已存在","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_companyNoValid","krText":"등록가능한 사업자등록번호입니다.","cnText":"本企业登录账号可用","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_companyIDFormatInvalid","krText":"영문,숫자 또는 조합4~12자리,특수문자 불가","cnText":"英文、数字或者英文数字组合4~12位，不能添加特殊符号","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_companyIDHasInvalidChar","krText":"아이디에 사용할수 없는 문자가 있습니다.","cnText":"用户名中的部分文字不可用","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_companyIDExist","krText":"사용중인 아이디입니다.","cnText":"本用户名正在使用中","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_companyIDValid","krText":"등록가능한 아이디입니다.","cnText":"本用户名可用","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_emailMustCheckDupe","krText":"이메일 중복 체크를 해주세요","cnText":"请再一次确认邮箱","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_companyNameEmpty","krText":"기업명은 1개이상 입력하셔야합니다.","cnText":"必须输入至少一个公司名称","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_passwordCheckNotMatch","krText":"비밀번호확인이 틀립니다.","cnText":"密码与上一次输入不一致","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_emailEmpty","krText":"이메일을 입력하세요","cnText":"请输入邮箱","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_jobTypeEmpty","krText":"업종을 선택하세요","cnText":"请选择行业","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_etcTypeEmpty","krText":"기타 업종을 입력하세요","cnText":"请输入其他行业","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_companyTypeEmpty","krText":"기업유형을 선택하세요","cnText":"请选择企业类型","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_representativeEmpty","krText":"대표자명을 입력하세요","cnText":"请输入法定代表人","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_descriptionEmpty","krText":"주요사업 내용을입력하세요","cnText":"请输入主要业务内容","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_managerEmpty","krText":"채용담당자를 입력하세요","cnText":"请输入招聘负责人","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_phoneEmpty","krText":"회사 전화번호를 입력하세요","cnText":"请输入公司电话号码","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_faxEmpty","krText":"팩스번호를 입력하세요","cnText":"请输入传真号码","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_addressEmpty","krText":"본사주소를 입력하세요","cnText":"请输入总部地址","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_company_modify.aspx_agreeNotChecked","krText":"사실확인을 하셔야합니다.","cnText":"请确认输入内容","enText":""});
  	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_21","krText":"참가여부","cnText":"是否参加","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_30","krText":"참가","cnText":"参加","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_36","krText":"불참","cnText":"不参加","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_44","krText":"참가정보","cnText":"参加信息","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_52","krText":"참가인원","cnText":"参加人员","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_66","krText":"면접관명","cnText":"面试官姓名","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_75","krText":"구인직종","cnText":"招聘职位","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_102","krText":"경력","cnText":"工作经历","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_111","krText":"무관","cnText":"不限","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_year","krText":"년","cnText":"年","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_over10","krText":"10년 이상","cnText":"十年以上","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_159","krText":"인원","cnText":"人员","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_166","krText":"명","cnText":"名","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_174","krText":"성별","cnText":"性别","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_183","krText":"무관","cnText":"不限","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_190","krText":"남","cnText":"男","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_197","krText":"여","cnText":"女","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_205","krText":"연령","cnText":"年龄","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_214","krText":"무관","cnText":"不限","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_220","krText":"제한","cnText":"限制","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_224","krText":"선택하세요","cnText":"请选择","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_231","krText":"직접입력","cnText":"直接输入","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_243","krText":"학력","cnText":"学历","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_252","krText":"무관","cnText":"不限","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_259","krText":"고졸이상","cnText":"高中学历以上","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_265","krText":"전문대졸이상","cnText":"大专学历以上","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_272","krText":"대졸이상","cnText":"本科学历以上","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_279","krText":"대학원이상","cnText":"本科学历以上","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_287","krText":"전공","cnText":"专业","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_296","krText":"무관","cnText":"不限","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_302","krText":"인문계열","cnText":"人文类","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_309","krText":"법계열","cnText":"法学类","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_316","krText":"이공계열","cnText":"理工类","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_323","krText":"예술계열","cnText":"艺术类","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_329","krText":"직접입력","cnText":"直接输入","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_340","krText":"중국어","cnText":"中文","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_349","krText":"무관","cnText":"不限","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_356","krText":"기본회화가능","cnText":"可基本对话","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_363","krText":"업무상 소통 가능","cnText":"可业务沟通","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_370","krText":"현지인 수준","cnText":"达到当地人水平","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_377","krText":"영어","cnText":"英语","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_386","krText":"무관","cnText":"不限","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_393","krText":"기본회화가능","cnText":"可基本对话","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_400","krText":"업무상 소통 가능","cnText":"可业务沟通","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_407","krText":"현지인 수준","cnText":"达到当地人水平","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_414","krText":"일본어","cnText":"日语","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_423","krText":"무관","cnText":"不限","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_430","krText":"기본회화가능","cnText":"可基本对话","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_437","krText":"업무상 소통 가능","cnText":"可业务沟通","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_444","krText":"현지인 수준","cnText":"达到当地人水平","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_451","krText":"기타언어","cnText":"其他语种","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_457","krText":"언어","cnText":"语种","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_467","krText":"기본회화가능","cnText":"可基本对话","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_474","krText":"업무상 소통 가능","cnText":"可业务沟通","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_481","krText":"현지인 수준","cnText":"达到当地人水平","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_488","krText":"주요업무","cnText":"主要业务","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_502","krText":"근무지역","cnText":"办公地区","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_520","krText":"상세주소","cnText":"详细地址","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_531","krText":"채용예정시기","cnText":"计划录用时间","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_540","krText":"년","cnText":"年","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_540_2","krText":"월","cnText":"月","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_540_3","krText":"일","cnText":"日","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_565","krText":"기타자격요건","cnText":"其他资格条件","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_577","krText":"급여","cnText":"薪资","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_596","krText":"계약기간","cnText":"合同期限","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_605","krText":"협의","cnText":"面议","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_612","krText":"년","cnText":"年","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_653","krText":"근무시간","cnText":"办公时间","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_662","krText":"해당국가 노동법률 의거","cnText":"相关国家劳动法规定","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_669","krText":"직접입력","cnText":"直接输入","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_680","krText":"후생복리","cnText":"福利待遇","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_686","krText":"보험","cnText":"保险","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_692","krText":"제공","cnText":"提供","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_699","krText":"미제공","cnText":"不提供","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_706","krText":"협의","cnText":"面议","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_713","krText":"기타","cnText":"其他","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_724","krText":"숙식","cnText":"食宿","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_744","krText":"보조","cnText":"补贴","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_768","krText":"퇴직금","cnText":"退职金","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_755","krText":"유","cnText":"有","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_782","krText":"무","cnText":"没有","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_795","krText":"회사내규","cnText":"公司内部规定","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_813","krText":"휴가","cnText":"假期","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_869","krText":"상기와 같이 구인요청 및 「2011 중국취업박람회」 참가를 신청합니다.","cnText":"连同上述招聘请求一起申请参加「2011 中国酒业博览会」 ","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_1135","krText":"참가여부를 선택해 주세요.","cnText":"请选择是否参加","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_1136","krText":"구인Á종을 선택해 주세요.","cnText":"请选择招聘职位","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_1137","krText":"인원을 선택해 주세요.","cnText":"请选择人员","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_1138","krText":"성별을 선택해 주세요.","cnText":"请选择性别","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_1139","krText":"연령을 입력해 주세요.","cnText":"请输入年龄","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_1141","krText":"주요업무를 입력해 주세요.","cnText":"请输入主要业务内容","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_1142","krText":"근무지역을 선택해 주세요.","cnText":"请选择办公地区","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_1143","krText":"계약기간을 입력해주세요.","cnText":"请输入合同期限","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist.aspx_1144","krText":"근무시간을 입력해주세요.","cnText":"请输入办公时间","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist_list.aspx_17","krText":"채용제목","cnText":"录用目录","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist_list.aspx_18","krText":"디자인 전략팀 매니저","cnText":"设计战略经理","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_regist_list.aspx_78","krText":"정말로 삭제하시겠습니까?","cnText":"确认要删除吗？","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_manage.aspx_recruitTitle","krText":"구인직종","cnText":"招聘职位","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_manage.aspx_regist","krText":"지원자","cnText":"报名者","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_manage.aspx_male","krText":"남","cnText":"男","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_manage.aspx_female","krText":"녀","cnText":"女","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_manage.aspx_age","krText":"세","cnText":"岁","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_manage.aspx_new","krText":"신입","cnText":"新入职","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_manage.aspx_career","krText":"경력","cnText":"经验","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_manage.aspx_registDate","krText":"지원일시","cnText":"报名时间","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_manage.aspx_wait","krText":"대기","cnText":"等待","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_manage.aspx_show","krText":"보기","cnText":"查看","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_manage.aspx_approve","krText":"승인","cnText":"同意","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_manage.aspx_waiting","krText":"대기중","cnText":"等待中","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_manage.aspx_approved","krText":"승인","cnText":"同意","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_manage.aspx_denied","krText":"거절","cnText":"拒绝","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_manage.aspx_deny","krText":"거절","cnText":"拒绝","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_manage.aspx_delete","krText":"삭제","cnText":"删除","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_manage.aspx_deleted","krText":"삭제","cnText":"删除","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_manage.aspx_approve?","krText":"승인하시겠습니까?","cnText":"您要同意吗？","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_manage.aspx_deny?","krText":"거절하시겠습니까?","cnText":"您要拒绝吗？","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Company_recruit_manage.aspx_delete?","krText":"삭제하시겠습니까?","cnText":"您要删除吗？","enText":""});
 	$.translateHelper.getTextCore = function(countryCode, transCode) {
		var entity = null;
		var found = false;
		$.each($.translateHelper.translateData, function(idx, data) {
			if ( !found )
			{
				if ( data.transCode == transCode)
				{
					entity = data;
				}
			}
		});
		
		var retVal = "";
		if (entity == null)
		{
			alert("transCode not found");
			return retVal;
		}
 
		if ( countryCode == $.translateHelper.countryCode_kr )
		{
			retVal = entity.krText;
		}
		else if ( countryCode == $.translateHelper.countryCode_cn)
		{
			retVal = entity.cnText;
		}
		else if ( countryCode == $.translateHelper.countryCode_en)
		{
			retVal = entity.enText;
		}
		else
		{
			alert("contryCode not found");
			return retVal;
		}
		
		return retVal;
	}
	$.translateHelper.getText = function(transCode) {
		return $.translateHelper.getTextCore($.translateHelper.countryCode, transCode);
	}
})(jQuery);
 


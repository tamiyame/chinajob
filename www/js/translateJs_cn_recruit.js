 
 
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
 	
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_48","krText":"기업명","cnText":"企业名","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_56","krText":"기업코드","cnText":"企业号码","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_60","krText":"업종","cnText":"业种","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_64","krText":"대표자","cnText":"法定代表人","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_66","krText":"기업유형","cnText":"企业类型","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_70","krText":"홈페이지","cnText":"网站","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_74","krText":"설립년도","cnText":"成立年度","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_76","krText":"사원수","cnText":"员工数","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_80","krText":"자본금","cnText":"注册资本金","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_82","krText":"매출액","cnText":"销售额","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_86","krText":"주소","cnText":"地址","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_102","krText":"면접관","cnText":"面试管理","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_106","krText":"전화","cnText":"电话","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_114","krText":"이메일","cnText":"邮箱","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_118","krText":"팩스","cnText":"传真","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_144","krText":"구인직종","cnText":"招聘职位","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_151","krText":"인원","cnText":"人员","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_155","krText":"연령","cnText":"年龄","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_159","krText":"학력","cnText":"学历","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_163","krText":"중국어","cnText":"中文","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_167","krText":"일본어","cnText":"日语","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_171","krText":"근무지역","cnText":"办公地区","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_178","krText":"급여","cnText":"薪资","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_186","krText":"주요업무","cnText":"主要业务","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_190","krText":"성별","cnText":"性别","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_194","krText":"경력","cnText":"工作经历","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_198","krText":"전공","cnText":"专业","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_202","krText":"영어","cnText":"英语","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_206","krText":"기타","cnText":"其他","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_210","krText":"계약기간","cnText":"合同期限","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_214","krText":"근무시간","cnText":"办公时间","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_224","krText":"후생복리","cnText":"福利待遇","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_226","krText":"보험","cnText":"保险","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_227","krText":"숙식","cnText":"食宿","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_228","krText":"퇴직금","cnText":"退职金","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_229","krText":"휴가","cnText":"假期","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_230","krText":"기타","cnText":"其他","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_234","krText":"기타자격요건","cnText":"其他资格条件","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Recruit_recruit_detail.aspx_244","krText":"상기기업의 구인정보에 틀림없음을 확인합니다.","cnText":"请确认以上企业招聘信息内容无误","enText":""});
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
 


 
 
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
	
	
 	$.translateHelper.translateData.push({"transCode":"CN_Operation_freeboard_detail.aspx_30","krText":"정말로 삭제하시겠습니까?","cnText":"确认要删除吗？","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Operation_freeboard_list.aspx_12","krText":"분류","cnText":"类别","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Operation_freeboard_list.aspx_13","krText":"제목","cnText":"标题","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Operation_freeboard_list.aspx_14","krText":"작성자","cnText":"填写人","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Operation_freeboard_list.aspx_15","krText":"작성일","cnText":"填写日期","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Operation_freeboard_modify.aspx_14","krText":"분류","cnText":"类别","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Operation_freeboard_modify.aspx_22","krText":"제목","cnText":"标题","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Operation_freeboard_modify.aspx_33","krText":"글꼴","cnText":"字体","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Operation_freeboard_modify.aspx_42","krText":"크기","cnText":"字体大小","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Operation_freeboard_modify.aspx_114","krText":"제목을 입력하세요","cnText":"请输入标题","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Operation_freeboard_modify.aspx_123","krText":"내용을 입력하세요","cnText":"请输入内容","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Operation_freeboard_write.aspx_14","krText":"분류","cnText":"类别","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Operation_freeboard_write.aspx_22","krText":"제목","cnText":"","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Operation_freeboard_write.aspx_33","krText":"글꼴","cnText":"字体","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Operation_freeboard_write.aspx_42","krText":"크기","cnText":"字体大小","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Operation_freeboard_write.aspx_114","krText":"제목을 입력하세요","cnText":"请输入标题","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Operation_freeboard_write.aspx_123","krText":"내용을 입력하세요","cnText":"请输入内容","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Operation_notice_list.aspx_13","krText":"분류","cnText":"类别","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Operation_notice_list.aspx_14","krText":"제목","cnText":"标题","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Operation_notice_list.aspx_15","krText":"작성자","cnText":"填写人","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Operation_notice_list.aspx_16","krText":"작성일","cnText":"填写日期","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Operation_qna_list.aspx_12","krText":"분류","cnText":"类别","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Operation_qna_list.aspx_13","krText":"제목","cnText":"标题","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Operation_qna_list.aspx_14","krText":"작성자","cnText":"填写人","enText":""});
 	$.translateHelper.translateData.push({"transCode":"CN_Operation_qna_list.aspx_15","krText":"작성일","cnText":"填写日期","enText":""});
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
 


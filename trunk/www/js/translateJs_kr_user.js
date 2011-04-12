 
 
(function($)
{
	$.translateHelper = {};
	$.translateHelper.countryCode_kr = 1;
	$.translateHelper.countryCode_cn = 2;
	$.translateHelper.countryCode_en = 3;
	$.translateHelper.countryCode = 1;
	$.translateHelper.translateData = new Array();
	$.translateHelper.translateData.push({"transCode":"KR_user_human_regist_detail.aspx_requireSSN","krText":"주민등록번호를 입력해주세요.","cnText":"请输入身份证号码","enText":"주민등록번호를 입력해주세요.e"});
	$.translateHelper.translateData.push({"transCode":"KR_user_human_regist_detail.aspx_516","krText":"만 나이를 입력해 주세요.","cnText":"请输入实际周岁年龄","enText":"만 나이를 입력해 주세요.e"});
    $.translateHelper.translateData.push({"transCode":"KR_user_human_regist_detail.aspx_517","krText":"나이를 입력해 주세요.","cnText":"请输入年龄","enText":"나이를 입력해 주세요.e"});
	$.translateHelper.translateData.push({"transCode":"KR_user_human_regist_detail.aspx_518","krText":"주소를 입력해 주세요.","cnText":"请输入地址","enText":"주소를 입력해 주세요.e"});
    $.translateHelper.translateData.push({"transCode":"KR_user_human_regist_detail.aspx_519","krText":"보유기술 및 특기사항을 입력해 주세요.","cnText":"请输入特长技能","enText":"보유기술 및 특기사항을 입력해 주세요.e"});
 	$.translateHelper.translateData.push({"transCode":"KR_user_human_regist_detail.aspx_520","krText":"자기소개서를 입력해 주세요.","cnText":"请输入自我介绍","enText":"자기소개서를 입력해 주세요."});
 	$.translateHelper.translateData.push({"transCode":"KR_user_human_regist_detail.aspx_521","krText":"병역을 확인해주세요.","cnText":"请确认兵役情况","enText":"병역을 확인해주세요.e"});
 	$.translateHelper.translateData.push({"transCode":"KR_user_human_regist_detail.aspx_522","krText":"경력여부를 확인해주세요.","cnText":"请确认工作经验","enText":"경력여부를 확인해주세요.e"});
 	$.translateHelper.translateData.push({"transCode":"KR_user_human_regist_detail.aspx_523","krText":"등록동의여부를 확인해주세요.","cnText":"请确认是否同意注册","enText":"등록동의여부를 확인해주세요.e"});
 	$.translateHelper.translateData.push({"transCode":"KR_user_human_regist_detail.aspx_527","krText":"학력을 하나이상 입력해 주세요.","cnText":"请输入一个以上学历","enText":"학력을 하나이상 입력해 주세요e"});
 	$.translateHelper.translateData.push({"transCode":"KR_user_human_regist_detail.aspx_531","krText":"외국어를 하나이상 입력해 주세요","cnText":"请输入一门以上外语","enText":"외국어를 하나이상 입력해 주세요e"});
 	$.translateHelper.translateData.push({"transCode":"KR_recruit_human_detail.js_isCareer_no","krText":"신입","cnText":"新入职","enText":"New"});
 	$.translateHelper.translateData.push({"transCode":"KR_recruit_human_detail.js_isCareer_yes","krText":"경력","cnText":"经验","enText":"Career"});
 	$.translateHelper.translateData.push({"transCode":"KR_recruit_human_detail.js_other","krText":"-","cnText":"-","enText":"-"});
 	$.translateHelper.translateData.push({"transCode":"KR_recruit_human_detail.js_languagelevel_high","krText":"고급","cnText":"上级","enText":"LEVEL1"});
 	$.translateHelper.translateData.push({"transCode":"KR_recruit_human_detail.js_languagelevel_middle","krText":"중급","cnText":"中级","enText":"LEVEL2"});
 	$.translateHelper.translateData.push({"transCode":"KR_recruit_human_detail.js_languagelevel_low","krText":"초급","cnText":"下级","enText":"LEVEL3"});
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
 


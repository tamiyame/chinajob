<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/UserMaster.master" AutoEventWireup="true" CodeFile="human_regist_detail_en.aspx.cs" Inherits="KR_User_human_regist_detail_en" Title="제목 없음" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/kr/Css/human.css" />
<script language="javascript" type="text/javascript">
 
 
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
 
(function($)
{
	$.translateHelper.getText = function(transCode) {
		return $.translateHelper.getTextCore(<%= (byte)CountryCode %>, transCode);
	}
})(jQuery);
</script>
<script language="javascript" type="text/javascript">
var countryCode = <%= (byte)CountryCode %>;

var academicAbilities = <%= GetAcademicAbilityJson() %>;
var careers = <%= GetCareerJson() %>;
var languages = <%= GetLanguageJson() %>;
var licenses = <%= GetLicensesJson() %>;

var ssn1 = '<%= GetDetailValue("SSN1") %>';
var ssn2 = '<%= GetDetailValue("SSN2") %>';
var koreanAge = '<%= GetDetailValue("KoreanAge") %>';
var age = '<%= GetDetailValue("Age") %>';
var chinaExpChunk = '<%= GetDetailValue("ChinaExp") %>';
var chinaExp = chinaExpChunk.split("-");
var military = '<%= GetDetailValue("Military") %>';
var isCareer = '<%= GetDetailValue("IsCareer") %>';
var address = '<%= GetDetailValue("Address").Replace("\\", "\\\\").Replace("\r\n", "\\n").Replace("'", "\\'") %>';
var description = '<%= GetDetailValue("Description").Replace("\\", "\\\\").Replace("\r\n", "\\n").Replace("'", "\\'") %>';
var aboutMe = '<%= GetDetailValue("AboutMe").Replace("\\", "\\\\").Replace("\r\n", "\\n").Replace("'", "\\'") %>';
var lasteastEducation = '<%= GetDetailValue("LastestEducation").Replace("\\", "\\\\").Replace("\r\n", "\\n").Replace("'", "\\'") %>';
var graduationYear = '<%= GetDetailValue("GraduationYear").Replace("\\", "\\\\").Replace("\r\n", "\\n").Replace("'", "\\'") %>';
var militaryService = '<%= GetDetailValue("MilitaryService").Replace("\\", "\\\\").Replace("\r\n", "\\n").Replace("'", "\\'") %>';
jQuery(function()
{

	$("div.tab ul li").removeClass("icon-folder-middle-on").addClass("icon-folder-middle-off").removeClass("select");
	$("div.tab ul li:eq("+ countryCode +")").removeClass("icon-folder-middle-off").addClass("icon-folder-middle-on").addClass("select");

	$("input[name=ssn1]").val(ssn1);
	$("input[name=ssn2]").val(ssn2);
	$("input[name=korean_age]").val(koreanAge);
	$("input[name=age]").val(age);
	$("select[name=inchina_year]").val(chinaExp[0]);
	$("select[name=inchina_month]").val(chinaExp[1]);
	$("input[name=army]").each(function() {
		if( $(this).val() == military )
		{
			$(this).attr("checked", "checked");
		}
		else
		{
			$(this).attr("checked", "");
		}
	});
	$("input[name=isCareer]").each(function() {
		if( $(this).val() == isCareer )
		{
			$(this).attr("checked", "checked");
		}
		else
		{
			$(this).attr("checked", "");
		}
	});
	$("input[name=address]").val(address);
	$("textarea[name=award_text]").val(description);
	$("textarea[name=introduce]").val(aboutMe);
	
	$("input[name=lastestEducation]").val(lasteastEducation);
	$("input[name=graduationYear]").val(graduationYear);
	$("input[name=militaryService]").val(militaryService);
    $.each(academicAbilities, function(idx, data) {
        $("input[name=education_school]:eq("+idx+")").val(data.SchoolName);
        $("input[name=education_period_start]:eq("+idx+")").val(data.SchoolStartDate);
        $("input[name=education_period_end]:eq("+idx+")").val(data.SchoolEndDate);
        $("select[name=education_state]:eq("+idx+")").val(data.SchoolStatus);
        $("input[name=education_major]:eq("+idx+")").val(data.MajorMinor);
        $("input[name=education_national]:eq("+idx+")").val(data.SchoolCountryName);
    });

    $.each(careers, function(idx, data) {
        $("input[name=career_company]:eq("+idx+")").val(data.CareerCompanyName);
        $("input[name=career_period_start]:eq("+idx+")").val(data.CareerStartDate);
        $("input[name=career_period_end]:eq("+idx+")").val(data.CareerEndDate);
        $("input[name=career_department]:eq("+idx+")").val(data.CareerJobs);
        $("input[name=career_detail]:eq("+idx+")").val(data.CareerPosition);
        $("input[name=career_location]:eq("+idx+")").val(data.CareerLocation);
        
    });

    $.each(languages, function(idx, data) {
        $("input[name=language_type]:eq("+idx+")").val(data.LanguageName);
        $("input[name=language_testname]:eq("+idx+")").val(data.TestDesc);
        $("input[name=language_score]:eq("+idx+")").val(data.GradeDesc);
        $("input[name=language_level_"+(idx+1)+"]").each(function() {
            if( $(this).val() == data.ConversationLevel)
            {
                $(this).attr("checked", "checked");
            }
            else{
                $(this).attr("checked", "");
            }
        });
    });

    $.each(licenses, function(idx, data) {
        $("input[name=licence_year]:eq("+idx+")").val(data.LicensedDate);
        $("input[name=licence_title]:eq("+idx+")").val(data.LicenseName);
        $("input[name=licence_institution]:eq("+idx+")").val(data.Organization);
    });
    
});

(function($){
    $.extend({
        onWrite : function()
        {
            /* resume detail */
            var 
            ssn1,
            ssn2,
            age,
            korean_age,
            inchina_year,
            inchina_month,
            army,
            isCareer,
            address,
            agree,
            award_text,
            introduce;
            
            ssn1=$("input[name=ssn1]").val();
            ssn2=$("input[name=ssn2]").val();
            age=$("input[name=age]").val();
            korean_age=$("input[name=korean_age]").val();
            inchina_year=$("select[name=inchina_year]").val();
            inchina_month=$("select[name=inchina_month]").val();
            army=$("input[name=army]:checked").val();
            isCareer=$("input[name=isCareer]:checked").val();
            address=$("input[name=address]").val();
            agree=$("input[name=agree]:checked").val();
            award_text=$("textarea[name=award_text]").val();
            introduce=$("textarea[name=introduce]").val();
            
            if(countryCode==$.translateHelper.countryCode_kr && ssn1==""){ alert("주민등록번호를 입력해주세요.");return;  }
            if(countryCode==$.translateHelper.countryCode_kr && ssn2==""){ alert("주민등록번호를 입력해주세요.");return;  }
                        
            if(age==""){ alert("만 나이를 입력해 주세요.");return;  }
            if(korean_age==""){ alert("나이를 입력해 주세요.");return;  }
            if(address==""){ alert("주소를 입력해 주세요.");return;  }
            if(award_text==""){ alert("보유기술 및 특기사항을 입력해 주세요.");return;  }
            if(introduce==""){ alert("자기소개서를 입력해 주세요.");return;  }
            
            if(countryCode==$.translateHelper.countryCode_kr && !army){ alert("병역을 확인해주세요.");return;  }
            if(countryCode!=$.translateHelper.countryCode_en && !isCareer){ alert("경력여부를 확인해주세요.");return;  }
            if(!agree){ alert("등록동의여부를 확인해주세요.");return;  }
            
            var education_school_count = 0;
            $("input[name=education_school]").each(function(){if($(this).val()!="")education_school_count++});
            if(education_school_count == 0){alert("학력을 하나이상 입력해 주세요"); return;}
            
            var language_type_count = 0;
            $("input[name=language_type]").each(function(){if($(this).val()!="")language_type_count++});
            if(language_type_count == 0){alert("외국어를 하나이상 입력해 주세요"); return;}
            
            $("form:eq(0)").submit();
        }
    });
})(jQuery);
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">

<%= GetDetailValue("AboutMe").Replace("\\", "\\\\").Replace("\r\n", "\\n").Replace("'", "\\'") %>
	<div class="title">
        <div class="human-title-regist"></div>
    </div>
    <div class="tab-content">
    <div class="contents">
        <div class="tab">
            <ul>
	            <li class="icon icon-folder-middle-off" onclick="location.href='/KR/user/human_regist_basic.aspx'">
		            <div><span style="font-family:tahoma;color:#007be3">STEP1 </span>기본정보</div>
	            </li>
	            <li class="icon icon-folder-middle-off" onclick="location.href='/KR/user/human_regist_detail_kr.aspx'">
		            <div><span style="font-family:tahoma;color:#007be3">STEP2 </span>한국어</div>
	            </li>	
	            <li class="icon icon-folder-middle-off" onclick="location.href='/KR/user/human_regist_detail_cn.aspx'">
		            <div><span style="font-family:tahoma;color:#007be3">STEP3 </span>中文</div>
	            </li>
	            <li class="select last icon icon-folder-middle-on" onclick="location.href='/KR/user/human_regist_detail_en.aspx'">
		            <div><span style="font-family:tahoma;color:#007be3">STEP4 </span>English</div>
	            </li>												
            </ul>						
        </div>
        <div class="tab-content">
            <div class="regist">
                <div class="regist-item">
                    <div class="regist-header">Personal Information</div>                                
                    <table class="regist-table">                                            
                        <tr>
                            <td class="regist-label">Name</td>
                            <td><%=UserInfo.ENGName%></td>
                            <td class="regist-label">Gender</td>
                            <td><%=UserInfo.Gender==1?"Male":"Female" %></td>                                                    
                        </tr>
                        <tr>
                            <td class="regist-label">Date of Birth</td>
                            <td><%=UserInfo.Birthday.ToString("yyyy.MM.dd") %></td>
                            <td class="regist-label">Military service <span class="require">*</span></td>
                            <td><input name="militaryService" type="text" class="w100"/>
                            </td>                                                                                                    
                        </tr>
                        <tr>
                            <td class="regist-label">Phone</td>
                            <td><%=UserInfo.CNPhoneNo%></td>
                            <td class="regist-label">E-mail</td>
                            <td><%=UserInfo.Email%></td>                                                                                                    
                        </tr>
                        <tr>
                            <td class="regist-label">Address</td>
                            <td colspan="3"><input name="address" type="text" class="w100"/></td>                                 
                        </tr>
                    </table>
                </div>
                
                <div class="regist-item">
                    <div class="regist-header">Education Background </div>                                
                    <table class="regist-table">
                        <tr>
                            <td class="regist-label" style="width:141px;">Name of Institute</td>
                            <td class="regist-label" style="width:248px;">Major</td>
                            <td class="regist-label" style="width:173px;">Period</td>
                            <td class="regist-label" style="width:159px;">Location</td>                                                 
                        </tr>
                        <tr>
                           <td><input type="text" class="w100" name="education_school"/></td>
                           <td><input type="text" class="w100" name="education_major"/></td>
                           <td>
								<input class="w4" name="education_period_start"/>&nbsp;-&nbsp;<input class="w4" name="education_period_end"/>
						   </td>
                           <td><input type="text" class="w100" name="education_national"/></td>
                        </tr>
						<tr>
                           <td><input type="text" class="w100" name="education_school"/></td>
                           <td><input type="text" class="w100" name="education_major"/></td>
                           <td>
								<input class="w4" name="education_period_start"/>&nbsp;-&nbsp;<input class="w4" name="education_period_end"/>
						   </td>
                           <td><input type="text" class="w100" name="education_national"/></td>
                        </tr>
						<tr>
                           <td><input type="text" class="w100" name="education_school"/></td>
                           <td><input type="text" class="w100" name="education_major"/></td>
                           <td>
								<input class="w4" name="education_period_start"/>&nbsp;-&nbsp;<input class="w4" name="education_period_end"/>
						   </td>
                           <td><input type="text" class="w100" name="education_national"/></td>
                        </tr>
                    </table>
                </div>
                
                <div class="regist-item">
                    <div class="regist-header">Career</div>                                
                    <table class="regist-table">
                        <tr>
                            <td class="regist-label" style="width:177px">Period</td>
                            <td class="regist-label" style="width:144px">Company Name</td>
                            <td class="regist-label" style="width:123px">Department</td>
                            <td class="regist-label" style="width:130px">Details of duties</td>                                             
							<td class="regist-label" style="width:143px">Location</td>
                        </tr>
                        <tr>
                           <td>
								<input class="w4" name="career_period_start"/>&nbsp;-&nbsp;<input class="w4" name="career_period_end"/>
						   </td>
                           <td><input type="text" class="w100" name="career_company"/></td>
                           <td><input type="text" class="w100" name="career_department"/></td>
                           <td><input type="text" class="w100" name="career_detail"/></td>
						   <td><input type="text" class="w100" name="career_location"/></td>
                        </tr>
						<tr>
                           <td>
								<input class="w4" name="career_period_start"/>&nbsp;-&nbsp;<input class="w4" name="career_period_end"/>
						   </td>
                           <td><input type="text" class="w100" name="career_company"/></td>
                           <td><input type="text" class="w100" name="career_department"/></td>
                           <td><input type="text" class="w100" name="career_detail"/></td>
						   <td><input type="text" class="w100" name="career_location"/></td>
                        </tr>
						<tr>
                           <td>
								<input class="w4" name="career_period_start"/>&nbsp;-&nbsp;<input class="w4" name="career_period_end"/>
						   </td>
                           <td><input type="text" class="w100" name="career_company"/></td>
                           <td><input type="text" class="w100" name="career_department"/></td>
                           <td><input type="text" class="w100" name="career_detail"/></td>
						   <td><input type="text" class="w100" name="career_location"/></td>
                        </tr>
                    </table>
                </div>
                
                <div class="regist-item">
                    <div class="regist-header">Foreign Language Skill </div>                                
                    <table class="regist-table">
                        <tr>
                            <td class="regist-label" style="width:143px">Foreign Language Skill </td>
                            <td class="regist-label" style="width:134px">Level</td>
                            <td class="regist-label" style="width:310px">Score of Authenticated Language Test</td>
                            <td class="regist-label" style="width:142px">Score/Grade</td>                                             
                        </tr>
                        <tr>
                           <td><input type="text" class="w100" name="language_type"/></td>
                           <td>
                                <table>
                                    <tr>
                                        <td>
                                            <input id="languageLevel-1" type="radio" class="radio" name="language_level_1" value="1"/>
                                        </td>
                                        <td>
                                            <label for="languageLevel-1">1</label>
                                        </td>
                                        <td>
                                            <input id="languageLevel-2" type="radio" class="radio" name="language_level_1" value="2"/>
                                        </td>
                                        <td>
                                            <label for="languageLevel-2">2</label>
                                        </td>
                                        <td>
                                            <input id="languageLevel-3" type="radio" class="radio" name="language_level_1" value="3"/>
                                        </td>
                                        <td>
                                            <label for="languageLevel-3">3</label>
                                        </td>
                                        <td>
                                            <input id="languageLevel-4" type="radio" class="radio" name="language_level_1" value="4"/>
                                        </td>
                                        <td>
                                            <label for="languageLevel-4">4</label>
                                        </td>
                                        <td>
                                            <input id="languageLevel-5" type="radio" class="radio" name="language_level_1" value="5"/>
                                        </td>
                                        <td>
                                            <label for="languageLevel-5">5</label>
                                        </td>
                                    </tr>
                                </table>
                           </td>
                           <td><input type="text" class="w100" name="language_testname"/></td>
                           <td><input type="text" class="w100" name="language_score"/></td>
                        </tr>
						<tr>
                           <td><input type="text" class="w100" name="language_type"/></td>
                           <td>
                                <table>
                                    <tr>
                                        <td>
                                            <input id="languageLeve2-1" type="radio" class="radio" name="language_level_2" value="1"/>
                                        </td>
                                        <td>
                                            <label for="languageLeve2-1">1</label>
                                        </td>
                                        <td>
                                            <input id="languageLeve2-2" type="radio" class="radio" name="language_level_2" value="2"/>
                                        </td>
                                        <td>
                                            <label for="languageLeve2-2">2</label>
                                        </td>
                                        <td>
                                            <input id="languageLeve2-3" type="radio" class="radio" name="language_level_2" value="3"/>
                                        </td>
                                        <td>
                                            <label for="languageLeve2-3">3</label>
                                        </td>
                                        <td>
                                            <input id="languageLeve2-4" type="radio" class="radio" name="language_level_2" value="4"/>
                                        </td>
                                        <td>
                                            <label for="languageLeve2-4">4</label>
                                        </td>
                                        <td>
                                            <input id="languageLeve2-5" type="radio" class="radio" name="language_level_2" value="5"/>
                                        </td>
                                        <td>
                                            <label for="languageLeve2-5">5</label>
                                        </td>
                                    </tr>
                                </table>
                           </td>
                           <td><input type="text" class="w100" name="language_testname"/></td>
                           <td><input type="text" class="w100" name="language_score"/></td>
                        </tr>
						<tr>
                           <td><input type="text" class="w100" name="language_type"/></td>
                           <td>
                                <table>
                                    <tr>
                                        <td>
                                            <input id="languageLeve3-1" type="radio" class="radio" name="language_level_3" value="1"/>
                                        </td>
                                        <td>
                                            <label for="languageLeve3-1">1</label>
                                        </td>
                                        <td>
                                            <input id="languageLeve3-2" type="radio" class="radio" name="language_level_3" value="2"/>
                                        </td>
                                        <td>
                                            <label for="languageLeve3-2">2</label>
                                        </td>
                                        <td>
                                            <input id="languageLeve3-3" type="radio" class="radio" name="language_level_3" value="3"/>
                                        </td>
                                        <td>
                                            <label for="languageLeve3-3">3</label>
                                        </td>
                                        <td>
                                            <input id="languageLeve3-4" type="radio" class="radio" name="language_level_3" value="4"/>
                                        </td>
                                        <td>
                                            <label for="languageLeve3-4">4</label>
                                        </td>
                                        <td>
                                            <input id="languageLeve3-5" type="radio" class="radio" name="language_level_3" value="5"/>
                                        </td>
                                        <td>
                                            <label for="languageLeve3-5">5</label>
                                        </td>
                                    </tr>
                                </table>
                           </td>
                           <td><input type="text" class="w100" name="language_testname"/></td>
                           <td><input type="text" class="w100" name="language_score"/></td>
                        </tr>
                    </table>
					<table class="regist-table">
						<tr>
							<td style="border:none; font-family:tahoma; font-size:11px">LEVEL5 : Can use very simple daily words and phrases.</td>
							<td style="border:none;font-family:tahoma; font-size:11px">LEVEL4 : Can talk briefly about very familiar topics only.</td>
						</tr>
						<tr>
							<td style="border:none;font-family:tahoma; font-size:11px">LEVEL3 : Can talk about work, with some restrictions.</td>
							<td style="border:none;font-family:tahoma; font-size:11px">LEVEL2 : Can communicate satisfactorily in almost all situations.</td>
						</tr>
						<tr>
							<td style="border:none;font-family:tahoma; font-size:11px">LEVEL1 : Can communicate effectively in all situations.</td>
							<td style="border:none;font-family:tahoma; font-size:11px"></td>
						</tr>
					</table>
                </div>
                
                <div class="regist-item">
                    <div class="regist-header">Certification & Licenses</div>                                
                    <table class="regist-table">
                        <tr>
                            <td class="regist-label" style="width:170px">Title</td>
                            <td class="regist-label" style="width:340px">Issuing Institution</td>
                            <td class="regist-label" style="width:268px">Date of acquisition</td>                                         
                        </tr>
                        <tr>
                            <td><input type="text" class="w100" name="licence_title"/></td>
                            <td><input type="text" class="w100" name="licence_institution"/></td>
                            <td><input type="text" class="w100" name="licence_year"/></td>
                        </tr>
						<tr>
                            <td><input type="text" class="w100" name="licence_title"/></td>
                            <td><input type="text" class="w100" name="licence_institution"/></td>
                            <td><input type="text" class="w100" name="licence_year"/></td>
                        </tr>
						<tr>
                            <td><input type="text" class="w100" name="licence_title"/></td>
                            <td><input type="text" class="w100" name="licence_institution"/></td>
                            <td><input type="text" class="w100" name="licence_year"/></td>
                        </tr>
                    </table>
                </div>
                
                <div class="regist-item">
                    <div class="regist-header">Awards, O/A Ability, Professional Experience  Etc </div>                                
                    <textarea class="w100" rows="20" name="award_text"></textarea>
                </div>
                                                    
                <div class="regist-item">
                    <div class="regist-tool">
                        <span class="agree">
                            <input class="checkbox" id="agree" name="agree" type="checkbox" />
                            <label for="agree">취업을 희망하여 동 이력서를 작성하였으며 해외취업을 목적으로 한국산업인력공단 월드잡사이트 등록 및 해외 구인기업체에게 제공되는 것에 동의합니다.</label>
                            </span>
                        <br />
                        <br />
                        <br />
                        <br />
                        <a class="icon icon-human-regist-btn" href="javascript:$.onWrite();"></a>
                    </div>
                </div>
            </div>
        </div>
	</div>
	</div>
</asp:Content>


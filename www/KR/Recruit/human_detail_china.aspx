<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/UserMaster.master" AutoEventWireup="true" CodeFile="human_detail_china.aspx.cs" Inherits="KR_Recruit_human_detail_china" Title="제목 없음" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/kr/Css/human.css" />
<script language="javascript" type="text/javascript" src="/js/translateJs_kr_user.js"></script>

<script language="javascript" type="text/javascript">
(function($) {
	// type here your code
	
    // ready
    $(document).ready(function() {
		$("div.tab ul li").removeClass("icon-folder-middle-on").addClass("icon-folder-middle-off").removeClass("select");
		$("div.tab ul li:eq("+ ( countryCode -1 ) +")").removeClass("icon-folder-middle-off").addClass("icon-folder-middle-on").addClass("select");
		
		$("td.ssn").text(ssn1+"-"+ssn2);
		$("td.age").text(koreanAge + "세 (만 " + age + "세)");
		$("td.inchina").text(chinaExp[0]+"년 " + chinaExp[1] + "개월");
		$("td.army").text(military==1?"필":military==2?"미필":military==3?"면제":military==4?"무관":"기타");
		$("td.isCareer").text(isCareer==1?$.translateHelper.getText("KR_recruit_human_detail.js_isCareer_no"):
								isCareer==2?$.translateHelper.getText("KR_recruit_human_detail.js_isCareer_yes"):
								$.translateHelper.getText("KR_recruit_human_detail.js_other"));
		$("td.address").text(address);
		$("textarea[name=award_text]").val(description);
		$("textarea[name=introduce]").val(aboutMe);

		$("td.lastestEducation").text(lasteastEducation);
		$("td.graduationYear").text(graduationYear);
		$("td.militaryService").text(militaryService);

		$.each(academicAbilities, function(idx, data) {
			$("td.education_school:eq("+idx+")").text(data.SchoolName);
			$("td.education_period_start:eq("+idx+")").text(data.SchoolStartDate);
			$("td.education_period_end:eq("+idx+")").text(data.SchoolEndDate);
			$("td.education_state:eq("+idx+")").text(data.SchoolStatus==1?"졸업":"-");
			$("td.education_major:eq("+idx+")").text(data.MajorMinor);
			$("td.education_national:eq("+idx+")").val(data.SchoolCountryName);
		});

		$.each(careers, function(idx, data) {
			$("td.career_company:eq("+idx+")").text(data.CareerCompanyName);
			$("td.career_period_start:eq("+idx+")").text(data.CareerStartDate);
			$("td.career_period_end:eq("+idx+")").text(data.CareerEndDate);
			$("td.career_department:eq("+idx+")").text(data.CareerJobs);
			$("td.career_detail:eq("+idx+")").text(data.CareerPosition);
			$("td.career_location:eq("+idx+")").text(data.CareerLocation);
		});

		$.each(languages, function(idx, data) {
			$("td.language_type:eq("+idx+")").text(data.LanguageName);
			$("td.language_testname:eq("+idx+")").text(data.TestDesc);
			$("td.language_score:eq("+idx+")").text(data.GradeDesc);
			$("td.language_level:eq("+idx+")").text(data.ConversationLevel==1?$.translateHelper.getText("KR_recruit_human_detail.js_languagelevel_high"):
												data.ConversationLevel==2?$.translateHelper.getText("KR_recruit_human_detail.js_languagelevel_middle"):
												data.ConversationLevel==3?$.translateHelper.getText("KR_recruit_human_detail.js_languagelevel_low"):
												data.ConversationLevel==4?"LEVEL4":
												data.ConversationLevel==5?"LEVEL5":
												$.translateHelper.getText("KR_recruit_human_detail.js_other"));
		});

		$.each(licenses, function(idx, data) {
			$("td.licence_year:eq("+idx+")").text(data.LicensedDate);
			$("td.licence_title:eq("+idx+")").text(data.LicenseName);
			$("td.licence_institution:eq("+idx+")").text(data.Organization);
		});
	    
	});
})(jQuery);
</script>
<script language="javascript" type="text/javascript">
(function($)
{
	$.translateHelper.getText = function(transCode) {
		return $.translateHelper.getTextCore(<%= (byte)CountryCode %>, transCode);
	}
})(jQuery);

var countryCode = <%= (byte)CountryCode %>;
var userNo = <%= UserNo %>;

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
var address = '<%= GetDetailValue("Address") %>';
var description = '<%= GetDetailValue("Description").Replace("\\", "\\\\").Replace("\r\n", "\\n").Replace("'", "\\'") %>';
var aboutMe = '<%= GetDetailValue("AboutMe").Replace("\\", "\\\\").Replace("\r\n", "\\n").Replace("'", "\\'") %>';
var lasteastEducation = '<%= GetDetailValue("LastestEducation") %>';
var graduationYear = '<%= GetDetailValue("GraduationYear") %>';
var militaryService = '<%= GetDetailValue("MilitaryService") %>';

</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
                        <div class="title">
                            <div class="human-title-detail"></div>
                        </div>
                        <div class="contents">
                            <div class="tab">
					            <ul>
						            <li class="icon icon-folder-middle-off">
							            <div><a href="<%=GetDetailViewer("human_detail_korean.aspx",this.UserNo)  %>">한국어</a></div>
						            </li>	
						            <li class="select icon icon-folder-middle-on">
							            <div><a href="<%=GetDetailViewer("human_detail_china.aspx",this.UserNo)  %>">中文</a></div>
						            </li>
						            <li class="last icon icon-folder-middle-off">
							            <div><a href="<%=GetDetailViewer("human_detail_english.aspx",this.UserNo)  %>">English</a></div>
						            </li>											
					            </ul>						
				            </div>
                            <div class="tab-content">
                                <div class="regist">
                                    <div class="regist-item">
                                        <div class="regist-header">本人槪况</div>                                
                                        <table class="regist-table">
                                            <tr>
                                                <td class="regist-label">姓名</td>
                                                <td><%=UserInfo.CNName%></td>
                                                <td class="regist-label">性別</td>
                                                <td><%=UserInfo.Gender==1?"男":"女" %></td>                                                    
                                            </tr>
                                            <tr>
                                                <td class="regist-label">出生年月</td>
                                                <td><%=UserInfo.Birthday.ToString("yyyy年 MM月 dd日") %></td>
                                                <td class="regist-label">工作年限</td>
                                                <td class="isCareer">无</td>                                                                                                    
                                            </tr>
                                            <tr>
                                                <td class="regist-label">最高学历(学位)</td>
                                                <td class="lastestEducation">大学</td>
                                                <td class="regist-label">毕业学校</td>
                                                <td class="education_school">复旦大学</td>                                                                                                    
                                            </tr>
                                            <tr>
                                                <td class="regist-label">专业</td>
                                                <td class="education_major">汉语</td>
                                                <td class="regist-label">毕业时间</td>
                                                <td class="graduationYear">2010.5</td>                                                                                                    
                                            </tr>                                            
                                            <tr>
                                                <td class="regist-label">现详细居住地址</td>
                                                <td colspan="3" class="address">上海市民港区古北路5382弄14号1392室</td>                                 
                                            </tr>
											<!--<tr>
                                                <td class="regist-label">手机</td>
                                                <td><%/*UserInfo.CNPhoneNo*/%></td>
                                                <td class="regist-label">电子邮件</td>
                                                <td><%/*UserInfo.Email*/%></td>                                                                                                    
                                            </tr>-->
                                        </table>
                                    </div>
                                    
                                    <div class="regist-item">
                                        <div class="regist-header">工作/实习经历 </div>                                
                                        <table class="regist-table">
                                            <tr>
                                                <td class="regist-label" style="width:174px;">起止时间</td>
                                                <td class="regist-label" style="width:143px;">工作单位</td>
                                                <td class="regist-label" style="width:122px;">工作部门</td>
                                                <td class="regist-label" style="width:130px;">岗位/职务</td>
                                                <td class="regist-label" >单位性质</td>                                                    
                                            </tr>
                                            <tr>
                                               <td>
													<table>
                                                        <tr>
                                                            <td class="size-sub-k-2-1 career_period_start"></td>
                                                            <td class="size-sub-k-2-2">-</td>
                                                            <td class="size-sub-k-2-3 career_period_end"></td>
                                                        </tr>
													</table>
											   </td>
                                               <td class="career_company"></td>
                                               <td class="career_department"></td>
                                               <td class="career_detail"></td>
                                               <td class="career_location"></td>
                                            </tr>
                                            <tr>
                                               <td>
													<table>
                                                        <tr>
                                                            <td class="size-sub-k-2-1 career_period_start"></td>
                                                            <td class="size-sub-k-2-2">-</td>
                                                            <td class="size-sub-k-2-3 career_period_end"></td>
                                                        </tr>
													</table>
											   </td>
                                               <td class="career_company"></td>
                                               <td class="career_department"></td>
                                               <td class="career_detail"></td>
                                               <td class="career_location"></td>
                                            </tr>
                                            <tr>
                                               <td>
													<table>
                                                        <tr>
                                                            <td class="size-sub-k-2-1 career_period_start"></td>
                                                            <td class="size-sub-k-2-2">-</td>
                                                            <td class="size-sub-k-2-3 career_period_end"></td>
                                                        </tr>
													</table>
											   </td>
                                               <td class="career_company"></td>
                                               <td class="career_department"></td>
                                               <td class="career_detail"></td>
                                               <td class="career_location"></td>
                                            </tr>
                                        </table>
                                    </div>
                                    
                                    <div class="regist-item">
                                        <div class="regist-header">语言水平</div>                                
                                        <table class="regist-table">
                                            <tr>
                                                <td class="regist-label" style="width:141px">语言</td>
                                                <td class="regist-label" style="width:258px">考试名称</td>
                                                <td class="regist-label" style="width:182px">分数</td>
                                                <td class="regist-label" style="width:143px">会话</td>                                             
                                            </tr>
                                            <tr>
                                               <td class="language_type"></td>
                                               <td class="language_testname"></td>
                                               <td class="language_score"></td>
                                               <td class="language_level"></td>
                                            </tr>
                                            <tr>
                                               <td class="language_type"></td>
                                               <td class="language_testname"></td>
                                               <td class="language_score"></td>
                                               <td class="language_level"></td>
                                            </tr>
                                            <tr>
                                               <td class="language_type"></td>
                                               <td class="language_testname"></td>
                                               <td class="language_score"></td>
                                               <td class="language_level"></td>
                                            </tr>
                                        </table>
                                    </div>
                                                                        
                                    <div class="regist-item">
                                        <div class="regist-header">自我评价（主要业绩，个人特长，电脑能力等）</div>                                
                                        <textarea class="w100" rows="20" name="award_text" readonly="readonly">
                                            哈哈哈
我是很漂亮哈哈哈
我是很漂亮哈哈哈我是很漂亮我是很漂亮我是很漂亮我是很漂亮我是很漂亮我是很漂亮
我是很漂亮我是很漂亮我是很漂亮我是很漂亮我是很漂亮我是很漂亮我是很漂亮
哈哈哈哈哈哈我是很漂亮我是很漂亮我是很漂亮我是很漂亮我是很漂亮
我是很漂亮我是很漂亮我是很漂亮我是很漂亮我是很漂亮我是很漂亮
我是很漂亮
                                        </textarea>
                                    </div>                                    
                                                                        
                                    <div class="regist-item">
                                        <div class="regist-tool">
                                            <span class="agree">                                                
                                                <label for="agree">취업을 희망하여 동 이력서를 작성하였으며 해외취업을 목적으로 한국산업인력공단 월드잡사이트 등록 및 해외 구인기업체에게 제공되는 것에 동의합니다.</label>
                                            </span>
                                            <br />
                                            <br />
                                            <br />
                                            <!--<a class="icon icon-human-interview-btn" href="javascript:;"></a>-->
                                        </div>
                                        <br /><br /><br />
                                        
                                        <div class="regist-tool-right"><a class="icon icon-board-list" href="<%=GetSearch()%>"></a></div>
                                    </div>
                                </div>
                            </div>
                        </div>
</asp:Content>


<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/UserMaster.master" AutoEventWireup="true" CodeFile="human_detail_english.aspx.cs" Inherits="KR_Recruit_human_detail_english" Title="제목 없음" %>

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
                                                <td class="regist-label">Military service</td>
                                                <td class="militaryService">done</td>                                                                                                    
                                            </tr>
                                            <!--<tr>
                                                <td class="regist-label">Phone</td>
                                                <td><%/*UserInfo.CNPhoneNo*/%></td>
                                                <td class="regist-label">E-mail</td>
                                                <td><%/*UserInfo.Email*/%></td>                                                                                                    
                                            </tr>-->
                                            <tr>
                                                <td class="regist-label">Address</td>
                                                <td colspan="3" class="address">Room 12323, minhang-qu, Shanghai-city, China</td>                                 
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
                                               <td class="education_school"></td>
                                               <td class="education_major"></td>
                                               <td>
													<table>
                                                        <tr>
                                                            <td class="size-sub-k-2-1 education_period_start"></td>
                                                            <td class="size-sub-k-2-2">-</td>
                                                            <td class="size-sub-k-2-3 education_period_end"></td>
                                                        </tr>
													</table>
											   </td>
                                               <td class="education_national"></td>
                                            </tr>
                                            <tr>
                                               <td class="education_school"></td>
                                               <td class="education_major"></td>
                                               <td>
													<table>
                                                        <tr>
                                                            <td class="size-sub-k-2-1 education_period_start"></td>
                                                            <td class="size-sub-k-2-2">-</td>
                                                            <td class="size-sub-k-2-3 education_period_end"></td>
                                                        </tr>
													</table>
											   </td>
                                               <td class="education_national"></td>
                                            </tr>
                                            <tr>
                                               <td class="education_school"></td>
                                               <td class="education_major"></td>
                                               <td>
													<table>
                                                        <tr>
                                                            <td class="size-sub-k-2-1 education_period_start"></td>
                                                            <td class="size-sub-k-2-2">-</td>
                                                            <td class="size-sub-k-2-3 education_period_end"></td>
                                                        </tr>
													</table>
											   </td>
                                               <td class="education_national"></td>
                                            </tr>
                                        </table>
                                    </div>
                                    
                                    <div class="regist-item">
                                        <div class="regist-header">Career</div>                                
                                        <table class="regist-table">
                                            <tr>
                                                <td class="regist-label" style="width:174px">Period</td>
                                                <td class="regist-label" style="width:144px">Company Name</td>
                                                <td class="regist-label" style="width:123px">Department</td>
                                                <td class="regist-label" style="width:130px">Details of duties</td>                                             
												<td class="regist-label" style="width:143px">Location</td>
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
                                        <div class="regist-header">Foreign Language Skill </div>                                
                                        <table class="regist-table">
                                            <tr>
                                                <td class="regist-label" style="width:143px">Foreign Language Skill </td>
                                                <td class="regist-label" style="width:134px">Level</td>
                                                <td class="regist-label" style="width:310px">Score of Authenticated Language Test</td>
                                                <td class="regist-label" style="width:142px">Score/Grade</td>                                             
                                            </tr>
                                            <tr>
                                               <td class="language_type"></td>
                                               <td class="language_level"></td>
                                               <td class="language_testname"></td>
                                               <td class="language_score"></td>
                                            </tr>
                                            <tr>
                                               <td class="language_type"></td>
                                               <td class="language_level"></td>
                                               <td class="language_testname"></td>
                                               <td class="language_score"></td>
                                            </tr>
                                            <tr>
                                               <td class="language_type"></td>
                                               <td class="language_level"></td>
                                               <td class="language_testname"></td>
                                               <td class="language_score"></td>
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
                                                <td class="licence_title"></td>
                                                <td class="licence_institution"></td>
                                                <td class="licence_year"></td>
                                            </tr>
                                            <tr>
                                                <td class="licence_title"></td>
                                                <td class="licence_institution"></td>
                                                <td class="licence_year"></td>
                                            </tr>
                                            <tr>
                                                <td class="licence_title"></td>
                                                <td class="licence_institution"></td>
                                                <td class="licence_year"></td>
                                            </tr>
                                        </table>
                                    </div>
                                    
                                    <div class="regist-item">
                                        <div class="regist-header">Awards, O/A Ability, Professional Experience  Etc </div>                                
                                        <textarea class="w100" rows="20" name="award_text" readonly="readonly">
                                            This is Kim so hyun.
Those interested should forward a detailed resume and cover letter.
Those interested should forward a detailed resume and cover letter.
Those interested should forward a detailed resume and cover letter.Those interested should forward a detailed resume and cover letter.
Those interested should forward a detailed resume and cover letter.Those interested should forward a detailed resume and cover letter.
Those interested should forward a detailed resume and cover letter.Those interested should forward a detailed resume and cover letter.

thanks
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


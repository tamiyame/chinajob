<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/UserMaster.master" AutoEventWireup="true" CodeFile="human_regist_detail_en.aspx.cs" Inherits="KR_User_human_regist_detail_en" Title="제목 없음" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/kr/Css/human.css" />
<script language="javascript" type="text/javascript" src="human_regist_detail.js"></script>
<script language="javascript" type="text/javascript">
(function($)
{
	$.translateHelper.getText = function(transCode) {
		return $.translateHelper.getTextCore(<%= (byte)CountryCode %>, transCode);
	}
})(jQuery);

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
var address = '<%= GetDetailValue("Address") %>';
var description = '<%= GetDetailValue("Description") %>';
var aboutMe = '<%= GetDetailValue("AboutMe") %>';
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
		            <div>기본정보</div>
	            </li>
	            <li class="icon icon-folder-middle-off">
		            <div>한국어</div>
	            </li>	
	            <li class="icon icon-folder-middle-off">
		            <div>中文</div>
	            </li>
	            <li class="select last icon icon-folder-middle-on">
		            <div>English</div>
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
</asp:Content>


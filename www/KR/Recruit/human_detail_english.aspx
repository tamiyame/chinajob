<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/UserMaster.master" AutoEventWireup="true" CodeFile="human_detail_english.aspx.cs" Inherits="KR_Recruit_human_detail_english" Title="제목 없음" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/kr/Css/human.css" />
<script language="javascript" type="text/javascript" src=human_detail.js></script>
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
var description = '<%= GetDetailValue("Description") %>';
var aboutMe = '<%= GetDetailValue("AboutMe") %>';

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
                                                <td>kim kim kim</td>
                                                <td class="regist-label">Gender</td>
                                                <td>Famle</td>                                                    
                                            </tr>
                                            <tr>
                                                <td class="regist-label">Date of Birth</td>
                                                <td>2011.8.23</td>
                                                <td class="regist-label">Military service</td>
                                                <td>done</td>                                                                                                    
                                            </tr>
                                            <tr>
                                                <td class="regist-label">Phone</td>
                                                <td>131-4443-2124</td>
                                                <td class="regist-label">E-mail</td>
                                                <td>kimkimkim@hotmail.com</td>                                                                                                    
                                            </tr>
                                            <tr>
                                                <td class="regist-label">Address</td>
                                                <td colspan="3">Room 12323, minhang-qu, Shanghai-city, China</td>                                 
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
                                               <td>Seoul university</td>
                                               <td>Chinese</td>
                                               <td>
													<table>
                                                        <tr>
                                                            <td class="size-sub-k-2-1">2008.2</td>
                                                            <td class="size-sub-k-2-2">-</td>
                                                            <td class="size-sub-k-2-3">2011.3</td>
                                                        </tr>
													</table>
											   </td>
                                               <td>Korea</td>
                                            </tr>
											<tr>
                                               <td>Seoul university</td>
                                               <td>Chinese</td>
                                               <td>
													<table>
                                                        <tr>
                                                            <td class="size-sub-k-2-1">2008.2</td>
                                                            <td class="size-sub-k-2-2">-</td>
                                                            <td class="size-sub-k-2-3">2011.3</td>
                                                        </tr>
													</table>
											   </td>
                                               <td>Korea</td>
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
                                                            <td class="size-sub-k-2-1">2008.6</td>
                                                            <td class="size-sub-k-2-2">-</td>
                                                            <td class="size-sub-k-2-3">2008.8</td>
                                                        </tr>
													</table>
											   </td>
                                               <td>wise-ecommerce</td>
                                               <td>online service</td>
                                               <td>intern</td>
											   <td>Korea</td>
                                            </tr>
											<tr>
                                               <td>
													<table>
                                                        <tr>
                                                            <td class="size-sub-k-2-1">2008.6</td>
                                                            <td class="size-sub-k-2-2">-</td>
                                                            <td class="size-sub-k-2-3">2008.8</td>
                                                        </tr>
													</table>
											   </td>
                                               <td>wise-ecommerce</td>
                                               <td>online service</td>
                                               <td>intern</td>
											   <td>Korea</td>
                                            </tr>
											<tr>
                                               <td>
													<table>
                                                        <tr>
                                                            <td class="size-sub-k-2-1">2008.6</td>
                                                            <td class="size-sub-k-2-2">-</td>
                                                            <td class="size-sub-k-2-3">2008.8</td>
                                                        </tr>
													</table>
											   </td>
                                               <td>wise-ecommerce</td>
                                               <td>online service</td>
                                               <td>intern</td>
											   <td>Korea</td>
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
                                               <td>Chinese</td>
                                               <td>level5</td>
                                               <td>new HSK</td>
                                               <td>5</td>
                                            </tr>
											<tr>
                                               <td>Chinese</td>
                                               <td>level5</td>
                                               <td>new HSK</td>
                                               <td>5</td>
                                            </tr>
											<tr>
                                               <td>Chinese</td>
                                               <td>level5</td>
                                               <td>new HSK</td>
                                               <td>5</td>
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
                                                <td>Make-up</td>
                                                <td>Korea Make-up Association</td>
                                                <td>2007.1</td>
                                            </tr>
											<tr>
                                                <td>Make-up</td>
                                                <td>Korea Make-up Association</td>
                                                <td>2007.1</td>
                                            </tr>
                                        </table>
                                    </div>
                                    
                                    <div class="regist-item">
                                        <div class="regist-header">Awards, O/A Ability, Professional Experience  Etc </div>                                
                                        <textarea class="w100" rows="20" name="award-text">
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
                                            <a class="icon icon-human-interview-btn" href="javascript:;"></a>
                                        </div>                                        
                                        <div class="regist-tool-right"><a class="icon icon-board-list" href="javascript:;"></a></div>
                                    </div>
                                </div>
                            </div>
                        </div>
</asp:Content>


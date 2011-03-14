<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/UserMaster.master" AutoEventWireup="true" CodeFile="human_detail_korean.aspx.cs" Inherits="KR_Recruit_human_detail_korean" Title="제목 없음" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/kr/Css/human.css" />
<script language="javascript" type="text/javascript" src="human_detail.js"></script>
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
							            <div><a href="<%=GetDetailViewer("human_detail_basic.aspx",this.UserNo)  %>">기본정보</a></div>
						            </li>
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
                                        <div class="regist-header">1.개인정보</div>                                
                                        <table class="regist-table">
                                            <tr>
                                                <td rowspan="6" class="size-k-1-1">
                                                    <img class="picture" width="104px" height="138px" src="/FileServer/Company/10/Company_1024.jpg" />
                                                </td>
                                                <td class="size-k-1-2 regist-label">국문</td>
                                                <td class="size-k-1-3"><%=UserInfo.KRName%></td>
                                                <td class="size-k-1-4 regist-label">주민등록번호</td>
                                                <td class="size-k-1-5 ssn">840924-1846018</td>                                                    
                                            </tr>
                                            <tr>
                                                <td class="regist-label">중문</td>
                                                <td><%=UserInfo.CNName%></td>
                                                <td class="regist-label">연령</td>
                                                <td class="age">24세 (만 23세)</td>                                                    
                                            </tr>
                                            <tr>
                                                <td class="regist-label">영문</td>
                                                <td><%=UserInfo.ENGName%></td>
                                                <td class="regist-label">재중경험</td>
                                                <td class="inchina">3년 3개월</td>                                                                                                    
                                            </tr>
                                            <tr>
                                                <td class="regist-label">한국연락처</td>
                                                <td><%=UserInfo.KRPhoneNo%></td>
                                                <td class="regist-label">중국연락처</td>
                                                <td><%=UserInfo.CNPhoneNo%></td>                                                                                                    
                                            </tr>
                                            <tr>
                                                <td class="regist-label">거주국가</td>
                                                <td><%=GetCountryName(UserInfo.ResidanceCountry)%></td>
                                                <td class="regist-label">병역</td>
                                                <td class="army">미필</td>                                                                                                    
                                            </tr>
                                            <tr>
                                                <td class="regist-label">이메일</td>
                                                <td><%=UserInfo.Email%></td>
                                                <td class="regist-label">경력여부</td>
                                                <td class="isCareer">신입</td>                                                                                                    
                                            </tr>
                                            <tr>
                                                <td class="regist-label" colspan="2">주소(현재 실 거주지)</td>
                                                <td colspan="3" class="address">주소주소</td>                                 
                                            </tr>
                                        </table>
                                    </div>
                                    
                                    <div class="regist-item">
                                        <div class="regist-header">2.학력</div>                                
                                        <table class="regist-table">
                                            <tr>
                                                <td class="size-k-2-1 regist-label">학교명</td>
                                                <td class="size-k-2-2 regist-label">재학기간(년,월)</td>
                                                <td class="size-k-2-3 regist-label">상태</td>
                                                <td class="size-k-2-4 regist-label">전공/부전공</td>
                                                <td class="size-k-2-5 regist-label">소재국가</td>                                                    
                                            </tr>
                                            <tr>
                                               <td class="education_school"></td>
                                               <td>
                                                   <table>
                                                        <tr>
                                                            <td class="size-sub-k-2-1 education_period_start"></td>
                                                            <td class="size-sub-k-2-2">-</td>
                                                            <td class="size-sub-k-2-3 education_period_end"></td>
                                                        </tr>
                                                   </table>
                                               </td>
                                               <td class="v-center education_state"></td>
                                               <td class="education_major"></td>
                                               <td class="education_national"></td>
                                            </tr>
                                            <tr>
                                               <td class="education_school"></td>
                                               <td>
                                                   <table>
                                                        <tr>
                                                            <td class="size-sub-k-2-1 education_period_start"></td>
                                                            <td class="size-sub-k-2-2">-</td>
                                                            <td class="size-sub-k-2-3 education_period_end"></td>
                                                        </tr>
                                                   </table>
                                               </td>
                                               <td class="v-center education_state"></td>
                                               <td class="education_major"></td>
                                               <td class="education_national"></td>
                                            </tr>
                                            <tr>
                                               <td class="education_school"></td>
                                               <td>
                                                   <table>
                                                        <tr>
                                                            <td class="size-sub-k-2-1 education_period_start"></td>
                                                            <td class="size-sub-k-2-2">-</td>
                                                            <td class="size-sub-k-2-3 education_period_end"></td>
                                                        </tr>
                                                   </table>
                                               </td>
                                                   <td class="v-center education_state"></td>
                                               <td class="education_major"></td>
                                               <td class="education_national"></td>
                                            </tr>
                                        </table>
                                    </div>
                                    
                                    <div class="regist-item">
                                        <div class="regist-header">3.경력</div>                                
                                        <table class="regist-table">
                                            <tr>
                                                <td class="size-k-3-1 regist-label">근무지(회사명)</td>
                                                <td class="size-k-3-2 regist-label">재직기간(년,월)</td>
                                                <td class="size-k-3-3 regist-label">직종</td>
                                                <td class="size-k-3-4 regist-label">직책 및 근무내역</td>                                             
                                            </tr>
                                            <tr>
                                               <td class="career_company"></td>
                                               <td>
                                                   <table>
                                                        <tr>
                                                            <td class="size-sub-k-2-1 career_period_start"></td>
                                                            <td class="size-sub-k-2-2">-</td>
                                                            <td class="size-sub-k-2-3 career_period_end"></td>
                                                        </tr>
                                                   </table>
                                               </td>
                                               <td class="career_department"></td>
                                               <td class="career_detail"></td>
                                            </tr>
                                            <tr>
                                               <td class="career_company"></td>
                                               <td>
                                                   <table>
                                                        <tr>
                                                            <td class="size-sub-k-2-1 career_period_start"></td>
                                                            <td class="size-sub-k-2-2">-</td>
                                                            <td class="size-sub-k-2-3"></td>
                                                        </tr>
                                                   </table>
                                               </td>
                                               <td class="career_department"></td>
                                               <td class="career_detail"></td>
                                            </tr>
                                            <tr>
                                               <td class="career_company"></td>
                                               <td>
                                                   <table>
                                                        <tr>
                                                            <td class="size-sub-k-2-1 career_period_start"></td>
                                                            <td class="size-sub-k-2-2">-</td>
                                                            <td class="size-sub-k-2-3 career_period_end"></td>
                                                        </tr>
                                                   </table>
                                               </td>
                                               <td class="career_department"></td>
                                               <td class="career_detail"></td>
                                            </tr>
                                        </table>
                                    </div>
                                    
                                    <div class="regist-item">
                                        <div class="regist-header">4.외국어</div>                                
                                        <table class="regist-table">
                                            <tr>
                                                <td class="size-k-4-1 regist-label">언어구분</td>
                                                <td class="size-k-4-2 regist-label">시험명 or (실제 수준 기술)</td>
                                                <td class="size-k-4-3 regist-label">시험점수/등급</td>
                                                <td class="size-k-4-4 regist-label">회화</td>                                             
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
                                        <div class="regist-header">5.자격/면허</div>                                
                                        <table class="regist-table">
                                            <tr>
                                                <td class="size-k-4-1 regist-label">발행년월</td>
                                                <td class="size-k-4-2 regist-label">자격/면허명</td>
                                                <td class="size-k-4-3 regist-label">발급기관</td>                                         
                                            </tr>
                                            <tr>
                                                <td class="licence_year"></td>
                                                <td class="licence_title"></td>
                                                <td class="licence_institution"></td>
                                            </tr>
                                            <tr>
                                                <td class="licence_year"></td>
                                                <td class="licence_title"></td>
                                                <td class="licence_institution"></td>
                                            </tr>
                                            <tr>
                                                <td class="licence_year"></td>
                                                <td class="licence_title"></td>
                                                <td class="licence_institution"></td>
                                            </tr>
                                        </table>
                                    </div>
                                    
                                    <div class="regist-item">
                                        <div class="regist-header">6.보유기술 및 특기사항</div>                                
                                        <textarea class="w100" rows="20" name="award_text" readonly="readonly">
                                            이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다
이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고
이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다
이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다
이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다
                                        </textarea>
                                    </div>
                                    
                                    <div class="regist-item">
                                        <div class="regist-header">7.자기소개서</div>                                
                                        <textarea class="w100" rows="20" name="introduce" readonly="readonly">
                                        역시나 이쁘고 착합니다역시나 이쁘고 착합니다역시나 이쁘고 착합니다역시나 이쁘고 착합니다역시나 이쁘고 착합니다
역시나 이쁘고 착합니다역시나 이쁘고 착합니다역시나 이쁘고 착합니다역시나 이쁘고 착합니다역시나 이쁘고 착합니다
역시나 이쁘고 착합니다역시나 이쁘고 착합니다역시나 이쁘고 착합니다역시나 이쁘고 착합니다역시나 이쁘고 착합니다
역시나 이쁘고 착합니다역시나 이쁘고 착합니다역시나 이쁘고 착합니다역시나 이쁘고 착합니다역시나 이쁘고 착합니다역시나 이쁘고 착
합니다역시나 이쁘고 착합니다역시나 이쁘고 착합니다역시나 이쁘고 착합니다역시나 이쁘고 착합니다역시나 이쁘고 착합니다역시나 이쁘고
 착합니다역시나 이쁘고 착합니다역시나 이쁘고 착합니다역시나 이쁘고 착합니다
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
                                        <div class="regist-tool-right"><a class="icon icon-board-list" href="<%=GetSearch()%>"></a></div>
                                    </div>
                                </div>
                            </div>
                        </div>
</asp:Content>


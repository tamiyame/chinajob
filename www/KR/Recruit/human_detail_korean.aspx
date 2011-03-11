<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/UserMaster.master" AutoEventWireup="true" CodeFile="human_detail_korean.aspx.cs" Inherits="KR_Recruit_human_detail_korean" Title="제목 없음" %>

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
						            <li class="select icon icon-folder-middle-on">
							            <div>한국어</div>
						            </li>	
						            <li class="icon icon-folder-middle-off">
							            <div>中文</div>
						            </li>
						            <li class="last icon icon-folder-middle-off">
							            <div>English</div>
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
                                                <td class="size-k-1-3">김개똥</td>
                                                <td class="size-k-1-4 regist-label">주민등록번호</td>
                                                <td class="size-k-1-5">840924-1846018</td>                                                    
                                            </tr>
                                            <tr>
                                                <td class="regist-label">중문</td>
                                                <td>김개똥</td>
                                                <td class="regist-label">연령</td>
                                                <td>24세 (만 23세)</td>                                                    
                                            </tr>
                                            <tr>
                                                <td class="regist-label">영문</td>
                                                <td>Kim Kim Kim</td>
                                                <td class="regist-label">재중경험</td>
                                                <td>3년 3개월</td>                                                                                                    
                                            </tr>
                                            <tr>
                                                <td class="regist-label">한국연락처</td>
                                                <td>011-1111-1111</td>
                                                <td class="regist-label">중국연락처</td>
                                                <td>131-1111-1131</td>                                                                                                    
                                            </tr>
                                            <tr>
                                                <td class="regist-label">거주국가</td>
                                                <td>중국</td>
                                                <td class="regist-label">병역</td>
                                                <td>미필</td>                                                                                                    
                                            </tr>
                                            <tr>
                                                <td class="regist-label">이메일</td>
                                                <td>asdad@asd.com</td>
                                                <td class="regist-label">경력여부</td>
                                                <td>신입</td>                                                                                                    
                                            </tr>
                                            <tr>
                                                <td class="regist-label" colspan="2">주소(현재 실 거주지)</td>
                                                <td colspan="3">주소주소</td>                                 
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
                                               <td>서울대학교</td>
                                               <td>
                                                   <table>
                                                        <tr>
                                                            <td class="size-sub-k-2-1">2008.2</td>
                                                            <td class="size-sub-k-2-2">-</td>
                                                            <td class="size-sub-k-2-3">2011.3</td>
                                                        </tr>
                                                   </table>
                                               </td>
                                               <td class="v-center">졸업</td>
                                               <td>대외한어과</td>
                                               <td>한국</td>
                                            </tr>
                                            <tr>
                                               <td>서울대학교</td>
                                               <td>
                                                   <table>
                                                        <tr>
                                                            <td class="size-sub-k-2-1">2008.2</td>
                                                            <td class="size-sub-k-2-2">-</td>
                                                            <td class="size-sub-k-2-3">2011.3</td>
                                                        </tr>
                                                   </table>
                                               </td>
                                               <td class="v-center">졸업</td>
                                               <td>대외한어과</td>
                                               <td>한국</td>
                                            </tr>
                                            <tr>
                                               <td>서울대학교</td>
                                               <td>
                                                   <table>
                                                        <tr>
                                                            <td class="size-sub-k-2-1">2008.2</td>
                                                            <td class="size-sub-k-2-2">-</td>
                                                            <td class="size-sub-k-2-3">2011.3</td>
                                                        </tr>
                                                   </table>
                                               </td>
                                                   <td class="v-center">졸업</td>
                                               <td>대외한어과</td>
                                               <td>한국</td>
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
                                               <td>대한적십자</td>
                                               <td>
                                                   <table>
                                                        <tr>
                                                            <td class="size-sub-k-2-1">2008.6</td>
                                                            <td class="size-sub-k-2-2">-</td>
                                                            <td class="size-sub-k-2-3">2008.8</td>
                                                        </tr>
                                                   </table>
                                               </td>
                                               <td>정부기관</td>
                                               <td>인턴,자원봉사</td>
                                            </tr>
                                            <tr>
                                               <td>대한적십자</td>
                                               <td>
                                                   <table>
                                                        <tr>
                                                            <td class="size-sub-k-2-1">2008.6</td>
                                                            <td class="size-sub-k-2-2">-</td>
                                                            <td class="size-sub-k-2-3">2008.8</td>
                                                        </tr>
                                                   </table>
                                               </td>
                                               <td>정부기관</td>
                                               <td>인턴,자원봉사</td>
                                            </tr>
                                            <tr>
                                               <td>대한적십자</td>
                                               <td>
                                                   <table>
                                                        <tr>
                                                            <td class="size-sub-k-2-1">2008.6</td>
                                                            <td class="size-sub-k-2-2">-</td>
                                                            <td class="size-sub-k-2-3">2008.8</td>
                                                        </tr>
                                                   </table>
                                               </td>
                                               <td>정부기관</td>
                                               <td>인턴,자원봉사</td>
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
                                               <td>중국어</td>
                                               <td>신HSK</td>
                                               <td>5급</td>
                                               <td>고급</td>
                                            </tr>
                                            <tr>
                                               <td>중국어</td>
                                               <td>신HSK</td>
                                               <td>5급</td>
                                               <td>고급</td>
                                            </tr>
                                            <tr>
                                               <td>중국어</td>
                                               <td>신HSK</td>
                                               <td>5급</td>
                                               <td>고급</td>
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
                                                <td>2007.4</td>
                                                <td>운전면허 보통1급</td>
                                                <td>서울지방경찰청</td>
                                            </tr>
                                        </table>
                                    </div>
                                    
                                    <div class="regist-item">
                                        <div class="regist-header">6.보유기술 및 특기사항</div>                                
                                        <textarea class="w100" rows="20" name="award-text">
                                            이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다
이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고
이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다
이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다
이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다이쁘고 착합니다
                                        </textarea>
                                    </div>
                                    
                                    <div class="regist-item">
                                        <div class="regist-header">7.자기소개서</div>                                
                                        <textarea class="w100" rows="20" name="introduce">
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
                                        <div class="regist-tool-right"><a class="icon icon-board-list" href="javascript:;"></a></div>
                                    </div>
                                </div>
                            </div>
                        </div>
</asp:Content>


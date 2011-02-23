<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/RecruitMaster.master" AutoEventWireup="true" CodeFile="recruit_detail.aspx.cs" Inherits="CN_Recruit_recruit_detail" Title="제목 없음" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/cn/Css/recruit.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
<div class="title">
                            <div class="recruit-title-detail"></div>
                        </div>
                        <div class="contents">
                            <div class="tab">
                                <ul>
                                    <li class="<%=CountryNo == 1 ? "select icon icon-folder-big-on" : "icon icon-folder-big-off"%> korean">
                                        <div><a href="recruit_detail.aspx?CompanyNo=<%=CompanyNo %>&RecruitNo=<%=RecruitNo %>&CountryNo=1">한국어</a></div>
                                    </li>
                                    <li class="<%=CountryNo == 2 ? "select icon icon-folder-big-on" : "icon icon-folder-big-off"%> china">
                                        <div><a href="recruit_detail.aspx?CompanyNo=<%=CompanyNo %>&RecruitNo=<%=RecruitNo %>&CountryNo=2">中文</a></div>
                                    </li>													
                                    <li class="<%=CountryNo == 3 ? "select icon icon-folder-big-on" : "icon icon-folder-big-off"%> english">
                                        <div><a href="recruit_detail.aspx?CompanyNo=<%=CompanyNo %>&RecruitNo=<%=RecruitNo %>&CountryNo=3">english</a></div>
                                    </li>				
                                </ul>						
                            </div>
                            <div class="tab-content">
                                <table class="recruit-detail">
                                    <tr class="tab">
                                        <td class="col1"><span class="icon icon-recruit-company"></span></td>
                                        <td class="col2"></td>
                                    </tr>                                
                                    <tr class="content">
                                        <td class="col1 v-top">
                                            <table>
                                                <tr class="picture">
                                                    <td>
                                                        <img src="<%=CompanyDetailInfo.CompanyImage %>" width="327" height="115" />
                                                    </td>
                                                </tr>
                                                <tr class="description">
                                                    <td>
                                                        <%=CompanyDetailInfo.CompanyDescrition %>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                        <td class="col2">
                                            <table class="company-detail">
                                                <tr>
                                                    <td class="label v-top">기업명</td>
                                                    <td colspan="3" class="text-2 company-name">
                                                        <%=CompanyDetailInfo.KRName == string.Empty ? "" : CompanyDetailInfo.KRName+"<br />"%>
                                                        <%=CompanyDetailInfo.CNName == string.Empty ? "" : CompanyDetailInfo.CNName + "<br />"%>
                                                        <%=CompanyDetailInfo.ENGName == string.Empty ? "" : CompanyDetailInfo.ENGName%>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="label">기업코드</td>
                                                    <td colspan="3" class="text-2"><%=CompanyInfo.CompanyNo %></td>                                                    
                                                </tr>
                                                <tr>
                                                    <td class="label">업종</td>
                                                    <td colspan="3" class="text-2"><%=CompanyDetailInfo.BusinessCategoryEtc == string.Empty ? GetCategoryName(CompanyDetailInfo.BusinessCategoryNo) : CompanyDetailInfo.BusinessCategoryEtc %></td>
                                                </tr>
                                                <tr>
                                                    <td class="label">대표자</td>
                                                    <td class="text-1"><%=CompanyDetailInfo.PresidentName %></td>
                                                    <td class="label">기업유형</td>
                                                    <td class="text-1"><%= GetCategoryName(CompanyDetailInfo.CapitalType)%></td>                                                    
                                                </tr>
                                                <tr>
                                                    <td class="label">홈페이지</td>
                                                    <td colspan="3"3 class="text-2"><%=CompanyDetailInfo.HomepageURL %></td>                                                    
                                                </tr>
                                                <tr>
                                                    <td class="label">설립년도</td>
                                                    <td class="text-1"><%=CompanyDetailInfo.FoundYear %>년</td>
                                                    <td class="label">사원수</td>
                                                    <td class="text-1"><%=CompanyDetailInfo.EmployeeCount %>명</td>                                                    
                                                </tr>
                                                <tr>
                                                    <td class="label">자본금</td>
                                                    <td class="text-1"><%=CompanyDetailInfo.Capital%><%= GetCategoryName(CompanyDetailInfo.CapitalCurrencyNo)%></td>
                                                    <td class="label">매출액</td>
                                                    <td class="text-1"><%=CompanyDetailInfo.Turnover%><%= GetCategoryName(CompanyDetailInfo.TurnoverCurrencyNo)%></td>                                                    
                                                </tr>
                                                <tr>
                                                    <td class="label">주소</td>
                                                    <td colspan="3" class="text-2"><%= CompanyDetailInfo.HeadAddress%></td>                                                    
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                 </table>
                                 <table class="recruit-detail">
                                    <tr class="tab">
                                        <td class="col1"><span class="icon icon-recruit-judge"></span></td>
                                        <td class="col2"></td>
                                    </tr>                                
                                    <tr class="content">
                                        <td class="col1">
                                            <table class="company-detail">
                                                <tr>
                                                    <td class="label">면접관</td>
                                                    <td class="text-2"><%if (RecruitInfo.JoinType == 1 ) { %><%=RecruitInfo.JobFairRecruiter%><% } %></td>
                                                </tr>                                            
                                                <tr>
                                                    <td class="label">전화</td>
                                                    <td class="text-2"><%=CompanyDetailInfo.PhoneNo%></td>
                                                </tr>                          
                                            </table>
                                        </td>
                                        <td class="col2">
                                            <table class="company-detail">
                                                <tr>
                                                    <td class="label">이메일</td>
                                                    <td class="text-2"><%=CompanyDetailInfo.Email%></td>
                                                </tr>
                                                <tr>
                                                    <td class="label">팩스</td>
                                                    <td class="text-2"><%=CompanyDetailInfo.FaxNo%></td>
                                                </tr>                          
                       
                                            </table>
                                        </td>
                                    </tr>
                                 </table>
                                 <table class="recruit-detail">
                                    <tr class="tab">
                                        <td class="col1">
                                            <span class="icon icon-recruit-condition"></span>
                                            <span class="icon-set">
<% if (RecruitInfo.JoinType == 1) { %>
                                                <a class="icon icon-recruit-expo-join"></a>
<% } else { %>
                                                <a class="icon icon-recruit-expo-notjoin"></a>
<% } %>
                                            </span>
                                        </td>
                                        <td class="col2"></span></td>
                                    </tr>                                
                                    <tr class="content no-blank">
                                        <td class="col1">
                                            <table class="company-detail">
                                                <tr>
                                                    <td class="label">구인직종</td>
                                                    <td class="text-2 job-type">
                                                    <%=GetCategoryName(RecruitInfo.Category1No) %>,
                                                    <%=GetSubCategoryName(RecruitInfo.Category2No) %>
                                                    </td>
                                                </tr>                                            
                                                <tr>
                                                    <td class="label">인원</td>
                                                    <td class="text-2"><%=RecruitInfo.RecruitCount %>명</td>
                                                </tr>                          
                                                <tr>
                                                    <td class="label">연령</td>
                                                    <td class="text-2"><%=GetCategoryName(RecruitInfo.AgeCategory) %>세</td>
                                                </tr>                       
                                                <tr>
                                                    <td class="label">학력</td>
                                                    <td class="text-2"><%=GetCategoryName(RecruitInfo.AcademicAbility) %></td>
                                                </tr>                         
                                                <tr>
                                                    <td class="label">중국어</td>
                                                    <td class="text-2"><%=GetCategoryName(RecruitInfo.ChineseLevel)%></td>
                                                </tr>                         
                                                <tr>
                                                    <td class="label">일본어</td>
                                                    <td class="text-2"><%=GetCategoryName(RecruitInfo.JapanessLevel)%></td>
                                                </tr>                         
                                                <tr>
                                                    <td class="label">근무지역</td>
                                                    <td class="text-2">
                                                    <%=GetCategoryName(RecruitInfo.CityCategory) %>,
                                                    <%=GetSubCategoryName(RecruitInfo.AreaCategory) %>
                                                    </td>
                                                </tr>                         
                                                <tr>
                                                    <td class="label">급여</td>
                                                    <td class="text-2"><%=GetCategoryName(RecruitInfo.PayCategory)%></td>
                                                </tr> 
                                            </table>
                                        </td>
                                        <td class="col2">
                                            <table class="company-detail">
                                                <tr>
                                                    <td class="label">주요업무</td>
                                                    <td class="text-2"><%=RecruitInfo.MainWork%></td>
                                                </tr>                                            
                                                <tr>
                                                    <td class="label">성별</td>
                                                    <td class="text-2"><%=RecruitInfo.Gender == 0 ? "무관" :(RecruitInfo.Gender == 1 ? "남" : "여" )%></td>
                                                </tr>                          
                                                <tr>
                                                    <td class="label">경력</td>
                                                    <td class="text-2"><%=RecruitInfo.Career%>년</td>
                                                </tr>                       
                                                <tr>
                                                    <td class="label">전공</td>
                                                    <td class="text-2"><%=GetCategoryName(RecruitInfo.Major)%></td>
                                                </tr>                         
                                                <tr>
                                                    <td class="label">영어</td>
                                                    <td class="text-2"><%=GetCategoryName(RecruitInfo.EnglishLevel)%></td>
                                                </tr>                         
                                                <tr>
                                                    <td class="label">기타</td>
                                                    <td class="text-2"><%=RecruitInfo.ETCLanguageName%> - <%=GetCategoryName(RecruitInfo.ETCLanguageLevel)%></td>
                                                </tr>                         
                                                <tr>
                                                    <td class="label">계약기간</td>
                                                    <td class="text-2"><%=RecruitInfo.ContactPeriod%>년</td>
                                                </tr>                         
                                                <tr>
                                                    <td class="label">근무시</td>
                                                    <td class="text-2"><%if ( RecruitInfo.WorkingHoursType == 0 ) {  %>해당국가 노동법률 의거<% } else { %><%=RecruitInfo.WorkingHours%><% } %></td>
                                                </tr> 
                                            </table>
                                        </td>
                                    </tr>
                                    <tr class="desc-row">
                                        <td colspan="2" class="col1">
                                            <table class="company-detail">
                                                <tr>
                                                    <td class="label">후생복리</td>
                                                    <td class="text-3">
                                                        보험 - <% if (RecruitInfo.BenefitsInsurance != 0){ %><%=GetCategoryName(RecruitInfo.BenefitsInsurance)%><% }else{ %><%=RecruitInfo.BenefitsInsuranceEtcValue%><% } %> / 
                                                        숙식 - <% if (RecruitInfo.BenefitsRoomAndBoard != 0){ %><%=GetCategoryName(RecruitInfo.BenefitsRoomAndBoard)%><% }else{ %><%=RecruitInfo.BenefitsRoomAndBoardEtcValue%><% } %> / 
                                                        퇴직금 - <% if (RecruitInfo.BenefitsSeverancePay != 0){ %><%=GetCategoryName(RecruitInfo.BenefitsSeverancePay)%><% }else{ %><%=RecruitInfo.BenefitsSeverancePayEtcValue%><% } %> / 
                                                        휴가 - <% if (RecruitInfo.BenefitsVacation != 0){ %><%=GetCategoryName(RecruitInfo.BenefitsVacation)%><% }else{ %><%=RecruitInfo.BenefitsVacationEtcValue%><% } %><br />
                                                        기타 - <%=RecruitInfo.BenefitsETC%>
                                                    </td>
                                                </tr>
                                                 <tr>
                                                    <td class="label v-top">기타자격요건</td>
                                                    <td class="text-3">
                                                        <%=RecruitInfo.EtcEligibilityRule %>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                                <div class="company-confirm">
                                    <div>상기기업의 구인정보에 틀림없음을 확인합니다.</div>
                                    <div>
                                        <a class="icon icon-recruit-supply-btn"></a>
                                    </div>
                                    <div class="toolbox">
                                        <a class="icon icon-board-list"></a>
                                    </div>
                                </div>
                            </div>
                        </div>

</asp:Content>


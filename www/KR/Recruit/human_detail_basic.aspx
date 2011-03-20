<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/UserMaster.master" AutoEventWireup="true" CodeFile="human_detail_basic.aspx.cs" Inherits="KR_Recruit_human_detail_basic" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/kr/Css/human.css" />
<script language="javascript" type="text/javascript">
var countryCode = 0;
var userNo = <%= UserNo %>;

$(document).ready(function() {
	var companyNo1 = '<%= GetResumeEntityValue("CompanyNo1") %>';
	var companyNo2 = '<%= GetResumeEntityValue("CompanyNo2") %>';
	var companyNo3 = '<%= GetResumeEntityValue("CompanyNo3") %>';
	var hopeSalary = '<%= GetResumeEntityValue("HopeSalary") %>';
	var cityNo1 = '<%= GetResumeEntityValue("CityNo1") %>';
	var arrayNo1 = '<%= GetResumeEntityValue("ArrayNo1") %>';
	var cityNo2 = '<%= GetResumeEntityValue("CityNo2") %>';
	var arrayNo2 = '<%= GetResumeEntityValue("ArrayNo2") %>';
	var hopeRecruitDate = '<%= GetResumeEntityValue("HopeRecruitDate") %>';
	var businessCategoryNo = '<%= GetResumeEntityValue("BusinessCategoryNo") %>';
	var category1No = '<%= GetResumeEntityValue("Category1No") %>';
	var category2No = '<%= GetResumeEntityValue("Category2No") %>';
	var joinType = '<%= GetResumeEntityValue("JoinType") %>';
	
	$("td.hopejob_1").text(companyNo1);
	$("td.hopejob_2").text(companyNo2);
	$("td.hopejob_3").text(companyNo3);
	$("span.pay").text(hopeSalary);
	
	$("td.location1").text(cityNo1 + " > " + arrayNo1);
	$("td.location2").text(cityNo2 + " > " + arrayNo2);
	$("span.hopeRecruteDate").text(hopeRecruitDate);
	$("td.hope_job_category1_1").text(businessCategoryNo);
	$("td.hope_job_category2_1").text(category1No + " > " + category2No);
	
	
	$("td.isJoin").text(joinType==1?"가능":"불가능");

	$("div.tab ul li").removeClass("icon-folder-middle-on").addClass("icon-folder-middle-off").removeClass("select");
	$("div.tab ul li:eq("+ countryCode +")").removeClass("icon-folder-middle-off").addClass("icon-folder-middle-on").addClass("select");
	$("div.tab ul li:eq(0)").click(function() { location.href="<%=GetDetailViewer("human_detail_basic.aspx",this.UserNo)  %>"; });
	$("div.tab ul li:eq(1)").click(function() { location.href="<%=GetDetailViewer("human_detail_korean.aspx",this.UserNo)  %>"; });
	$("div.tab ul li:eq(2)").click(function() { location.href="<%=GetDetailViewer("human_detail_china.aspx",this.UserNo)  %>"; });
	$("div.tab ul li:eq(3)").click(function() { location.href="<%=GetDetailViewer("human_detail_english.aspx",this.UserNo)  %>"; });
});
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
                        <div class="title">
                            <div class="human-title-regist"></div>
                        </div>
                        <div class="contents">
                            <div class="tab">
					            <ul>
						            <li class="select icon icon-folder-middle-on">
							            <div><span style="font-family:tahoma;color:#007be3">STEP1 </span>기본정보</div>
						            </li>
						            <li class="icon icon-folder-middle-off">
							            <div><span style="font-family:tahoma;color:#007be3">STEP2 </span>한국어</div>
						            </li>	
						            <li class="icon icon-folder-middle-off">
							            <div><span style="font-family:tahoma;color:#007be3">STEP3 </span>中文</div>
						            </li>
						            <li class="last icon icon-folder-middle-off">
							            <div><span style="font-family:tahoma;color:#007be3">STEP4 </span>English</div>
						            </li>												
					            </ul>						
				            </div>
                            <div class="tab-content">
                                <div class="regist detail">
                                    <div class="regist-item">
                                        <div class="regist-header">1.희망지원 회사 코드 및 기타사항 </div>                                
                                        <table class="regist-table">
                                            <tr>
                                                <td class="size33 regist-label">1지망<span class="require">*</span></td>
                                                <td class="size33 regist-label">2지망<span class="require">*</span></td>
                                                <td class="size33 regist-label">3지망<span class="require">*</span></td>
                                            </tr>
                                            <tr>
                                                <td class="hopejob_1">삼성SDS(3322)</td>
                                                <td class="hopejob_2">삼성SDS(3322)</td>
                                                <td class="hopejob_3">삼성SDS(3322)</td>
                                            </tr>
                                            <tr>
                                                <td class="regist-label">희망급여 (RMB/1개월)<span class="require">*</span></td>
                                                <td colspan="2"><span class="pay">12,000</span> <span class="label">RMB (세후금액)</span></td>                                            
                                            </tr>
                                            <tr>
                                                <td class="regist-label" rowspan="2">희망지역<span class="require">*</span></td>
                                                <td colspan="2">
                                                    <table>
                                                        <tr>
                                                            <td><span class="label">1지망</span>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                                            <td class="location1">
                                                                흑룡강 > 하얼빈
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>                                            
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    <table>
                                                        <tr>
                                                            <td><span class="label">2지망</span>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                                            <td class="location2">
                                                                흑룡강 > 하얼빈
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>                                            
                                            </tr>
                                            <tr>
                                                <td class="regist-label">취업희망시기<span class="require">*</span></td>
                                                <td colspan="2"><span class="hopeRecruteDate">2011년 5월 4일</span> <span class="label">이후</span></td>                                            
                                            </tr>
                                        </table>
                                    </div>
                                     <div class="regist-item">
                                        <div class="regist-header">2.희망/관심 업종 및 직종</div>                                
                                        <table class="regist-table">
                                            <tr>
                                                <td class="size33 regist-label">희망/관심 업종<span class="require">*</span></td>
                                                <td colspan="2" class="hope_job_category1_1">서비스업 - 학교, 학원, 교육서비스</td>                                            
                                            </tr>
                                            <tr>
                                                <td class="regist-label">희망/관심 직종<span class="require">*</span></td>
                                                <td colspan="2" class="hope_job_category2_1">광고기획/제작/구매</td>                                            
                                            </tr>
                                        </table>
                                    </div>
                                    <div class="regist-item">
                                        <div class="regist-header">3.면접참가 가능 여부</div>                                
                                        <table class="regist-table">
                                            <tr>
                                                <td class="size33 regist-label">박람회 당일 면접참가여부<span class="require">*</span></td>
                                                <td colspan="2" class="isJoin">가능</td>                                            
                                            </tr>
                                        </table>
                                    </div>
                                    <div class="regist-item">
                                        <div class="regist-tool">
                                            <span class="agree">                                                
                                                <label for="agree">취업을 희망하여 동 이력서를 작성하였으며 해외취업을 목적으로 한국산업인력공단 월드잡사이트 등록 및 해외 구인기업체에게 제공되는 것에 동의합니다.</label>
                                            </span>
                                            <br />
                                            <br />
                                            <br />
                                            <% if ( this.WebCookies.isCompany ) { %>
                                            <!--<a class="icon icon-human-interview-btn" href=""></a>-->
                                            <% } %>
                                        </div>
                                        <br /><br />                             
                                        <div class="regist-tool-right"><a class="icon icon-board-list" href="<%=GetSearch()%>"></a></div>
                                        
                                    </div>
                                </div>
                            </div>
                        </div>
</asp:Content>


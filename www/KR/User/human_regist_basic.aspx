<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/UserMaster.master" AutoEventWireup="true" CodeFile="human_regist_basic.aspx.cs" Inherits="KR_User_human_regist_basic" %>
<%@ Import Namespace="Com.Library.DB.Category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/kr/Css/human.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
<asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server">
    <Services>
        <asp:ServiceReference Path="~/Soap/Category.asmx"></asp:ServiceReference>
    </Services>
</asp:ScriptManagerProxy>
<div class="title">
                            <div class="human-title-regist"></div>
                        </div>
<div class="tab-content">
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
                                <div class="regist">
                                    <div class="comment" style="line-height:16px;font-size:12px">
                                        <b>입력단계</b><br>
										&nbsp;&nbsp;STEP1 : 기본정보 필수 작성<br>
										&nbsp;&nbsp;STEP2 : 국문이력서 필수 작성<br>
										&nbsp;&nbsp;STEP3 or STEP4 : 중문 또는 영문이력서 중 1부 필수 작성<br>
										&nbsp;&nbsp;<font size="11px">(외국기업 및 중국기업을 위한 외국어이력서 1부를 반드시 작성해주시기 바랍니다.)</font><br>
										# 주의 : 이력서를 작성하지 않으시면 박람회 참가기업에 지원이 불가능합니다.
                                    </div>
                                    <div class="regist-item">
                                        <div class="regist-header">1.희망급여/지역/시기</div>                                
                                        <table class="regist-table">
                                            <tr>
                                                <td class="regist-label">희망급여 (RMB/1개월)<span class="require">*</span></td>
                                                <td colspan="2"><input class="w1" type="text" name="pay"/> <span class="label">RMB (세후금액)</span></td>                                            
                                            </tr>
                                            <tr>
                                                <td class="regist-label" rowspan="2">희망지역<span class="require">*</span></td>
                                                <td colspan="2">
                                                    <table>
                                                        <tr>
                                                            <td><span class="label">1지망</span>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                                            <td>
                                                                <select name="location1_1">
<% if (CityCategory != null)
   { %>
<% foreach (CategoryEntity item in CityCategory)
   { %>
												<option value="<%=item.CategoryNo %>"><%=item.CategoryKRName%></option>
<% } %>
<% } %>
                                                                </select>
                                                            </td>
                                                            <td>
                                                                <select name="location2_1">
                                                                    <option value="1">흑룡강</option>
                                                                </select>
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
                                                            <td>
                                                                <select name="location1_2">
                                                                    <% if (CityCategory != null)
																	   { %>
<% foreach (CategoryEntity item in CityCategory)
   { %>
												<option value="<%=item.CategoryNo %>"><%=item.CategoryKRName%></option>
<% } %>
<% } %>
                                                                </select>
                                                            </td>
                                                            <td>
                                                                <select name="location2_2">
                                                                    <option value="1">흑룡강</option>
                                                                </select>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>                                            
                                            </tr>
                                            <tr>
                                                <td class="regist-label">취업희망시기<span class="require">*</span></td>
                                                <td colspan="2">
                                                    <table>
                                                        <tr>
                                                            <td>
                                                                <select class="year" name="year">
                                                                    <option value="2011">2011</option>
                                                                    <option value="2012">2012</option>
                                                                    <option value="2013">2013</option>
                                                                </select>년
                                                            </td>
                                                            <td>
                                                                <select class="month" name="month">
                                                                 <%for (int i = 1; i <= 12; i++)
																   { %>
										                            <option value="<%=i %>" ><%=i%></option> 
									                             <% } %>
                                                                </select>월
                                                            </td>
                                                            <td>
                                                                <select class="day" name="day">
                                                                <%for (int i = 1; i <= 31; i++)
																  { %>
										                            <option value="<%=i %>" ><%=i%></option> 
									                             <% } %>
                                                                </select><span class="label">일 이후</span>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>                                            
                                            </tr>
                                        </table>
                                    </div>
                                     <div class="regist-item">
                                        <div class="regist-header">2.희망/관심 업종 및 직종</div>                                
                                        <table class="regist-table">
                                            <tr>
                                                <td class="size33 regist-label">희망/관심 업종<span class="require">*</span></td>
                                                <td colspan="2">
                                                    <table>
                                                        <tr>
                                                            <td>
                                                                <select class="big" name="hope_job_category1_1">
<% if (BusinessCategory != null)
   { %>
<% foreach (CategoryEntity item in BusinessCategory)
   { %>
												<option value="<%=item.CategoryNo %>"><%=item.CategoryKRName%></option>
<% } %>
<% } %>
                                                                </select>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>                                            
                                            </tr>
                                            <tr>
                                                <td class="regist-label">희망/관심 직종<span class="require">*</span></td>
                                                <td colspan="2">
                                                    <table>
                                                        <tr>
                                                            <td>
                                                                <select name="hope_job_category2_1">
                                                                    <% if (JobCategory != null)
																	   { %>
<% foreach (CategoryEntity item in JobCategory)
   { %>
												<option value="<%=item.CategoryNo %>"><%=item.CategoryKRName%></option>
<% } %>
<% } %>
                                                                </select>
                                                            </td>
                                                            <td>
                                                                <select name="hope_job_category2_2">
                                                                </select>
                                                            </td>
                                                            <td>
																<input type="text" class="w100" name="hope_job_category_etc" style="display:none"/>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>                                            
                                            </tr>
                                        </table>
                                    </div>
                                    <div class="regist-item">
                                        <div class="regist-header">3.면접참가 가능 여부</div>                                
                                        <table class="regist-table">
                                            <tr>
                                                <td class="size33 regist-label">박람회 당일 면접참가여부<span class="require">*</span></td>
                                                <td colspan="2">
                                                    <table>
                                                        <tr>
                                                            <td>
                                                                <input id="isJoin1" type="radio" class="radio" name="isJoin" value="1"/>
                                                            </td>
                                                            <td>
                                                                <label for="isJoin1">가능</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                            </td>
                                                            <td>
                                                                <input id="isJoin2" type="radio" class="radio" name="isJoin" value="2"/>
                                                            </td>
                                                            <td>
                                                                <label for="isJoin2">불가능</label>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>                                            
                                            </tr>
                                        </table>
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
<script language="javascript" type="text/javascript">

function SetJobType(no,value)
{
    $('input:[name=hopejob_'+no+']').val(value);
}

$(document).ready(function() {
    jQuery.CreateInit();
	// 이력서가 있는 경우 값 세팅
	var companyNo1 = '<%= GetResumeEntityValue("CompanyNo1") %>';
	var companyNo2 = '<%= GetResumeEntityValue("CompanyNo2") %>';
	var companyNo3 = '<%= GetResumeEntityValue("CompanyNo3") %>';
	var hopeSalary = '<%= GetResumeEntityValue("HopeSalary") %>';
	var cityNo1 = '<%= GetResumeEntityValue("CityNo1") %>';
	var arrayNo1 = '<%= GetResumeEntityValue("ArrayNo1") %>';
	var cityNo2 = '<%= GetResumeEntityValue("CityNo2") %>';
	var arrayNo2 = '<%= GetResumeEntityValue("ArrayNo2") %>';
	var hopeRecruitDate = new Date(<%= GetResumeEntityValue("HopeRecruitDateYear") %>, <%= GetResumeEntityValue("HopeRecruitDateMonth") %>-1, <%= GetResumeEntityValue("HopeRecruitDateDay") %>);
	var businessCategoryNo = '<%= GetResumeEntityValue("BusinessCategoryNo") %>';
	var category1No = '<%= GetResumeEntityValue("Category1No") %>';
	var category2No = '<%= GetResumeEntityValue("Category2No") %>';
	var categoryEtc = '<%= GetResumeEntityValue("CategoryEtc") %>'
	var joinType = '<%= GetResumeEntityValue("JoinType") %>';
	
	$("input[name=hopejob_1]").val(companyNo1);
	$("input[name=hopejob_2]").val(companyNo2);
	$("input[name=hopejob_3]").val(companyNo3);
	$("input[name=pay]").val(hopeSalary);
	$("select[name=location1_1]").val(cityNo1);
	if ( cityNo1 != "" )
		$.FillCategory(cityNo1,$("select[name=location2_1]"),function() {setTimeout(function() {$("select[name=location2_1]").val(arrayNo1);}, 100);});
	$("select[name=location1_2]").val(cityNo2);
	if ( cityNo2 != "" )
		$.FillCategory(cityNo2,$("select[name=location2_2]"),function() {setTimeout(function() {$("select[name=location2_2]").val(arrayNo2);}, 100);});
	$("select[name=year]").val(hopeRecruitDate.getFullYear());
	$("select[name=month]").val(hopeRecruitDate.getMonth());
	$("select[name=day]").val(hopeRecruitDate.getDate());
	$("select[name=hope_job_category1_1]").val(businessCategoryNo);
	$("select[name=hope_job_category2_1]").val(category1No);
	$("input[name=hope_job_category_etc]").val(categoryEtc);
	if ( category1No != "" )
		$.FillCategory(category1No,$("select[name=hope_job_category2_2]"),function() {setTimeout(function() {$("select[name=hope_job_category2_2]").val(category2No);$("select[name=hope_job_category2_2]").change();}, 100);});
	
	$("input[name=isJoin]").each(function() {
		if ( $(this).val() == joinType )
		{
			$(this).attr("checked", "checked");
		}
		else
		{
			$(this).attr("checked", "");
		}
	});

	$("div.tab ul li:eq(0)").click(function() { location.href=GetURL("/user/human_regist_basic.aspx"); });
	$("div.tab ul li:eq(1)").click(function() { location.href=GetURL("/user/human_regist_detail_kr.aspx"); });
	$("div.tab ul li:eq(2)").click(function() { location.href=GetURL("/user/human_regist_detail_cn.aspx"); });
	$("div.tab ul li:eq(3)").click(function() { location.href=GetURL("/user/human_regist_detail_en.aspx"); });
});
(function($){
    $.extend({
        FillCategory : function(category1No,targetCategory,afterFillFunc)
        {            
            Site.Web.Soap.Category.GetSubCategory(category1No, 
            function(results, context, methodNames){
	            targetCategory.find("option").remove(); 
                $.each(results,function(i){                     
                    targetCategory.append($("<option value='"+this.SubCategoryNo+"'>"+ $.SubCategoryLangName(this)+"</option>"));                    
                })
                
                if (afterFillFunc != undefined)
                {
					afterFillFunc();
                }
            },
            function(results, context, methodNames){
                alert( results.get_message() );
            });
        },
        CreateInit:function()
        {
            $("select[name=location1_1]").change(function(){
                if($(this).val())                
                    $.FillCategory($(this).val(),$("select[name=location2_1]"));
            }).change();
            
            $("select[name=location1_2]").change(function(){
                if($(this).val())                
                    $.FillCategory($(this).val(),$("select[name=location2_2]"));
            }).change();
            
            /*
            $("select[name=hope_job_category2_2]").change(function() {
                alert( this.options.length );
				if (this.options[this.selectedIndex].innerHTML == "직접입력")
					$("input[name=hope_job_category_etc]").show();
				else
					$("input[name=hope_job_category_etc]").hide();
            });
            */
            
            $("select[name=hope_job_category2_1]").change(function() {
				if ($(this).val())
					$.FillCategory($(this).val(),$("select[name=hope_job_category2_2]"),function() {$("select[name=hope_job_category2_2]").change();});
			    if ( this.options[this.selectedIndex].text == "직접입력")
			    {
			        $("input[name=hope_job_category_etc]").show();
			        $("select[name=hope_job_category2_2]").hide();
			    }
				else
				{
					$("input[name=hope_job_category_etc]").hide();
					$("select[name=hope_job_category2_2]").show();
			    }
            }).change();
            
            $(".jobcode_select input").each(function(i){
                $(this).click(function(){
                    var popup = window.open('./company_search.aspx?no='+(i+1),'','width=380px,height=280px,menubar=no,toolbars=no,scrollbars=no','');                
                })                                
            })
        },        
        onWrite : function()
        {
            var 
            hopejob_1,
            hopejob_2,
            hopejob_3,
            pay,
            location1_1,
            location2_1,
            location1_2,
            location2_2,
            year,
            month,
            day,
            hope_job_category1_1,
            hope_job_category2_1,
            hope_job_category2_2,
            isJoin,
            agree;
            
            hopejob_1= $("input[name=hopejob_1]").val();
            hopejob_2= $("input[name=hopejob_2]").val();
            hopejob_3= $("input[name=hopejob_3]").val();
            pay= $("input[name=pay]").val();
            location1_1= $("select[name=location1_1]").val();
            location2_1= $("select[name=location2_1]").val();
            location1_2= $("select[name=location1_2]").val();
            location2_2= $("select[name=location2_2]").val();
            year= $("select[name=year]").val();
            month= $("select[name=month]").val();
            day= $("select[name=day]").val();
            hope_job_category1_1= $("select[name=hope_job_category1_1]").val();
            hope_job_category2_1= $("select[name=hope_job_category2_1]").val();
            hope_job_category2_2= $("select[name=hope_job_category2_2]").val();
            isJoin= $("input[name=isJoin]:checked").val();
            agree= $("input[name=agree]:checked").val();   
            
            if(hopejob_1==""){ alert("1지망 기업을 선택해주세요.");return;  }
            if(hopejob_2==""){ alert("2지망 기업을 선택해주세요.");return;  }
            if(hopejob_3==""){ alert("3지망 기업을 선택해주세요.");return;  }
            if(pay==""){ alert("희망급여를 입력해주세요.");return;  }
            if(year==""){ alert("날짜를 선택해주세요.");return;  }
            if(month==""){ alert("날짜를 선택해주세요.");return;  }
            if(day==""){ alert("날짜를 선택해주세요.");return;  }
            if(!isJoin){ alert("가입여부를 선택해주세요.");return;  }
            if(!agree){ alert("이력서 지원 동의사항을 확인해주세요.");return;  }
            
            $("form:eq(0)").submit();
        }
    });
})(jQuery);
</script>                        

</asp:Content>


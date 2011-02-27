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
                                <div class="regist">
                                    <div class="comment">
                                        귀하가 작성하신 이력서는 한국산업인력공단 해외취업국에 등록되어 취업박람회 참가 구인처 및 기타 구인처의 채용과 관련된 정보로만 활용됩니다.<br />  
                                        제출 후에도 지속적 관리를 통해 채용 연계 예정이오니 수정 및 보충 사항 있을 시, 재 제출하실 경우 교체 등록해드립니다.
                                    </div>
                                    <div class="regist-item">
                                        <div class="regist-header">1.희망지원 회사 코드 및 기타사항 <span class="desc">(채용정보 기업체 코드와 회사명을 확인 후,기입해 주시기 바랍니다.)</span></div>                                
                                        <table class="regist-table">
                                            <tr>
                                                <td class="size33 regist-label">1지망<span class="require">*</span></td>
                                                <td class="size33 regist-label">2지망<span class="require">*</span></td>
                                                <td class="size33 regist-label">3지망<span class="require">*</span></td>
                                            </tr>
                                            <tr class="jobcode_select">
                                                <td><input class="w1" type="text" readonly="true" name="hopejob_1"/></td>
                                                <td><input class="w1" type="text" readonly="true" name="hopejob_2"/></td>
                                                <td><input class="w1" type="text" readonly="true" name="hopejob_3"/></td>
                                            </tr>
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
												<option value="<%=item.CategoryNo %>"><%=item.CategoryKRName %></option>
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
												<option value="<%=item.CategoryNo %>"><%=item.CategoryKRName %></option>
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
                                                                 <%for ( int i = 1; i <= 12; i ++ ) { %>
										                            <option value="<%=i %>" ><%=i %></option> 
									                             <% } %>
                                                                </select>월
                                                            </td>
                                                            <td>
                                                                <select class="day" name="day">
                                                                <%for ( int i = 1; i <= 31; i ++ ) { %>
										                            <option value="<%=i %>" ><%=i %></option> 
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
												<option value="<%=item.CategoryNo %>"><%=item.CategoryKRName %></option>
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
												<option value="<%=item.CategoryNo %>"><%=item.CategoryKRName %></option>
<% } %>
<% } %>
                                                                </select>
                                                            </td>
                                                            <td>
                                                                <select name="hope_job_category2_2">
                                                                    <% if (JobCategory != null)
   { %>
<% foreach (CategoryEntity item in JobCategory)
   { %>
												<option value="<%=item.CategoryNo %>"><%=item.CategoryKRName %></option>
<% } %>
<% } %>
                                                                </select>
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

<script language="javascript" type="text/javascript">

function SetJobType(no,value)
{
    $('input:[name=hopejob_'+no+']').val(value);
}

jQuery(function()
{
    jQuery.CreateInit();
});

(function($){
    $.extend({
        FillCategory : function(category1No,targetCategory)
        {            
            targetCategory.html('');            
            Site.Web.Soap.Category.GetSubCategory(category1No, 
            function(results, context, methodNames){
                $.each(results,function(i){                     
                    targetCategory.append($("<option value='"+this.SubCategoryNo+"'>"+ $.SubCategoryLangName(this)+"</option>"));                    
                })
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


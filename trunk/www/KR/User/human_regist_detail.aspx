<%@ Page Language="C#"  MasterPageFile="~/KR/WebMaster/UserMaster.master" AutoEventWireup="true" CodeFile="human_regist_detail.aspx.cs" Inherits="KR_User_human_regist_detail" %>
<%@ Import Namespace="Com.Library.DB.Category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/kr/Css/human.css" />
<script language="javascript" type="text/javascript">
(function($)
{
	$.translateHelper.getText = function(transCode) {
		return $.translateHelper.getTextCore(<%= (byte)CountryCode %>, transCode);
	}
})(jQuery);
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
<input type="text" name="ResumeNo" value=""/>
    <div class="title">
        <div class="human-title-regist"></div>
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
                                <img class="picture" width="104px" height="138px" src="<%=UserInfo.ImageUrl %>" />
                            </td>
                            <td class="size-k-1-2 regist-label"><%= GetText("KR_user_human_regist_detail.aspx_37") %></td>
                            <td class="size-k-1-3"><%=UserInfo.KRName %></td>
                            <td class="size-k-1-4 regist-label"><%= GetText("KR_user_human_regist_detail.aspx_39")%><span class="require">*</span></td>
                            <td class="size-k-1-5">
                                <table>
                                    <tr>
                                        <td><input style="width:120px;" type="password" name="ssn1" /></td>
                                        <td style="text-align:center;padding:0 2px;">-</td>
                                        <td><input style="width:120px;" type="password" name="ssn2" /></td>
                                    </tr>
                                </table>                                
                            </td>                                                    
                        </tr>
                        <tr>
                            <td class="regist-label"><%= GetText("KR_user_human_regist_detail.aspx_51")%></td>
                            <td><%=UserInfo.CNName %></td>
                            <td class="regist-label"><%= GetText("KR_user_human_regist_detail.aspx_53")%><span class="require">*</span></td>
                            <td>
                                <table>
                                    <tr>
                                        <td><input type="text" class="w3" name="korean_age"/><%= GetText("KR_user_human_regist_detail.aspx_57")%></td>
                                        <td>(<%= GetText("KR_user_human_regist_detail.aspx_58") %><input type="text" class="w3" name="age" /><%= GetText("KR_user_human_regist_detail.aspx_57")%>)</td>
                                    </tr>
                                </table>
                            </td>                                                    
                        </tr>
                        <tr>
                            <td class="regist-label"><%= GetText("KR_user_human_regist_detail.aspx_64")%></td>
                            <td><%=UserInfo.ENGName %></td>
                            <td class="regist-label"><%= GetText("KR_user_human_regist_detail.aspx_66")%><span class="require">*</span></td>
                            <td>
                                <table>
                                <tr>
                                    <td>
                                        <select class="year" name="inchina_year">
                                            <%for (int i = 0; i <= 10; ++i)
                                              { %>
                                                <option value="<%=i %>"><%=i %></option>
                                            <%} %>
                                        </select><%= GetText("KR_user_human_regist_detail.aspx_76")%>
                                    </td>
                                    <td>
                                        <select class="month" name="inchina_month">
                                            <%for (int i = 1; i <= 11; ++i)
                                              { %>
                                                <option value="<%=i %>"><%=i %></option>
                                            <%} %>
                                        </select><%= GetText("KR_user_human_regist_detail.aspx_84")%>
                                    </td>
                                </tr>
                            </table>
                            </td>                                                                                                    
                        </tr>
                        <tr>
                            <td class="regist-label"><%= GetText("KR_user_human_regist_detail.aspx_91")%></td>
                            <td><%=UserInfo.KRPhoneNo %></td>
                            <td class="regist-label"><%= GetText("KR_user_human_regist_detail.aspx_93")%></td>
                            <td>131-1111-1131</td>                                                                                                    
                        </tr>
                        <tr>
                            <td class="regist-label"><%= GetText("KR_user_human_regist_detail.aspx_97")%></td>
                            <td><%=UserInfo.ResidanceCountry %></td>
                            <td class="regist-label"><%= GetText("KR_user_human_regist_detail.aspx_99")%><span class="require">*</span></td>
                            <td>
                                <table>
                                    <tr>
                                        <td>
                                            <input id="army1" type="radio" class="radio" name="army" value="1"/>
                                        </td>
                                        <td>
                                            <label for="army1"><%= GetText("KR_user_human_regist_detail.aspx_107")%></label>
                                        </td>
                                        <td>
                                            <input id="army2" type="radio" class="radio" name="army" value="2"/>
                                        </td>
                                        <td>
                                            <label for="army2"><%= GetText("KR_user_human_regist_detail.aspx_113")%></label>
                                        </td>
                                        <td>
                                            <input id="army3" type="radio" class="radio" name="army" value="3"/>
                                        </td>
                                        <td>
                                            <label for="army3"><%= GetText("KR_user_human_regist_detail.aspx_119")%></label>
                                        </td>
                                    </tr>
                                </table>
                            </td>                                                                                                    
                        </tr>
                        <tr>
                            <td class="regist-label"><%= GetText("KR_user_human_regist_detail.aspx_126")%></td>
                            <td><%=UserInfo.Email %></td>
                            <td class="regist-label"><%= GetText("KR_user_human_regist_detail.aspx_128")%><span class="require">*</span></td>
                            <td>
                                <table>
                                    <tr>
                                        <td>
                                            <input id="isCareer1" type="radio" class="radio" name="isCareer" value="1"/>
                                        </td>
                                        <td>
                                            <label for="isCareer1"><%= GetText("KR_user_human_regist_detail.aspx_136")%></label>
                                        </td>
                                        <td>
                                            <input id="isCareer2" type="radio" class="radio" name="isCareer" value="2"/>
                                        </td>
                                        <td>
                                            <label for="isCareer2"><%= GetText("KR_user_human_regist_detail.aspx_142")%></label>
                                        </td>
                                    </tr>
                                </table>
                            </td>                                                                                                    
                        </tr>
                        <tr>
                            <td class="regist-label" colspan="2"><%= GetText("KR_user_human_regist_detail.aspx_149")%><span class="require">*</span></td>
                            <td colspan="3">
                                <input type="text" name="address" class="w100"/>
                            </td>                                 
                        </tr>
                    </table>
                </div>
                
                <div class="regist-item">
                    <div class="regist-header">2.<%= GetText("KR_user_human_regist_detail.aspx_158")%> <span class="desc"><%= GetText("KR_user_human_regist_detail.aspx_158_2")%></span></div>                                
                    <table class="regist-table">
                        <tr>
                            <td class="size-k-2-1 regist-label"><%= GetText("KR_user_human_regist_detail.aspx_161")%></td>
                            <td class="size-k-2-2 regist-label"><%= GetText("KR_user_human_regist_detail.aspx_162")%></td>
                            <td class="size-k-2-3 regist-label"><%= GetText("KR_user_human_regist_detail.aspx_163")%></td>
                            <td class="size-k-2-4 regist-label"><%= GetText("KR_user_human_regist_detail.aspx_164")%></td>
                            <td class="size-k-2-5 regist-label"><%= GetText("KR_user_human_regist_detail.aspx_165")%></td>                                                    
                        </tr>
                        <tr>
                           <td><input class="w100" name="education_school"/></td>
                           <td><input class="w4" name="education_period_start"/>&nbsp;-&nbsp;<input class="w4" name="education_period_end"/></td>
                           <td><select class="state" name="education_state">
                                <option value="0"><%= GetText("KR_user_human_regist_detail.aspx_graduate")%></option>
                           </select></td>
                           <td><input class="w100" name="education_major"/></td>
                           <td><input class="w100" name="education_national"/></td>
                        </tr>
                        <tr>
                           <td><input class="w100" name="education_school"/></td>
                           <td><input class="w4" name="education_period_start"/>&nbsp;-&nbsp;<input class="w4" name="education_period_end"/></td>
                           <td><select class="state" name="education_state">
                                <option value="0"><%= GetText("KR_user_human_regist_detail.aspx_graduate")%></option>
                           </select></td>
                           <td><input class="w100" name="education_major"/></td>
                           <td><input class="w100" name="education_national"/></td>
                        </tr>
                        <tr>
                           <td><input class="w100" name="education_school"/></td>
                           <td><input class="w4" name="education_period_start"/>&nbsp;-&nbsp;<input class="w4" name="education_period_end"/></td>
                           <td><select class="state" name="education_state">
                                <option value="0"><%= GetText("KR_user_human_regist_detail.aspx_graduate")%></option>
                           </select></td>
                           <td><input class="w100" name="education_major"/></td>
                           <td><input class="w100" name="education_national"/></td>
                        </tr>
                    </table>
                </div>
                
                <div class="regist-item">
                    <div class="regist-header">3.<%= GetText("KR_user_human_regist_detail.aspx_198")%></div>                                
                    <table class="regist-table">
                        <tr>
                            <td class="size-k-3-1 regist-label"><%= GetText("KR_user_human_regist_detail.aspx_201")%></td>
                            <td class="size-k-3-2 regist-label"><%= GetText("KR_user_human_regist_detail.aspx_202")%></td>
                            <td class="size-k-3-3 regist-label"><%= GetText("KR_user_human_regist_detail.aspx_203")%></td>
                            <td class="size-k-3-4 regist-label"><%= GetText("KR_user_human_regist_detail.aspx_204")%></td>                                             
                        </tr>
                        <tr>
                           <td><input class="w100" name="career_company"/></td>
                           <td><input class="w4" name="career_period_start"/>&nbsp;-&nbsp;<input class="w4" name="career_period_end"/></td>
                           <td><input class="w100" name="career_department"/></td>
                           <td><input class="w100" name="career_detail"/></td>
                        </tr>
                        <tr>
                           <td><input class="w100" name="career_company"/></td>
                           <td><input class="w4" name="career_period_start"/>&nbsp;-&nbsp;<input class="w4" name="career_period_end"/></td>
                           <td><input class="w100" name="career_department"/></td>
                           <td><input class="w100" name="career_detail"/></td>
                        </tr>
                        <tr>
                           <td><input class="w100" name="career_company"/></td>
                           <td><input class="w4" name="career_period_start"/>&nbsp;-&nbsp;<input class="w4" name="career_period_end"/></td>
                           <td><input class="w100" name="career_department"/></td>
                           <td><input class="w100" name="career_detail"/></td>
                        </tr>
                    </table>
                </div>
                
                <div class="regist-item">
                    <div class="regist-header">4.<%= GetText("KR_user_human_regist_detail.aspx_228")%></div>                                
                    <table class="regist-table">
                        <tr>
                            <td class="size-k-4-1 regist-label"><%= GetText("KR_user_human_regist_detail.aspx_231")%></td>
                            <td class="size-k-4-2 regist-label"><%= GetText("KR_user_human_regist_detail.aspx_232")%></td>
                            <td class="size-k-4-3 regist-label"><%= GetText("KR_user_human_regist_detail.aspx_233")%></td>
                            <td class="size-k-4-4 regist-label"><%= GetText("KR_user_human_regist_detail.aspx_234")%></td>                                             
                        </tr>
                        <tr>
                           <td><input class="w100" name="language_type"/></td>                                              
                           <td><input class="w100" name="language_testname"/></td>
                           <td><input class="w100" name="language_score"/></td>
                           <td>
                                <table>
                                    <tr>
                                        <td>
                                            <input id="languageLevel-1" type="radio" class="radio" name="language_level_1" value="1"/>
                                        </td>
                                        <td>
                                            <label for="languageLevel-1"><%= GetText("KR_user_human_regist_detail.aspx_languagegrade_high")%></label>
                                        </td>
                                        <td>
                                            <input id="languageLevel-2" type="radio" class="radio" name="language_level_1" value="2"/>
                                        </td>
                                        <td>
                                            <label for="languageLevel-2"><%= GetText("KR_user_human_regist_detail.aspx_languagegrade_middle")%></label>
                                        </td>
                                        <td>
                                            <input id="languageLevel-3" type="radio" class="radio" name="language_level_1" value="3"/>
                                        </td>
                                        <td>
                                            <label for="languageLevel-3"><%= GetText("KR_user_human_regist_detail.aspx_languagegrade_low")%></label>
                                        </td>
                                    </tr>
                                </table>
                           </td>
                        </tr>
                        <tr>
                           <td><input class="w100" name="language_type"/></td>                                              
                           <td><input class="w100" name="language_testname"/></td>
                           <td><input class="w100" name="language_score"/></td>
                           <td>
                                <table>
                                    <tr>
                                        <td>
                                            <input id="Radio1" type="radio" class="radio" name="language_level_2" value="1"/>
                                        </td>
                                        <td>
                                            <label for="languageLevel-1"><%= GetText("KR_user_human_regist_detail.aspx_languagegrade_high")%></label>
                                        </td>
                                        <td>
                                            <input id="Radio2" type="radio" class="radio" name="language_level_2" value="2"/>
                                        </td>
                                        <td>
                                            <label for="languageLevel-2"><%= GetText("KR_user_human_regist_detail.aspx_languagegrade_middle")%></label>
                                        </td>
                                        <td>
                                            <input id="Radio3" type="radio" class="radio" name="language_level_2" value="3"/>
                                        </td>
                                        <td>
                                            <label for="languageLevel-3"><%= GetText("KR_user_human_regist_detail.aspx_languagegrade_low")%></label>
                                        </td>
                                    </tr>
                                </table>
                           </td>
                        </tr>
                        <tr>
                           <td><input class="w100" name="language_type"/></td>                                              
                           <td><input class="w100" name="language_testname"/></td>
                           <td><input class="w100" name="language_score"/></td>
                           <td>
                                <table>
                                    <tr>
                                        <td>
                                            <input id="Radio4" type="radio" class="radio" name="language_level_3" value="1"/>
                                        </td>
                                        <td>
                                            <label for="languageLevel-1"><%= GetText("KR_user_human_regist_detail.aspx_languagegrade_high")%></label>
                                        </td>
                                        <td>
                                            <input id="Radio5" type="radio" class="radio" name="language_level_3" value="2"/>
                                        </td>
                                        <td>
                                            <label for="languageLevel-2"><%= GetText("KR_user_human_regist_detail.aspx_languagegrade_middle")%></label>
                                        </td>
                                        <td>
                                            <input id="Radio6" type="radio" class="radio" name="language_level_3" value="3"/>
                                        </td>
                                        <td>
                                            <label for="languageLevel-3"><%= GetText("KR_user_human_regist_detail.aspx_languagegrade_low")%></label>
                                        </td>
                                    </tr>
                                </table>
                           </td>
                        </tr>
                    </table>
                </div>
                
                <div class="regist-item">
                    <div class="regist-header">5.<%= GetText("KR_user_human_regist_detail.aspx_327")%></div>                                
                    <table class="regist-table">
                        <tr>
                            <td class="size-k-4-1 regist-label"><%= GetText("KR_user_human_regist_detail.aspx_330")%></td>
                            <td class="size-k-4-2 regist-label"><%= GetText("KR_user_human_regist_detail.aspx_331")%></td>
                            <td class="size-k-4-3 regist-label"><%= GetText("KR_user_human_regist_detail.aspx_332")%></td>                                         
                        </tr>
                        <tr>
                            <td><input class="w100" name="licence_year"/></td>                                              
                            <td><input class="w100" name="licence_title"/></td>
                            <td><input class="w100" name="licence_institution"/></td>
                        </tr>
                        <tr>
                            <td><input class="w100" name="licence_year"/></td>                                              
                            <td><input class="w100" name="licence_title"/></td>
                            <td><input class="w100" name="licence_institution"/></td>
                        </tr>
                        <tr>
                            <td><input class="w100" name="licence_year"/></td>                                              
                            <td><input class="w100" name="licence_title"/></td>
                            <td><input class="w100" name="licence_institution"/></td>
                        </tr>
                    </table>
                </div>
                
                <div class="regist-item">
                    <div class="regist-header">6.<%= GetText("KR_user_human_regist_detail.aspx_353")%> <span class="desc"><%= GetText("KR_user_human_regist_detail.aspx_353_2")%></span></div>                                
                    <textarea class="w100" rows="20" name="award_text"></textarea>
                </div>
                
                <div class="regist-item">
                    <div class="regist-header">7.<%= GetText("KR_user_human_regist_detail.aspx_358")%></div>                                
                    <textarea class="w100" rows="20" name="introduce"></textarea>
                </div>
                
                <div class="regist-item">
                    <div class="regist-tool">
                        <span class="agree">
                            <input class="checkbox" id="agree" name="agree" type="checkbox" />
                            <label for="agree"><%= GetText("KR_user_human_regist_detail.aspx_336")%></label>
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
jQuery(function()
{
	var countryCode = <%= (byte)CountryCode %>
    jQuery.CreateInit();

	$("div.tab ul li").removeClass("icon-folder-middle-on").addClass("icon-folder-middle-off").removeClass("select");
	$("div.tab ul li:eq("+ countryCode +")").removeClass("icon-folder-middle-off").addClass("icon-folder-middle-on").addClass("select");
	$("div.tab ul li:eq(0)").click(function() { location.href=GetURL("/user/human_regist_basic.aspx"); });
	$("div.tab ul li:eq(1)").click(function() { location.href=GetURL("/user/human_regist_detail.aspx?CountryCode=1"); });
	$("div.tab ul li:eq(2)").click(function() { location.href=GetURL("/user/human_regist_detail.aspx?CountryCode=2"); });
	$("div.tab ul li:eq(3)").click(function() { location.href=GetURL("/user/human_regist_detail.aspx?CountryCode=3"); });

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
	
	$("input[name=ssn1]").val(ssn1);
	$("input[name=ssn2]").val(ssn2);
	$("input[name=korean_age]").val(koreanAge);
	$("input[name=age]").val(age);
	$("select[name=inchina_year]").val(chinaExp[0]);
	$("select[name=inchina_month]").val(chinaExp[1]);
	$("input[name=army]").each(function() {
		if( $(this).val() == military )
		{
			$(this).attr("checked", "checked");
		}
		else
		{
			$(this).attr("checked", "");
		}
	});
	$("input[name=isCareer]").each(function() {
		if( $(this).val() == isCareer )
		{
			$(this).attr("checked", "checked");
		}
		else
		{
			$(this).attr("checked", "");
		}
	});
	$("input[name=address]").val(address);
	$("textarea[name=award_text]").val(description);
	$("textarea[name=introduce]").val(aboutMe);

    $.each(academicAbilities, function(idx, data) {
        $("input[name=education_school]:eq("+idx+")").val(data.SchoolName);
        $("input[name=education_period_start]:eq("+idx+")").val(formatDateTime(data.SchoolStartDate));
        $("input[name=education_period_end]:eq("+idx+")").val(formatDateTime(data.SchoolEndDate));
        $("select[name=education_state]:eq("+idx+")").val(data.SchoolStatus);
        $("input[name=education_major]:eq("+idx+")").val(data.MajorMinor);
        $("input[name=education_national]:eq("+idx+")").val(data.SchoolCountryName);
    });

    $.each(careers, function(idx, data) {
        $("input[name=career_company]:eq("+idx+")").val(data.CareerCompanyName);
        $("input[name=career_period_start]:eq("+idx+")").val(formatDateTime(data.CareerStartDate));
        $("input[name=career_period_end]:eq("+idx+")").val(formatDateTime(data.CareerEndDate));
        $("input[name=career_department]:eq("+idx+")").val(data.CareerJobs);
        $("input[name=career_detail]:eq("+idx+")").val(data.CareerPosition);
    });

    $.each(languages, function(idx, data) {
        $("input[name=language_type]:eq("+idx+")").val(data.LanguageName);
        $("input[name=language_testname]:eq("+idx+")").val(data.TestDesc);
        $("input[name=language_score]:eq("+idx+")").val(data.GradeDesc);
        $("input[name=language_level_"+(idx+1)+"]").each(function() {
            if( $(this).val() == data.ConversationLevel)
            {
                $(this).attr("checked", "checked");
            }
            else{
                $(this).attr("checked", "");
            }
        });
    });

    $.each(licenses, function(idx, data) {
        $("input[name=licence_year]:eq("+idx+")").val(formatDateTime(data.LicensedDate));
        $("input[name=licence_title]:eq("+idx+")").val(data.LicenseName);
        $("input[name=licence_institution]:eq("+idx+")").val(data.Organization);
    });
    
    function formatDateTime(date)
    {
		return date.getFullYear() + '-' + padLeft((date.getMonth()+1).toString(), 2, '0') + '-' + padLeft(date.getDate().toString(), 2, 0);
    }
    
    function padLeft(str, n, pad)
    {
		t = '';
		if(n>str.length){
			for(i=0;i < n-str.length;i++){
				t+=pad;
			}
		}
		return t+str;
    }
});

(function($){
    $.extend({
        CreateInit:function()
        {
        },        
        onWrite : function()
        {
            /* resume detail */
            var 
            ssn1,
            ssn2,
            age,
            korean_age,
            inchina_year,
            inchina_month,
            army,
            isCareer,
            address,
            agree,
            award_text,
            introduce;
            
            ssn1=$("input[name=ssn1]").val();
            ssn2=$("input[name=ssn2]").val();
            age=$("input[name=age]").val();
            korean_age=$("input[name=korean_age]").val();
            inchina_year=$("select[name=inchina_year]").val();
            inchina_month=$("select[name=inchina_month]").val();
            army=$("input[name=army]:checked").val();
            isCareer=$("input[name=isCareer]:checked").val();
            address=$("input[name=address]").val();
            agree=$("input[name=agree]:checked").val();
            award_text=$("textarea[name=award_text]").val();
            introduce=$("textarea[name=introduce]").val();
                        
            if(ssn1==""){ alert("주민등록번호를 입력해주세요.");return;  }
            if(ssn2==""){ alert("주민등록번호를 입력해주세요.");return;  }
            if(age==""){ alert("만 나이를 입력해 주세요.");return;  }
            if(korean_age==""){ alert("나이를 입력해 주세요.");return;  }
            if(address==""){ alert("주소를 입력해 주세요.");return;  }
            if(award_text==""){ alert("보유기술 및 특기사항을 입력해 주세요.");return;  }
            if(introduce==""){ alert("자기소개서를 입력해 주세요.");return;  }
            if(!army){ alert("병역을 확인해주세요.");return;  }
            if(!isCareer){ alert("경력여부를 확인해주세요.");return;  }
            if(!agree){ alert("등록동의여부를 확인해주세요.");return;  }
            
            var education_school_count = 0;
            $("input[name=education_school]").each(function(){if($(this).val()!="")education_school_count++});
            if(education_school_count == 0){alert("학력을 하나이상 입력해 주세요"); return;}
            
            var language_type_count = 0;
            $("input[name=language_type]").each(function(){if($(this).val()!="")language_type_count++});
            if(language_type_count == 0){alert("외국어를 하나이상 입력해 주세요"); return;}
            
            $("form:eq(0)").submit();
        }
    });
})(jQuery);
</script>          

</asp:Content>
<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/SiteMaster.master" AutoEventWireup="true" CodeFile="company_modify.aspx.cs" Inherits="KR_Company_company_modify"%>

<%@ Import Namespace="Com.Library.DB.Category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/kr/css/company-join.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
<asp:ScriptManagerProxy ID="px" runat="server">
    <Services>
        <asp:ServiceReference Path="~/Soap/Company.asmx"></asp:ServiceReference>
    </Services>
</asp:ScriptManagerProxy>
                <div class="join">
					<div class="header manage-company">					
					</div>
					<br />
					<table>
					    <tr>
							<td class="label">기업코드</td>
							<td class="input">
								<span class="highlight"><%=CompanyInfo.CompanyNo.ToString() %></span>
							</td>
						</tr>
						<tr>
							<td class="label">로고이미지</td>
							<td class="input">
								<table>
								    <tr>
								        <image class="company-logo" src="<%=CompanyDetailInfo.CompanyImage %>" alt=""/>
								    </tr>
									<tr>
										<td><input class="w3" type="File" name="logo"></input></td>
										<td class="description">로고사이즈는 325*115px이며,JPG,GIF,PNG만 가능합니다.</td>
									</tr>
								</table>								
							</td>
						</tr>
						<tr>
							<td class="label">기업명<span class="require">*</span></td>
							<td class="input">
								<table class="sub-table">
									<tr>
										<td class="sub-label">국문</td>
										<td class="sub-input"><input class="w2" type="text" name="koreaName" value="<%=CompanyDetailInfo.KRName %>" /></td>
										<td class="description" rowspan="3">
											사업자등록증(영업집조)에 등록된 정규적인 회사명을 입력하는것을 추천하며,<br/>
											국문,중문,영문 중 반드시 하나 이상 기입하셔야 합니다.
										</td>
									</tr>
										<td class="sub-label">중문</td>
										<td class="sub-input"><input class="w2" type="text" name="chinaName" value="<%=CompanyDetailInfo.CNName %>"/></td>
									</tr>
									</tr>
										<td class="sub-label">영문</td>
										<td class="sub-input"><input class="w2" type="text" name="englishName" value="<%=CompanyDetailInfo.ENGName %>"/></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label">사업자등록번호<span class="require">*</span></td>
							<td class="input">
								<%=CompanyDetailInfo.PermitNo %>
							</td>
						</tr>
						<tr>
							<td class="label">아이디<span class="require">*</span></td>
							<td class="input">
								<%=CompanyInfo.CompanyID%>
							</td>
						</tr>
						<tr>
							<td class="label">비밀번호<span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w2" type="text" name="password"></input></td>
										<td class="description">영문,숫자 또는 조합 4~12자리</td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label">비밀번호확인<span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w2" type="text" name="password_confirm"></input></td>
										<td class="description">비밀번호를 다시 한번 입력해 주세요</td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label">이메일<span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w3" type="text" name="email"  value="<%=CompanyDetailInfo.Email %>"/></td>
										<td><a href="javascript:;" class="icon icon-duplicate-check" id="aEmail"></a></td>
										<td class="description"><span id="spEmail">가장 자주 쓰는 이메일 하나만 입력하세요</span></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label">업종<span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td>
											<select class="w3" name="jobType">
												<option value="0">업종선택---------------------------</option> 
<% if (BusinessCategoryList != null) { %>
<% foreach (CategoryEntity item in BusinessCategoryList)
   { %>
												<option value="<%=item.CategoryNo %>" <%=item.CategoryNo == CompanyDetailInfo.BusinessCategoryNo ? "selected='selected'" : "" %>><%=item.CategoryKRName %></option>
<% } %>
<% } %>
											</select>
										</td>
										<td>
										    <input class="w2 hide" name="jobType_etc" value="<%= CompanyDetailInfo.BusinessCategoryEtc%>" />
										</td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label">대표자명<span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w2" type="text" name="representative" value="<%=CompanyDetailInfo.PresidentName%>"/></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label">기업유형<span class="require">*</span></td>
							<td class="input">
								<table>
									<tr class="radio">
										<td>
											<input class="radio" type="radio" name="company_type" value="135" id="company_type_1" <%=CompanyDetailInfo.CapitalType==135?"checked='checked'":"" %> />
										</td>
										<td>
											<label for="company_type_1">외자</label>
										</td>											
										<td>
											<input class="radio" type="radio" name="company_type" value="136" id="company_type_2" <%=CompanyDetailInfo.CapitalType==136?"checked='checked'":"" %> />
										</td>
										<td>
											<label for="company_type_2">독자</label>
										</td>
										<td>
											<input class="radio" type="radio" name="company_type" value="137" id="company_type_3" <%=CompanyDetailInfo.CapitalType==137?"checked='checked'":"" %> />
										</td>
										<td>
											<label for="company_type_3">합자</label>
										</td>
										<td>
											<input class="radio" type="radio" name="company_type" value="138" id="company_type_4" <%=CompanyDetailInfo.CapitalType==138?"checked='checked'":"" %> />
										</td>
										<td>
											<label for="company_type_4">기타</label>
										</td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label">설립년도<span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w1" type="text" name="build_date" value="<%=CompanyDetailInfo.FoundYear %>"></td>
										<td>년</td>
										<td class="description">숫자만 입력</td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label">사원수</td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w1" type="text" name="employ_count" value="<%=CompanyDetailInfo.EmployeeCount %>"></td>
										<td>명</td>
										<td class="description">숫자만 입력</td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label">자본금</td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w1" type="text" name="fund" value="<%=CompanyDetailInfo.Capital %>"></td>
										<td>
											<select class="w1" name="fundcurrency">
												<option value="0" <%=CompanyDetailInfo.CapitalCurrencyNo == 0 ? "selected='selected'":"" %>>화폐단위</option>
												<option value="186" <%=CompanyDetailInfo.CapitalCurrencyNo == 186 ? "selected='selected'":"" %>>원화</option>
												<option value="187" <%=CompanyDetailInfo.CapitalCurrencyNo == 187 ? "selected='selected'":"" %>>RMB</option>
												<option value="188" <%=CompanyDetailInfo.CapitalCurrencyNo == 188 ? "selected='selected'":"" %>>달러</option>
											</select>
										</td>
										<td class="description">숫자만 입력</td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label">매출액</td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w1" type="text" name="investment" value="<%=CompanyDetailInfo.Turnover %>"></td>
										<td>
											<select class="w1" name="investment_currency">
												<option value="0" <%=CompanyDetailInfo.TurnoverCurrencyNo == 0 ? "selected='selected'":"" %>>화폐단위</option> 
												<option value="186" <%=CompanyDetailInfo.TurnoverCurrencyNo == 186 ? "selected='selected'":"" %>>원화</option>
												<option value="187" <%=CompanyDetailInfo.TurnoverCurrencyNo == 187 ? "selected='selected'":"" %>>RMB</option>
												<option value="188" <%=CompanyDetailInfo.TurnoverCurrencyNo == 188 ? "selected='selected'":"" %>>달러</option>
											</select>
										</td>
										<td class="description">숫자만 입력</td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label">주요사업 내용<span class="require">*</span><br/>(기업소개)</td>
							<td class="input">
								<table>
									<tr>
										<td><textarea cols="100" rows="8" name="business_description"><%=CompanyDetailInfo.CompanyDescrition%></textarea></td>
									</tr>
									<tr>
										입력 예)재중 한인업체 및 개인의 구인/구직서비스,헤드헌팅,채용대행.
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label">채용담당자<span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w2" type="text" name="recruiting_manager" value="<%=CompanyDetailInfo.RecruiterName %>" /></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label">회사 전화번호<span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w2" type="text" name="phone" value="<%=CompanyDetailInfo.PhoneNo %>"/></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label">회사 팩스번호<span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w2" type="text" name="fax" value="<%=CompanyDetailInfo.FaxNo %>"/></input></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label">기업본사주소<span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w4" type="text" name="address" value="<%=CompanyDetailInfo.HeadAddress %>"/></input></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr class="bottom">
							<td class="label">홈페이지</td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w3" type="text" name="homepage"  value="<%=CompanyDetailInfo.HomepageURL %>" /></td>
										<td class="description">예)http://www.chinajobgo.com</td>
									</tr>
								</table>
							</td>
						</tr>
					</table>
					<div class="agree"><input class="checkbox" type="checkbox" name="agree"> 상기 기업소개 내용이 틀림없는 사실임을 확인합니다.</div>
					<div class="submit"><a href="#" onclick="jQuery.Submit(); return false;" class="icon icon-company-join"></a></div>
				</div>
<script language="javascript" type="text/javascript">
jQuery(function()
{
    jQuery.CreateInit();
});

(function($)
{
    var Email = "<%=CompanyDetailInfo.Email %>";
    $.extend({
        CreateInit : function()
        {
             $("select:[name=jobType]").change(function(){
                if($(this).val()=='42')
                    $("input:[name=jobType_etc]").show();
                else
                    $("input:[name=jobType_etc]").hide();
            }).change();
        
            $("input:[name=companyNo]").bind("keypress", function() {
                PermitNo = "";
            });
            $("input:[name=companyID]").bind("keypress", function() {
                CompanyID = "";
            });
            $("input:[name=email]").bind("keypress", function() {
                Email = "";
            });

            $("#aEmail").click(function()
            {
                $.IsEmail();
                return false;
            });
        },
        
        IsEmail : function()
        {
            var email = $("input:[name=email]").val();
            if ( email.indexOf("@") == -1 )
            {
                $("#spEmail").html("이메일 형식이 아닙니다.");
                return false;
            }
            
            if ( email.indexOf(".") == -1 )
            {
                $("#spEmail").html("이메일 형식이 아닙니다.");
                return false;
            }
            
            Site.Web.Soap.Company.IsEmail(email, 
            function(results, context, methodNames){
                if ( results.CompanyNo != 0 )
                {
                    $("#spEmail").html("존재하는 이메일주소입니다.");
                }
                else
                {
                    Email = $("input:[name=email]").val();
                    $("#spEmail").html("등록가능한 이메일주소입니다.");
                }
            },
            function(results, context, methodNames){
                alert( results.get_message() );
            });
        },
        
        IsPermitNo : function()
        {
            var permitNo;
            permitNo = $("input:[name=companyNo]").val();
            if ( permitNo.length < 4 )
            {
                $("#spCompanyNo").html("사업자등록번호를 입력하세요");
                return false;
            }
            
            Site.Web.Soap.Company.IsPermitNo(permitNo, 
            function(results, context, methodNames){
                if ( results.CompanyNo != 0 )
                {
                    $("#spCompanyNo").html("존재하는 사업자등록번호입니다.");
                }
                else
                {
                    PermitNo = $("input:[name=companyNo]").val();
                    $("#spCompanyNo").html("등록가능한 사업자등록번호입니다.");
                }
            },
            function(results, context, methodNames){
                alert( results.get_message() );
            });
        },
        
        IsCompanyID : function()
        {
            var companyID;
            var ch = "abcdefghijklmnopqrstuvwxyz_1234567890";
            companyID = $("input:[name=companyID]").val();
            if ( companyID.length < 4 )
            {
                $("#spCompanyID").html("영문,숫자 또는 조합4~12자리,특수문자 불가");
                return false;
            }
            for ( var i = 0; i < companyID.length; i ++ )
            {
                if ( companyID.charAt( i ) > 255 )
                {
                    $("#spCompanyID").html("영문,숫자 또는 조합4~12자리,특수문자 불가");
                    return false;
                }
                var b = false;
                for( var j = 0; j < ch.length; j ++ )
                {
                    if ( companyID.charAt( i ) != ch.charAt(j) )
                    {
                        b = true;
                    }
                    else
                    {
                        b = false;
                        break;
                    }
                }
                if ( b )
                {
                    $("#spCompanyID").html("아이디에 사용할수 없는 문자가 있습니다.");
                    return false;
                }
            }
            Site.Web.Soap.Company.IsCompanyID(companyID, 
            function(results, context, methodNames){
                if ( results.CompanyNo != 0 )
                {
                    $("#spCompanyID").html("사용중인 아이디입니다.");
                }
                else
                {
                    CompanyID = $("input:[name=companyID]").val();
                    $("#spCompanyID").html("등록가능한 아이디입니다.");
                }
            },
            function(results, context, methodNames){
                alert( results.get_message() );
            });
        },
        
        Submit : function()
        {
            var koreaName, chinaName, englishName;
            var companyNo, companyID, password, password_confirm;
            var email, jobType, jobType_etc, representative, company_type, build_date;
            var employ_count, fundcurrency, investment;
            var business_description, recruiting_manager, phone, fax, address, homepage;
            
            
            company_type = "0";
            $("input:[name=company_type]").each(function()
            {
                if ( $(this).attr("checked") )
                    company_type = $(this).val();
            });
            
            if ( Email == "" )
            {
                alert( "이메일 중복 체크를 해주세요" );
                return false;
            }
            
            $("input:[name=employ_count]").val(parseInt($("input:[name=employ_count]").val(), 10 ));
            $("input:[name=fundcurrency]").val(parseInt($("input:[name=fundcurrency]").val(), 10 ));
            $("input:[name=fund]").val(parseInt($("input:[name=fund]").val(), 10 ));
            $("input:[name=investment]").val(parseInt($("input:[name=investment]").val(), 10 ));
            
            koreaName = $("input:[name=koreaName]").val();
            chinaName = $("input:[name=chinaName]").val();
            englishName = $("input:[name=englishName]").val();
            
            companyNo = $("input:[name=companyNo]").val();
            companyID = $.trim($("input:[name=companyID]").val());
            password = $.trim($("input:[name=password]").val());
            password_confirm = $.trim($("input:[name=password_confirm]").val());
            
            email = $("input:[name=email]").val();
            representative = $("input:[name=representative]").val();
            build_date = $("input:[name=build_date]").val();
            jobType = $("select:[name=jobType]").val();
            jobType_etc = $("input:[name=jobType_etc]").val();
            employ_count = $("input:[name=employ_count]").val();
            fundcurrency = $("input:[name=fundcurrency]").val();
            investment = $("input:[name=investment]").val();
            business_description = $("input:[name=business_description]").val();
            recruiting_manager = $("input:[name=recruiting_manager]").val();
            phone = $("input:[name=phone]").val();
            fax = $("input:[name=fax]").val();
            address = $("input:[name=address]").val();
            homepage = $("input:[name=homepage]").val();

            if (koreaName=="" && chinaName == "" && englishName == "" )
            {
                alert( "기업명은 1개이상 입력하셔야합니다.");
                return false;
            }
            
            if(companyNo == "" )
            {
                alert( "사업자등록번호를 입력하셔야합니다.");
                return false;
            }
            
            if ( password != "" )
            {
                if ( password != password_confirm )
                {
                    alert( "비밀번호확인이 틀립니다.");
                    return false;
                }
            }
            
            if ( email == "" )
            {
                alert( "이메일을 입력하세요");
                return false;
            }
            
            if ( jobType == "0" )
            {
                alert( "업종을 선택하세요" );
                return false;
            }
            
            if ( jobType == "42" )
            {
                if ( jobType_etc == "" )
                {
                    alert( "기타 업종을 입력하세요" );
                    return false;
                }
            }
            
            if ( company_type == "0" )
            {
                alert("기업유형을 선택하세요");
                return false;
            }
            
            if ( representative == "" )
            {
                alert( "설립일을 입력하세요");
                return false;
            }
            
            if ( business_description == "" )
            {
                alert( "주요사업 내용을입력하세요");
                return false;
            }
            
            if ( recruiting_manager == "" )
            {
                alert( "채용담당자를 입력하세요");
                return false;
            }
            
            if ( phone == "" )
            {
                alert( "회사 전화번호를 입력하세요");
                return false;
            }
            
            if ( fax == "" )
            {
                alert( "팩스번호를 입력하세요");
                return false;
            }
            
            if ( address == "" )
            {
                alert( "본사주소를 입력하세요");
                return false;
            }
            
            if ( !$("input:[name=agree]").attr("checked") )
            {
                alert( "사실확인을 하셔야합니다.");
                return false;
            }
            $("form:eq(0)").submit();
        }
    });
})(jQuery);

</script>
</asp:Content>


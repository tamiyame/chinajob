<%@ Page Language="C#" MasterPageFile="~/CN/WebMaster/SiteMaster.master" AutoEventWireup="true" CodeFile="company_modify.aspx.cs" Inherits="CN_Company_company_modify"%>

<%@ Import Namespace="Com.Library.DB.Category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/cn/css/company-join.css" />
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
							<td class="label"><%= GetText("CN_Company_company_modify.aspx_19") %></td>
							<td class="input">
								<span class="highlight"><%=CompanyInfo.CompanyNo.ToString() %></span>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_modify.aspx_25")%></td>
							<td class="input">
								<table>
								    <tr>
								        <image class="company-logo" src="<%=CompanyDetailInfo.CompanyImage %>" alt=""/>
								    </tr>
									<tr>
										<td><input class="w3" type="File" name="logo"></input></td>
										<td class="description"><%= GetText("CN_Company_company_modify.aspx_33")%></td>
									</tr>
								</table>								
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_modify.aspx_39")%><span class="require">*</span></td>
							<td class="input">
								<table class="sub-table">
									<tr>
										<td class="sub-label"><%= GetText("CN_Company_company_modify.aspx_43")%></td>
										<td class="sub-input"><input class="w2" type="text" name="koreaName" value="<%=CompanyDetailInfo.KRName %>" /></td>
										<td class="description" rowspan="3">
											<%= GetText("CN_Company_company_modify.aspx_46")%>
										</td>
									</tr>
										<td class="sub-label"><%= GetText("CN_Company_company_modify.aspx_50")%></td>
										<td class="sub-input"><input class="w2" type="text" name="chinaName" value="<%=CompanyDetailInfo.CNName %>"/></td>
									</tr>
									</tr>
										<td class="sub-label"><%= GetText("CN_Company_company_modify.aspx_54")%></td>
										<td class="sub-input"><input class="w2" type="text" name="englishName" value="<%=CompanyDetailInfo.ENGName %>"/></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_modify.aspx_61")%><span class="require">*</span></td>
							<td class="input">
								<%=CompanyDetailInfo.PermitNo %>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_modify.aspx_67")%><span class="require">*</span></td>
							<td class="input">
								<%=CompanyInfo.CompanyID%>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_modify.aspx_73")%><span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w2" type="text" name="password"></input></td>
										<td class="description"><%= GetText("CN_Company_company_modify.aspx_78")%></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_modify.aspx_84")%><span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w2" type="text" name="password_confirm"></input></td>
										<td class="description"><%= GetText("CN_Company_company_modify.aspx_89")%></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_modify.aspx_95")%><span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w3" type="text" name="email"  value="<%=CompanyDetailInfo.Email %>"/></td>
										<td><a href="javascript:;" class="icon icon-duplicate-check" id="aEmail"></a></td>
										<td class="description"><span id="spEmail"><%= GetText("CN_Company_company_modify.aspx_101")%></span></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_modify.aspx_107")%><span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td>
											<select class="w3" name="jobType">
												<option value="0"><%= GetText("CN_Company_company_modify.aspx_113")%>---------------------------</option> 
<% if (BusinessCategoryList != null) { %>
<% foreach (CategoryEntity item in BusinessCategoryList)
   { %>
												<option value="<%=item.CategoryNo %>" <%=item.CategoryNo == CompanyDetailInfo.BusinessCategoryNo ? "selected='selected'" : "" %>><%=item.CategoryCNName %></option>
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
							<td class="label"><%= GetText("CN_Company_company_modify.aspx_130")%><span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w2" type="text" name="representative" value="<%=CompanyDetailInfo.PresidentName%>"/></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_modify.aspx_140")%><span class="require">*</span></td>
							<td class="input">
								<table>
									<tr class="radio">
										<td>
											<input class="radio" type="radio" name="company_type" value="135" id="company_type_1" <%=CompanyDetailInfo.CapitalType==135?"checked='checked'":"" %> />
										</td>
										<td>
											<label for="company_type_1"><%= GetText("CN_Company_company_modify.aspx_148")%></label>
										</td>											
										<td>
											<input class="radio" type="radio" name="company_type" value="136" id="company_type_2" <%=CompanyDetailInfo.CapitalType==136?"checked='checked'":"" %> />
										</td>
										<td>
											<label for="company_type_2"><%= GetText("CN_Company_company_modify.aspx_154")%></label>
										</td>
										<td>
											<input class="radio" type="radio" name="company_type" value="137" id="company_type_3" <%=CompanyDetailInfo.CapitalType==137?"checked='checked'":"" %> />
										</td>
										<td>
											<label for="company_type_3"><%= GetText("CN_Company_company_modify.aspx_160")%></label>
										</td>
										<td>
											<input class="radio" type="radio" name="company_type" value="138" id="company_type_4" <%=CompanyDetailInfo.CapitalType==138?"checked='checked'":"" %> />
										</td>
										<td>
											<label for="company_type_4"><%= GetText("CN_Company_company_modify.aspx_166")%></label>
										</td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_modify.aspx_173")%><span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w1" type="text" name="build_date" value="<%=CompanyDetailInfo.FoundYear %>"></td>
										<td><%= GetText("CN_Company_company_modify.aspx_178")%></td>
										<td class="description"><%= GetText("CN_Company_company_modify.aspx_number_only")%></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_modify.aspx_184")%></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w1" type="text" name="employ_count" value="<%=CompanyDetailInfo.EmployeeCount %>"></td>
										<td><%= GetText("CN_Company_company_modify.aspx_189")%></td>
										<td class="description"><%= GetText("CN_Company_company_modify.aspx_number_only")%></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_modify.aspx_197")%></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w1" type="text" name="fund" value="<%=CompanyDetailInfo.Capital %>"></td>
										<td>
											<select class="w1" name="fundcurrency">
												<option value="0" <%=CompanyDetailInfo.CapitalCurrencyNo == 0 ? "selected='selected'":"" %>><%= GetText("CN_Company_company_modify.aspx_currencyUnit")%></option>
												<option value="186" <%=CompanyDetailInfo.CapitalCurrencyNo == 186 ? "selected='selected'":"" %>><%= GetText("CN_Company_company_modify.aspx_currencyUnit_krw")%></option>
												<option value="187" <%=CompanyDetailInfo.CapitalCurrencyNo == 187 ? "selected='selected'":"" %>><%= GetText("CN_Company_company_modify.aspx_currencyUnit_rmb")%></option>
												<option value="188" <%=CompanyDetailInfo.CapitalCurrencyNo == 188 ? "selected='selected'":"" %>><%= GetText("CN_Company_company_modify.aspx_currencyUnit_usd")%></option>
											</select>
										</td>
										<td class="description"><%= GetText("CN_Company_company_modify.aspx_number_only")%></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_modify.aspx_216")%></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w1" type="text" name="investment" value="<%=CompanyDetailInfo.Turnover %>"></td>
										<td>
											<select class="w1" name="investment_currency">
												<option value="0" <%=CompanyDetailInfo.TurnoverCurrencyNo == 0 ? "selected='selected'":"" %>><%= GetText("CN_Company_company_modify.aspx_currencyUnit")%></option> 
												<option value="186" <%=CompanyDetailInfo.TurnoverCurrencyNo == 186 ? "selected='selected'":"" %>><%= GetText("CN_Company_company_modify.aspx_currencyUnit_krw")%></option>
												<option value="187" <%=CompanyDetailInfo.TurnoverCurrencyNo == 187 ? "selected='selected'":"" %>><%= GetText("CN_Company_company_modify.aspx_currencyUnit_rmb")%></option>
												<option value="188" <%=CompanyDetailInfo.TurnoverCurrencyNo == 188 ? "selected='selected'":"" %>><%= GetText("CN_Company_company_modify.aspx_currencyUnit_usd")%></option>
											</select>
										</td>
										<td class="description"><%= GetText("CN_Company_company_modify.aspx_number_only")%></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_modify.aspx_235")%><span class="require">*</span><br/>(<%= GetText("CN_Company_company_modify.aspx_235_1")%>)</td>
							<td class="input">
								<table>
									<tr>
										<td><textarea cols="100" rows="8" name="business_description"><%=CompanyDetailInfo.CompanyDescrition%></textarea></td>
									</tr>
									<tr>
										<%= GetText("CN_Company_company_modify.aspx_242")%>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_modify.aspx_248")%><span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w2" type="text" name="recruiting_manager" value="<%=CompanyDetailInfo.RecruiterName %>" /></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_modify.aspx_258")%><span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w2" type="text" name="phone" value="<%=CompanyDetailInfo.PhoneNo %>"/></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_modify.aspx_268")%><span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w2" type="text" name="fax" value="<%=CompanyDetailInfo.FaxNo %>"/></input></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_modify.aspx_278")%><span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w4" type="text" name="address" value="<%=CompanyDetailInfo.HeadAddress %>"/></input></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr class="bottom">
							<td class="label"><%= GetText("CN_Company_company_modify.aspx_288")%></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w3" type="text" name="homepage"  value="<%=CompanyDetailInfo.HomepageURL %>" /></td>
										<td class="description"><%= GetText("CN_Company_company_modify.aspx_293")%></td>
									</tr>
								</table>
							</td>
						</tr>
					</table>
					<div class="agree"><input class="checkbox" type="checkbox" name="agree"> <%= GetText("CN_Company_company_modify.aspx_299")%></div>
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
                $("#spEmail").html($.translateHelper.getText("CN_Company_company_modify.aspx_emailFormatInvalid"));
                return false;
            }
            
            if ( email.indexOf(".") == -1 )
            {
                $("#spEmail").html($.translateHelper.getText("CN_Company_company_modify.aspx_emailFormatInvalid"));
                return false;
            }
            
            Site.Web.Soap.Company.IsEmail(email, 
            function(results, context, methodNames){
                if ( results.CompanyNo != 0 )
                {
                    $("#spEmail").html($.translateHelper.getText("CN_Company_company_modify.aspx_emailExist"));
                }
                else
                {
                    Email = $("input:[name=email]").val();
                    $("#spEmail").html($.translateHelper.getText("CN_Company_company_modify.aspx_emailValid"));
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
                $("#spCompanyNo").html($.translateHelper.getText("CN_Company_company_modify.aspx_companyNoEmpty"));
                return false;
            }
            
            Site.Web.Soap.Company.IsPermitNo(permitNo, 
            function(results, context, methodNames){
                if ( results.CompanyNo != 0 )
                {
                    $("#spCompanyNo").html($.translateHelper.getText("CN_Company_company_modify.aspx_companyNoExist"));
                }
                else
                {
                    PermitNo = $("input:[name=companyNo]").val();
                    $("#spCompanyNo").html($.translateHelper.getText("CN_Company_company_modify.aspx_companyNoValid"));
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
                $("#spCompanyID").html($.translateHelper.getText("CN_Company_company_modify.aspx_companyIDFormatInvalid"));
                return false;
            }
            for ( var i = 0; i < companyID.length; i ++ )
            {
                if ( companyID.charAt( i ) > 255 )
                {
                    $("#spCompanyID").html($.translateHelper.getText("CN_Company_company_modify.aspx_companyIDFormatInvalid"));
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
                    $("#spCompanyID").html($.translateHelper.getText("CN_Company_company_modify.aspx_companyIDHasInvalidChar"));
                    return false;
                }
            }
            Site.Web.Soap.Company.IsCompanyID(companyID, 
            function(results, context, methodNames){
                if ( results.CompanyNo != 0 )
                {
                    $("#spCompanyID").html($.translateHelper.getText("CN_Company_company_modify.aspx_companyIDExist"));
                }
                else
                {
                    CompanyID = $("input:[name=companyID]").val();
                    $("#spCompanyID").html($.translateHelper.getText("CN_Company_company_modify.aspx_companyIDValid"));
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
                alert($.translateHelper.getText("CN_Company_company_modify.aspx_emailMustCheckDupe"));
                return false;
            }
            
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
                alert($.translateHelper.getText("CN_Company_company_modify.aspx_companyNameEmpty"));
                return false;
            }
            
            if(companyNo == "" )
            {
                alert($.translateHelper.getText("CN_Company_company_modify.aspx_companyNoEmpty"));
                return false;
            }
            
            if ( password != "" )
            {
                if ( password != password_confirm )
                {
                    alert($.translateHelper.getText("CN_Company_company_modify.aspx_passwordCheckNotMatch"));
                    return false;
                }
            }
            
            if ( email == "" )
            {
                alert($.translateHelper.getText("CN_Company_company_modify.aspx_emailEmpty"));
                return false;
            }
            
            if ( jobType == "0" )
            {
                alert($.translateHelper.getText("CN_Company_company_modify.aspx_jobTypeEmpty"));
                return false;
            }
            
            if ( jobType == "42" )
            {
                if ( jobType_etc == "" )
                {
                    alert($.translateHelper.getText("CN_Company_company_modify.aspx_etcTypeEmpty"));
                    return false;
                }
            }
            
            if ( company_type == "0" )
            {
                alert($.translateHelper.getText("CN_Company_company_modify.aspx_companyTypeEmpty"));
                return false;
            }
            
            if ( representative == "" )
            {
                alert($.translateHelper.getText("CN_Company_company_modify.aspx_representativeEmpty"));
                return false;
            }
            
            if ( business_description == "" )
            {
                alert($.translateHelper.getText("CN_Company_company_modify.aspx_descriptionEmpty"));
                return false;
            }
            
            if ( recruiting_manager == "" )
            {
                alert($.translateHelper.getText("CN_Company_company_modify.aspx_managerEmpty"));
                return false;
            }
            
            if ( phone == "" )
            {
                alert($.translateHelper.getText("CN_Company_company_modify.aspx_phoneEmpty"));
                return false;
            }
            
            if ( fax == "" )
            {
                alert($.translateHelper.getText("CN_Company_company_modify.aspx_faxEmpty"));
                return false;
            }
            
            if ( address == "" )
            {
                alert($.translateHelper.getText("CN_Company_company_modify.aspx_addressEmpty"));
                return false;
            }
            
            if ( !$("input:[name=agree]").attr("checked") )
            {
                alert($.translateHelper.getText("CN_Company_company_modify.aspx_agreeNotChecked"));
                return false;
            }
            $("form:eq(0)").submit();
        }
    });
})(jQuery);

</script>
</asp:Content>


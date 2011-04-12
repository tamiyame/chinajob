<%@ Page Language="C#" MasterPageFile="~/CN/WebMaster/SiteMaster.master" AutoEventWireup="true" CodeFile="company_join.aspx.cs" Inherits="CN_Company_company_join"%>

<%@ Import Namespace="Com.Library.DB.Category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/cn/css/company-join.css" />
<script language="javascript" src="/js/translateJs_cn_company.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">


<asp:ScriptManagerProxy ID="px" runat="server">
    <Services>
        <asp:ServiceReference Path="~/Soap/Company.asmx"></asp:ServiceReference>
    </Services>
</asp:ScriptManagerProxy>
                <div class="join">
					<div class="header">					
					</div>
					<br />
					<table>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_join.aspx_19")%></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w3" type="File" name="logo"></input></td>
										<td class="description"><%= GetText("CN_Company_company_join.aspx_24")%></td>
									</tr>
								</table>								
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_join.aspx_30")%><span class="require">*</span></td>
							<td class="input">
								<table class="sub-table">
									<tr>
										<td class="sub-label"><%= GetText("CN_Company_company_join.aspx_34")%></td>
										<td class="sub-input"><input class="w2" type="text" name="koreaName"/></td>
										<td class="description" rowspan="3">
											<%= GetText("CN_Company_company_join.aspx_37")%>
										</td>
									</tr>
										<td class="sub-label"><%= GetText("CN_Company_company_join.aspx_41")%></td>
										<td class="sub-input"><input class="w2" type="text" name="chinaName"/></td>
									</tr>
									</tr>
										<td class="sub-label"><%= GetText("CN_Company_company_join.aspx_45")%></td>
										<td class="sub-input"><input class="w2" type="text" name="englishName"/></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_join.aspx_52")%><span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w3" type="text" name="companyNo"></input></td>
										<td><a href="javascript:;" class="icon icon-duplicate-check" id="aCompanyNo"></a></td>
										<td class="description"><span id="spCompanyNo"></span></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_join.aspx_64")%></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w3" type="File" name="fiPermit"></input></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_join.aspx_74")%><span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w3" type="text" name="companyID"></input></td>
										<td><a href="javascript:;" class="icon icon-duplicate-check" id="aCompanyID"></a></td>
										<td class="description"><span id="spCompanyID"></span></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_join.aspx_86")%><span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w2" type="password" name="password"></input></td>
										<td class="description"><%= GetText("CN_Company_company_join.aspx_91")%></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_join.aspx_97")%><span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w2" type="password" name="password_confirm"></input></td>
										<td class="description"><%= GetText("CN_Company_company_join.aspx_102")%></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_join.aspx_108")%><span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w3" type="text" name="email"></input></td>
										<td><a href="javascript:;" class="icon icon-duplicate-check" id="aEmail"></a></td>
										<td class="description"><span id="spEmail"><%= GetText("CN_Company_company_join.aspx_114")%></span></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_join.aspx_120")%><span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td>
											<select class="w3" name="jobType">
												<option value="0"><%= GetText("CN_Company_company_join.aspx_126")%>---------------------------</option> 
<% if (BusinessCategoryList != null) { %>
<% foreach (CategoryEntity item in BusinessCategoryList)
   { %>
												<option value="<%=item.CategoryNo %>"><%=item.CategoryCNName %></option>
<% } %>
<% } %>
											</select>
										</td>
										<td>
										    <input class="w2 hide" name="jobType_etc" />
										</td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_join.aspx_143")%><span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w2" type="text" name="representative"></input></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_join.aspx_153")%><span class="require">*</span></td>
							<td class="input">
								<table>
									<tr class="radio">
										<td>
											<input class="radio" type="radio" name="company_type" value="135" id="company_type_1" />
										</td>
										<td>
											<label for="company_type_1"><%= GetText("CN_Company_company_join.aspx_161")%></label>
										</td>											
										<td>
											<input class="radio" type="radio" name="company_type" value="136" id="company_type_2" />
										</td>
										<td>
											<label for="company_type_2"><%= GetText("CN_Company_company_join.aspx_167")%></label>
										</td>
										<td>
											<input class="radio" type="radio" name="company_type" value="137" id="company_type_3" />
										</td>
										<td>
											<label for="company_type_3"><%= GetText("CN_Company_company_join.aspx_173")%></label>
										</td>
										<td>
											<input class="radio" type="radio" name="company_type" value="138" id="company_type_4" />
										</td>
										<td>
											<label for="company_type_4"><%= GetText("CN_Company_company_join.aspx_179")%></label>
										</td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_join.aspx_186")%><span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w1" type="text" name="build_date"></input></td>
										<td><%= GetText("CN_Company_company_join.aspx_191")%><span class="require"></td>
										<td class="description"><%= GetText("CN_Company_company_join.aspx_number_only")%></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_join.aspx_197")%></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w1" type="text" name="employ_count"></input></td>
										<td><%= GetText("CN_Company_company_join.aspx_202")%></td>
										<td class="description"><%= GetText("CN_Company_company_join.aspx_number_only")%></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_join.aspx_210")%></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w1" type="text" name="fund"></input></td>
										<td>
											<select class="w1" name="fundcurrency">
												<option value="0"><%= GetText("CN_Company_company_join.aspx_currencyUnit")%></option> 
												<option value="186"><%= GetText("CN_Company_company_join.aspx_currencyUnit_krw")%></option>
												<option value="187"><%= GetText("CN_Company_company_join.aspx_currencyUnit_rmb")%></option>
												<option value="188"><%= GetText("CN_Company_company_join.aspx_currencyUnit_usd")%></option>
											</select>
										</td>
										<td class="description"><%= GetText("CN_Company_company_join.aspx_number_only")%></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_join.aspx_229")%></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w1" type="text" name="investment"></input></td>
										<td>
											<select class="w1" name="investment_currency">
												<option value="0"><%= GetText("CN_Company_company_join.aspx_currencyUnit")%></option> 
												<option value="186"><%= GetText("CN_Company_company_join.aspx_currencyUnit_krw")%></option>
												<option value="187"><%= GetText("CN_Company_company_join.aspx_currencyUnit_rmb")%></option>
												<option value="188"><%= GetText("CN_Company_company_join.aspx_currencyUnit_usd")%></option>
											</select>
										</td>
										<td class="description"><%= GetText("CN_Company_company_join.aspx_number_only")%></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_join.aspx_248")%><span class="require">*</span><br/>(<%= GetText("CN_Company_company_join.aspx_248_1")%>)</td>
							<td class="input">
								<table>
									<tr>
										<td><textarea cols="100" rows="8" name="business_description"></textarea></td>
									</tr>
									<tr>
										<%= GetText("CN_Company_company_join.aspx_255")%>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_join.aspx_261")%><span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w2" type="text" name="recruiting_manager"></input></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_join.aspx_271")%><span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w2" type="text" name="phone"></input></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_join.aspx_281")%><span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w2" type="text" name="fax"></input></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td class="label"><%= GetText("CN_Company_company_join.aspx_291")%><span class="require">*</span></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w4" type="text" name="address"></input></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr class="bottom">
							<td class="label"><%= GetText("CN_Company_company_join.aspx_301")%></td>
							<td class="input">
								<table>
									<tr>
										<td><input class="w3" type="text" name="homepage"></input></td>
										<td class="description"><%= GetText("CN_Company_company_join.aspx_306")%></td>
									</tr>
								</table>
							</td>
						</tr>
					</table>
					<div class="agree"><input class="checkbox" type="checkbox" name="agree"> <%= GetText("CN_Company_company_join.aspx_312")%></div>
					<div class="submit"><a href="#" onclick="jQuery.Submit(); return false;" class="icon icon-company-join"></a></div>
				</div>
<script language="javascript" type="text/javascript">
jQuery(function()
{
    NumInput( $("input[name=investment]"));
    NumInput( $("input[name=fund]"));
    NumInput( $("input[name=employ_count]"));
    NumInput( $("input[name=build_date]"));
    jQuery.CreateInit();
});

(function($)
{
    var PermitNo = "";
    var CompanyID = "";
    var Email = "";
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
            
            $("#aCompanyNo").click(function()
            {
                $.IsPermitNo();
                return false;
            });
            
            $("#aCompanyID").click(function()
            {
                $.IsCompanyID();
                return false;
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
                $("#spEmail").html($.translateHelper.getText("CN_Company_company_join.aspx_emailFormatInvalid"));
                return false;
            }
            
            if ( email.indexOf(".") == -1 )
            {
                $("#spEmail").html($.translateHelper.getText("CN_Company_company_join.aspx_emailFormatInvalid"));
                return false;
            }
            
            Site.Web.Soap.Company.IsEmail(email, 
            function(results, context, methodNames){
                if ( results.CompanyNo != 0 )
                {
                    $("#spEmail").html($.translateHelper.getText("CN_Company_company_join.aspx_emailExist"));
                }
                else
                {
                    Email = $("input:[name=email]").val();
                    $("#spEmail").html($.translateHelper.getText("CN_Company_company_join.aspx_emailValid"));
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
                $("#spCompanyNo").html($.translateHelper.getText("CN_Company_company_join.aspx_companyNoEmpty"));
                return false;
            }
            
            Site.Web.Soap.Company.IsPermitNo(permitNo, 
            function(results, context, methodNames){
                if ( results.CompanyNo != 0 )
                {
                    $("#spCompanyNo").html($.translateHelper.getText("CN_Company_company_join.aspx_companyNoExist"));
                }
                else
                {
                    PermitNo = $("input:[name=companyNo]").val();
                    $("#spCompanyNo").html($.translateHelper.getText("CN_Company_company_join.aspx_companyNoValid"));
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
                $("#spCompanyID").html($.translateHelper.getText("CN_Company_company_join.aspx_companyIDFormatInvalid"));
                return false;
            }
            for ( var i = 0; i < companyID.length; i ++ )
            {
                if ( companyID.charAt( i ) > 255 )
                {
                    $("#spCompanyID").html($.translateHelper.getText("CN_Company_company_join.aspx_companyIDFormatInvalid"));
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
                    $("#spCompanyID").html($.translateHelper.getText("CN_Company_company_join.aspx_companyIDHasInvalidChar"));
                    return false;
                }
            }
            Site.Web.Soap.Company.IsCompanyID(companyID, 
            function(results, context, methodNames){
                if ( results.CompanyNo != 0 )
                {
                    $("#spCompanyID").html($.translateHelper.getText("CN_Company_company_join.aspx_companyIDExist"));
                }
                else
                {
                    CompanyID = $("input:[name=companyID]").val();
                    $("#spCompanyID").html($.translateHelper.getText("CN_Company_company_join.aspx_companyIDValid"));
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
            
            if ( PermitNo == "" )
            {
                alert( $.translateHelper.getText("CN_Company_company_join.aspx_companyNoMustCheckDupl"));
                return false;
            }
            
            if ( CompanyID == "" )
            {
                alert( $.translateHelper.getText("CN_Company_company_join.aspx_companyIDMustCheckDupl"));
                return false;
            }
            
            if ( Email == "" )
            {
                alert( $.translateHelper.getText("CN_Company_company_join.aspx_emailMustCheckDupe") );
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
                alert( $.translateHelper.getText("CN_Company_company_join.aspx_companyNameEmpty"));
                return false;
            }

            if ( companyID == "" )
            {
                alert( $.translateHelper.getText("CN_Company_company_join.aspx_idEmpty"));
                return false;
            }
            
            if ( companyID.length < 4 )
            {
                alert( $.translateHelper.getText("CN_Company_company_join.aspx_idLengthMustOver4"));
                return false;
            }
            
            if ( password == "" )
            {
                alert( $.translateHelper.getText("CN_Company_company_join.aspx_passwordEmpty"));
                return false;
            }
            
            if ( password != password_confirm )
            {
                alert( $.translateHelper.getText("CN_Company_company_join.aspx_passwordCheckNotMatch"));
                return false;
            }
            
            if ( email == "" )
            {
                alert( $.translateHelper.getText("CN_Company_company_join.aspx_emailEmpty"));
                return false;
            }
            
            
            if ( jobType == "0" )
            {
                alert( $.translateHelper.getText("CN_Company_company_join.aspx_jobTypeEmpty") );
                return false;
            }
            
            if ( jobType == "42" )
            {
                if ( jobType_etc == "" )
                {
                    alert( $.translateHelper.getText("CN_Company_company_join.aspx_etcTypeEmpty") );
                    return false;
                }
            }
            
            if ( company_type == "0" )
            {
                alert($.translateHelper.getText("CN_Company_company_join.aspx_companyTypeEmpty"));
                return false;
            }
            
            if ( build_date == "" )
            {
                alert( $.translateHelper.getText("CN_Company_company_join.aspx_buildDateEmpty"));
                return false;
            }
            
            
            if ( representative == "" )
            {
                alert( $.translateHelper.getText("CN_Company_company_join.aspx_representativeEmpty"));
                return false;
            }
            
            if ( business_description == "" )
            {
                alert( $.translateHelper.getText("CN_Company_company_join.aspx_descriptionEmpty"));
                return false;
            }
            
            if ( recruiting_manager == "" )
            {
                alert( $.translateHelper.getText("CN_Company_company_join.aspx_managerEmpty"));
                return false;
            }
            
            if ( phone == "" )
            {
                alert( $.translateHelper.getText("CN_Company_company_join.aspx_phoneEmpty"));
                return false;
            }
            
            if ( fax == "" )
            {
                alert( $.translateHelper.getText("CN_Company_company_join.aspx_faxEmpty"));
                return false;
            }
            
            if ( address == "" )
            {
                alert( $.translateHelper.getText("CN_Company_company_join.aspx_addressEmpty"));
                return false;
            }
            
            if ( !$("input:[name=agree]").attr("checked") )
            {
                alert( $.translateHelper.getText("CN_Company_company_join.aspx_agreeNotChecked"));
                return false;
            }
            $("form:eq(0)").submit();
        }
    });
})(jQuery);

</script>
</asp:Content>


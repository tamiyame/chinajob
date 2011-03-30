<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/RecruitMaster.master" AutoEventWireup="true" CodeFile="recruit_search.aspx.cs" Inherits="KR_Recruit_recruit_search" Title="Untitled Page" %>
<%@ Import Namespace="Com.Library.DB.Category" %>
<%@ Import Namespace="Com.Library.DB.Company" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
    <link rel="stylesheet" type="text/css" href="/ImgSrv/kr/Css/recruit.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
<asp:ScriptManagerProxy ID="px" runat="server">
    <Services>
        <asp:ServiceReference Path="~/Soap/Category.asmx"></asp:ServiceReference>
    </Services>
</asp:ScriptManagerProxy>
                        <div class="title">
                            <div class="recruit-title-search"></div>
                        </div>
                        <div class="contents">
                            <div class="tab" style="margin-bottom:20px;">
				                <ul>
					                <li class="select icon <%=CountryNo == 1 ? "icon-folder-big-on":"icon-folder-big-off" %>">
						                <div><a href="recruit_search.aspx?Country=1">한국어</a></div>
					                </li>
					                <li class="select icon <%=CountryNo == 2 ? "icon-folder-big-on":"icon-folder-big-off" %>">
						                <div><a href="recruit_search.aspx?Country=2">中文</a></div>
					                </li>	
					                <!--<li class="select icon icon-folder-big-off">
						                <div>English</div>
					                </li>-->
				                </ul>
                            </div>
                            <div class="search-box">
                                <div class="search-table">
                                    <table>
                                        <tr>
                                            <td class="col1 label">참가</td>
                                            <td class="col2" colspan="3">
                                                <table>
                                                    <tr>
                                                        <td><input class="radio" id="isJoin_1" type="radio" value="1" name="JoinType" <%=JoinType == 1 ? "checked='checked'":"" %>/></td>
                                                        <td><label for="isJoin_1">참가</label></td>
                                                        <td><input class="radio" id="isJoin_2" type="radio" value="0" name="JoinType" <%=JoinType == 0 ? "checked='checked'":"" %>/></td>
                                                        <td><label for="isJoin_2">불참</label></td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="col1 label">직종</td>
                                            <td class="col2">
                                                <table>
                                                    <tr>
                                                        <td><select name="Category1No"><option value="0">전체</option>
                                                        <% foreach (CategoryEntity item in Category1List)
                                                           { %>
												                <option value="<%=item.CategoryNo %>" <%=item.CategoryNo == Category1No ? "selected='selected'" : "" %>><%=item.CategoryKRName%></option>
                                                        <% } %>
                                                        </select></td>
                                                        <td><select name="Category2No"><option value="0">전체</option>
                                                        <% if (Category2List != null) { %>
                                                            <% foreach (SubCategoryEntity item in Category2List) { %>
												                <option value="<%=item.SubCategoryNo %>" <%=item.SubCategoryNo == Category2No ? "selected='selected'" : "" %>><%=item.SubCategoryKRName%></option>
                                                            <% } %>
                                                        <% } %>
                                                        </select></td>
                                                    </tr>
                                                </table>
                                            </td>
                                            <td class="col3 label">연령</td>
                                            <td class="col4"><select name="AgeCategory">
                                                <option value="0">무관</option>
                                                <% foreach (CategoryEntity item in AgeCategoryList)
                                                       if ( item.CategoryNo != 10 )
                                                       {
                                                           { 
                                                %>
												        <option value="<%=item.CategoryNo %>" <%=AgeCategory == item.CategoryNo ? "selected='selected'":"" %>><%=item.CategoryKRName%></option>
                                                <% 
                                                            }
                                                       } 
                                                %>
                                            </select>
                                            </td>                                            
                                        </tr>
                                        <tr>
                                            <td class="col1 label">지역</td>
                                            <td class="col2">
                                                <table>
                                                    <tr>
                                                        <td><select name="CityCategory"><option value="0">전체</option>
                                                        <% foreach (CategoryEntity item in CityCategoryList) { %>
												                <option value="<%=item.CategoryNo %>" <%=item.CategoryNo == CityCategory ? "selected='selected'" : ""%>><%=item.CategoryKRName%></option>
                                                        <% } %>
                                                        </select></td>
                                                        <td><select name="AreaCategory"><option value="0">전체</option>
                                                        <% if (AreaSubCategoryList != null) { %>
                                                            <% foreach (SubCategoryEntity item in AreaSubCategoryList) { %>
												                <option value="<%=item.SubCategoryNo %>" <%=item.SubCategoryNo == AreaCategory ? "selected='selected'" : "" %>><%=item.SubCategoryKRName%></option>
                                                            <% } %>
                                                        <% } %>
                                                        </select></td>
                                                    </tr>
                                                </table>
                                            </td>
                                            <td class="col3 label">성별</td>
                                            <td class="col4"><select name="Gender">
                                                <option value="0" <%=Gender==0?"selected='selected'":"" %>>무관</option>
                                                <option value="1" <%=Gender==1?"selected='selected'":"" %>>남성</option>
                                                <option value="2" <%=Gender==2?"selected='selected'":"" %>>여성</option>
                                                </select>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="col1 label">기업명</td>
                                            <td class="col2">
                                                <input type="text" class="big" name="CompanyName" maxlength="50"/>
                                            </td>
                                            <td class="col3 label">경력</td>
                                            <td class="col4"><select name="Career">
                                                <option value="0" <%=Career==0?"selected='selected'":"" %>>무관</option>
                                                <option value="1" <%=Career==1?"selected='selected'":"" %>>1년</option>
                                                <option value="2" <%=Career==2?"selected='selected'":"" %>>2년</option>
                                                <option value="3" <%=Career==3?"selected='selected'":"" %>>3년</option>
                                                <option value="4" <%=Career==4?"selected='selected'":"" %>>4년</option>
                                                <option value="5" <%=Career==5?"selected='selected'":"" %>>5년</option>
                                                <option value="10" <%=Career==10?"selected='selected'":"" %>>10년</option>
                                                
                                            </select>
                                            </td>                                            
                                        </tr>
                                    </table>
                                </div>
                                <div class="search-btn">
                                    <a class="icon icon-recruit-search-btn" onclick="jQuery.onSearch(); return false;" style="cursor:pointer"></a>
                                    <a class="icon icon-recruit-request" onclick="location.href='<%=this.GetURL("/company/recruit_regist_list.aspx") %>'; return false;" style="cursor:pointer"/></a>
                                </div>
                            </div>
                            <div class="search-data">
                                <div class="tab">
						            <ul>
							            <li class="<%=CapitalType == 0 ? "select icon icon-folder-small-on" : "last icon icon-folder-small-off"%>">
								            <div><a href="<%=GetCapitalType(0) %>">전체</a></div>
							            </li>
							            <li class="<%=CapitalType == 135 ? "select icon icon-folder-small-on" : "last icon icon-folder-small-off"%>">
								            <div><a href="<%=GetCapitalType(135) %>">외자기업</a></div>
							            </li>	
							            <li class="<%=CapitalType == 136 ? "select icon icon-folder-small-on" : "last icon icon-folder-small-off"%>">
								            <div><a href="<%=GetCapitalType(136) %>">독자기업</a></div>
							            </li>
							            <li class="<%=CapitalType == 137 ? "select icon icon-folder-small-on" : "last icon icon-folder-small-off"%>">
								            <div><a href="<%=GetCapitalType(137) %>">합자기업</a></div>
							            </li>
							            <li class="<%=CapitalType == 138 ? "select icon icon-folder-small-on" : "last icon icon-folder-small-off"%>">
								            <div><a href="<%=GetCapitalType(138) %>">기타</a></div>
							            </li>												
						            </ul>						
					            </div>
<script language="javascript" type="text/javascript">
jQuery(function()
{
    jQuery.InitProc();    
});

(function($)
{
    $.extend({
        InitProc : function()
        {
            jQuery("select:[name=Category1No]").bind("change", function()
            {
                Site.Web.Soap.Category.GetSubCategory($(this).val(), function(results, context, methodName)
                {
                    if ( results.valueOf() )
                    {
                        jQuery("select:[name=Category2No]").find("option").remove();
                        jQuery("select:[name=Category2No]").append(
                            $("<option value='0'>전체</option>")
                        )
                        if ( results.length > 0 )
                        {
                            $(results).each(function()
                            {
                                jQuery("select:[name=Category2No]").append(
                                    $("<option value='" + this.SubCategoryNo + "'>" + this.SubCategoryKRName + "</option>")
                                )
                            });
                        }
                    };
                },
                $.onFailed);
            });
            
            jQuery("select:[name=CityCategory]").bind("change", function()
            {
                Site.Web.Soap.Category.GetSubCategory($(this).val(), function(results, context, methodName)
                {
                    if ( results.valueOf() )
                    {
                        
                        jQuery("select:[name=AreaCategory]").find("option").remove();
                        jQuery("select:[name=AreaCategory]").append(
                            $("<option value='0'>전체</option>")
                        )
                        if ( results.length > 0 )
                            {
                            $(results).each(function()
                            {
                                jQuery("select:[name=AreaCategory]").append(
                                    $("<option value='" + this.SubCategoryNo + "'>" + this.SubCategoryKRName + "</option>")
                                )
                            });
                        }
                    };
                },
                $.onFailed);
            });
        },
        
        onFailed : function(results, methodName, context )
        {
            alert( results.get_message() );
        },
        
        onSearch : function()
        {
            var CountryNo = 1;
            var JoinType = null;
            var Category1No = jQuery("select:[name=Category1No]").val();
            var Category2No = jQuery("select:[name=Category2No]").val();
            var AgeCategory = jQuery("select:[name=AgeCategory]").val();
            var CityCategory = jQuery("select:[name=CityCategory]").val();
            var AreaCategory = jQuery("select:[name=AreaCategory]").val();
            var Gender = jQuery("select:[name=Gender]").val();
            var CompanyName = jQuery("input:[name=CompanyName]").val();
            var Career = jQuery("select:[name=Career]").val();
            
            jQuery("input:[name=CountryNo]").each(function(){
                if ( jQuery(this).attr("checked") )
                {
                    CountryNo = jQuery(this).val();
                }
            });
            jQuery("input:[name=JoinType]").each(function(){
                if ( jQuery(this).attr("checked") )
                {
                    JoinType = jQuery(this).val();
                }
            });
            
            var url = "recruit_search.aspx?Country=" + CountryNo;
            if ( JoinType != null )
                url += "&join=" + JoinType;
            if ( Category1No != 0 )
                url += "&Category1=" + Category1No;
            if ( Category2No != 0 )
                url += "&Category2=" + Category2No;
            if ( AgeCategory != 0 )
                url += "&Age=" + AgeCategory;
            if ( CityCategory != 0 )
                url += "&City=" + CityCategory;
            if ( AreaCategory != 0 )
                url += "&Area=" + AreaCategory;
            if ( Gender != 0 )
                url += "&Gender=" + Gender;
            if ( Career != 0 )
                url += "&Career=" + Career;
            if ( jQuery.trim(CompanyName) != "" )
                url += "&Name=" + encodeURIComponent(CompanyName);
            location.href = url;
        }
    });
})(jQuery);
</script>
                                <div class="tab-content">
                                    <table>
                                        <tr class="first">
                                            <th class="col1">기업코드</th>
                                            <th colspan="2">기업명</th>
                                            <th>구인직종</th>
                                            <th>참가여부</th>
                                            <th>마감일</th>
                                        </tr>
<% foreach(RecruitSearchEntity item in SearchList.Record) { %>
                                        <tr style="cursor:pointer" onclick="location.href='<%=DetailViewer(item.CompanyNo, item.RecruitNo)%>'">
                                            <td class="col1"><%=item.CompanyNo %></td>
                                            <td class="col2"><img src="<%=item.CompanyImage == string.Empty ? "/ImgSrv/kr/images/recruit/no-logo.png" : item.CompanyImage%>" /></td>
                                            <td class="col3"><%=item.KRName %><br /><%=item.CNName %><br /><%=item.ENGName %></td>
                                            <td class="col4">
                                                <% if (GetCategoryName(item.Category1No) == "직접입력" || GetCategoryName(item.Category2No) == "직접입력" || GetCategoryName(item.Category1No) == "直接输入" || GetCategoryName(item.Category2No) == "直接输入"){  %>
                                                    <%=item.CategoryEtcValue %>
                                                <% } else { %>
                                                    <%=GetCategoryName(item.Category1No) %><%=GetSubCategoryName(item.Category2No)%>
                                                <% } %>
                                            </td>
                                            <td class="col5"><%=item.JoinType == 0 ? "불참가" : "참가" %></td>
                                            <td class="col6"><%=item.RecruitDate.ToString("yyyy-MM-dd") %></td>
                                        </tr>
<% }%>
                                    </table>
                                    <div class="pager">
<%
    int TotalPageNo = 1;
    int StartPageNo = 1;
    int EndPageNo = StartPageNo + 9;
    TotalPageNo = SearchList.Output.CntTotal != 0 ? ((SearchList.Output.CntTotal - 1) / 10) + 1 : 1;
    StartPageNo = (((PageNo - 1) / 10) * 10) + 1;
    EndPageNo = StartPageNo + 9;
    EndPageNo = EndPageNo > TotalPageNo ? TotalPageNo : EndPageNo;
%>
<%  if (PageNo > 10) { %>
                                            <a href="<%=PageMove(StartPageNo-10)%>" class="icon icon-board-icon-prev"></a>
<% } %>
<%  for (int pageNo = StartPageNo; pageNo <= EndPageNo; pageNo++) { %>
                                            <a href="<%=PageMove(pageNo)%>" <%=pageNo==PageNo ? "class='select'" : "" %>><%=pageNo %></a>
<% } %>
<% if ( EndPageNo < TotalPageNo ) { %>
                                            <a href="<%=PageMove(StartPageNo+10)%>" class="icon icon-board-icon-next"></a>
<% } %>
                                    </div>
                                </div>
                            </div>

</asp:Content>


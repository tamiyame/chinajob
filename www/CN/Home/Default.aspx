<%@ Page Language="C#" MasterPageFile="~/CN/WebMaster/CNMaster.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="CN_Home_Default"%>
<%@ Import Namespace="Com.Library.DB.Board" %>
<%@ Import Namespace="Com.Library.DB.Banner" %>
<%@ Import Namespace="Site.Web.Util" %>
<%@ Import Namespace="Com.Library.DB.Company" %>
<%@ Import Namespace="Com.Library.DB.User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
<% DateTime dateStart = Convert.ToDateTime("2011-03-30"); %>
<asp:ScriptManagerProxy ID="px" runat="server">
    <Services>
        <asp:ServiceReference Path="~/Soap/Company.asmx"></asp:ServiceReference>
    </Services>
</asp:ScriptManagerProxy>
				<div class="notice"> 
					<div class="vertical-line"></div>
					<div class="info-news">
						<div class="info">
							<div class="more">
								<a href="<%=this.GetURL("/operation/qna_list.aspx")%>" class="icon icon-more"></a>
							</div>
							<div class="industry-phone"><%=PageEntity.PhoneNo%></div>
							<div class="recruit-phone"><%=PageEntity.FaxNo%></div>
						</div>
						<div class="news">
							<div class="more">
								<a href="<%=this.GetURL("/operation/notice_list.aspx")%>" class="icon icon-more"></a>
							</div>
							<div class="list">
								<ul>
<% foreach (ArticleEntity item in ArticleList.Record) { %>
									<li><a href="<%=this.GetURL("/operation/notice_detail.aspx?PageNo=1&ArticleNo=" + item.ArticleNo.ToString())%>"><%=Message.strCut(item.ArticleTitle, 15)%></a></li>
<% } %>
								</ul>
							</div>
						</div>
						<div class="expo-news">
							<div class="text">
								
							</div>
							<div class="more">
								<a href="<%=this.GetURL("/info/info.aspx?TopMenuNo=1&SubMenuNo=1")%>" class="icon icon-more-smth"></a>
							</div>
						</div>
					</div>					
					<div class="vertical-line"></div>
					<div class="recommend-human banner-container">
						<div class="banner"> 
<% foreach (BannerEntity item in BannerList_Human.Record)
   { %>
							<img style="width:354px;height:273px;cursor:pointer" src="<%=item.LargeImageURL %>" onclick="location.href='<%=item.Link %>'; return false;"/>
<% } %>													
						</div>
						<div class="action">
							<a class="icon icon-view" href="javascript:;"></a>
						</div>
						<div class="navigation">
							<ul class="pager">
<% {int seq = 0; foreach (BannerEntity item in BannerList_Human.Record)
   { 
   %>
                            <li><a href="<%=item.Link %>">0<%=++seq%></a></li>							
<% }} %>		
							</ul>
						</div>
					</div>
					<div class="vertical-line"></div>
					<div class="recommend-recruit banner-container">					
						<div class="banner">
<% foreach (BannerEntity item in BannerList_Company.Record)
   { %>
							<img style="width:354px;height:273px;cursor:pointer" src="<%=item.LargeImageURL %>" onclick="location.href='<%=item.Link %>'; return false;"/>
<% } %>
						</div>	
						<div class="action">
							<a class="icon icon-apply" href="javascript:;"></a>
						</div>					
						<div class="navigation">
							<ul class="pager">
<% {
       int seq = 0; foreach (BannerEntity item in BannerList_Company.Record)
   { 
   %>
                            <li><a href="<%=item.Link %>">0<%=++seq%></a></li>							
<% }} %>					
							</ul>
						</div>
					</div>
					<div class="vertical-line"></div>
				</div>
				<div class="new-recruit">
					<div class="more">
						<a href="/kr/recruit/recruit_search.aspx" class="icon icon-more-smth"></a>
					</div>
					<div class="preview-container">
<% if (DateTime.Now >= dateStart)
   { %>
                        <div class="preview-list">
							<div class="prev">
								<a href="javascript:;" onclick="$.CompanyList.Prev(); return false;" class="icon icon-prev"></a>
							</div>
							<div class="info-boxes" id="divCompanyList">
<% 
int idx = 0;
foreach (RecruitSearchEntity item in RecruitSearchList.Record)
{ 
 %>
								<div class="info-box icon icon-info-box" <%= idx < 8 ? "" : "style='display:none'" %>>
									<% if (item.JoinType == 1)
            { %><div class="special-tag icon icon-join"></div><% } %>
									<div>
										<div class="company-logo"><img src="<%=item.CompanyImage %>" /></div>
										<div class="company-name"><%=item.KRName == string.Empty ? item.CNName : item.KRName%></div>
										<div class="job-number">
											<div class="job">
											    <% if (GetCategoryName(item.Category1No) == "직접입력" || GetCategoryName(item.Category2No) == "직접입력" || GetCategoryName(item.Category1No) == "直接输入" || GetCategoryName(item.Category2No) == "直接输入"){  %>
                                                    <%=item.CategoryEtcValue %>
                                                <% } else { %>
                                                    <%=GetCategoryName(item.Category1No) %>
                                                <% } %>
											</div>
										</div>								
										<div class="link">
											<a href="/KR/recruit/recruit_detail.aspx?Country=<%=this.WebMaster.CountryCode %>&CompanyNo=<%=item.CompanyNo %>&RecruitNo=<%=item.RecruitNo %>&PageNo=1" class="icon icon-go"></a>
										</div>
									</div>
								</div>
<%
idx++;
} 
%>
<% for (int i = RecruitSearchList.Record.Count; i < 32; i++)
   { %>
								<div class="info-box icon icon-info-box" <%= i < 8 ? "" : "style='display:none'" %>></div>
<% } %>
							</div>
							<div class="next">
								<a href="javascript:;" onclick="$.CompanyList.Next(); return false;" class="icon icon-next"></a>
							</div>
						</div>
						<div class="pager" id="CompanyPager">
							<ul>
<% for (int i = 0; i < 4; i++)
   { %>
								<li><a href="javascript:;" onclick="$.CompanyList.Page(<%=i %>); return false;" class="icon <%=i==0?"icon-pager-select":"icon-pager" %>"></a></li> 	
<% } %>
                            </ul>
                        </div>
                    </div>
				</div>
<script language="javascript" type="text/javascript">
(function($) {
    var PageNo = 0;
    var isIE6 = /msie|MSIE 6/.test(navigator.userAgent);
    $.CompanyList = $.fn.CompanyList = {
        Prev: function() {
            if ( (PageNo - 1 ) < 0) {
                PageNo = 0;
                return;
            }
            $.CompanyList.Page(PageNo-1);
        },

        Next: function() {
            if ( ( PageNo + 1 ) >= 4) {
                PageNo = PageNo - 1;
                return;
            }
            $.CompanyList.Page(PageNo+1);
        },

        Page: function(idx,check) {

            $("#CompanyPager ul li:eq(" + PageNo + ") a").addClass("icon-pager").removeClass("icon-pager-select").parent().removeClass("select");
            $("#CompanyPager ul li:eq(" + idx + ") a").addClass("icon-pager-select").removeClass("icon-pager");
            PageNo = idx;
            $.CompanyList.List();
            if (isIE6) {
                if (idx != 0)
                    $("#divCompanyList").addClass('company_list_ie6fix');
                else
                    $("#divCompanyList").removeClass('company_list_ie6fix');
                if (check != true)
                    $.CompanyList.Page(idx, true);
            }
        },

        List: function() {

            $("#divCompanyList div.info-box").hide();
            for (var i = 0 + (PageNo * 8); i < ((PageNo * 8) + 8); i++) {
                $("#divCompanyList div.info-box:eq(" + i + ")").show();
            }
        }
    }
})(jQuery);
</script>
		
<% }
   else
   { %>
						<div class="preview-list">
							<div class="prev">
								
							</div>
							<div class="info-boxes">
								<div class="info-box icon icon-info-box-empty"></div>
								<div class="info-box icon icon-info-box-empty"></div>
								<div class="info-box icon icon-info-box-empty"></div>
								<div class="info-box icon icon-info-box-empty"></div>
								<div class="info-box icon icon-info-box-empty"></div>
								<div class="info-box icon icon-info-box-empty"></div>
								<div class="info-box icon icon-info-box-empty"></div>
								<div class="info-box icon icon-info-box-empty"></div>
							</div>
							<div class="next">
								
							</div>
						</div>
					</div>
				</div>
 <% } %>
<% if (this.WebCookies.IsLogin)
   {  %>
<%  if (this.WebCookies.isCompany)
    { %>
<% if (DateTime.Now >= dateStart)
   { %>
                <div class="new-human">
					<div class="more">
						<a href="/KR/recruit/human_search.aspx" class="icon icon-more-smth"></a>
					</div>
					<div class="preview-container">
						<div class="preview-list">
							<div class="prev">
								<a href="javascript:;" onclick="$.UserList.Prev(); return false;" class="icon icon-prev"></a>
							</div>
							<div class="info-boxes" id="divUserList">
<% 
    int idx = 0;
    foreach (ResumeSearchEntity item in UserSearchList.Record)
    { 
%>
								<div class="info-box icon icon-info-box" <%= idx < 8 ? "" : "style='display:none'" %>>
									<div class="special-tag">
									<% if ( item.JoinType == 1 ) { %>
										<div class="icon icon-recommend"></div>
								    <% } %>
									</div>
									<div class="profile">
										<div class="picture-link">
											<div class="picture"><img src="<%=item.UserImage %>" /></div>
											<div class="link">
												<a href="javascript:;" class="icon icon-go"></a>
											</div>	
										</div>									
										<div class="profile-text">
											<div class="name-birth">
												<span class="name"><%=item.KRName == string.Empty ? item.CNName : item.KRName %></span><span class="birth">(<%=item.Age %>)</span>
											</div>
											<div class="career"><%=item.Career == 1 ? " 신입" : "경력" %></div>
											<div class="job">
											<% if (GetCategoryName(item.Category1No) == "직접입력" || GetCategoryName(item.Category2No) == "직접입력" || GetCategoryName(item.Category1No) == "直接输入" || GetCategoryName(item.Category2No) == "直接输入"){  %>
                                                    <%=item.CategoryEtc%>
                                                <% } else { %>
                                                    <%=GetCategoryName(item.Category1No) %>
                                                <% } %>
											</div>
											<div class="university"><%=GetCategoryName(item.CityCategory)%>/<%=GetCategoryName(item.AreaCategory)%></div>
										</div>
									</div>
								</div>
<%
        idx++;
    } 
%>
<%  for (int i = UserSearchList.Record.Count; i < 32; i++)
    { %>
								<div class="info-box icon icon-info-box" <%= i < 8 ? "" : "style='display:none'" %>></div>
<%  } %>
							</div>
							<div class="next">
								<a href="javascript:;" onclick="$.UserList.Next(); return false;" class="icon icon-next"></a>
							</div>
						</div>
						<div class="pager" id="UserPager">
							<ul>
<% for (int i = 0; i < 4; i++)
   { %>
								<li><a href="javascript:;" onclick="$.UserList.Page(<%=i %>); return false;" class="icon <%=i==0?"icon-pager-select":"icon-pager" %>"></a></li> 	
<% } %>
							</ul>
						</div>
					</div>
				</div>
<script language="javascript" type="text/javascript">
(function($) {
    var PageNo = 0;
    var isIE6 = /msie|MSIE 6/.test(navigator.userAgent);
    $.UserList = $.fn.UserList = {
        Prev: function() {
            if ( (PageNo - 1 ) < 0) {
                PageNo = 0;
                return;
            }
            $.UserList.Page(PageNo-1);
        },

        Next: function() {
            if ( ( PageNo + 1 ) >= 4) {
                PageNo = PageNo - 1;
                return;
            }
            $.UserList.Page(PageNo+1);
        },

        Page: function(idx,check) {

            $("#UserPager ul li:eq(" + PageNo + ") a").addClass("icon-pager").removeClass("icon-pager-select").parent().removeClass("select");
            $("#UserPager ul li:eq(" + idx + ") a").addClass("icon-pager-select").removeClass("icon-pager");
            PageNo = idx;
            $.UserList.List();
            if (isIE6) {
                if (idx != 0)
                    $("#divUserList").addClass('company_list_ie6fix');
                else
                    $("#divUserList").removeClass('company_list_ie6fix');
                if (check != true) {
                    $.UserList.Page(idx, check);
                }
            }
        },

        List: function() {

            $("#divUserList div.info-box").hide();
            for (var i = 0 + (PageNo * 8); i < ((PageNo * 8) + 8); i++) {
                $("#divUserList div.info-box:eq(" + i + ")").show();
            }
        }
    }
})(jQuery);
</script>
<% }
   else
   { %>
				<div class="new-human">
					<div class="more">
						<a href="javascript:;" class="icon icon-more-smth"></a>
					</div>
					<div class="preview-container">
						<div class="preview-list">
							<div class="prev">
								
							</div>
							<div class="info-boxes">
								<div class="info-box icon icon-info-box-empty"></div>
								<div class="info-box icon icon-info-box-empty"></div>
								<div class="info-box icon icon-info-box-empty"></div>
								<div class="info-box icon icon-info-box-empty"></div>
								<div class="info-box icon icon-info-box-empty"></div>
								<div class="info-box icon icon-info-box-empty"></div>
								<div class="info-box icon icon-info-box-empty"></div>
								<div class="info-box icon icon-info-box-empty"></div>
							</div>
							<div class="next">
								
							</div>
						</div>
					</div>
				</div>
<% } %>
<% } %>
<% } %>
</asp:Content>


<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/KRMaster.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="KR_Home_Default"%>
<%@ Import Namespace="Com.Library.DB.Board" %>
<%@ Import Namespace="Com.Library.DB.Banner" %>
<%@ Import Namespace="Site.Web.Util" %>
<%@ Import Namespace="Com.Library.DB.Company" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
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
<% if (DateTime.Now > Convert.ToDateTime("2010-04-13")) { %>
                        <div class="preview-list">
							<div class="prev">
								<a href="javascript:;" onclick="$.CompanyList.Prev(); return false;" class="icon icon-prev"></a>
							</div>
							<div class="info-boxes" id="divCompanyList">
<% 
       int idx = 0;    
       foreach(RecruitSearchEntity item in RecruitSearchList.Record) { 
 %>
								<div class="info-box icon icon-info-box" <%= idx < 8 ? "" : "style='display:none'" %>>
									<% if (item.JoinType == 1){ %><div class="special-tag icon icon-join"></div><% } %>
									<div>
										<div class="company-logo"><img src="<%=item.CompanyImage %>" /></div>
										<div class="company-name"><%=item.KRName %></div>
										<div class="job-number">
											<div class="job"><%=GetCategoryName(item.Category1No)%></div>
										</div>								
										<div class="link">
											<a href="/KR/recruit/recruit_detail.aspx?Country=<%=this.WebMaster.CountryCode %>&CompanyNo=<%=item.CompanyNo %>&RecruitNo=<%=item.RecruitNo %>&PageNo=1" class="icon icon-go"></a>
										</div>
									</div>
								</div>
<%
           idx ++;      
        } 
%>
<% for ( int i = RecruitSearchList.Record.Count; i < 32; i ++ ) { %>
								<div class="info-box icon icon-info-box-empty" <%= i < 8 ? "" : "style='display:none'" %>></div>
<% } %>
							</div>
							<div class="next">
								<a href="javascript:;" onclick="$.CompanyList.Next(); return false;" class="icon icon-next"></a>
							</div>
						</div>
						<div class="pager" id="CompanyPager">
							<ul>
<% for ( int i = 0; i < 4; i ++ ) { %>
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
            PageNo--;
            if (PageNo < 0) {
                PageNo = 0;
                return;
            }
            $.CompanyList.Page(PageNo);
        },

        Next: function() {
            PageNo++;
            if (PageNo >= 4) {
                PageNo = PageNo - 1;
                return;
            }
            $.CompanyList.Page(PageNo);
        },

        Page: function(idx) {

            $("#CompanyPager ul li:eq(" + PageNo + ") a").addClass("icon-pager").removeClass("icon-pager-select").parent().removeClass("select");
            $("#CompanyPager ul li:eq(" + idx + ") a").addClass("icon-pager-select").removeClass("icon-pager");
            PageNo = idx;
            $.CompanyList.List();
            if (isIE6) {
                if (idx != 0)
                    $("#divCompanyList").addClass('company_list_ie6fix');
                else
                    $("#divCompanyList").removeClass('company_list_ie6fix');
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
		
<% } else { %>
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
<% if ( this.WebCookies.IsLogin ) {  %>
<%  if ( this.WebCookies.isCompany ) { %>
<% if (DateTime.Now > Convert.ToDateTime("2010-04-13")) { %>
                <div class="new-human">
					<div class="more">
						<a href="javascript:;" class="icon icon-more-smth"></a>
					</div>
					<div class="preview-container">
						<div class="preview-list">
							<div class="prev">
								<a href="javascript:;" class="icon icon-prev"></a>
							</div>
							<div class="info-boxes">
								<div class="info-box icon icon-info-box">
									<div class="special-tag">
										<div class="icon icon-recommend"></div>
									</div>
									<div class="profile">
										<div class="picture-link">
											<div class="picture"><img src="./banner/khe.jpg" /></div>
											<div class="link">
												<a href="javascript:;" class="icon icon-go"></a>
											</div>	
										</div>									
										<div class="profile-text">
											<div class="name-birth">
												<span class="name">김효은</span><span class="birth">(1984)</span>
											</div>
											<div class="job">제조/판매</div>
											<div class="career">신입</div>
											<div class="university">한국해양대학교</div>
											<div class="major">동아시아학</div>
											<div class="ability">중국어(상),영어(상)</div>
										</div>
									</div>
								</div>
								<div class="info-box icon icon-info-box"></div>
								<div class="info-box icon icon-info-box-empty"></div>
								<div class="info-box icon icon-info-box-empty"></div>
								<div class="info-box icon icon-info-box-empty"></div>
								<div class="info-box icon icon-info-box-empty"></div>
								<div class="info-box icon icon-info-box-empty"></div>
								<div class="info-box icon icon-info-box-empty"></div>
							</div>
							<div class="next">
								<a href="javascript:;" class="icon icon-next"></a>
							</div>
						</div>
						<div class="pager">
							<ul>
								<li><a href="javascript:;" class="icon icon-pager-select"></a></li>								
								<li><a href="javascript:;" class="icon icon-pager"></a></li>								
								<li><a href="javascript:;" class="icon icon-pager"></a></li>
								<li><a href="javascript:;" class="icon icon-pager"></a></li>
							</ul>
						</div>
					</div>
				</div>
<% } else  { %>
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


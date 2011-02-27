<%@ Page Language="C#" MasterPageFile="~/CN/WebMaster/CNMaster.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="CN_Home_Default"%>
<%@ Import Namespace="Com.Library.DB.Board" %>
<%@ Import Namespace="Com.Library.DB.Banner" %>
<%@ Import Namespace="Site.Web.Util" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<script type="text/javascript">
$(function(){$(".expo-sponsor .expo-folder").click();});
</script>
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
						<a href="javascript:;" class="icon icon-more-smth"></a>
					</div>
					<div class="preview-container">
						<div class="preview-list" id="divCompanyList">
							<div class="prev">
								<a href="javascript:;" class="icon icon-prev"></a>
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
<script language="javascript">
(function($)
{
    $.Company = $.fn.Company = 
    {
        PageNo : 1,
        PageSize : 8,
        TotalPageSize : 1,
        
        Init : function()
        {
            $.Company.GetList();
        },
        
        Prev : function()
        {
            $.Company.PageNo--;
            if ( $.Company.PageNo < 1 )
            {
                $.Company.PageNo = 1;
                return;
            }
        },
        
        Next : function()
        {
        },
        
        SetPage : function( pageNo )
        {
        },
        
        GetList : function()
        {
            Site.Web.Soap.Company.CompanyList(0, $.Company.PageNo, $.Company.PageSize, $.Company.onGetList, $.Company.onFailed );
        },
        
        onGetList : function(results, methodName, context )
        {
            /*
            var total = results.Output.CntTotal;
            var cntRow = results.Output.CntRow;
            var totalPage = 1;
            totalPage = parseInt( total < $.Company.PageSize ? 1 : ( ( total - 1 ) / $.Company.PageSize ) + 1, 10 );
            $.Company.TotalPageSize = totalPage;
            
            $("#divCompanyList div.info-boxes" ).html( "" );
            $.each(results.Record, function()
            {
                $("#divCompanyList div.info-boxes" ).append(
                    $('<div class="info-box icon icon-info-box" />').append(
                        $( '<div class="special-tag icon icon-join"></div>' )
                    ).append(
                        $(' <div />' ).append(
                            $( '<div class="company-logo"><img src="./banner/samsung-bi.jpg" />' )
                        ).append(
                            $( '<div class="company-name">삼성SDS 북경지사</div>' )
                        ).append(
                            $( '$<div class="job-number" />' ).append(
                                $( '<div class="job">웹시스템개발자</div>' )
                            ).append (
                                $( '<div class="number">2명</div>' )
                            )
                        ).append(
                            $( '<div class="link"/>' ).append(
                                $( '<a href="javascript:;" class="icon icon-go"></a>' )
                            )
                        )
                    )
                )
            });
            */
        },
        
        onFailed : function(results, methodName, context )
        {
        }
    };
})(jQuery);

jQuery(function(){
    jQuery.Company.Init();
    $("div.expo-folder").hide();
    $("div.expo-content").show();
});

</script>
<% if ( this.WebCookies.IsLogin ) {  %>
<%  if ( this.WebCookies.isCompany ) { %>
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
<% } %>
<% } %>
</asp:Content>


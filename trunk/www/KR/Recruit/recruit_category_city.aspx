<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/RecruitMaster.master" AutoEventWireup="true" CodeFile="recruit_category_city.aspx.cs" Inherits="KR_Recruit_recruit_category_city" Title="Untitled Page" %>
<%@ Import Namespace="Com.Library.DB.Category" %>
<%@ Import Namespace="System.Collections.Generic" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/kr/Css/recruit.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">


                        <div class="title">
                            <div class="recruit-title-category">
                                
                               <img src="/imgsrv/kr/images/submenu/recruit-title-category-location.png" />
                            </div>
                        </div>
                        <div class="contents">
                            <div class="tab">
                                <ul>
                                    <li class=" icon <%=CountryNo == 1 ? "select icon-folder-big-on" : "icon-folder-big-off"%> korean">
                                        <div><a href="recruit_category_city.aspx?CountryNo=1">한국어</a></div>
                                    </li>
                                    <li class=" icon <%=CountryNo == 2 ? "select icon-folder-big-on" : "icon-folder-big-off"%> china">
                                        <div><a href="recruit_category_city.aspx?CountryNo=2">中文M</a></div>
                                    </li>													
                                    <li class=" icon <%=CountryNo == 3 ? "select icon-folder-big-on" : "icon-folder-big-off"%> english">
                                        <div><a href="recruit_category_city.aspx?CountryNo=3">english</a></div>
                                    </li>				
                                </ul>						
                            </div>
                            <div class="category-detail">
                                <div class="top"></div>
                                <div class="board-content">
                                <table class="category-table">    
<%for (int i = 0; i < CategoryList.Count; i++) { 
                                if(i%3==0)
                                {%>
                                    <tr class="categoryList">
                                <%} %> 
                                        <td class="categoryItem <%= i % 3 == 2 ? "" : "sideline"%>">
                                     
                                            <span class="category1"><a href="recruit_search.aspx?Country=<%=CountryNo%>&City=<%=CategoryList[i].CategoryNo%>"><%=GetCategoryName(CategoryList[i])%></a><span class="icon icon-board-icon-next" onclick="location.href='recruit_search.aspx?Country=<%=CountryNo%>&City=<%=CategoryList[i].CategoryNo%>'" style="cursor:pointer;"></span></span>
                                            <ul class="category2">
<%
    List<SubCategoryEntity> lstSubCategory = GetSubCategory(CategoryList[i].CategoryNo);
    foreach (SubCategoryEntity item in lstSubCategory)
    {
        if ( item.SubCategoryNo != 360 )
        {
%>
                                                <li><a href="recruit_search.aspx?Country=<%=CountryNo%>&City=<%=CategoryList[i].CategoryNo%>&Area=<%=item.SubCategoryNo %>"><%=GetSubCategoryName(item)%></a><!--(<span class="number">0</span>)--></li>
<%     } 
    }
%>
                                            </ul>  
                                        </td>
                                     <%
                                if(i%3==2)
                                {%>
                                    </tr>
                                    <tr class="category-tr-blank"><td colspan="3"></td></tr>
                                <%} %>
<% } %>                         </table>
                                   
                                </div>
                                <div class="bottom"></div>
                            </div>	
                        </div>
</asp:Content>


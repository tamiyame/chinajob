<%@ Page Language="C#" MasterPageFile="~/Backoffice/WebMaster/OperationMaster.master" AutoEventWireup="true" CodeFile="board_list.aspx.cs" Inherits="Backoffice_Operation_list" %>
<%@ Import Namespace="Com.Library.DB.Board" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
<div class="title">운영센터</div>
<div class="desc">운영센터 관리입니다(<%=boardName%>)</div>


<div class="">
                        <div class="contents">
                            <table class="board-list">
                                <tr>
                                    <th>분류</td>
                                    <th>제목</td>
                                    <th>작성자</td>
                                    <th>작성일</td>
                                </tr>
<% foreach (ArticleEntity item in ArticleList.Record) { %>
                                <tr>
                                    <td class="col1"><%=this.GetCategoryName(item.BoardCategoryNo) %></td>
                                    <td class="col2">
                                        <a href="<%=PageMoveWithBoardNo("board_detail.aspx",BoardNo) %>&ArticleNo=<%=item.ArticleNo %>"><%=item.ArticleTitle %></a>
                                        <span class="reply-count">(<%=item.CommentCreate - item.CommentRemove%>)</span>
                                    </td>
                                    <td class="col3"><%=item.UserName%></td>
                                    <td class="col4"><%=item.DateCreated.ToString("yyyyy.MM.dd")%></td>
                                </tr>
<% } %>
                                <tr class="toolbox">
                                    <td colspan="4">
                                        <div class="pager">
<%
    int TotalPageNo = 1;
    int StartPageNo = 1;
    int EndPageNo = StartPageNo + 9;
    TotalPageNo = ArticleList.Output.CntTotal != 0 ? ( ( ArticleList.Output.CntTotal - 1 ) / 10 ) + 1 : 1;
    StartPageNo = (((PageNo - 1) / 10) * 10) + 1;
    EndPageNo = StartPageNo + 9;
    EndPageNo = EndPageNo > TotalPageNo ? TotalPageNo : EndPageNo;
%>
<%  if (PageNo > 10) { %>
                                            <a href="<%=PageMove("board_list.aspx", StartPageNo-10,BoardNo)%>" class="icon icon-board-icon-prev"></a>
<% } %>
<%  for (int pageNo = StartPageNo; pageNo <= EndPageNo; pageNo++) { %>
                                            <a href="<%=PageMove("board_list.aspx", pageNo,BoardNo)%>" <%=pageNo==PageNo ? "class='select'" : "" %>><%=pageNo %></a>
<% } %>
<% if ( EndPageNo < TotalPageNo ) { %>
                                            <a href="<%=PageMove("board_list.aspx", StartPageNo+10,BoardNo)%>" class="icon icon-board-icon-next"></a>
<% } %>
                                        </div>
                                        <div class="button">
                                            <a href="<%=PageMoveWithBoardNo("board_write.aspx",BoardNo)%>" class="icon icon-board-confirm-simple"></a>
                                        </div>                                        
                                    </td>
                                </tr>
                                <tr class="search">
                                    <td colspan="4">
                                        <table>
                                            <tr>
                                                <td>
                                                    <select name="search_type">
                                                        <option value="1">제목 + 내용</option>
                                                        <option value="2">제목</option>
                                                        <option value="3">내용</option>
                                                    </select>
                                                </td>
                                                <td>
                                                    <input type="text" name="search_text"/>
                                                </td>
                                                <td class="search_button"><a href="javascript:;" class="icon icon-board-search"></a></td>
                                            </tr>
                                        </table>
                                    </td>
                                <tr/>
                            </table>                            
                        </div>
</div>
</asp:Content>


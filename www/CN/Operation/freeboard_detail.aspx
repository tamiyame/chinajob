<%@ Page Language="C#" MasterPageFile="~/CN/WebMaster/OperationMaster.master" AutoEventWireup="true" CodeFile="freeboard_detail.aspx.cs" Inherits="CN_Operation_freeboard_detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<script language="javascript" src="/js/translateJs_cn_operation.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
                        <div class="title">
                            <div class="operation-title-freeboard"></div>
                        </div>
                        <div class="contents">
                            <div class="board-detail">
                                <div class="top"></div>
                                <div class="board-content">
                                    <table>
                                        <tr class="label">
                                            <td class="col1"><%=GetCategoryName(this.ArticleInfo.BoardCategoryNo)%></td>
                                            <td class="col2"><%=ArticleInfo.ArticleTitle%><!--<span class="secret">비밀글</span>--></td>
                                            <td class="col3"><%=ArticleInfo.UserName.Split('|').Length > 1 ? ( ArticleInfo.UserName.Split('|')[1] == string.Empty ? ArticleInfo.UserName.Split('|')[0] : ArticleInfo.UserName.Split('|')[1] ) : ArticleInfo.UserName%></td>
                                            <td class="col4"><%=ArticleInfo.DateCreated.ToString("yyyy.MM.dd") %></td>
                                        </tr>
                                        <tr class="text">
                                            <td colspan="4"><%=ArticleInfo.ArticleContent %></td>
                                        </tr>
                                    </table>
                                </div>
                                <div class="bottom"></div>
                            </div>
                            <div class="board-detail-tool">
                            <%if (ArticleInfo.UserNo == this.WebCookies.UserNo) { %>
                                <div class="tool-left">
                                    <a href="<%=PageMove("freeboard_modify.aspx")%>&ArticleNo=<%=ArticleNo %>" class="icon icon-board-modify"></a>
                                    <a href="javascript:;" class="icon icon-board-delete"  onclick="if ( confirm($.translateHelper.getText("CN_Operation_freeboard_detail.aspx_30")) ) { location.href='<%=PageMove("freeboard_remove.aspx")%>&ArticleNo=<%=ArticleNo %>' } return false;"></a>
                                </div>
                                <% } %>
                                <div class="tool-right">
                                    <a href="<%=PageMove("freeboard_list.aspx")%>" class="icon icon-board-list"></a>
                                </div>
                            </div>
                            <!--
                            <div class="board-reply">
                                <div class="reply-header">
                                    <span class="icon icon-logo-reply"></span> <span class="reply-desc">답변은 관리자만 가능합니다</span>
                                </div>
                                <div class="reply-box">
                                    <table>
                                        <tr>
                                            <td><textarea></textarea></td>
                                            <td><a href="javascript:;" class="icon icon-reply-confirm"></a></td>
                                        </tr>
                                    </table>                                    
                                </div>
                                <div class="reply-list">
                                    <ul>
                                        <li>
                                            <table class="reply-table">
                                                <tr class="label">
                                                    <td class="col1">양광현</td>
                                                    <td class="col2">2011.01.27</td>
                                                    <td class="col3">
                                                        <a href="javascript:;">삭제</a>
                                                        <span class="bar"></span>
                                                        <a href="javascript:;">수정</a>
                                                    </td>
                                                </tr>
                                                <tr class="text">
                                                    <td colspan="3">이런 박람회가 자주 있었으면 좋겠어요</td>
                                                </tr>
                                            </table>
                                        </li>
                                    </ul>
                                </div>
                            </div>-->
                        </div>

</asp:Content>


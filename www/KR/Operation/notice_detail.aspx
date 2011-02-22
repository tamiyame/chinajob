<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/OperationMaster.master" AutoEventWireup="true" CodeFile="notice_detail.aspx.cs" Inherits="KR_Operation_notice_detail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
                        <div class="title">
                            <div class="operation-title-notice"></div>
                        </div>
                        <div class="contents">
                            <div class="board-detail">
                                <div class="top"></div>
                                <div class="board-content">
                                    <table>
                                        <tr class="label">
                                            <td class="col1"><%=GetCategoryName(this.ArticleInfo.BoardCategoryNo)%></td>
                                            <td class="col2"><%=ArticleInfo.ArticleTitle%><!--<span class="secret">비밀글</span>--></td>
                                            <td class="col3"><%=ArticleInfo.UserName %></td>
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
                                <div class="tool-left">
<!--
                                    <a href="javascript:;" class="icon icon-board-modify"></a>
                                    <a href="javascript:;" class="icon icon-board-delete"></a>
-->
                                </div>
                                <div class="tool-right">
                                    <a href="<%=PageMove("qna_list.aspx")%>" class="icon icon-board-list"></a>
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


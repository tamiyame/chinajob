﻿<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/OperationMaster.master" AutoEventWireup="true" CodeFile="qna_detail.aspx.cs" Inherits="CN_Operation_qna_detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
                        <div class="title">
                            <div class="operation-title-qna"></div>
                        </div>
                        <div class="contents notice-board">
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
                                    <span class="icon icon-reply-opinion"></span> <span class="reply-desc">댓글을 달고 버튼을 클릭해주세요</span>
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
                                <div class="pager">
                                    <a href="javascript:;" class="icon icon-board-icon-prev"></a>
                                    <a href="javascript:;" class="select">1</a>
                                    <a href="javascript:;">2</a>
                                    <a href="javascript:;">3</a>
                                    <a href="javascript:;">4</a>
                                    <a href="javascript:;">5</a>
                                    <a href="javascript:;">6</a>
                                    <a href="javascript:;">7</a>
                                    <a href="javascript:;">8</a>
                                    <a href="javascript:;">9</a>
                                    <a href="javascript:;" class="icon icon-board-icon-next"></a>
                                </div>
                            </div>
-->
                        </div>
</asp:Content>


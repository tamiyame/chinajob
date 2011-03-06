<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/UserMaster.master" AutoEventWireup="true" CodeFile="user_search.aspx.cs" Inherits="KR_Recruit_user_search" Title="제목 없음" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/kr/Css/human.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
<div class="title">
                            <div class="human-title-search"></div>
                        </div>
                        <div class="contents">
                            <div class="search-box">
                                <div class="search-table">
                                    <table name="search-table">
                                        <tr>
                                            <td class="col1 label">참가</td>
                                            <td class="col2" colspan="3">
                                                <table>
                                                    <tr>
                                                        <td><input class="radio" id="isJoin_1" type="radio" value="1" name="isJoin" /></td>
                                                        <td><label for="isJoin_1">참가</label></td>
                                                        <td><input class="radio" id="isJoin_2" type="radio" value="2" name="isJoin" /></td>
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
                                                        <td><select name="category1"><option value="1">전체</option></select></td>
                                                        <td><select name="category2"><option value="1">전체</option></select></td>
                                                    </tr>
                                                </table>
                                            </td>
                                            <td class="col3 label">연령</td>
                                            <td class="col4"><select name="age"><option value="1">무관</option></select></td>                                            
                                        </tr>
                                        <tr>
                                            <td class="col1 label">지역</td>
                                            <td class="col2">
                                                <table>
                                                    <tr>
                                                        <td><select name="address1"><option value="1">전체</option></select></td>
                                                        <td><select name="address2"><option value="1">전체</option></select></td>
                                                    </tr>
                                                </table>
                                            </td>
                                            <td class="col3 label">성별</td>
                                            <td class="col4"><select name="gender"><option value="1">무관</option></select></td>                                            
                                        </tr>
                                        <tr>
                                            <td class="col1 label">성명</td>
                                            <td class="col2" colspan="3">
                                                <input type="text" class="big" name="name"/>
                                            </td>
                                            <!--<td class="col3 label">경력</td>
                                            <td class="col4"><select name="career"><option value="1">무관</option></select></td>  -->                                          
                                        </tr>
                                    </table>
                                </div>
                                <div class="search-btn">
                                    <a class="icon icon-human-search-btn"></a>
                                    <a class="icon icon-human-regist-btn" href="/login/join_select.aspx"></a>x
                                </div>
                            </div>
                            <div class="search-data">
                                <div class="tab">
						            <ul>
							            <li class="select icon icon-folder-big-on">
								            <div>한국어</div>
							            </li>
							            <li class="last icon icon-folder-big-off">
								            <div>中文</div>
							            </li>	
							            <li class="last icon icon-folder-big-off">
								            <div>English</div>
							            </li>							
						            </ul>						
					            </div>
                                <div class="tab-content">
                                    <table>
                                        <tr class="first">
                                            <th class="col1">성명</th>
                                            <th>희망/관심직종</th>
                                            <th>희망지역</th>
                                            <th>참가</th>                                            
                                        </tr>
                                        <tr>
                                            <td class="col1">김광현<span class="desc">(남,31)</span></td>
                                            <td class="col2">영업/마케팅/판매</td>
                                            <td class="col3">광동 > 심천</td>
                                            <td class="col4">참가</td>
                                        </tr>
                                    </table>
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
                            </div>
                        </div>

</asp:Content>


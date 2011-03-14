<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/UserMaster.master" AutoEventWireup="true" CodeFile="human_recruit_manage.aspx.cs" Inherits="KR_User_human_recruit_manage" %>
<%@ Import Namespace="Com.Library.DB.Participate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/kr/css/human.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
                <div class="join">
				    <div class="human-title-recruit-manage"></div>
				    <table class="recruit-table">
						<tr>
							<th>구인직종</th>
							<th>지원가입</th>
							<th>지원일시</th>
							<th>결과</th>
							<th>관리</th>
						</tr>
<%foreach (ParticipateEntity item in ParticiapteList.Record) { %>
						<tr>
							<td class="col1"><%=GetCategoryName(item.Category1No)%></td>
							<td class="col2"><a href="/KR/recruit/recruit_detail.aspx?Country=<%=item.CountryNo %>&CompanyNo=<%=item.CompanyNo %>&RecruitNo=<%=item.RecruitNo %>" target="_blank">
							<%=item.CountryNo == 1 ? item.KRCompanyName : ( item.CountryNo == 2 ? item.CNCompanyName : item.ENGCompanyName ) %>
							(<%=item.CompanyNo %>)
							</a>
							</td>
							<td class="col3"><%=item.DateCreated.ToString("yyyy-MM-dd HH:mm") %></td>
							<td class="col4">
							<% if (item.ConfirmType == 0){ %>
							    대기
							<% } else if (item.ConfirmType == 1) { %>
							        승인
							<% }  else { %>
							        거절
							<% } %>
							</td>
							<td class="col5">
							<% if (item.ConfirmType == 0){ %>
							    <% if (item.RecruitType == 1){ %>
						            <a href="#" onclick="btnConfirm(<%=item.SeqNo %>, 1); return false;">수락</a> / <a href="" onclick="btnConfirm(<%=item.SeqNo %>, 2); return false;">거절</a>
						        <% } else { %> 
						            <a href="#" onclick="btnRemove(<%=item.SeqNo %>); return false;">취소</a>
						        <% } %>
							<% } else {%>
						        <a href="#" onclick="btnRemove(<%=item.SeqNo %>); return false;">취소</a>
							<% } %>
						</tr>
<% } %>
<script language="javascript" type="text/javascript">
function btnConfirm(seqno, type)
{
    PageMethods.SetConfirm(seqno, type, function(results, context, methodNames)
    {
        location.href = location.href;
    }, onFailed );
}

function btnRemove(seqno)
{
    PageMethods.Remove(seqno, function(results, context, methodNames)
    {
        location.href = location.href;
    }, onFailed );
}

function onFailed(results, context, methodNames)
{
    alert( results.get_message() );
}
</script>
						<tr class="toolbox">
							<td colspan="5">
								<div class="pager">
<%
    int TotalPageNo = 1;
    int StartPageNo = 1;
    int EndPageNo = StartPageNo + 9;
    TotalPageNo = ParticiapteList.Output.CntTotal != 0 ? ((ParticiapteList.Output.CntTotal - 1) / 10) + 1 : 1;
    StartPageNo = (((PageNo - 1) / 10) * 10) + 1;
    EndPageNo = StartPageNo + 9;
    EndPageNo = EndPageNo > TotalPageNo ? TotalPageNo : EndPageNo;
%>
<%  if (PageNo > 10) { %>
                                            <a href="human_recruit_manage.aspx?PageNo=<%=StartPageNo-10%>" class="icon icon-board-icon-prev"></a>
<% } %>
<%  for (int pageNo = StartPageNo; pageNo <= EndPageNo; pageNo++) { %>
                                            <a href="human_recruit_manage.aspx?PageNo=<%=pageNo%>" <%=pageNo==PageNo ? "class='select'" : "" %>><%=pageNo %></a>
<% } %>
<% if ( EndPageNo < TotalPageNo ) { %>
                                            <a href="human_recruit_manage.aspx?PageNo=<%=StartPageNo+10%>" class="icon icon-board-icon-next"></a>
<% } %>
								</div>                                     
							</td>
						</tr>
				    </table>			
				</div>
</asp:Content>


<%@ Page Language="C#" MasterPageFile="~/Backoffice/WebMaster/UserMaster.master" AutoEventWireup="true" CodeFile="company.aspx.cs" Inherits="Backoffice_User_Company" %>
<%@ Import Namespace="Com.Library.DB.Company" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">

<div class="title">기업회원</div>
<div class="desc">기업회원의 현황입니다. 기업회원 승인을 하셔야 채용정보등록이 가능합니다.</div>
<div class="company">
    <table class="companyTable">
<% foreach (CompanyAllEntity item in CompanyList.Record) { %>
        <tr onclick="javascript:;">
            <td class="col1"><%=item.CompanyNo %></td>
            <td class="col2">기업명</td>
            <td class="col3"><a href="/kr/Company/Company_modify.aspx?CompanyNo=<%=item.CompanyNo %>" target="_blank"><%=item.KRName != string.Empty ? item.KRName : ( item.CNName != string.Empty ? item.CNName : item.ENGName ) %></a></td>
            <td class="col4">가입일</td>
            <td class="col5"><%=item.RegistyTime.ToString("yyyy-MM-dd")%></td>
            <td class="col6"><% if (item.Approval == 0) { %><a href="javascript:;" onclick="onApply(this, <%=item.CompanyNo %>); return false;" class="icon-admin icon-approve"></a><% } else { %><a>기업회원승인</a><% } %></td>
            <td class="col7"></td>
        </tr>
<% } %>
        <tr class="toolbox">
            <td colspan="7">
                <div style="text-align:center;">
<%
    int TotalPageNo = 1;
    int StartPageNo = 1;
    int EndPageNo = StartPageNo + 9;
    TotalPageNo = CompanyList.Output.CntTotal != 0 ? ((CompanyList.Output.CntTotal - 1) / PageSize) + 1 : 1;
    StartPageNo = ( ( ( PageNo - 1 ) / 10 ) * 10 ) + 1;
    EndPageNo = StartPageNo + 9;
    EndPageNo = EndPageNo > TotalPageNo ? TotalPageNo : EndPageNo;
%>
<%  if (PageNo > 10) { %>
                                            <a href="company.aspx?PageNo=<%=StartPageNo-10 %>">[이전]</a>
<% } %>
<%  for (int pageNo = StartPageNo; pageNo <= EndPageNo; pageNo++) { %>
                                            <a href="company.aspx?PageNo=<%=pageNo %>" <%=pageNo==PageNo ? "class='select'" : "" %>><%=pageNo %></a>
<% } %>
<% if ( EndPageNo < TotalPageNo ) { %>
                                            <a href="company.aspx?PageNo=<%=StartPageNo+10 %>">[다음]</a>
<% } %>
                </div>
            </td>
        </tr>
    </table>
</div>
<script language="javascript" type="text/javascript">
function onApply(obj, companyNo)
{
    var _obj = obj;
    PageMethods.ApprovalCompany( companyNo,
    function(results, methodName, context)
    {
        jQuery(obj).parent().html("기업회원승인");
    },
    function(results, methodName, context)
    {
        alert( results.get_message() );
    });
}
</script>
</asp:Content>


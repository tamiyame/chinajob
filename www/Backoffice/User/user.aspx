<%@ Page Language="C#" MasterPageFile="~/Backoffice/WebMaster/UserMaster.master" AutoEventWireup="true" CodeFile="user.aspx.cs" Inherits="Backoffice_User_User" %>
<%@ Import Namespace="Com.Library.DB.User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">


<div class="title">개인회원</div>
<div class="desc">개인회원의 현황입니다.</div>


<div class="user">
    <table class="userTable">
<% foreach (UserEntity item in UserList.Record) { %>
        <tr onclick="window.open('/kr/user/resume_view.aspx?userno=<%=item.UserNo %>');">
            <td class="col1"><%=item.UserNo %></td>
            <td class="col2">성명</td>
            <td class="col3"><span class="name"><%=item.KRName %></span><span class="age-gender">(<%=item.Gender == 1 ? "남" : "여" %>,<%=item.Birthday.ToString("yyyy")%>)</span></td>
            <td class="col4">연락처</td>
            <td class="col5"><%=item.KRPhoneNo %></td>
            <td class="col6">현재거주국</td>
            <td class="col7"><%=item.ResidanceCountry == 1 ? "한국" : "중국" %></td>
            <td class="col8">가입일</td>
            <td class="col9"><% if (item.Status == 1) { %><%=item.DateCreated.ToString("yyyy-MM-dd hh:mm:ss")%><% } else {  %>탈퇴<%} %></td>
        </tr>
<% } %>
        <tr>
            <td colspan="9">
                <div style="text-align:center;">
<%
    int TotalPageNo = 1;
    int StartPageNo = 1;
    int EndPageNo = StartPageNo + 9;
    TotalPageNo = UserList.Output.CntTotal != 0 ? ((UserList.Output.CntTotal - 1) / PageSize) + 1 : 1;
    StartPageNo = ( ( ( PageNo - 1 ) / 10 ) * 10 ) + 1;
    EndPageNo = StartPageNo + 9;
    EndPageNo = EndPageNo > TotalPageNo ? TotalPageNo : EndPageNo;
%>
<%  if (PageNo > 10) { %>
                                            <a href="user.aspx?PageNo=<%=StartPageNo-10 %>">[이전]</a>
<% } %>
<%  for (int pageNo = StartPageNo; pageNo <= EndPageNo; pageNo++) { %>
                                            <a href="user.aspx?PageNo=<%=pageNo %>" <%=pageNo==PageNo ? "class='select'" : "" %>><%=pageNo %></a>
<% } %>
<% if ( EndPageNo < TotalPageNo ) { %>
                                            <a href="user.aspx?PageNo=<%=StartPageNo+10 %>">[다음]</a>
<% } %>
                </div>
            </td>
        </tr>
    </table>
</div>

<script language="javascript" type="text/javascript">
jQuery(function()
{
    jQuery.CreateInit();
});

(function($)
{
    $.extend({
        CreateInit : function()
        {      
        }
    });
})(jQuery);

</script>


</asp:Content>


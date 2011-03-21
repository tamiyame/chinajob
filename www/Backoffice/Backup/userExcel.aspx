<%@ Page Language="C#" AutoEventWireup="true" CodeFile="userExcel.aspx.cs" Inherits="Backoffice_Backup_userExcel" %>
<%@ Import Namespace="Com.Library.DB.User" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv=Content-Type content='application/vnd.ms-excel; charset=utf-8'>
</head>
<body>
<table border="1">
<tr style="background-color:Yellow">
    <td>회원번호</td>
    <td>아이디</td>
    <td>국문</td>
    <td>중문</td>
    <td>영문</td>
    <td>성별</td>
    <td>생일</td>
    <td>이메일</td>
    <td>한국번호</td>
    <td>중국번호</td>
    <td>거주국</td>
    <td>홈페이지</td>
    
</tr>
<% 
    foreach (UserEntity item in UserList)
    {
%>
<tr>
    <td><%=item.UserNo %></td>
    <td><%=item.UserID %></td>
    <td><%=item.KRName %></td>
    <td><%=item.CNName %></td>
    <td><%=item.ENGName %></td>
    <td><%=item.Gender == 1 ? "남" : "여" %></td>
    <td><%=item.Birthday.ToString("yyyy-MM-dd") %></td>
    <td><%=item.Email %></td>
    <td><%=item.KRPhoneNo %></td>
    <td><%=item.CNPhoneNo %></td>
    <td><%=item.ResidanceCountry == 1 ? "한국" : "중국" %></td>
    <td><%=item.HomepageUrl %></td>
</tr>
<% } %>
</table>
</body>
</html>

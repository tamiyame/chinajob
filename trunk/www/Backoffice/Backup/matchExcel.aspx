<%@ Page Language="C#" AutoEventWireup="true" CodeFile="matchExcel.aspx.cs" Inherits="Backoffice_Backup_matchExcel" %>
<%@ Import Namespace="Com.Library.DB.Company" %>
<%@ Import Namespace="Com.Library.DB.Participate" %>
<%@ Import Namespace="Com.Library.DB.User" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>제목 없음</title>
</head>
<body>
<table border="1">
<tr>
    <td>기업번호</td>
    <td>국문</td>
    <td>중문</td>
    <td>영문</td>
    <td>업종</td>
    <td>아이디</td>
    <td>연락처</td>
    <td>이메일</td>
    <td>감독관명</td>
    <td>채용직종</td>
    
    <td>지원자</td>
    <td>성별</td>
    <td>나이</td>
    <td>거주자</td>
    <td>연락처</td>
    <td>이메일</td>
</tr>
<%foreach (RecruitEntity item in RecruitList) {
      CompanyDetailEntity companyDetail = GetDetailCompany(item.CompanyNo);
      CompanyEntity company = GetCompany(item.CompanyNo);
%>
<tr>
    <td><%=companyDetail.CompanyNo%></td>
    <td><%=companyDetail.KRName%></td>
    <td><%=companyDetail.CNName%></td>
    <td><%=companyDetail.ENGName%></td>
    <td><%=GetCategoryName(companyDetail.BusinessCategoryNo)%></td>
    <td><%=company.CompanyID%></td>
    <td><%=companyDetail.PhoneNo%></td>
    <td><%=companyDetail.Email%></td>
    <td><%=item.JobFairRecruiter %></td>
    <td>
        <% if (GetSubCategoryName(item.Category2No) == "직접입력") { %>
            <%=item.CategoryEtcValue %>
        <% } else { %>
            <%=GetCategoryName(item.Category1No)%> - <%=GetSubCategoryName(item.Category2No)%>
        <%} %>
    </td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
    <%foreach( ParticipateEntity pitem in ParticipateList(item.CompanyNo, item.RecruitNo)) { 
          UserEntity user = UserInfo(pitem.UserNo);
    %>
    <tr>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td><%=pitem.KRUserName %></td>
        <td><%=pitem.Gender == 1 ? "남" : "여" %></td>
        <td><%=pitem.Age.ToString() + (pitem.KoreanAge == 0 ? "" : "(" + pitem.KoreanAge.ToString() + ")") %></td>
        <td><%=user.ResidanceCountry == 1 ? "한국" : "중국" %></td>
        <td><%=user.KRPhoneNo %></td>
        <td><%=user.Email %></td>
    </tr>
    <% } %>
</tr>
<% } %>
</table>
</body>
</html>

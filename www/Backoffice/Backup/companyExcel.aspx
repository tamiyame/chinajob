<%@ Page Language="C#" AutoEventWireup="true" CodeFile="companyExcel.aspx.cs" Inherits="Backoffice_Backup_companyExcel" %>
<%@ Import Namespace="Com.Library.DB.Company" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv=Content-Type content='application/vnd.ms-excel; charset=utf-8'>
</head>
<body>
<table border="1">
<tr>
    <td>기업번호</td>
    <td>기업아이디</td>
    <td>등록일</td>
    <td>국문</td>
    <td>중문</td>
    <td>영문</td>
    <td>사업자등록번호</td>
    <td>이메일</td>
    <td>업종</td>
    <td>대표자명</td>
    <td>기업유형</td>
    <td>설립년도</td>
    <td>사원수</td>
    <td>자본금</td>
    <td>매출액</td>
    <td>체영딤딩자</td>
    <td>회사전화번호</td>
    <td>회사팩스</td>
    <td>본사주소</td>
    <td>홈페이지</td>
</tr>
<%foreach(CompanyAllEntity item in CompanyList ) { %>
<tr>
    <td><%=item.CompanyNo %></td>
    <td><%=item.CompanyID %></td>
    <td><%=item.RegistDatetime.ToString("yyyy-MM-dd HH:mm:ss") %></td>
    <td><%=item.KRName %></td>
    <td><%=item.CNName %></td>
    <td><%=item.ENGName %></td>
    <td><%=item.PermitNo %></td>
    <td><%=item.Email %></td>
    <td><%=GetCategoryName(item.BusinessCategoryNo)%></td>
    <td><%=item.PresidentName %></td>
    <td><%=GetCategoryName(item.CapitalType)%></td>
    <td><%=item.FoundYear %></td>
    <td><%=item.EmployeeCount %></td>
    <td><%=item.Capital%><%=item.CapitalCurrencyNo == 186 ? "원화" : (item.CapitalCurrencyNo == 187 ? "RMB" : "달러" ) %></td>
    <td><%=item.Turnover%><%=item.TurnoverCurrencyNo == 186 ? "원화" : (item.TurnoverCurrencyNo == 187 ? "RMB" : "달러" ) %></td>
    <td><%=item.RecruiterName %></td>
    <td><%=item.PhoneNo %></td>
    <td><%=item.FaxNo %></td>
    <td><%=item.HeadAddress %></td>
    <td><%=item.HomepageURL %></td>
</tr>
<% } %>
</table>
</body>
</html>

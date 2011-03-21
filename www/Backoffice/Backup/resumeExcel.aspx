<%@ Page Language="C#" AutoEventWireup="true" CodeFile="resumeExcel.aspx.cs" Inherits="Backoffice_Backup_resumeExcel" %>
<%@ Import Namespace="Com.Library.DB.User" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv=Content-Type content='application/vnd.ms-excel; charset=utf-8'>
</head>
<body>
<table border="1">
<tr style="background-color:#efefef">
    <td colspan="11">기본정보</td>
    <td colspan="5">한국어</td>
</tr>
<tr style="background-color:Yellow">
    <td>회원번호</td>
    <td>1지망</td>
    <td>2지망</td>
    <td>3지망</td>
    <td>희망급여</td>
    <td>희망지역-1</td>
    <td>희망지역-2</td>
    <td>취업희망시기</td>
    <td>관심업종</td>
    <td>관심직종</td>
    <td>참가여부</td>
    
    <td>연령</td>
    <td>재중경험</td>
    <td>병역</td>
    <td>경력여부</td>
    <td>실거주지</td>
</tr>
<% 
    foreach (ResumeEntity item in ResumeList) {
        ResumeDetailEntity kr = GetResumeDetail(item.UserNo, 1);
%>
<tr>
    <td><%=item.UserNo %></td>
    <td><%=item.CompanyNo1 %></td>
    <td><%=item.CompanyNo2 %></td>
    <td><%=item.CompanyNo3 %></td>
    <td><%=item.HopeSalary %></td>
    <td><%=GetCategoryName(item.CityNo1) %> - <%=GetSubCategoryName(item.ArrayNo1) %></td>
    <td><%=GetCategoryName(item.CityNo2) %> - <%=GetSubCategoryName(item.ArrayNo2) %></td>
    <td><%=item.HopeRecruitDate.ToString("yyyy-MM-dd") %>이후</td>
    <td><%=GetCategoryName(item.BusinessCategoryNo) %></td>
    <td><%=GetCategoryName(item.Category1No) %> - <%=GetSubCategoryName(item.Category2No) %></td>
    <td><%=item.JoinType == 1 ? "가능" : "불가능" %></td>
    
    <td><%=kr.Age %>(만 <%=kr.KoreanAge %>)</td>
    <td><%=kr.ChinaExp %></td>
    <td><%=kr.Military == 1 ? "필" : ( kr.Military == 2 ? "미필" : ( kr.Military == 3 ? "면제" : "무관") )%></td>
    <td><%=kr.IsCareer == 1 ? "신입" : "경력" %></td>
    <td><%=kr.Address %></td>
</tr>
<% } %>
</table>
</body>
</html>

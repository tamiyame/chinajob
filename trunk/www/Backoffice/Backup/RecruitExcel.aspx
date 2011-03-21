<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RecruitExcel.aspx.cs" Inherits="Backoffice_Backup_RecruitExcel" %>
<%@ Import Namespace="Com.Library.DB.Company" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv=Content-Type content='application/vnd.ms-excel; charset=utf-8'>
</head>
<body>
<table border="1">
<tr style="background-color:Yellow">
    <td>기업번호</td>
    <td>채용등록번호</td>
    <td>언어</td>
    <td>등록일</td>
    <td>참가여부</td>
    <td>면접관수</td>
    <td>면접관명</td>
    <td>구인직종-1</td>
    <td>구인직종-2</td>
    <td>경력</td>
    <td>인원</td>
    <td>성별</td>
    <td>나이</td>
    <td>학력</td>
    <td>전공</td>
    <td>중국어</td>
    <td>영어</td>
    <td>일본어</td>
    <td>기타언어-1</td>
    <td>기타언어-2</td>
    <td>주요업무</td>
    <td>근무지역-1</td>
    <td>근무지역-2</td>
    <td>상세주소</td>
    <td>채용예정시기</td>
    <td>급여</td>
    <td>계약기간</td>
    <td>근무시간</td>
    <td>보험</td>
    <td>숙식</td>
    <td>퇴직금</td>
    <td>휴가</td>
    <td>기타</td>
    <td>기타자격요건</td>
</tr>
<%foreach( RecruitEntity item in RecruitList ) { %>
<tr>
    <td><%=item.CompanyNo %></td>
    <td><%=item.RecruitNo %></td>
    <td><%=item.CountryNo == 1 ? "한국어" : (item.CountryNo == 2 ? "중국어" : "영어")%></td>
    <td><%=item.RegistryTime.ToString("yyyy-MM-dd HH:mm:ss") %></td>
    <td><%=item.JoinType == 0 ? "불참":"참가" %></td>
    <td><%=item.JobFairValue %></td>
    <td><%=item.JobFairRecruiter %></td>
    <td><%=GetCategoryName(item.Category1No) %></td>
    <td><%=GetSubCategoryName(item.Category1No) %></td>
    <td><%=item.Career == 0 ? "무관":item.Career.ToString() %></td>
    <td><%=item.RecruitCount %></td>
    <td><%=item.Gender == 1 ? "남" : "여" %></td>
    <td><%=item.AgeType == 0 ? "무관" : ( item.AgeCategory == 0 ? item.AgeEtcValue : GetCategoryName(item.AgeCategory) ) %></td>
    <td><%=GetCategoryName(item.AcademicAbility) %></td>
    <td><%=item.Major == 150 ? item.MajorEtcValue : GetCategoryName(item.Major)%></td>
    <td><%=GetCategoryName(item.ChineseLevel) %></td>
    <td><%=GetCategoryName(item.EnglishLevel) %></td>
    <td><%=GetCategoryName(item.JapanessLevel) %></td>
    <td><%=item.ETCLanguageName%></td>
    <td><%=GetCategoryName(item.ETCLanguageLevel) %></td>
    <td><%=item.MainWork %></td>
    <td><%=GetCategoryName(item.CityCategory) %></td>
    <td><%=GetSubCategoryName(item.AreaCategory) %></td>
    <td><%=item.RecruitAddressDetail%></td>
    <td><%=item.RecruitDate.ToString("yyyy-MM-dd") %></td>
    <td><%=GetCategoryName(item.PayCategory) %></td>
    <td><%=GetCategoryName(item.ContactPeriod) %></td>
    <td><%=item.WorkingHoursType == 0 ? "해당국가 노동법률 의거" : item.WorkingHours%></td>
    <td><%=item.BenefitsInsurance == 0 ? item.BenefitsInsuranceEtcValue : GetCategoryName(item.BenefitsInsurance)%></td>
    <td><%=item.BenefitsRoomAndBoard == 0 ? item.BenefitsRoomAndBoardEtcValue : GetCategoryName(item.BenefitsRoomAndBoard)%></td>
    <td><%=item.BenefitsSeverancePay == 0 ? item.BenefitsSeverancePayEtcValue : GetCategoryName(item.BenefitsSeverancePay)%></td>
    <td><%=item.BenefitsVacation == 0 ? item.BenefitsVacationEtcValue : GetCategoryName(item.BenefitsVacation)%></td>
    <td><%=item.BenefitsETC%></td>
    <td><%=item.EtcEligibilityRule%></td>
</tr>
<%} %>
</table>
</body>
</html>

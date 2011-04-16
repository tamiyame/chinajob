<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/SiteMaster.master" AutoEventWireup="true" CodeFile="human_recruit_manage.aspx.cs" Inherits="KR_User_human_recruit_manage" %>
<%@ Import Namespace="Com.Library.DB.Participate" %>
<%@ Import Namespace="Com.Library.DB.Company" %>
<%@ Import Namespace="Com.Library.DB.Company" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/kr/css/human.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
<br />
                <div class="join">
				    <div class="human-title-recruit-manage"></div>
				    <table class="recruit-table">
						<tr>
							<th>구분</th>
							<th>구인직종</th>
							<th>지원기업</th>
							<th>지원일시</th>
							<th>결과</th>
						</tr>

<% 
        for (int i = 0; i < ParticiapteList.Record.Count; i++)
        {
            CompanyDetailEntity companyDetail = GetCompanyInfo(ParticiapteList.Record[i].CompanyNo);
            RecruitEntity recruit = GetRecruit(ParticiapteList.Record[i].CompanyNo, ParticiapteList.Record[i].RecruitNo, ParticiapteList.Record[i].CountryNo);
%>
            			<tr>
							<td class="col0">
								<select name="UserIDX" style="width:100px;"><%=(ParticiapteList.Record[i].UserIDX == i+1) ? "selected" : "" %>
									<option value="1" <%=ParticiapteList.Record[i].UserIDX == 1 ? "selected" : "" %>>1지망</option>
									<option value="2" <%=ParticiapteList.Record[i].UserIDX == 2 ? "selected" : "" %>>2지망</option>
									<option value="3" <%=ParticiapteList.Record[i].UserIDX == 3 ? "selected" : "" %>>3지망</option>
									<option value="0">지원취소</option>
								</select>
								<input type="hidden" name="SeqNo" value="<%=ParticiapteList.Record[i].SeqNo%>" />
							</td>
							<td class="col1"><%=recruit.Category2No == 360 ? recruit.CategoryEtcValue : (GetCategoryName(recruit.Category1No) + "<br/>" + GetSubCategoryName(recruit.Category2No))%></td>
							<td class="col2"><%=companyDetail.KRName != string.Empty ? companyDetail.KRName : (companyDetail.CNName == string.Empty ? companyDetail.CNName : companyDetail.ENGName)%> (<%=ParticiapteList.Record[i].CompanyNo%>)</td>
							<td class="col3"><%=ParticiapteList.Record[i].DateLastUpdated.ToString("yyyy-MM-dd HH:mm:ss") %></td>
							<td class="col4"><%=ParticiapteList.Record[i].ConfirmType== 0 ? "대기" : (ParticiapteList.Record[i].ConfirmType == 1 ? "승인" : "거절") %></td>
						</tr>
<%
    }
%>                        
				    </table>
				    <div style="text-align:center;margin-top:30px;"><a href="javascript:;" onclick="onSet(); return false;" class="icon icon-board-confirm"></a></div>
				</div>				
<script language="javascript" type="text/javascript">
function onSet()
{
    var arrTest = new Array();
    var b = false;
    jQuery("select[name=UserIDX]").each(function()
    {
        if ( arrTest[jQuery(this).val()] == undefined )
            arrTest[jQuery(this).val()] = 1;
        else
            b = true;
    });
    
    if ( b )
    {
        alert( "구분에 같은 지원을 선택하실수 없습니다." );
        return;
    }
    jQuery("form:eq(0)").submit();
}
</script>

</asp:Content>


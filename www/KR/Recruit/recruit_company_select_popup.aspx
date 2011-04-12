<%@ Page Language="C#" AutoEventWireup="true" CodeFile="recruit_company_select_popup.aspx.cs" Inherits="KR_Recruit_recruit_company_select_popup" %>
<%@ Import Namespace="Com.Library.DB.Participate" %>
<%@ Import Namespace="Com.Library.DB.Company" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/kr/Css/base.css" />
	<link rel="stylesheet" type="text/css" href="/ImgSrv/kr/Css/icon.css" />
	<link rel="stylesheet" type="text/css" href="/ImgSrv/kr/Css/popup.css" />
	<title>희망지원 기업 선택</title>
    <script type="text/javascript" src="/js/jquery-1.4.2.min.js"> </script>
	<script type="text/javascript" src="/js/common.js"></script>	
	<style>
		.company-select{color:#676767;width:560px;height:360px;padding:20px;line-height:15px;}
		.company-select input{border:none;}
		.company-select p,
		.company-select div,
		.company-select td,
		.company-select label{font-size:12px;}		
		.company-select h1{font-size:12px;font-weight:bold;color:#010101;margin-bottom:12px;}
		.company-select .company-select-table{margin-top:30px;margin-bottom:30px;width:100%;}
		.company-select .company-select-table tr{height:27px;}
		.company-select .company-select-table td{border:1px solid #dededc;}
		.company-select .company-select-table td.col1{color:#7b7f82;width:113px;background-color:#e5f0f6;text-align:center;}
		.company-select .company-select-table td.col2{color:#7b7f82;padding-left:9px;width:205px;}
		.company-select .company-select-table td.col3{padding-left:9px;color:#469ed9;}
		.company-select div.info{color:#999999; }		
		.company-select .paragraph{margin-left:9px;color:#999999;}
		.company-select .small{font-size:11px;}		
		.company-select .tool-box{margin-top:39px; text-align:center;}
	</style>

</head>
<body>
    <form id="form1" runat="server">
<asp:ScriptManager ID="sm" runat="server" EnablePageMethods="true"></asp:ScriptManager>
<div class="company-select">
		<h1>희망지원 기업 선택</h1>		
		<p>아래 3가지 중 선택하세요.<br/>단, 중복 선택 시 기존 희망지원 기업은 삭제됩니다.</p>
		<table class="company-select-table">
<% 
    for (int cnt = 0; cnt < 3; cnt++)
    {
        bool b = false;
        for (int i = 0; i < ParticipateList.Record.Count; i++)
        {
            if (ParticipateList.Record[i].UserIDX == ( cnt + 1) )
            {
                b = true;
                CompanyDetailEntity companyDetail = GetCompanyInfo(ParticipateList.Record[i].CompanyNo);
%>
			<tr>
				<td class="col1">
					<input type="radio" name="UserIDX" id="select-<%=cnt %>" value="<%=cnt+1 %>"/>&nbsp;<label for="select-<%=cnt %>"><%=cnt + 1%>지망</label>
				</td>
				<td class="col2">
					<%=companyDetail.KRName != string.Empty ? companyDetail.KRName : (companyDetail.CNName != string.Empty ? companyDetail.CNName : companyDetail.ENGName)%>
				</td>
				<td class="col3">
				    <%=GetCategoryName(ParticipateList.Record[i].Category1No)%>, 
					<%=GetSubCategoryName(ParticipateList.Record[i].Category2No)%> 
				</td>
			</tr>
<%
            }
        }
        if (!b)
        {
%>
            <tr>
				<td class="col1">
					<input type="radio" name="UserIDX" id="select-<%=cnt %>" value="<%=cnt+1 %>"/>&nbsp;<label for="select-<%=cnt %>"><%=cnt + 1%>지망</label>
				</td>
				<td class="col2">
				    -
				</td>
				<td class="col3">
					-
				</td>
			</tr>
<%
        }
    }
%>
		</table>
		<div class="info">
			희망지원 회사
			<div class="paragraph">
				1. 이력서 입력 후, 희망하는 채용정보에 채용지원 <br/>
				2. 동일한 방법으로 1, 2, 3지망 선정<br/>
				3. 해당 기업의 채용담당자의 결과 대기<br/>
				<span class="small">(채용지원 기간 내에 채용지원 건은 변경 가능하며, 지원 결과는 채용지원 기간 이후 확인 가능합니다.)</span>
			</div>
			# 주의: 1, 2, 3지망 모두 거절될 수도 있으며, 결과는 '지원관리'에서 확인할 수 있습니다.
		</div>
		<div class="tool-box">
			<a class="icon icon-board-confirm" href="javascript:;" onclick="Set(); return false;"></a>
		</div>
	</div>

<script language="javascript" type="text/javascript">
function Set()
{
    var UserIDX = 0;
    
    jQuery("input[name=UserIDX]").each(function(){
        if ( jQuery(this).attr("checked") )
        {
            UserIDX = jQuery(this).val();
        }
    });
    
    if ( UserIDX == 0 )
    {
        alert( "선택하세요");
        return false;
    }
    
    if (confirm("등록하시겠습니까?") )
    {
        PageMethods.SetParticiapte(UserIDX, <%=CompanyNo %>, <%=RecruitNo %>, <%=CountryNo %>, 
        function()
        {
            alert( "등록하였습니다.");
            self.close();
        },
        function( results, methodName, context)
        {
            alert(results.get_message() );
        });
    }
}
</script>
    </form>
</body>
</html>

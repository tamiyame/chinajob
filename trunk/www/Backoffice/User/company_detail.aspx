<%@ Page Language="C#" AutoEventWireup="true" CodeFile="company_detail.aspx.cs" Inherits="Backoffice_User_company_detail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">    
		<script type="text/javascript" src="/js/jquery-1.4.2.min.js"> </script>
		<script type="text/javascript" src="/js/link.js"></script>			
		<script type="text/javascript" src="/js/common.js"></script>
    <link rel="stylesheet" type="text/css" href="/ImgSrv/kr/Css/base.css" />
    <link rel="stylesheet" type="text/css" href="/ImgSrv/kr/Css/icon.css" />
    <link rel="stylesheet" type="text/css" href="/ImgSrv/kr/css/company-join.css" />  
    <!--[if IE 6]>
		<link rel="stylesheet" type="text/css" href="/imgsrv/kr/css/base.ie6.css" />
		<script src="/js/DD_belatedPNG.js"></script>
		<script>
		  DD_belatedPNG.fix('.icon');		  
		</script>
<![endif]-->  
    <title>Company Detail</title>
    <style>
        .body{padding:20px;}
        .tab ul {           list-style-type: none;         height:32px;     padding-left:5px;z-index:1;  }
        .tab li{z-index:1;}
        .tab-content{border-top: 1px solid #DBDBDB;    width: 770px;z-index:99;}
        .tab-content table.company{width:770px;margin-top:10px;}
        .tab-content td{padding:0px 5px;}
        .tab-content tr{height:30px;}
        .tab-content td.input{font-size:12px;color:#555555;}
        .tab-content td.label{padding-left:15px;}
        .sub-table td{font-size:12px;color:#555555;}
        .company-logo{width:329px;height:117px;}
        .highlight{color:#469ed9;font-size:12px;font-weight:bold;}
        a.button{border:1px solid #bebebe; background:#fbfbfb;padding:8px 20px;color:Black;}
    </style>
</head>
<body>
<div class="body">
    
    <div class="tab-content">
        <table class="company">
		    <tr>
				<td class="label">����ڵ�</td>
				<td class="input">
					<span class="highlight"><%=CompanyInfo.CompanyNo %></span>
				</td>
			</tr>
			<tr>
				<td class="label">�ΰ��̹���</td>
				<td class="input">
					        <image class="company-logo" src="<%=CompanyDetailInfo.CompanyImage %>" alt=""/>
				</td>
			</tr>
			<tr>
				<td class="label">�����</td>
				<td class="input">
					<table class="sub-table">
						<tr>
							<td class="sub-label">����</td>
							<td class="sub-input"><%=CompanyDetailInfo.KRName %></td>							
						</tr>
							<td class="sub-label">�߹�</td>
							<td class="sub-input"><%=CompanyDetailInfo.CNName %></td>
						</tr>
						<tr>
							<td class="sub-label">����</td>
							<td class="sub-input"><%=CompanyDetailInfo.ENGName %></td>
						</tr>
					</table>
				</td>
			</tr>
			<tr>
				<td class="label">����ڵ�Ϲ�ȣ</td>
				<td class="input">
					<%=CompanyDetailInfo.PermitNo %>
				</td>
			</tr>
			<tr>
				<td class="label">���̵�</td>
				<td class="input">
					<%=CompanyInfo.CompanyID %>
				</td>
			</tr>
			
			<tr>
				<td class="label">�̸���</td>
				<td class="input">
				    <%=CompanyDetailInfo.Email %>
				</td>
			</tr>
			<tr>
				<td class="label">����</td>
				<td class="input">
				<%= GetEtcValue(GetCategoryName(CompanyDetailInfo.BusinessCategoryNo),CompanyDetailInfo.BusinessCategoryEtc) %>
				</td>
			</tr>
			<tr>
				<td class="label">��ǥ�ڸ�</td>
				<td class="input">
				    <%=CompanyDetailInfo.PresidentName %>
				</td>
			</tr>
			<tr>
				<td class="label">�������</td>
				<td class="input"><%= GetCategoryName(CompanyDetailInfo.CapitalType)%>
				</td>
			</tr>
			<tr>
				<td class="label">�����⵵</td>
				<td class="input"><%=CompanyDetailInfo.FoundYear %>��</td>
			</tr>
			<tr>
				<td class="label">�����</td>
				<td class="input"><%=CompanyDetailInfo.EmployeeCount %>��</td>
			</tr>
			<tr>
				<td class="label">�ں���</td>
				<td class="input"><%=CompanyDetailInfo.Capital%><%= GetCategoryName(CompanyDetailInfo.CapitalCurrencyNo)%></td>
			</tr>
			<tr>
				<td class="label">�����</td>
				<td class="input"><%=CompanyDetailInfo.Turnover%><%= GetCategoryName(CompanyDetailInfo.TurnoverCurrencyNo)%></td>
			</tr>
			<tr>
				<td class="label">�ֿ��� ����<br/>(����Ұ�)</td>
				<td class="input">
					<textarea cols="100" rows="8" name="business_description"><%=CompanyDetailInfo.CompanyDescrition %></textarea>
				</td>
			</tr>
			<tr>
				<td class="label">ä������</td>
				<td class="input"><%= CompanyDetailInfo.RecruiterName%></td>
			</tr>
			<tr>
				<td class="label">ȸ�� ��ȭ��ȣ</td>
				<td class="input"><%= CompanyDetailInfo.PhoneNo%></td>
			</tr>
			<tr>
				<td class="label">ȸ�� �ѽ���ȣ</td>
				<td class="input"><%= CompanyDetailInfo.FaxNo%></td>
			</tr>
			<tr>
				<td class="label">��������ּ�</td>
				<td class="input"><%= CompanyDetailInfo.HeadAddress%></td>
			</tr>
			<tr class="bottom">
				<td class="label">Ȩ������</td>
				<td class="input"><%=CompanyDetailInfo.HomepageURL %></td>
			</tr>			
		</table>
		<div style="margin-top:25px;text-align:center;">
		    <a href="javascript:;" class="button" onclick="window.print();">����Ʈ</a>&nbsp;
		    <a href="javascript:;" class="button" onclick="self.close();">�ݱ�</a>
		</div>
    </div>
</div>
</body>
</html>
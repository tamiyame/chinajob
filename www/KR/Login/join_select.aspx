<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/SiteMaster.master" AutoEventWireup="true" CodeFile="join_select.aspx.cs" Inherits="KR_Login_join_select" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/kr/css/company-join.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
                <div class="join-select">
					<img src="/ImgSrv/kr/images/base/join-select.png" usemap="#join-select" border="0"/>
					<map name="join-select">
						<area shape="rect" coords="30,166,231,209" href="<%=this.GetURL("/company/company_join.aspx")%>">
						<area shape="rect" coords="339,166,540,209" href="<%=this.GetURL("/user/human_join.aspx")%>">
					</map>
				</div>

</asp:Content>


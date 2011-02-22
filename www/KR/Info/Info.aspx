<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/InfoMaster.master" AutoEventWireup="true" CodeFile="Info.aspx.cs" Inherits="KR_Info_Info" Title="sdsfsdfsdf" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
<div class="title">
    <img src="<%=SubMenuInfo.SubImageUrl %>"/>
</div>
<div class="contents">
<div class="article">
   <%=SubMenuInfo.CenterContent %>
</div>
</div>
</asp:Content>
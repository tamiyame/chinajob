<%@ Page Language="C#" MasterPageFile="~/Backoffice/WebMaster/BackupMaster.master" AutoEventWireup="true" CodeFile="Backup.aspx.cs" Inherits="Backoffice_Setting_Backup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
<style>
 .backup div{padding:10px 3px;}
 .backup div{font-size:12px;}
 a.button{border:1px solid #bebebe; background:#fbfbfb;padding:4px 8px;font-weight:bold;}
</style>

<div class="title">백업</div>
<div class="desc">현재 DB를 내려받습니다.</div>

<div class="backup">
    백업은 엑셀(xls)로만 가능합니다
    <div>채용정보   <a href="RecruitExcel.aspx" target="_blank" class="button">다운로드</a></div>
    <div>인재정보   <a href="ResumeExcel.aspx" target="_blank" class="button">다운로드</a></div>
    <div>기업회원   <a href="CompanyExcel.aspx" target="_blank" class="button">다운로드</a></div>
    <div>개인회원   <a href="UserExcel.aspx" target="_blank" class="button">다운로드</a></div>    
</div>

</asp:Content>
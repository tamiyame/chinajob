<%@ Page Language="C#"MasterPageFile="~/Backoffice/WebMaster/SettingMaster.master"  AutoEventWireup="true" CodeFile="logo.aspx.cs" Inherits="Backoffice_Setting_Logo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">


<div class="title">로고관리</div>
<div class="desc">박람회의 타이틀 및 로고를 관리합니다.</div>

<div>
    <table>        
        <tr>
            <td>국문</td>
        </tr>
        <tr>
            <td><input type="text" name="KRTitle" value="<%=PageEntity.KRTitle %>"/></td>
        </tr>
        <tr>
            <td><img src="<%=PageEntity.KRLogo %>" width="236px" height="89px;"/></td>
        </tr>
        <tr>
            <td><input type="file" name="fiKRLogo"/></td>            
        </tr>
        <tr>
            <td>로고이미지 크기는 최대 236*96px입니다. JPN,GIF,PNG만 가능합니다.</td>
        </tr>        
    </table>           
    <table>        
        <tr>
            <td>중문</td>
        </tr>
        <tr>
            <td><input type="text" name="CNTitle" value="<%=PageEntity.CNTitle %>"/></td>
        </tr>
        <tr>
            <td><img src="<%=PageEntity.CNLogo %>" width="236px" height="89px;"/></td>
        </tr>
        <tr>
            <td><input type="file" name="fiCNLogo" /></td>            
        </tr>
        <tr>
            <td>로고이미지 크기는 최대 236*96px입니다. JPN,GIF,PNG만 가능합니다.</td>
        </tr>        
    </table> 
    <table>        
        <tr>
            <td>영문</td>
        </tr>
        <tr>
            <td><input type="text" name="ENGTitle" value="<%=PageEntity.ENGTitle %>"/></td>
        </tr>
        <tr>
            <td><img src="<%=PageEntity.ENGLogo %>" width="236px" height="89px;"/></td>
        </tr>
        <tr>
            <td><input type="file" name="fiENGLogo" /></td>            
        </tr>
        <tr>
            <td>로고이미지 크기는 최대 236*96px입니다. JPN,GIF,PNG만 가능합니다.</td>
        </tr>        
    </table> 
    <input type="submit" value="업데이트"/>
</div>
</asp:Content>

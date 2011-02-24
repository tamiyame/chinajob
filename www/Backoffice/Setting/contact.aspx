<%@ Page Language="C#"MasterPageFile="~/Backoffice/WebMaster/SettingMaster.master"  AutoEventWireup="true" CodeFile="contact.aspx.cs" Inherits="Backoffice_Setting_contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">


<div class="title">문의안내</div>
<div class="desc">박람회 운영을 위한 문의 연락처 입니다.</div>

<div>
    <table>   
        <tr>
            <td>전화번호</td>
            <td><input type="text" /></td>
        </tr>      
        <tr>
            <td>팩스번호</td>
            <td><input type="text" /></td>
        </tr>      
        <tr>
            <td>이메일</td>
            <td><input type="text" /></td>
        </tr>      
    </table> 
    <input type="submit" value="업데이트"/>
</div>
</asp:Content>

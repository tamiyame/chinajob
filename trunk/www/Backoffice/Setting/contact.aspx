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
            <td><input type="text" id="PhoneNo" value="<%=PageEntity.PhoneNo%>"/></td>
        </tr>      
        <tr>
            <td>팩스번호</td>
            <td><input type="text" id="FaxNo" value="<%=PageEntity.FaxNo%>"/></td>
        </tr>      
        <tr>
            <td>이메일</td>
            <td><input type="text" id="Email" value="<%=PageEntity.Email%>"/></td>
        </tr>      
    </table> 
    <input type="submit" value="업데이트" onclick="onWrite(); return false;"/>
</div>
<script language="javascript" type="text/javascript">
function onWrite()
{
    var PhoneNo = jQuery("#PhoneNo").val();
    var FaxNo = jQuery("#FaxNo").val();
    var Email = jQuery("#Email").val();
    PageMethods.PageSetting(PhoneNo, FaxNo, Email, function(results, context, methodName)
    {
        alert( "저장되었습니다." );
    },
    function(results, context, methodName)
    {
        alert(results.get_message());
    });
}
</script>
</asp:Content>

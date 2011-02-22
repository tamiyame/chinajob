<%@ Page Language="C#"MasterPageFile="~/Backoffice/WebMaster/BannerMaster.master"  AutoEventWireup="true" CodeFile="banner_regist.aspx.cs" Inherits="Backoffice_Banner_BannerRegist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">


<div class="title">배너관리</div>
<div class="desc">배너를 등록하세요.</div>

<div>
    <input type="hidden" name="BannerNo" value="<%=BannerNo %>"/>
    <input type="hidden" name="BannerType" value="<%=BannerType %>" />
    <input type="hidden" name="Country" value="<%=Country %>" />
    <table>        
        <tr>
            <td>큰이미지</td>
            <td>
                <img src="<%=Banner.LargeImageURL %>" style="width:354px;height:273px;" />
                <input type="file" name="bigImage" />
            </td>
        </tr>
        <tr>
            <td>작은이미지</td>
            <td>
                <img src="<%=Banner.SmallImageUrl %>" style="width:354px;height:105px;"/>
                <input type="file" name="smallImage" />
            </td>
        </tr>
        <tr>
            <td>링크url</td>
            <td><input type="text" name="linkUrl" value="<%=Banner.Link %>" /></td>
        </tr>
    </table>       
    <input type="submit" value="등록"/>
</div>
</asp:Content>

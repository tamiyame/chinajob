<%@ Page Language="C#" MasterPageFile="~/Backoffice/WebMaster/BannerMaster.master"  AutoEventWireup="true" CodeFile="banner_list.aspx.cs" Inherits="Backoffice_Banner_BannerRegist" %>
<%@ Import Namespace="Com.Library.DB.Banner" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<script type="text/javascript">
    $(function(){
        $('input:[name=IsChanged]').val(0);
        $('select:[name=IsView]').change(function(){
            var parent = $(this).parents('tr');
            parent.find('.IsChanged').val(1);
        })
        $('input:[name=OrderNo]').change(function(){
            var parent = $(this).parents('tr');
            parent.find('.IsChanged').val(1);
        })
    })
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">

<style>
 .banner_list{margin-top:20px;}
 .banner_list .IsView td{background:#f5f5f5;} 
 .banner_list table{width:777px;}
 .banner_list table tr{height:33px;}
 .banner_list table th{border: 1px solid #cdcdcd;text-align:center;font-size:12px;}
 .banner_list table td{border: 1px solid #cdcdcd;text-align:center;}
 .bannerListContainer{}
 .bannerListContainer a{border:1px solid #cdcdcd; background:#efefef;padding:5px;}
 .bannerListContainer a.noeffect{border:none; background:#efefef;padding:0px;}
 .tool{overflow:hidden;padding:6px;}
 .tool .left{float:left;}
 .tool .right{float:right;}
</style>

<div class="title">배너관리</div>
<div class="desc"><%=BannerType==1?"채용관리":"인재관리"%>-<%=Country==1?"한국어":(Country==2?"중국어":"영어") %></div>
<div class="bannerListContainer">
    <div class="tool"> 
        <div class="left">
            <a href="./banner_regist.aspx?BannerType=<%=BannerType %>&Country=<%=Country %>">배너추가</a>
        </div>
        <div class="right">
            <a href="javascript:document.forms[0].submit();">화면표시,순서 변경</a>
        </div>
    </div>
    <input type="hidden" name="BannerType" value="<%=BannerType %>"/>
    <input type="hidden" name="Country" value="<%=Country %>"/>
    <div class="banner_list">
        <table>
            <tr>
                <th>그림,링크 수정</th>
                <th>큰이미지</th>
                <th>작은이미지</th>
                <th style="width:250px;">링크</th>
                <th>화면표시</th>
                <th>순서</th>                
                <th>삭제</th>
            </tr>
    <% foreach (BannerEntity item in BannerLists.Record)
       { %>
            <tr <%=item.IsView==1?"class=\"IsView\"":""%>>
                <td><a href="./banner_regist.aspx?BannerType=<%=BannerType %>&Country=<%=Country %>&BannerNo=<%=item.BannerNo %>">그림,링크 수정</a></td>
                <td><img src="<%=item.LargeImageURL %>" style="width:88px;height:68px;" /></td>
                <td><img src="<%=item.SmallImageUrl %>" style="width:88px;height:25px;"/></td>
                <td><a class="noeffect" href="<%=item.Link %>"><%=item.Link %></a></td>
                <td>
                    <input class="IsChanged" type="hidden" name="IsChanged" value="0" />
                    <input type="hidden" name="BannerNo" value="<%=item.BannerNo %>"/>
                    <input type="hidden" name="LargeImageURL" value="<%=item.LargeImageURL %>"/>
                    <input type="hidden" name="SmallImageUrl" value="<%=item.SmallImageUrl %>"/>
                    <input type="hidden" name="ItemBannerType" value="<%=item.BannerType %>"/>
                    <input type="hidden" name="ItemCountry" value="<%=item.CountryNo %>"/>
                    <input type="hidden" name="Link" value="<%=item.Link %>"/>
                    <select name="IsView">
                        <option value="1" <%=item.IsView==1?"selected":"" %>>보임</option>
                        <option value="0" <%=item.IsView==0?"selected":"" %>>안보임</option>
                    </select>
                </td>
                <td><input style="width:50px;" type="text" name="OrderNo" value="<%=item.OrderNo %>"/></td>                
                <td><a href="./banner_delete.aspx?BannerNo=<%=item.BannerNo %>">삭제</a>
            </tr>
    <% } %>
        </table>
    </div>
</div>
</asp:Content>

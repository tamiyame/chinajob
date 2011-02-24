<%@ Page Language="C#" MasterPageFile="~/Backoffice/WebMaster/SettingMaster.master" AutoEventWireup="true" CodeFile="Category1.aspx.cs" Inherits="Backoffice_Setting_Category1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<script type="text/javascript">
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
<style>
 .setting{margin-top:20px;} 
 .setting tr{height:26px;}
 .setting td,
 .setting input,
 .setting select{font-size:12px;}
 .category {}
 .category tr.header td{font-weight:bold;}
 .category td{text-align:center;border-bottom:1px solid #dddddd;}
 .category td.col1{width:150px;}
 .category td.col2{width:150px;}
 .category td.col3{width:150px;}
 .category td.col4{width:100px;}
 .category td.col5{width:100px;}
 .deleteRow td span{color:#dfdfdf;text-decoration:line-through;}
 .registColumn{width:100px}
 .hide{display:none;}
 a.button{border:1px solid #bebebe; background:#fbfbfb;padding:4px 8px;font-weight:bold;}
</style>
<script type="text/javascript">
$(function(){
    function categoryFunctionInit()
    {   
        $('.registTable .modifyButton').unbind();
        $('.registTable .modifyButton').click(function(){
            if($(this).text()=="수정")
            {
                $(this).text("확인"); 
                $(this).parents('.registRow').find('.registColumn').show();
                $(this).parents('.registRow').find('.labelColumn').hide();       
            }else
            { 
                $(this).text("수정");
                $(this).parents('.registRow').find('.registColumn').hide();
                $(this).parents('.registRow').find('.labelColumn').show();       
            }
             
        })
        
        $('.registTable .upButton').unbind();
        $('.registTable .upButton').click(function(){
            var prevRow = $(this).parents('.registRow').prev();
            if(prevRow.length == 0)
                return;                        
            var nowOrder = $(this).parents('.registRow').find('input:[name=order]').val();            
            $(this).parents('.registRow').find('input:[name=order]').val(prevRow.find('input:[name=order]').val());
            prevRow.find('input:[name=order]').val(nowOrder);
            resortTable();
        });
        
        $('.registTable .downButton').unbind();
        $('.registTable .downButton').click(function(){
            var nextRow = $(this).parents('.registRow').next();
            if(nextRow.length == 0)
                return;                        
            var nowOrder = $(this).parents('.registRow').find('input:[name=order]').val();            
            $(this).parents('.registRow').find('input:[name=order]').val(nextRow.find('input:[name=order]').val());
            nextRow.find('input:[name=order]').val(nowOrder);
            resortTable();
        });
        function resortTable()
        {
            
            var rows = $('.registTable tr.registRow');
             rows.sort(function(a, b) {
               var keyA = $(a).find('input:[name=order]').val();
               var keyB = $(b).find('input:[name=order]').val();
               if (keyA < keyB) return -1;
               if (keyA > keyB) return 1;
               return 0;
             });
             $.each(rows, function(index, row) {		 
                $('.registTable').append(row);
             });
        }
        
        $('.registColumn').unbind();
        $('.registColumn').change(function(){
            $(this).parents('.registRow').find('input:[name=IsChange]').val(1);
            $(this).parent().find('.labelColumn').text($(this).val());
        });
        
        $('.registTable .deleteButton').unbind();
        $('.registTable .deleteButton').click(function(){
            if($(this).text()=="삭제") {
                $(this).text("취소"); 
                $(this).parents('.registRow').find('input:[name=IsDelete]').val(1);
                $(this).parents('.registRow').find('.registColumn').hide();
                $(this).parents('.registRow').find('.labelColumn').show();    
                $(this).parents('.registRow').addClass('deleteRow');
                $(this).parents('.registRow').find('.modifyButton').hide();
            }else{
                $(this).text("삭제");
                $(this).parents('.registRow').find('input:[name=IsDelete]').val(0);                                
                $(this).parents('.registRow').removeClass('deleteRow');
                $(this).parents('.registRow').find('.modifyButton').show();
            }
            
        });
    };
    
    var categoryRowTemplate = 
        $('<tr class="registRow">'+
                '<td class="col0">'+
                    '<a class="button upButton" href="javascript:;">위로</a>'+
                    '<a class="button downButton" href="javascript:;">아래로</a>'+
                    '<input type="hidden" name="order" value="11" />'+
                '</td>'+
                '<td class="col1"><span class="labelColumn"></span><input type="text" name="categoryKRName" class="hide registColumn" value=""/></td>'+
                '<td class="col2"><span class="labelColumn"></span><input type="text" name="categoryCNName" class="hide registColumn" value=""/></td>'+
                '<td class="col3"><span class="labelColumn"></span><input type="text" name="categoryENName" class="hide registColumn" value=""/></td>'+
                '<td class="col4"><a class="button modifyButton" href="javascript:;">수정</a></td>'+
                '<td class="col5">'+
                    '<a class="button deleteButton" href="javascript:;">삭제</a>'+
                    '<input type="hidden" name="CategoryID" value="0"/>'+
                    '<input type="hidden" name="IsChange" value="0"/>'+
                    '<input type="hidden" name="IsDelete" value="0"/>'+
                '</td>'+
            '</tr>');
    
    $('.category1Add').click(function(){
        var row = categoryRowTemplate.clone();
        $('.category1').append(row);
        categoryFunctionInit();
        row.find('.modifyButton').click();    
        var max = 0;
        $('input:[name=order]').each(function(){
            if($(this).val() > max)
                max = $(this).val();
        });
        row.find('input:[name=order]').val((++max));
    });
     categoryFunctionInit();
})
</script>

<div class="title">카테고리 관리(지역)</div>
<div class="desc">카테고리 관리</div>
<div class="setting">
    <div style="overflow:hidden;height:30px;padding-top:5px;">
        <div style="float:left;">
            <a class="button" href="javascript:;">업데이트</a>
        </div>
        <div style="float:right;">
            <a class="button category1Add" href="javascript:;">추가</a>
        </div>
    </div>
    <table class="category">
        <tr class="header">
            <td class="col0">순서</td>
            <td class="col1">한글</td>
            <td class="col2">중국어</td>
            <td class="col3">영어</td>
            <td class="col4"></td>
            <td class="col5"></td>
        </tr>
    </table>
    <div style="height:250px;overflow-x: hidden; overflow-y: scroll;">
        <table class="category registTable category1">
            <tr class="registRow">
                <td class="col0">
                    <a class="button upButton" href="javascript:;">위로</a>
                    <a class="button downButton" href="javascript:;">아래로</a>
                    <input type="hidden" name="order" value="11" />
                </td>
                <td class="col1"><span class="labelColumn">길림</span><input type="text" name="categoryKRName" class="hide registColumn" value="길림"/></td>
                <td class="col2"><span class="labelColumn">吉臨</span><input type="text" name="categoryCNName" class="hide registColumn" value="吉臨"/></td>
                <td class="col3"><span class="labelColumn">gil lim</span><input type="text" name="categoryENName" class="hide registColumn" value="gil lim"/></td>
                <td class="col4"><a class="button modifyButton" href="javascript:;">수정</a></td>
                <td class="col5">
                    <a class="button deleteButton" href="javascript:;">삭제</a>   
                    <input type="hidden" name="CategoryID" value="12323"/>                 
                    <input type="hidden" name="IsChange" value="0"/>
                    <input type="hidden" name="IsDelete" value="0"/>                    
                </td>
            </tr>
        </table>        
    </div>    
</div>

</asp:Content>
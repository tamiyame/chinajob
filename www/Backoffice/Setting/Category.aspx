<%@ Page Language="C#" MasterPageFile="~/Backoffice/WebMaster/SettingMaster.master" AutoEventWireup="true" CodeFile="Category.aspx.cs" Inherits="Backoffice_Setting_Category" %>
<%@ Import Namespace="Com.Library.DB.Category" %>
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
 .category td span,
 .category td input,
 .category td{font-size:12px;} 
 .category td{text-align:center;border:1px solid #dddddd;} 
 /*.category td.col0{width:120px;}*/
 .category td.col0{display:none;}
 .category td.col1{width:200px;}
 .category td.col2{width:200px;}
 .category td.col3{width:200px;}
 .category td.col4{width:145px;text-align:left;padding-left:10px;}
 .category td.col5{width:100px;}
 .category td.col5 input{width:20px;}
 .deleteRow td span{color:#dfdfdf;text-decoration:line-through;}
 .modifyRow td {background:#eeeeee;}
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
            $(this).parents('.registRow').addClass('modifyRow');
            $(this).parent().find('.labelColumn').text($(this).val());
        });
        
        $('.registTable .deleteButton').unbind();
        $('.registTable .deleteButton').click(function(){            
            if(lastInserter != null)
            {
                if(
                    $(this).parents('.registRow').find('input:[name=order]').val()==
                    lastInserter.find('input:[name=order]').val()
                )
                {            
                    var krName = lastInserter.find('input:[name=categoryKRName]').val();
                    var cnName = lastInserter.find('input:[name=categoryCNName]').val();
                    var enName = lastInserter.find('input:[name=categoryENName]').val();            
                    if(krName == '' && cnName == '' && enName == '')
                    {
                        lastInserter.remove();
                        lastInserter = null;
                    }
                }
            }
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
                    '<a class="button upButton" href="javascript:;">위로</a>&nbsp;'+
                    '<a class="button downButton" href="javascript:;">아래로</a>'+                    
                '</td>'+
                '<td class="col1"><span class="labelColumn"></span><input type="text" name="categoryKRName" class="hide registColumn" value=""/></td>'+
                '<td class="col2"><span class="labelColumn"></span><input type="text" name="categoryCNName" class="hide registColumn" value=""/></td>'+
                '<td class="col3"><span class="labelColumn"></span><input type="text" name="categoryENName" class="hide registColumn" value=""/></td>'+
                '<td class="col4"><a class="button modifyButton" href="javascript:;">수정</a> '+
                    '<a class="button deleteButton" href="javascript:;">삭제</a>'+
                    '<input type="hidden" name="order" value="11" />'+
                    '<input type="hidden" name="CategoryNo" value="0"/>'+
                    '<input type="hidden" name="IsChange" value="0"/>'+
                    '<input type="hidden" name="IsDelete" value="0"/>'+
                '</td>'+
            '</tr>');
    
    var lastInserter = null;    
    $('.category1Add').click(function(){        
        if(lastInserter != null)
        {
            var krName = lastInserter.find('input:[name=categoryKRName]').val();
            var cnName = lastInserter.find('input:[name=categoryCNName]').val();
            var enName = lastInserter.find('input:[name=categoryENName]').val();            
            if(krName == '' && cnName == '' && enName == '')
            {
                alert('연속으로 두개 추가하실 수 없습니다. 추가한 카테고리에 값을 입력후 추가해주세요.');
                return;
            }
        }
        var row = categoryRowTemplate.clone();
        $('.category1').append(row);
        lastInserter = row;
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

<div class="title">카테고리 관리(<%=CategoryMaster.CategoryMasterName %>)</div>
<div class="desc">카테고리 관리</div>
<div class="setting">
    <div style="overflow:hidden;height:30px;margin-top:5px;">
        <a style="float:left;" class="button" href="javascript:$('form').eq(0).submit();">업데이트</a>
        <a style="float:right;" class="button category1Add" href="javascript:;">추가</a>
    </div>
    <input type="hidden" name="CategoryMaster" value="<%=CategoryMaster.CategoryMasterNo %>" />
    <table class="category registTable category1">
        <tr class="header">
            <td class="col0">순서</td>
            <td class="col1">한글</td>
            <td class="col2">중국어</td>
            <td class="col3">영어</td>
            <td class="col4"></td>
        </tr>
<%foreach (CategoryEntity category in CategoryLists.Record)
  { %>
        <tr class="registRow">
            <td class="col0">
                <a class="button upButton" href="javascript:;">위로</a>
                <a class="button downButton" href="javascript:;">아래로</a>                
            </td>
            <td class="col1">
                <span class="labelColumn"><%=category.CategoryKRName %></span>
                <input type="text" name="categoryKRName" class="hide registColumn" value="<%=category.CategoryKRName %>"/>
            </td>
            <td class="col2">
                <span class="labelColumn"><%=category.CategoryCNName %></span>
                <input type="text" name="categoryCNName" class="hide registColumn" value="<%=category.CategoryCNName %>"/>
            </td>
            <td class="col3">
                <span class="labelColumn"><%=category.CategoryENGName %></span>
                <input type="text" name="categoryENName" class="hide registColumn" value="<%=category.CategoryENGName %>"/>
            </td>
            <td class="col4">
                <a class="button modifyButton" href="javascript:;">수정</a>            
                <a class="button deleteButton" href="javascript:;">삭제</a>
                <a class="button subcategory" href="javascript:;" onclick="window.open('./SubCategory.aspx?CategoryNo=<%=category.CategoryNo %>','','menubar=no,width=700,scrollbars=yes,toolbars=no,resizable=yes','');">서브</a>
                <input type="hidden" name="order" value="11" />   
                <input type="hidden" name="CategoryNo" value="<%=category.CategoryNo %>"/>                 
                <input type="hidden" name="IsChange" value="0"/>
                <input type="hidden" name="IsDelete" value="0"/>                                    
            </td>
        </tr>
<%} %>
<script>

</script>
    </table> 
</div>

</asp:Content>
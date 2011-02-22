<%@ Page Language="C#" MasterPageFile="~/Backoffice/WebMaster/OperationMaster.master" AutoEventWireup="true" CodeFile="board_write.aspx.cs" Inherits="BackOffice_Operation_board_write" ValidateRequest="false" %>
<%@ Import Namespace="Com.Library.DB.Board" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/kr/Css/editor.css" />
<script language="javascript" src="/js/HyperTextArea.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
<div class="title">운영센터</div>
<div class="desc">운영센터 관리입니다(<%=boardName%>)</div>

                         
                        <div class="contents">
                            <table class="board-write">
                                <tr class="top">
                                    <td class="col1">분류<span class="require">*</span></td>
                                    <td class="col2">
                                        <select name="BoardCategoryNo">
<% foreach (BoardCategoryEntity item in BoardCategoryList) { %>
                                            <option value="<%=item.BoardCategoryNo %>"><%=item.CategoryName%></option>
<% } %>
                                        </select>
                                    </td>
                                    <td class="col3">제목<span class="require">*</span></td>
                                    <td class="col4">
                                        <input type="text" name="ArticleTitle" id="ArticleTitle" />
                                    </td>
                                </tr>
                                <tr class="middle">
                                    <td colspan="4">
                                        <div class="wyswig-editor">
                                            <div class="wyswig-tool">
                                                <div class="toolbox">
                                                    <select id="TEditor_fontSyle" class="font-type">
                                                        <option value="0">글꼴</option>
                                                        <option value="Arial, Helvetica, sans-serif">Arial</option>
                                                        <option value="Courier New, Courier, mono">Courier New</option>
                                                        <option value="Times New Roman, Times, serif">Times New Roman</option>
                                                        <option value="Verdana, Arial, Helvetica, sans-serif">Verdana</option>
                                                    </select>
                                                </div>
                                                <div class="toolbox">
                                                    <select id="TEditor_fontSize" class="font-size">
                                                        <option value="0">크기</option>
                                                        <option value="1">1</option>
                                                        <option value="2">2</option>
                                                        <option value="3">3</option>
                                                        <option value="4">4</option>
                                                        <option value="5">5</option>
                                                        <option value="6">6</option>
                                                        <option value="7">7</option>
                                                        <option value="8">8</option>
                                                    </select>  
                                                </div>
                                                <div class="toolbox"> 
                                                    <img id="TEditor_bold" src="/imgsrv/kr/images/editor/bold.png" />        
                                                    <img id="TEditor_underline" src="/imgsrv/kr/images/editor/underline.png" />
                                                    <img id="TEditor_italic" src="/imgsrv/kr/images/editor/italic.png" />                                                    
                                                    <img id="TEditor_forecolor" src="/imgsrv/kr/images/editor/font_color.png" />
                                                    <img id="TEditor_hilitecolor" src="/imgsrv/kr/images/editor/background_color.png" />
                                                </div>
                                                <div class="toolbox"> 
                                                    <img id="TEditor_image" src="/imgsrv/kr/images/editor/image.png" />
                                                </div>
                                                <div class="toolbox"> 
                                                    <img id="TEditor_editor" src="/imgsrv/kr/images/editor/editor.png" />                                
                                                </div>
                                                <div class="toolbox"> 
                                                    <img id="TEditor_html" src="/imgsrv/kr/images/editor/html.png" />
                                                </div>
                                            </div>
                                            <div class="wyswig-textarea">
                                                <textarea id="ArticleContent" name="ArticleContent" id="ArticleContent" style="display:none;"></textarea>
                                                <textarea id="ArticleSomeContent" name="ArticleSomeContent" id="ArticleSomeContent" style="display:none;"></textarea>
                                            </div>          
                                        </div> 
                                    </td>
                                </tr>
                                <tr class="last">
                                    <td class="col1" colspan="2">
                                        <!--<table>
                                            <tr>
                                                <td><input type="checkbox" class="checkbox" name="secret_check"/></td>
                                                <td>비밀글</td>
                                                <td><input type="password" name="secret_password" /></td>
                                            </tr>
                                        </table>-->
                                    </td>
                                    <td class="col2" colspan="2">
                                        <a href="javascript:;" onclick="onWrite(); return false;" class="icon icon-board-confirm"></a>
                                        <a href="<%=PageMoveWithBoardNo("board_list.aspx",BoardNo)%>" class="icon icon-board-cancle"></a>
                                    </td>
                                </tr>
                            </table>
                        </div>
<script language="JavaScript" type="text/javascript">
var TextEditor = new HyperTextArea("TEditor", '', 687, 285,"");
jQuery( "#TEditor_bold" ).click( function(){ TextEditor.formatText( "bold", "" ); } );
jQuery( "#TEditor_italic" ).click( function(){ TextEditor.formatText( "italic", "" ); } );
jQuery( "#TEditor_underline" ).click( function(){ TextEditor.formatText( "underline", "" ); } );
jQuery( "#TEditor_forecolor" ).click( function(){ TextEditor.formatText( "forecolor", "" ); $('#cpTEditor').css('left',($(this).position().left)); });
jQuery( "#TEditor_hilitecolor" ).click( function(){ TextEditor.formatText( "hilitecolor", "" ); $('#cpTEditor').css('left',($(this).position().left));} );
jQuery( "#TEditor_fontSize" ).bind( "change", function(){ if ( parseInt( this.value, 10 ) != 0 ) { TextEditor.formatText( "fontsize", this.value ); } });
jQuery( "#TEditor_fontSyle" ).bind( "change", function(){ if ( parseInt( this.value, 10 ) != 0 ) { TextEditor.formatText( "fontname", this.value ); } });
jQuery( "#TEditor_editor" ).click( function(){TextEditor.setViewMode(false);  } );
jQuery( "#TEditor_html" ).click( function(){ TextEditor.setViewMode(true);  } );
jQuery( "#TEditor_image" ).click( function(){ window.open( "/kr/popup/fileuploader.aspx", "fileuploader", "width=404, height=222" )});
jQuery( "#cpTEditor" ).appendTo('.wyswig-textarea');
jQuery( "#TEditor" ).appendTo('.wyswig-textarea');


function onWrite()
{
    if ( $( "#ArticleTitle" ).val() == "" )
    {
        alert( "제목을 입력하세요");
        return false;
    }
    
    TextEditor.update();
    jQuery( "#ArticleContent" ).val( TextEditor.html );
    
    if ( TextEditor.html == "" )
    {
        alert( "내용을 입력하세요" );
        return false;
    }
    
    document.forms[ 0 ].submit();
    
    
}

</script>

</asp:Content>


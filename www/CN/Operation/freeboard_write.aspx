<%@ Page Language="C#" MasterPageFile="~/CN/WebMaster/OperationMaster.master" AutoEventWireup="true" CodeFile="freeboard_write.aspx.cs" Inherits="CN_Operation_freeboard_write" ValidateRequest="false" %>
<%@ Import Namespace="Com.Library.DB.Board" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/cn/Css/editor.css" />
<script language="javascript" src="/js/HyperTextArea.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
                         <div class="title">
                            <div class="operation-title-freeboard"></div>
                        </div>
                        <div class="contents">
                            <table class="board-write">
                                <tr class="top">
                                    <td class="col1"><%= GetText("CN_Operation_freeboard_write.aspx_14")%><span class="require">*</span></td>
                                    <td class="col2">
                                        <select name="BoardCategoryNo">
<% foreach (BoardCategoryEntity item in BoardCategoryList) { %>
                                            <option value="<%=item.BoardCategoryNo %>"><%=item.CategoryName%></option>
<% } %>
                                        </select>
                                    </td>
                                    <td class="col3"><%= GetText("CN_Operation_freeboard_write.aspx_22")%><span class="require">*</span></td>
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
                                                        <option value="0"><%= GetText("CN_Operation_freeboard_write.aspx_33")%></option>
                                                        <option value="Arial, Helvetica, sans-serif">Arial</option>
                                                        <option value="Courier New, Courier, mono">Courier New</option>
                                                        <option value="Times New Roman, Times, serif">Times New Roman</option>
                                                        <option value="Verdana, Arial, Helvetica, sans-serif">Verdana</option>
                                                    </select>
                                                </div>
                                                <div class="toolbox">
                                                    <select id="TEditor_fontSize" class="font-size">
                                                        <option value="0"><%= GetText("CN_Operation_freeboard_write.aspx_42")%></option>
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
                                                    <img id="TEditor_bold" src="/ImgSrv/cn/images/editor/bold.png" />        
                                                    <img id="TEditor_underline" src="/ImgSrv/cn/images/editor/underline.png" />
                                                    <img id="TEditor_italic" src="/ImgSrv/cn/images/editor/italic.png" />                                                    
                                                    <img id="TEditor_forecolor" src="/ImgSrv/cn/images/editor/font_color.png" />
                                                    <img id="TEditor_hilitecolor" src="/ImgSrv/cn/images/editor/background_color.png" />
                                                </div>
                                                <div class="toolbox"> 
                                                   <img id="TEditor_image" src="/ImgSrv/cn/images/editor/image.png" />
                                                </div>
                                                <div class="toolbox"> 
                                                    <img id="TEditor_editor" src="/ImgSrv/cn/images/editor/editor.png" />                                
                                                </div>
                                                <div class="toolbox"> 
                                                    <img id="TEditor_html" src="/ImgSrv/cn/images/editor/html.png" />
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
                                        <a href="<%=PageMove("freeboard_list.aspx")%>" class="icon icon-board-cancle"></a>
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
        alert( "<%= GetText("CN_Operation_freeboard_write.aspx_114")%>");
        return false;
    }
    
    TextEditor.update();
    jQuery( "#ArticleContent" ).val( TextEditor.html );
    
    if ( TextEditor.html == "" )
    {
        alert( "<%= GetText("CN_Operation_freeboard_write.aspx_123")%>" );
        return false;
    }
    
    document.forms[ 0 ].submit();
    
    
}

</script>

</asp:Content>


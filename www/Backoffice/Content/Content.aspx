<%@ Page Language="C#" MasterPageFile="~/Backoffice/WebMaster/ContentMaster.master" AutoEventWireup="true" CodeFile="Content.aspx.cs" Inherits="Backoffice_Content_Content"  ValidateRequest="false" %>
<%@ Import Namespace="Com.Library.DB.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/kr/Css/editor.css" />
<script language="javascript" src="/js/HyperTextArea.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
<div class="title">박람회 소개</div>
<div class="desc">박람회 컨텐츠 관리입니다</div>
<div class="tab">
    <ul>
        <li class="<%=CountryNo == 1 ? "select icon icon-folder-big-on" : "icon icon-folder-big-off"%> korean"
            onclick="location.replace('Content.aspx?CountryNo=1&TopMenuNo=<%=TopMenuNo%>&SubMenuNo=<%=SubMenuNo %>')">
            <div>한국어</div>
        </li>

        <li class="<%=CountryNo == 2 ? "select icon icon-folder-big-on" : "icon icon-folder-big-off"%> china"
            onclick="location.replace('Content.aspx?CountryNo=2&TopMenuNo=<%=TopMenuNo%>&SubMenuNo=<%=SubMenuNo %>')">
            <div>中文</div>
        </li>													
        <li class="<%=CountryNo == 3 ? "select icon icon-folder-big-on" : "icon icon-folder-big-off"%> english"
            onclick="location.replace('Content.aspx?CountryNo=3&TopMenuNo=<%=TopMenuNo%>&SubMenuNo=<%=SubMenuNo %>')">
            <div>english</div>
        </li>				
    </ul>						
</div>
<div class="tab-content">
    <div class="promote">    
        <table class="promote-input-table">
            <tr>
                <td class="col1">서브메뉴</td>
                <td class="col2">
                    <select name="promote_type" style="width:200px;" onchange="onChange(this);">
<% foreach (SubMenuEntity item in SubMenuList) { %>
                        <option value="<%=item.SubMenuNo %>" <%=item.SubMenuNo == SubMenuNo ? "Selected='selected'" : "" %>><%=item.SubMenuName %></option>
<% } %>
                    </select>
<script language="javascript">
function onChange( obj )
{
    location.href= "Content.aspx?CountryNo=<%=CountryNo %>&TopMenuNo=<%=TopMenuNo%>&SubMenuNo=" + obj.value;
}
</script>
                </td>
            </tr>
            <tr>
                <td class="col1">타이틀이미지</td>
                <td class="col2">
                    <table>
                        <tr>
                            <td><img src="<%=SubMenuInfo.SubImageUrl%>"/></td>
                        </tr>
                        <tr>
                            <td><input type="file" name="title_image" /></td>
                        </tr>
                    </table>                
                </td>
            </tr>
            <tr class="noboarder">
                <td colspan="2" class="col1">
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
                            <textarea id="ArticleContent" name="ArticleContent" style="display:none;"></textarea>
                        </div>          
                    </div>  
                </td>
            </tr>
            <tr class="noboarder">
                <td colspan="2">
                    <a href="javascript:;" onclick="onModify(); return false;" class="icon icon-board-confirm"></a>
                    <!--<a href="javascript:;" class="icon icon-board-cancle"></a>-->
                </td>
            </tr>
        </table>
        
        <script language="JavaScript" type="text/javascript">
            var TextEditor = new HyperTextArea("TEditor", "<%= SubMenuInfo.CenterContent.Replace( "\r\n", "" ).Replace("\"", "\\\"") %>", 687, 285,"","border:none");
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
            jQuery( "#TEditor" ).attr({'frameborder':'0px','border':'0px'}).appendTo('.wyswig-textarea');
        </script>
    </div>
</div>

<script language="javascript" type="text/javascript">
function onModify()
{
    TextEditor.update();
    jQuery( "#ArticleContent" ).val( TextEditor.html );
    document.forms[ 0 ].submit();
}
</script>


</asp:Content>


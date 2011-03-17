<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/RecruitMaster.master" AutoEventWireup="true" CodeFile="recruit_regist_list.aspx.cs" Inherits="KR_Company_recruit_list" %>

<%@ Import Namespace="Com.Library.DB.Category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/kr/Css/recruit.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
<asp:ScriptManagerProxy ID="px" runat="server">
    <Services>
        <asp:ServiceReference Path="~/Soap/Recruit.asmx"></asp:ServiceReference>
    </Services>
</asp:ScriptManagerProxy>
<div class="recruit-list-title"></div>
<table class="recruit-list">
<tbody id="tbody_recruitList">
</tbody>
<tfoot>
	<tr class="last">
	    <td class="col3" colspan="3"><a class="icon icon-recruit-btn-new" href="javascript:;"></a></td>
	</tr>
</tfoot>
</table>   
<div class="recruit-list-guide"></div>
<script language="javascript" type="text/javascript">
jQuery(function()
{
    jQuery.CreateInit();
});

(function($)
{
    var _tempRemove = null;
    var _tempCreate = null;
    $.extend({
        CreateInit : function()
        {
            $( "tfoot tr td a.icon" ).click(function(){ $.AppendRow() });
            
            $.RecruitGetList();
        },
        
        AppendRow : function()
        {
            var $tr = $("<tr class='regist'/>")
            $tr.append(
                $('<td class="col1"><%= GetText("CN_Company_recruit_regist_list.aspx_17")%></td>')
            ).append(
                $('<td class="col2"><input type="text" maxlength="50" /></td>')
            ).append(
                $('<td class="col3"><a class="icon icon-recruit-btn-new" href="javascript:;" onclick="jQuery.RecruitCreate( this ); return false;"></a></td>')
            )
            
            $( "#tbody_recruitList" ).append( $tr);
        },
        
        RecruitCreate : function( obj )
        {
            if ( _tempCreate == null )
            {
                _tempCreate = obj;
                var recrutTitle = $.trim($( obj ).closest("tr").find("td.col2 input:[type=text]").val());
                if ( recrutTitle == "" )
                {
                    alert( "제목을 입력하세요" );
                    return false;
                }
                Site.Web.Soap.Recruit.MasterCreate(recrutTitle, $.onRecruitCreate, $.onRecruitFailed );
            }
        },
        
        RecruitRemove : function( obj, recruitNo )
        {
            if ( _tempRemove == null )
            {
                if ( confirm( "<%= GetText("CN_Company_recruit_regist_list.aspx_78")%>" ) )
                {
                    _tempRemove = obj;
                    Site.Web.Soap.Recruit.MasterRemove( recruitNo, $.onRecruitRemove, $.onRecruitFailed );
                }
            }
        },
        
        RecruitGetList : function()
        {
            Site.Web.Soap.Recruit.MasterGetList( $.onRecruitList, $.onRecruitFailed );
        },
        
        onRecruitCreate : function(results, methodName, context)
        {
            $( _tempCreate ).closest("tr").remove();
            $.RecruitGetList();
            _tempCreate = null;
        },
        
        onRecruitRemove : function(results, methodName, context)
        {
            $( _tempRemove ).closest("tr").remove();
            _tempRemove = null;
        },
        
        onRecruitList : function( results, methodName, context)
        {
            $( "#tbody_recruitList" ).html( "" );
            $(results).each(function(){
                var $tr = $("<tr class='regist'/>")
                $tr.append(
                    $('<td class="col1"><%= GetText("CN_Company_recruit_regist_list.aspx_17")%></td>')
                ).append(
                    $('<td class="col2">' + this.RecruitTitle + '</td>')
                ).append(
                    $('<td class="col3" />' ).append(
                        $('<a class="icon icon-recruit-btn-korean" href="recruit_regist.aspx?CountryNo=1&RecruitNo=' + this.RecruitNo + '"></a>')
                    ).append(
                        $('<a class="icon icon-recruit-btn-china" href="recruit_regist_cn.aspx?CountryNo=2&RecruitNo=' + this.RecruitNo + '"></a>')
                    ).append(
                        $('<a class="icon icon-recruit-btn-delete" href="javascript:;" onclick="jQuery.RecruitRemove(this, ' + this.RecruitNo + '); return false;"></a>')
                    )
                    /*
                    .append(
                        $('<a class="icon icon-recruit-btn-english" href="recruit_regist_eng.aspx?CountryNo=3&RecruitNo=' + this.RecruitNo + '"></a>')
                    )
                    */
                )
                
                $( "#tbody_recruitList" ).prepend( $tr);
            });
        },
        
        onFailed : function(results, methodName, context)
        {
        }
    });
})(jQuery);

</script>


</asp:Content>


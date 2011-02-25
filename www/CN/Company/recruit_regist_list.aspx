<%@ Page Language="C#" MasterPageFile="~/CN/WebMaster/RecruitMaster.master" AutoEventWireup="true" CodeFile="recruit_regist_list.aspx.cs" Inherits="CN_Company_recruit_list" %>

<%@ Import Namespace="Com.Library.DB.Category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/cn/Css/recruit.css" />
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
	<tr>
	    <td class="col1">채용제목</td>
	    <td class="col2">디자인 전략팀 매니저</td>
	    <td class="col3"><a class="icon icon-recruit-btn-korean" href="javascript:;"></a>
	    <a class="icon icon-recruit-btn-china" href="javascript:;"></a>
	    <a class="icon icon-recruit-btn-english" href="javascript:;"></a>
	    <a class="icon icon-recruit-btn-delete" href="javascript:;" onclick="jQuery.RecruitRemove(this); return false;"></a></td>
	</tr>
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
                $('<td class="col1">채용제목</td>')
            ).append(
                $('<td class="col2"><input type="text" /></td>')
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
                var recrutTitle = $( obj ).closest("tr").find("td.col2 input:[type=text]").val();
                Site.Web.Soap.Recruit.MasterCreate(recrutTitle, $.onRecruitCreate, $.onRecruitFailed );
            }
        },
        
        RecruitRemove : function( obj, recruitNo )
        {
            if ( _tempRemove == null )
            {
                if ( confirm( "정말로 삭제하시겠습니까?" ) )
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
                    $('<td class="col1">채용제목</td>')
                ).append(
                    $('<td class="col2">' + this.RecruitTitle + '</td>')
                ).append(
                    /*
                    $('<td class="col3" />' ).append(
                        $('<a class="icon icon-recruit-btn-korean" href="recruit_regist.aspx?CountryNo=1&RecruitNo=' + this.RecruitNo + '"></a>')
                    ).append(
                        $('<a class="icon icon-recruit-btn-china" href="recruit_regist.aspx?CountryNo=2&RecruitNo=' + this.RecruitNo + '"></a>')
                    ).append(
                        $('<a class="icon icon-recruit-btn-english" href="recruit_regist.aspx?CountryNo=3&RecruitNo=' + this.RecruitNo + '"></a>')
                    ).append(
                        $('<a class="icon icon-recruit-btn-delete" href="javascript:;" onclick="jQuery.RecruitRemove(this, ' + this.RecruitNo + '); return false;"></a>')
                    )
                    */
                    $('<td class="col3" />' ).append(
                        $('<a class="icon icon-recruit-btn-korean" href="recruit_regist.aspx?CountryNo=1&RecruitNo=' + this.RecruitNo + '"></a>')
                    ).append(
                        $('<a class="icon icon-recruit-btn-delete" href="javascript:;" onclick="jQuery.RecruitRemove(this, ' + this.RecruitNo + '); return false;"></a>')
                    )
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


<%@ Page Language="C#" MasterPageFile="~/CN/WebMaster/SiteMaster.master" AutoEventWireup="true" CodeFile="recruit_manage.aspx.cs" Inherits="CN_Company_recruit_manage" %>
<%@ Import Namespace="Com.Library.DB.Company" %>
<%@ Import Namespace="Com.Library.DB.Category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/cn/Css/recruit.css" />
<script language="javascript" src="/js/translateJs_cn_company.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
<div class="center">
    <div class="main">
        <div class="recruit-manage-title"></div>
        <div class="tab-content">
	        <div class="korean">
                <table class="recruit-manage">
                    <tbody>
<%foreach (RecruitMasterEntity item in RecruitList) { %>
                    <tr class="recruit-paper" id="tr_<%=item.RecruitNo %>" onclick="btnRecruit(<%=item.RecruitNo %>); return false;" style="cursor:pointer;">
                        <td class="col1"><%=GetText("CN_Company_recruit_manage.aspx_recruitTitle") %></td>
                        <td class="col2"><%=item.RecruitTitle %></td>
 
                    </tr>
                    <tr id="tr_hide_<%=item.RecruitNo %>" style="display:none;">
                        <td colspan="2">
                        </td>
                    </tr>
<% } %>
                    </tbody>
                </table>
<script language="javascript" type="text/javascript">
var _RecruitNo = null;
function btnRecruit( recruitNo )
{
    if ( _RecruitNo == recruitNo )
        return;
    jQuery("#tr_hide_" + _RecruitNo + " td").html( "" );
    jQuery("#tr_hide_" + _RecruitNo).hide();
    _RecruitNo = recruitNo;
    PageMethods.ParticipateGetList(recruitNo, onParticipateGetList, onFailed);
}

function onParticipateGetList(results, methodName, context)
{
    $table = jQuery("<table class='recruit-manage'/>")
    jQuery.each(results.Record, function()
    {
        $table.append(
            jQuery("<tr class='applicant' />").append(
                jQuery('<td class="col1">'+$.translateHelper.getText("CN_Company_recruit_manage.aspx_regist")+'</td>')
            ).append(
                jQuery('<td class="col2"><span class="name">' + ( this.CNUserName == "" ? ( this.ENGUserName == "" ? this.KRUserName : this.ENGUserName ) : this.CNUserName ) + 
                    '</span><span class="gender-age">(' + ( this.Gender % 2 == 1 ? $.translateHelper.getText("CN_Company_recruit_manage.aspx_male") : $.translateHelper.getText("CN_Company_recruit_manage.aspx_female") ) + ',' + this.Age + $.translateHelper.getText("CN_Company_recruit_manage.aspx_age") +')</span></td>'
                    )
            ).append(
                jQuery('<td class="col3">' + ( this.Career == 1 ? $.translateHelper.getText("CN_Company_recruit_manage.aspx_new") : $.translateHelper.getText("CN_Company_recruit_manage.aspx_career") ) + '</td>')
            ).append(
                jQuery('<td class="col4"></td>')
            ).append(
                jQuery('<td class="col5">'+$.translateHelper.getText("CN_Company_recruit_manage.aspx_registDate")+'</td>')
            ).append(
                jQuery('<td class="col6">' + this.StrDateCreated + '</td>')
            ).append(
                jQuery('<td class="col7">'+$.translateHelper.getText("CN_Company_recruit_manage.aspx_wait")+'</td>')
            )
<% if ( this.IsParticipate ) { %>
            .append(
                jQuery('<td class="col8"><a href="/kr/Recruit/human_detail_basic.aspx?userno=' + this.UserNo + '" target="_blank">'+$.translateHelper.getText("CN_Company_recruit_manage.aspx_show")+'</a></td>')
            ).append(
                jQuery('<td class="col9">' + ( this.ConfirmType == 1 ? "<b>"+$.translateHelper.getText("CN_Company_recruit_manage.aspx_approved")+"</b>" : "<a href='#' onclick='btnConfirm(" + this.SeqNo + ", 1)'>"+$.translateHelper.getText("CN_Company_recruit_manage.aspx_approved")+"</a>" ) + '</td>')
            ).append(
                jQuery('<td class="col10">' + ( this.ConfirmType == 2 ? "<b>"+$.translateHelper.getText("CN_Company_recruit_manage.aspx_deny")+"</b>" : "<a href='#' onclick='btnConfirm(" + this.SeqNo + ", 2)'>"+$.translateHelper.getText("CN_Company_recruit_manage.aspx_deny")+"</a>" ) + '</td>')
            ).append(
                jQuery('<td class="col11"></td>')
            )
<% } %>
        );
    });
    jQuery("#tr_hide_" + _RecruitNo + " td").html( "" ).append($table);
    jQuery("#tr_hide_" + _RecruitNo).show();
}

function btnConfirm(seqno, type)
{
    if ( type == 1 )
    {
        if ( !confirm($.translateHelper.getText("CN_Company_recruit_manage.aspx_approve?")) )
        {
            return;
        }
    }
    else
    {
        if ( !confirm($.translateHelper.getText("CN_Company_recruit_manage.aspx_deny?")) )
        {
            return;
        }
    }
    PageMethods.SetConfirm(seqno, type, function(results, context, methodNames)
    {
       PageMethods.ParticipateGetList(_RecruitNo, onParticipateGetList, onFailed);
    }, onFailed );
}

function btnRemove(seqno)
{
    if ( confirm($.translateHelper.getText("CN_Company_recruit_manage.aspx_delete?")) )
    {
        PageMethods.Remove(seqno, function(results, context, methodNames)
        {
            PageMethods.ParticipateGetList(_RecruitNo, onParticipateGetList, onFailed);
        }, onFailed );
    }
}

function onFailed(results, methodName, context)
{
    alert(results.get_message());
}
</script>
	        </div>
        </div>
    </div>
</div>
<script language="javascript" type="text/javascript">
jQuery(function()
{
    jQuery.CreateInit();
});

(function($)
{
    $.extend({
        CreateInit : function()
        {
        }
    });
})(jQuery);

</script>


</asp:Content>


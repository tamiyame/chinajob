<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/SiteMaster.master" AutoEventWireup="true" CodeFile="recruit_manage.aspx.cs" Inherits="KR_Company_recruit_manage" %>
<%@ Import Namespace="Com.Library.DB.Company" %>
<%@ Import Namespace="Com.Library.DB.Category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/KR/Css/recruit.css" />
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
                        <td class="col1">구인직종</td>
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
                jQuery('<td class="col1">지원자</td>')
            ).append(
                jQuery('<td class="col2"><span class="name">' + ( this.KRUserName != "" ? this.KRUserName : ( this.ENGUserName != "" ? this.ENGUserName : this.CNUserName ) ) + 
                    '</span><span class="gender-age">(' + ( this.Gender % 2 == 1 ? "남" : "여" ) + ',' + this.Age + '세)</span></td>'
                    )
            ).append(
                jQuery('<td class="col3">' + ( this.Career == 1 ? '신입' : '경력' ) + '</td>')
            ).append(
                jQuery('<td class="col4"></td>')
            ).append(
                jQuery('<td class="col5">지원일시</td>')
            ).append(
                jQuery('<td class="col6">' + this.StrDateCreated + '</td>')
            ).append(
                jQuery('<td class="col7">대기</td>')
            ).append(
                jQuery('<td class="col8"><a href="/kr/user/resume_view.aspx?userno=' + this.UserNo + '" target="_blank">보기</a></td>')
            ).append(
                jQuery('<td class="col9">' + ( this.ConfirmType == 1 ? "<b>승인</b>" : "<a href='#' onclick='btnConfirm(" + this.SeqNo + ", 1)'>승인</a>" ) + '</td>')
            ).append(
                jQuery('<td class="col10">' + ( this.ConfirmType == 2 ? "<b>거절</b>" : "<a href='#' onclick='btnConfirm(" + this.SeqNo + ", 2)'>거절</a>" ) + '</td>')
            ).append(
                jQuery('<td class="col11"></td>')
            )
        );
    });
    jQuery("#tr_hide_" + _RecruitNo + " td").html( "" ).append($table);
    jQuery("#tr_hide_" + _RecruitNo).show();
}

function btnConfirm(seqno, type)
{
    if ( type == 2 )
    {
        if ( !confirm("승인하시겠습니까?") )
        {
            return;
        }
    }
    else
    {
        if ( !confirm("거절하시겠습니까?") )
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
    if ( confirm("삭제하시겠습니까?") )
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


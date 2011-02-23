<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/SiteMaster.master" AutoEventWireup="true" CodeFile="recruit_manage.aspx.cs" Inherits="KR_Company_recruit_manage" %>

<%@ Import Namespace="Com.Library.DB.Category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/KR/Css/recruit.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
<div class="center">
    <div class="main">
        <div class="recruit-manage-title"></div>
        <div class="tab">
	        <ul>
		        <li class="select icon icon-folder-big-on korean">
			        <div>한국어</div>
		        </li>

		        <li class="icon icon-folder-big-off china">
			        <div>中文</div>
		        </li>													
		        <li class="icon icon-folder-big-off english">
			        <div>english</div>
		        </li>				
	        </ul>						
        </div>
        <div class="tab-content">
	        <div class="korean">
                <table class="recruit-manage">
                    <tr class="recruit-paper">
                        <td class="col1">구인직종</td>
                        <td class="col2" colspan="6">디자인 전략팀 매니저</td>
                        <td class="col8"><a class="icon icon-small-btn button" href="javascript:;">보기</a></td>
                        <td class="col9"><a class="icon icon-small-btn button" href="javascript:;">수정</a></td>
                        <td class="col10"><a class="icon icon-small-btn button" href="javascript:;">삭제</a></td>
                        <td class="col11"></td>
                    </tr>
                    <tr class="applicant">
                        <td class="col1">지원자</td>
                        <td class="col2"><span class="name">김개똥</span><span class="gender-age">(여,24세)</span></td>
                        <td class="col3">신입</td>
                        <td class="col4">한양대학교</td>
                        <td class="col5">지원일시</td>
                        <td class="col6">2011 3-11 14:53</td>
                        <td class="col7">대기</td>
                        <td class="col8">보기</td>
                        <td class="col9">승인</td>
                        <td class="col10">거절</td>
                        <td class="col11"></td>
                    </tr>
                    <tr class="applicant">
                        <td class="col1">지원자</td>
                        <td class="col2"><span class="name">김개똥</span><span class="gender-age">(여,24세)</span></td>
                        <td class="col3">신입</td>
                        <td class="col4">한양대학교</td>
                        <td class="col5">지원일시</td>
                        <td class="col6">2011 3-11 14:53</td>
                        <td class="col7">대기</td>
                        <td class="col8">보기</td>
                        <td class="col9">승인</td>
                        <td class="col10">거절</td>
                        <td class="col11"></td>
                    </tr>
                    <tr class="applicant">
                        <td class="col1">지원자</td>
                        <td class="col2"><span class="name">김개똥</span><span class="gender-age">(여,24세)</span></td>
                        <td class="col3">신입</td>
                        <td class="col4">한양대학교</td>
                        <td class="col5">지원일시</td>
                        <td class="col6">2011 3-11 14:53</td>
                        <td class="col7">대기</td>
                        <td class="col8">보기</td>
                        <td class="col9">승인</td>
                        <td class="col10">거절</td>
                        <td class="col11"></td>
                    </tr>
                    <tr class="recruit-paper">
                        <td class="col1">구인직종</td>
                        <td class="col2" colspan="6">디자인 전략팀 매니저</td>
                        <td class="col8"><a class="icon icon-small-btn button" href="javascript:;">보기</a></td>
                        <td class="col9"><a class="icon icon-small-btn button" href="javascript:;">수정</a></td>
                        <td class="col10"><a class="icon icon-small-btn button" href="javascript:;">삭제</a></td>
                        <td class="col11"></td>
                    </tr>
                    <tr class="applicant">
                        <td class="col1">지원자</td>
                        <td class="col2"><span class="name">김개똥</span><span class="gender-age">(여,24세)</span></td>
                        <td class="col3">신입</td>
                        <td class="col4">한양대학교</td>
                        <td class="col5">지원일시</td>
                        <td class="col6">2011 3-11 14:53</td>
                        <td class="col7">대기</td>
                        <td class="col8">보기</td>
                        <td class="col9">승인</td>
                        <td class="col10">거절</td>
                        <td class="col11"></td>
                    </tr>
                    <tr class="applicant">
                        <td class="col1">지원자</td>
                        <td class="col2"><span class="name">김개똥</span><span class="gender-age">(여,24세)</span></td>
                        <td class="col3">신입</td>
                        <td class="col4">한양대학교</td>
                        <td class="col5">지원일시</td>
                        <td class="col6">2011 3-11 14:53</td>
                        <td class="col7">대기</td>
                        <td class="col8">보기</td>
                        <td class="col9">승인</td>
                        <td class="col10">거절</td>
                        <td class="col11"></td>
                    </tr>
                    <tr class="applicant">
                        <td class="col1">지원자</td>
                        <td class="col2"><span class="name">김개똥</span><span class="gender-age">(여,24세)</span></td>
                        <td class="col3">신입</td>
                        <td class="col4">한양대학교</td>
                        <td class="col5">지원일시</td>
                        <td class="col6">2011 3-11 14:53</td>
                        <td class="col7">대기</td>
                        <td class="col8">보기</td>
                        <td class="col9">승인</td>
                        <td class="col10">거절</td>
                        <td class="col11"></td>
                    </tr>
                </table>
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


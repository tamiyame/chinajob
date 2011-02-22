<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/ParticipationMaster.master" AutoEventWireup="true" CodeFile="template_company_info_popup.aspx.cs" Inherits="KR_Participation_Info" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
<div class="popup">
    <table class="company-popup">
        <tr class="top">
            <td class="col1">기업정보</td>
            <td class="col2"><a href="javascript:;" class="icon icon-small-modify-btn"></a></td>
        </tr>
        <tr class="data">
            <td>
                <table class="company-summary">
                    <tr>
                        <td class="company-image"><image src="/FileServer/Company/10/Company_1024.jpg"></image></td>
                    </tr>
                    <tr>
                        <td class="company-desc">삼성패션은 패션 무역기업으로 한국과 중국을 삼성패션은 패션 무역기업으로 한국과 중국을 삼성패션은 패션 무역기업으로 한국과 중국을 삼성패션은 패션 무역기업으로 한국과 중국을 삼성패션은 패션 무역기업으로 한국과 중국을 삼성패션은 패션 무역기업으로 한국과 중국을 삼성패션은 패션 무역기업으로 한국과 중국을 삼성패션은 패션 무역기업으로 한국과 중국을</td>
                    </tr>
                </table>
            </td>
            <td>
                <table class="company-detail">
                    <tr>
                        <td class="col1">기업명</td>
                        <td class="col2">삼성패션 북경지사<br />三星贸易有限公司<br />SAMSUNG Fashion</td>
                    </tr>
                    <tr>
                        <td class="col1">업종</td>
                        <td class="col2">무역/도소매업 - 무역, 도소매, 유통</td>
                    </tr>
                    <tr>
                        <td class="col1">대표자</td>
                        <td class="col2">김개똥</td>
                        <td class="col3">기업유형</td>
                        <td class="col4">합자</td>
                    </tr>
                    <tr>
                        <td class="col1">홈페이지</td>
                        <td class="col2">www.samsung.cn</td>
                    </tr>
                    <tr>
                        <td class="col1">설립년도</td>
                        <td class="col2">2007년</td>
                        <td class="col3">사원수</td>
                        <td class="col4">400명</td>
                    </tr>
                    <tr>
                        <td class="col1">자본금</td>
                        <td class="col2">290,000RMB</td>
                        <td class="col3">매출액</td>
                        <td class="col4">500,000,000RMB</td>
                    </tr>
                    <tr>
                        <td class="col1">주소</td>
                        <td class="col2">북경 왕징시 3342호 삼성빌딩</td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
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


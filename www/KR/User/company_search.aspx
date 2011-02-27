<%@ Page Language="C#" AutoEventWireup="true" CodeFile="company_search.aspx.cs" Inherits="KR_User_company_search" %>
<%@ Import Namespace="Com.Library.DB.Company" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">   
    <title>회사 코드 검색</title> 
		<script type="text/javascript" src="/js/jquery-1.4.2.min.js"> </script>
		<script type="text/javascript" src="/js/link.js"></script>			
		<script type="text/javascript" src="/js/common.js"></script>    
    <link rel="stylesheet" type="text/css" href="/ImgSrv/kr/Css/icon.css" />
<style>
    *{padding:0px;margin:0px;}
    a.button{border:1px solid #bebebe; background:#fbfbfb;padding:5px 20px 2px;font-weight:bold;}
    table td.label{color:#7d7d7d;font-size:9pt;background-color:#e4eff6;width:100px;text-align:center;}
    td{vertical-align:middle;}
    td label{margin-top:3px;}
    table {border-collapse:collapse;}
    table tr{padding:0px;height:25px;}
    table td{border:1px solid #dbdbdb;padding:0px;}
    table td td{border:none;}
    a,a:hover,a:link,a:visited{text-decoration: none;color:#464646;}  
    body{width:360px;padding:10px;}
    .search{padding:2px 5px 0px;}
    .search a{padding:0px 10px;border:1px solid #dbdbdb; font-size:9pt;color:#454545;}
    option{font-size:9pt;color:#7d7d7d;}
</style>
<!--[if lte IE 7]>
<style>
    table td.search{padding:0px;}
    .search a{padding:3px 10px 0px;}
</style>
<![endif]-->
</head>
<script type="text/javascript">
    $(function(){
        $('select:[name=selectBox]').click(function(){
            var value = $(this).val();
            if(value == null)
                return;
            var r=confirm($('option:[value='+value+']').text()+"를 선택하시겠습니까?");
            if (r==true)
            {                
                opener.SetJobType(<%=no %>,value);                
                window.close();
            }
            else
                return;
        })
    });
</script>
<body>
<form id="form1" runat="server">
    <input type="hidden" name="no" value="<%=no %>" />
    <div>
        <div>
            <span style="color:#555555;font-size:9pt;font-weight:bold;">희망지원 회사 코드 검색</span>
            <span style="color:#999999;font-size:8pt;letter-spacing:-1px;">(검색결과 중 원하는 기업을 선택하세요)</span>        
        </div>
        <div>
            <table  style="width:360px;margin-top:5px;">
                <!--
                <tr>
                    <td class="label">선택</td>
                    <td style="padding:0 5px;">
                        <table>
                            <tr>
                                <td style="padding:0 2px 0 6px;">
                                    <input id="search_type_1" name="search_type" type="radio" />
                                </td>
                                <td style="padding-top:5px;">
                                    <label for="search_type_1" style="color:#555555;font-size:9pt;">기업명</label>
                                </td>  
                                <td style="padding:0 2px 0 10px;">
                                    <input id="search_type_2" name="search_type" type="radio" />
                                </td>
                                <td style="padding-top:5px;">
                                    <label for="search_type_2" style="color:#555555;font-size:9pt;">기업코드</label>
                                </td>                                
                            </tr>
                        </table>
                    </td>
                </tr>
                -->
                <tr>
                    <td class="label">검색어</td>
                    <td style="padding:0 5px;">
                        <table>
                            <tr>
                                <td style="padding:0 5px;">
                                    <input style="width:175px; border:1px solid #dbdbdb;" type="text" name="searchValue"/>
                                </td>
                                <td class="search" >
                                    <a href="javascript:;" onclick="$('form').eq(0).submit();">검색</a>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="padding:2px;">
                        <select name="selectBox" style="width:100%; border:1px solid #dbdbdb;" size="10">
<% if (SearchList != null)
{%>
<% foreach (CompanyDetailEntity item in SearchList.Record)
   { %>
                            <option value="<%=item.CompanyNo%>"><%=item.KRName%>(<%=item.CompanyNo%>)</option>
<%}
} %>
                        </select>
                    </td>
                </tr>
            </table>
        </div>
        <div style="margin-top:15px; text-align:center;">
            <a style="display:inline-block; font-size:9pt;color:#454545;font-weight:normal;" class="button" href="javascript:window.close();">닫기</a>
        </div>
    </div>
</form>
</body>
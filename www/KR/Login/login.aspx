<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/SiteMaster.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="KR_Login_login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/kr/Css/login.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
<div class="login">
    <div class="login-desc"></div>
    <div class="tab">
	    <ul>
		    <li class="select icon icon-folder-on company">
			    <div onclick="location.href='login.aspx';">기업회원</div>
		    </li>
		    <li class="last icon icon-folder-off person">
			    <div onclick="location.href='login_user.aspx';">개인회원</div>
		    </li>													
	    </ul>						
    </div>
    <div class="loginform company" id="divCompany">			
		    <table>
			    <tr>
				    <td>아이디</td>
				    <td><input type="text" name="id" id="company_id"/></td>
				    <td rowspan="2"><a class="icon icon-login-big" href="#" onclick="jQuery.LoginProc(1); return false;"></a></td>
			    </tr>
			    <tr>
				    <td>비밀번호</td>
				    <td><input type="password" name="pw" id="company_pwd"/></td>									
			    </tr>
		    </table>
		    <div class="tool">
			    <a class="id-find" href="<%=this.GetURL("/login/find_id.aspx")%>">아이디찾기</a>
			    <a class="pw-find" href="<%=this.GetURL("/login/find_pw.aspx")%>">비밀번호찾기</a>
		    </div>
		    <div class="join-btn">
			    <a class="icon icon-join-big" href="<%=GetURL("/company/company_join.aspx")%>"></a>
		    </div>
    </div>
</div>
<script language="javascript" type="text/javascript">
(function($)
{
    $.extend({
        LoginProc : function(type)
        {
            var userid = $("#company_id").val();
            var userpwd = $("#company_pwd").val();
            if ( userid == "" )
            {
                alert( "아이디를 입력하세요");
                return false;
            }
            if ( userpwd == "" )
            {
                alert( "비밀번호를 입력하세요");
                return false;
            }
            $.Login(1, userid, userpwd, false, GetURL("/home/"));
        }
    });
})(jQuery);
</script>

</asp:Content>


<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/SiteMaster.master" AutoEventWireup="true" CodeFile="login_user.aspx.cs" Inherits="KR_Login_login_user" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/kr/Css/login.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
<div class="login">
    <div class="login-desc"></div>
    <div class="tab">
	    <ul>
		    <li class="icon icon-folder-off company">
			    <div onclick="location.href='login.aspx';">기업회원</div>
		    </li>
		    <li class="last select icon icon-folder-on person">
			    <div onclick="location.href='login_user.aspx';">개인회원</div>
		    </li>													
	    </ul>						
    </div>
    <div class="loginform person " id="divPerson">
		    <table>
			    <tr>
				    <td>아이디</td>
				    <td><input type="text" name="id" id="user_id"/></td>
				    <td rowspan="2"><a class="icon icon-login-big" href="#" onclick="jQuery.LoginProc(2); return false;"></a></td>
			    </tr>
			    <tr>
				    <td>비밀번호</td>
				    <td><input type="password" name="pw" id="user_pwd"/></td>									
			    </tr>
		    </table>
		    <div class="tool">
			    <a class="id-find" href="/login/find_id.aspx">아이디찾기</a>
			    <a class="pw-find" href="/login/find_pw.aspx">비밀번호찾기</a>
		    </div>
		    <div class="join-btn">
			    <a class="icon icon-join-big-person" href="<%=GetURL("/user/human_join.aspx")%>"></a>
		    </div>
    </div>
</div>
<script language="javascript" type="text/javascript">
(function($)
{
    $.extend({
        LoginProc : function(type)
        {
            var userid = $("#user_id").val();
            var userpwd = $("#user_pwd").val();
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
            $.Login(2, userid, userpwd, false, GetURL("/home/"));
        }
    });
})(jQuery);
</script>

</asp:Content>


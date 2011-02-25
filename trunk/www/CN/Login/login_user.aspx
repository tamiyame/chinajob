<%@ Page Language="C#" MasterPageFile="~/CN/WebMaster/SiteMaster.master" AutoEventWireup="true" CodeFile="login_user.aspx.cs" Inherits="CN_Login_login_user"%>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/cn/Css/login.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
<div class="login">
    <div class="login-desc"></div>
    <div class="tab">
	    <ul>
		    <li class="icon icon-folder-off company">
			    <div onclick="location.href='login.aspx';"><%= GetText("CN_Login_login_user.aspx_12")%></div>
		    </li>
		    <li class="last select icon icon-folder-on person">
			    <div onclick="location.href='login_user.aspx';"><%= GetText("CN_Login_login_user.aspx_15")%></div>
		    </li>													
	    </ul>						
    </div>
    <div class="loginform person " id="divPerson">
		    <table>
			    <tr>
				    <td><%= GetText("CN_Login_login_user.aspx_22")%></td>
				    <td><input type="text" name="id" id="user_id"/></td>
				    <td rowspan="2"><a class="icon icon-login-big" href="#" onclick="jQuery.LoginProc(2); return false;"></a></td>
			    </tr>
			    <tr>
				    <td><%= GetText("CN_Login_login_user.aspx_27")%></td>
				    <td><input type="password" name="pw" id="user_pwd"/></td>									
			    </tr>
		    </table>
		    <div class="tool">
			    <a class="id-find" href="/login/find_id.aspx"><%= GetText("CN_Login_login_user.aspx_32")%></a>
			    <a class="pw-find" href="/login/find_pw.aspx"><%= GetText("CN_Login_login_user.aspx_33")%></a>
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
                alert($.translateHelper.getText("CN_Login_login_user.aspx_50"));
                return false;
            }
            if ( userpwd == "" )
            {
                alert($.translateHelper.getText("CN_Login_login_user.aspx_55"));
                return false;
            }
            $.Login(2, userid, userpwd, false, GetURL("/home/"));
        }
    });
})(jQuery);
</script>

</asp:Content>


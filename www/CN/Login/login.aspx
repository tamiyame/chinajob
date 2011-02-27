<%@ Page Language="C#" MasterPageFile="~/CN/WebMaster/SiteMaster.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="CN_Login_login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/cn/Css/login.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
<div class="login">
    <div class="login-desc"></div>
    <div class="tab">
	    <ul>
		    <li class="select icon icon-folder-on company">
			    <div onclick="location.href='login.aspx';"><%= GetText("CN_Login_login.aspx_12")%></div>
		    </li>
		    <li class="last icon icon-folder-off person">
			    <!--<div onclick="location.href='login_user.aspx';"><%= GetText("CN_Login_login.aspx_15")%></div>-->
		    </li>													
	    </ul>						
    </div>
    <div class="loginform company" id="divCompany">			
		    <table>
			    <tr>
				    <td><%= GetText("CN_Login_login.aspx_22")%></td>
				    <td><input type="text" name="id" id="company_id"/></td>
				    <td rowspan="2"><a class="icon icon-login-big" href="#" onclick="jQuery.LoginProc(1); return false;"></a></td>
			    </tr>
			    <tr>
				    <td><%= GetText("CN_Login_login.aspx_27")%></td>
				    <td><input type="password" name="pw" id="company_pwd"/></td>									
			    </tr>
		    </table>
		    <div class="tool">
			    <a class="id-find" href="<%=this.GetURL("/login/find_id.aspx")%>"><%= GetText("CN_Login_login.aspx_32")%></a>
			    <a class="pw-find" href="<%=this.GetURL("/login/find_pw.aspx")%>"><%= GetText("CN_Login_login.aspx_33")%></a>
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
                alert($.translateHelper.getText("CN_Login_login.aspx_50"));
                return false;
            }
            if ( userpwd == "" )
            {
                alert($.translateHelper.getText("CN_Login_login.aspx_55"));
                return false;
            }
            $.Login(1, userid, userpwd, false, GetURL("/home/"));
        }
    });
})(jQuery);
</script>

</asp:Content>


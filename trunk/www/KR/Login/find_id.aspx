<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/SiteMaster.master" AutoEventWireup="true" CodeFile="find_id.aspx.cs" Inherits="KR_Login_find_id" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/kr/css/login.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
<asp:ScriptManagerProxy ID="px" runat="server">
    <Services>
        <asp:ServiceReference Path="~/Soap/User.asmx"></asp:ServiceReference>
    </Services>
</asp:ScriptManagerProxy>
                <div class="login">
					<div class="login-desc idfind-desc"></div>
					<div class="tab">
						<ul>
							<li class="select icon icon-folder-on find-id">
								<div onclick="location.href='find_id.aspx';">아이디</div>
							</li>
							<li class="last icon icon-folder-off find-pw">
								<div onclick="location.href='find_pw.aspx';">비밀번호</div>
							</li>													
						</ul>						
					</div>
					<div class="loginform find-id">			
							<table>
							    <tr>
									<td>회원형태</td>
									<td colspan="2">
									    <input id="user_type_1" class="radio" type="radio" name="user_type" value="1"/>
									    <label for="user_type_1">기업</label>
									    <input id="user_type_2" class="radio" type="radio" name="user_type" value="2"/>
									    <label for="user_type_2">개인</label>
									</td>									
								</tr>
								<tr>
									<td>이메일</td>
									<td><input class="login-input" type="text" name="email"/></td>
									<td><a class="icon icon-send-oper" href="javascript:;" onclick="jQuery.SendMail(); return false;"></a></td>
								</tr>
							</table>
							<div class="tool">
								<span class="require">*</span>회원가입시,기입한 이메일을 입력하세요
							</div>
							<div class="join-btn">
								<a class="icon icon-question-oper" href="<%=GetURL("/operation/freeboard_list.aspx") %>"></a>
							</div>
					</div>
				</div>
<script language="javascript" type="text/javascript">
(function($)
{
    $.extend({
        SendMail : function()
        {
            var type = 0;
            $("input:[name=user_type]").each(function()
            {
                if ( $(this).attr("checked") )
                {
                    type = $(this).val();
                }
            });
            if ( type == 0 )
            {
                alert( "회원형태를 선택하세요");
                return false;
            }
            var email = $("input:[name=email]").val();
            
            if ( email == "" )
            {
                alert( "이메일을 입력하세요" );
                return false;
            }
            
            Site.Web.Soap.User.UserID_SendMail(type, email, 
            function(results, context, methodNames)
            {
                if ( results )
                {
                    alert( "발송하였습니다.");
                }
                else
                {
                    alert( "잘못된 정보를 입력하였습니다.");
                }
            },
            function(results, context, methodNames)
            {
                alert( results.get_message());
            });
        }
    });
})(jQuery)
</script>
</asp:Content>


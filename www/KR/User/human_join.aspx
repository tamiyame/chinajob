<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/SiteMaster.master" AutoEventWireup="true" CodeFile="human_join.aspx.cs" Inherits="KR_User_human_join"%>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/kr/Css/human.css" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">

<asp:ScriptManagerProxy ID="px" runat="server">
    <Services>
        <asp:ServiceReference Path="~/Soap/User.asmx"></asp:ServiceReference>
    </Services>
</asp:ScriptManagerProxy>

                <div class="join">
				    <div class="human-title-join"></div>
				    <table class="join-table">
				        <tr>
				            <td class="label">사진</td>
				            <td>
				                <table>
				                    <tr>
				                        <td><input type="file" name="UserImage"/></td>
				                        <td class="desc">사진사이즈는 100*134px이며 JPG,GIF,PNG만 가능합니다.</td>
				                    </tr>
				                </table>
				            </td>
				        </tr>
				        <tr>
				            <td class="label">성명<span class="require">*</span></td>
				            <td>
				                <table class="name">
				                    <tr>
				                        <td>국문</td><td><input type="text" name="KRName" maxlength="30"/></td>
				                        <td rowspan="3" class="desc">
				                            주민등록증에 등록된 정규적인 성명을 입력하는것을 추천하며,<br />
				                            국문,중문,영문 중 반드시 하나 이상 기입하셔야 합니다.
				                        </td>
				                    </tr>
				                    <tr><td>중문</td><td><input type="text" name="CNName"  maxlength="30"/></td></tr>
				                    <tr><td>영문</td><td><input type="text" name="ENGName"  maxlength="30"/></td></tr>
				                </table>
				            </td>
				        </tr>
				        <tr>
				            <td class="label">성별<span class="require">*</span></td>
				            <td>
				                <table>
				                    <tr>
				                        <td>
				                            <input type="radio" class="radio" name="Gender" value="1" id="gender_1"/>
				                        </td>
				                        <td>
				                            <label for="gender_1">남</label>
				                        </td>
				                        <td>
				                            <input type="radio" class="radio" name="Gender" value="2" id="gender_2"/>
				                        </td>
				                        <td>
				                            <label for="gender_2">여</label>
				                        </td>
				                    </tr>
				                </table>
				            </td>
				        </tr>
				        <tr>
				            <td class="label">출생년월<span class="require">*</span></td>
				            <td>
				                 <table>
                                    <tr>
                                        <td>
                                            <select class="year" name="Birthday_Year">
                                    <% for (int i = 1940; i < DateTime.Now.Year + 3; i++){ %>
										<option value="<%=i %>" ><%=i %></option>
									<% } %>
                                            </select>년
                                        </td>
                                        <td>
                                            <select class="month" name="Birthday_Month">
                                     <%for ( int i = 1; i <= 12; i ++ ) { %>
										<option value="<%=i %>" ><%=i %></option> 
									 <% } %>
                                            </select>월
                                        </td>
                                        <td>
                                            <select class="day" name="Birthday_Day">
                                     <%for ( int i = 1; i <= 31; i ++ ) { %>
										<option value="<%=i %>"><%=i %></option> 
									 <% } %>
                                            </select><span class="label">일</span>
                                        </td>
                                    </tr>
                                </table>
				            </td>
				        </tr>
				        <tr>
				            <td class="label">아이디<span class="require">*</span></td>
				            <td>				                
								<table>
									<tr>
										<td><input class="w2" name="UserID" type="text"  maxlength="20"/></td>
										<td><a href="javascript:;" class="icon icon-duplicate-check" id="aUserID"></a></td>
										<td class="desc" id="tdUserID">영문,숫자 또는 조합 4~12자리,특수문자 불가</td>
									</tr>
								</table>							
				            </td>
				        </tr>
				        <tr>
				            <td class="label">비밀번호<span class="require">*</span></td>
				            <td>
				                <table>
				                    <tr>
										<td><input class="w2" name="UserPWD" type="text"  maxlength="20"/></td>										
										<td class="desc">영문,숫자 조합 또는 4~12자리</td>
									</tr>
				                </table>
				            </td>
				        </tr>
				        <tr>
				            <td class="label">비밀번호확인<span class="require">*</span></td>
				            <td>
				                 <table>
				                    <tr>
										<td><input class="w2" name="UserPWD_confirm" type="password"  maxlength="20"/></td>										
										<td class="desc">비밀번호를 다시 한번 입력해주세요</td>
									</tr>
				                </table>
				            </td>
				        </tr>
				        <tr>
				            <td class="label">이메일<span class="require">*</span></td>
				            <td>
				                <table>
				                    <tr>
										<td><input class="w2" name="Email" type="text"  maxlength="100"/></td>
										<td><a href="javascript:;" class="icon icon-duplicate-check" id="aEmail"></a></td>
										<td class="desc" id="tdEmail">가장 자주 쓰는 이메일 하나만 입력하세요</td>
									</tr>
				                </table>
				            </td>
				        </tr>
				        <tr>
				            <td class="label">연락처<span class="require">*</span></td>
				            <td>
				                 <table>
				                    <tr>
				                        <td>한국</td>
										<td><input class="w2" name="KRPhoneNo" type="text"  maxlength="30"/></td>
										<td class="blank"></td>
										<td>중국</td>
										<td><input class="w2" name="CNPhoneNo" type="text"  maxlength="30"/></td>
										<td class="desc">하나 이상 기입하셔야 합니다</td>
									</tr>
				                </table>                
				            </td>
				        </tr>
				        <tr>
				            <td class="label">현재 거주국<span class="require">*</span></td>
				            <td>
				                <table>
				                    <tr>
				                        <td>
				                            <input type="radio" class="radio" name="ResidanceCountry" value="1" id="national_1"/>
				                        </td>
				                        <td>
				                            <label for="national_1">한국</label>
				                        </td>
				                        <td>
				                            <input type="radio" class="radio" name="ResidanceCountry" value="2" id="national_2"/>
				                        </td>
				                        <td>
				                            <label for="national_2">중국</label>
				                        </td>
				                    </tr>
				                </table>    
				            </td>
				        </tr>
				        <tr>
				            <td class="label">개인홈페이지</td>
				            <td>
				                <table>
				                    <tr>
										<td><input class="w2" name="HomepageUrl" type="input"  maxlength="100"/></td>										
										<td class="desc">입력 예 http://www.chinajobgo.com</td>
									</tr>
				                </table>
				            </td>
				        </tr>
				    </table>				    	
				    <div class="regist-item">
                        <div class="regist-tool">
                            <span class="agree">
                                <input class="checkbox" id="agree" name="agree" type="checkbox" />
                                <label for="agree">상기 개인정보 내용이 틀림없는 사실임을 확인합니다.</label>
                                </span>
                            <br />
                            <br />
                            <br />
                            <br />
                            <a class="icon icon-human-join-btn" href="javascript:;" onclick="jQuery.onWrite(); return false;"></a>
                        </div>
                    </div>
                </div>
<script language="javascript" type="text/javascript">
jQuery(function()
{
    jQuery.CreateInit();
});

(function($){
    var UserID = "";
    var Email = "";
    var isPrecess = false;
    $.extend({
        CreateInit:function()
        {
            $("input:[name=UserID]").bind("keypress", function() {
                UserID = "";
            });
            $("input:[name=Email]").bind("keypress", function() {
                Email = "";
            });
            
            $("#aUserID").click(function()
            {
                $.IsUserID();
                return false;
            });
            
            $("#aEmail").click(function()
            {
                $.IsEmail();
                return false;
            });
        },
        
        onWrite : function()
        {
            var UserImage = $("input[name=UserImage]").val();
            var KRName = $("input[name=KRName]").val();
            var CNName = $("input[name=CNName]").val();
            var ENGName = $("input[name=ENGName]").val();
            var Gender = false;
            var Birthday_Year = $("select[name=Birthday_Year]").val();
            var Birthday_Month = $("select[name=Birthday_Month]").val();
            var Birthday_Day = $("select[name=Birthday_Day]").val();
            var UserPWD = $("input[name=UserPWD]").val();
            var UserPWD_confirm = $("input[name=UserPWD_confirm]").val();
            var KRPhoneNo = $("input[name=KRPhoneNo]").val();
            var CNPhoneNo = $("input[name=CNPhoneNo]").val();
            var ResidanceCountry = false;
            var HomepageUrl = $("input[name=HomepageUrl]").val();
            
            if ( isPrecess )
            {
                alert( "가입 진행중입니다.\n잠시만 기다리세요");
                return false;
            }
            
            $("input[name=Gender]").each(function()
            {
                if ( $(this).attr("checked") )
                {
                    Gender = true;
                }
            });
            $("input[name=ResidanceCountry]").each(function()
            {
                if ( $(this).attr("checked") )
                {
                    ResidanceCountry = true;
                }
            });
            
            if ( UserImage == "" )
            {
                //alert( "사진을 추가하세요");
                //return false;
            }
            
            if ( UserID == "" )
            {
                alert( "아이디를 입력하세요");
                return false;
            }
            
            if (KRName=="" && CNName == "" && ENGName == "" )
            {
                alert( "성명은 1개이상 입력하셔야합니다.");
                return false;
            }
            
            if ( !Gender )
            {
                alert( "성별을 선택해주세요");
                return false;
            }
            
            if ( UserPWD == "" )
            {
                alert( "비밀번호를 입력하세요");
                return false;
            }
            
            if ( UserPWD.length < 4 )
            {
                alert( "비밀번호는 4글자 이상입니다.");
                return false;
            }
            
            if ( UserPWD != UserPWD_confirm )
            {
                alert( "확인 비밀번호랑 틀립니다." );
                return false;
            }
            
            if ( Email == "" )
            {
                alert( "이메일을 중복 체크해주세요");
                return false;
            }
            
            if ( $.trim(KRPhoneNo) == "" && $.trim(CNPhoneNo) == "" )
            {
                alert( "연락처를 입력하세요");
                return false;
            }
            
            if ( !ResidanceCountry )
            {
                alert( "거주국을 선택하세요" );
                return false;
            }
            
            if ( !$("input:[name=agree]").attr("checked") )
            {
                alert( "사실확인을 하셔야합니다.");
                return false;
            }
            
            isPrecess = true;
            $("form:eq(0)").submit();
        },

        IsEmail : function()
        {
            var email = $("input:[name=Email]").val();
            if ( email.indexOf("@") == -1 )
            {
                alert("이메일 형식이 아닙니다.");
                return false;
            }
            
            if ( email.indexOf(".") == -1 )
            {
                alert("이메일 형식이 아닙니다.");
                return false;
            }
            
            Site.Web.Soap.User.IsEmail(email, 
            function(results, context, methodNames){
                if ( results.UserNo != 0 )
                {
                    $("#tdEmail").html("존재하는 이메일주소입니다.");
                }
                else
                {
                    Email = $("input:[name=Email]").val();
                    $("#tdEmail").html("등록가능한 이메일주소입니다.");
                }
            },
            function(results, context, methodNames){
                alert( results.get_message() );
            });
        },
        
        IsUserID : function()
        {
            var userID;
            var ch = "abcdefghijklmnopqrstuvwxyz_1234567890";
            userID = $("input:[name=UserID]").val();
            if ( userID.length < 4 )
            {
                alert( "아이디는 4글자 이상입니다." );
                return false;
            }
            for ( var i = 0; i < userID.length; i ++ )
            {
                if ( userID.charAt( i ) > 255 )
                {
                    alert( "아이디에 사용할 수 없는 문자가 있습니다." );
                    return false;
                }
                var b = false;
                for( var j = 0; j < ch.length; j ++ )
                {
                    if ( userID.charAt( i ) != ch.charAt(j) )
                    {
                        b = true;
                    }
                    else
                    {
                        b = false;
                        break;
                    }
                }
                if ( b )
                {
                    $("#tdUserID").html("아이디에 사용할수 없는 문자가 있습니다.");
                    return false;
                }
            }
            Site.Web.Soap.User.IsUserID(userID, 
            function(results, context, methodNames){
                if ( results.UserNo != 0 )
                {
                    $("#tdUserID").html("사용중인 아이디입니다.");
                }
                else
                {
                    UserID = $("input:[name=companyID]").val();
                    $("#tdUserID").html("등록가능한 아이디입니다.");
                }
            },
            function(results, context, methodNames){
                alert( results.get_message() );
            });
        }
    });
})(jQuery);
</script>
</asp:Content>


<%@ Page Language="C#"  MasterPageFile="~/KR/WebMaster/UserMaster.master" AutoEventWireup="true" CodeFile="human_regist_detail.aspx.cs" Inherits="KR_User_human_regist_detail" %>
<%@ Import Namespace="Com.Library.DB.Category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/kr/Css/human.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
<input type="text" name="ResumeNo" value="<%=ResumeNo %>"/>
    <div class="title">
        <div class="human-title-regist"></div>
    </div>
    <div class="contents">
        <div class="tab">
            <ul>
	            <li class="icon icon-folder-middle-off">
		            <div>기본정보</div>
	            </li>
	            <li class="select icon icon-folder-middle-on">
		            <div>한국어</div>
	            </li>	
	            <li class="icon icon-folder-middle-off">
		            <div>中文</div>
	            </li>
	            <li class="last icon icon-folder-middle-off">
		            <div>English</div>
	            </li>												
            </ul>						
        </div>
        <div class="tab-content">
            <div class="regist">
                <div class="regist-item">
                    <div class="regist-header">1.개인정보</div>                                
                    <table class="regist-table">
                        <tr>
                            <td rowspan="6" class="size-k-1-1">
                                <img class="picture" width="104px" height="138px" src="<%=UserInfo.ImageUrl %>" />
                            </td>
                            <td class="size-k-1-2 regist-label">국문</td>
                            <td class="size-k-1-3"><%=UserInfo.KRName %></td>
                            <td class="size-k-1-4 regist-label">주민등록번호<span class="require">*</span></td>
                            <td class="size-k-1-5">
                                <table>
                                    <tr>
                                        <td><input style="width:120px;" type="password" name="ssn1" /></td>
                                        <td style="text-align:center;padding:0 2px;">-</td>
                                        <td><input style="width:120px;" type="password" name="ssn2" /></td>
                                    </tr>
                                </table>                                
                            </td>                                                    
                        </tr>
                        <tr>
                            <td class="regist-label">중문</td>
                            <td><%=UserInfo.CNName %></td>
                            <td class="regist-label">연령<span class="require">*</span></td>
                            <td>
                                <table>
                                    <tr>
                                        <td><input type="text" class="w3" name="korean_age"/>세</td>
                                        <td>(만<input type="text" class="w3" name="age" />세)</td>
                                    </tr>
                                </table>
                            </td>                                                    
                        </tr>
                        <tr>
                            <td class="regist-label">영문</td>
                            <td><%=UserInfo.ENGName %></td>
                            <td class="regist-label">재중경험<span class="require">*</span></td>
                            <td>
                                <table>
                                <tr>
                                    <td>
                                        <select class="year" name="inchina_year">
                                            <%for (int i = 0; i <= 10; ++i)
                                              { %>
                                                <option value="<%=i %>"><%=i %></option>
                                            <%} %>
                                        </select>년
                                    </td>
                                    <td>
                                        <select class="month" name="inchina_month">
                                            <%for (int i = 1; i <= 11; ++i)
                                              { %>
                                                <option value="<%=i %>"><%=i %></option>
                                            <%} %>
                                        </select>개월
                                    </td>
                                </tr>
                            </table>
                            </td>                                                                                                    
                        </tr>
                        <tr>
                            <td class="regist-label">한국연락처</td>
                            <td><%=UserInfo.KRPhoneNo %></td>
                            <td class="regist-label">중국연락처</td>
                            <td>131-1111-1131</td>                                                                                                    
                        </tr>
                        <tr>
                            <td class="regist-label">거주국가</td>
                            <td><%=UserInfo.ResidanceCountry %></td>
                            <td class="regist-label">병역<span class="require">*</span></td>
                            <td>
                                <table>
                                    <tr>
                                        <td>
                                            <input id="army1" type="radio" class="radio" name="army" value="1"/>
                                        </td>
                                        <td>
                                            <label for="army1">필</label>
                                        </td>
                                        <td>
                                            <input id="army2" type="radio" class="radio" name="army" value="2"/>
                                        </td>
                                        <td>
                                            <label for="army2">미필</label>
                                        </td>
                                        <td>
                                            <input id="army3" type="radio" class="radio" name="army" value="3"/>
                                        </td>
                                        <td>
                                            <label for="army3">면제</label>
                                        </td>
                                    </tr>
                                </table>
                            </td>                                                                                                    
                        </tr>
                        <tr>
                            <td class="regist-label">이메일</td>
                            <td><%=UserInfo.Email %></td>
                            <td class="regist-label">경력여부<span class="require">*</span></td>
                            <td>
                                <table>
                                    <tr>
                                        <td>
                                            <input id="isCareer1" type="radio" class="radio" name="isCareer" value="1"/>
                                        </td>
                                        <td>
                                            <label for="isCareer1">신입</label>
                                        </td>
                                        <td>
                                            <input id="isCareer2" type="radio" class="radio" name="isCareer" value="2"/>
                                        </td>
                                        <td>
                                            <label for="isCareer2">경력</label>
                                        </td>
                                    </tr>
                                </table>
                            </td>                                                                                                    
                        </tr>
                        <tr>
                            <td class="regist-label" colspan="2">주소(현재 실 거주지)<span class="require">*</span></td>
                            <td colspan="3">
                                <input type="text" name="address" class="w100"/>
                            </td>                                 
                        </tr>
                    </table>
                </div>
                
                <div class="regist-item">
                    <div class="regist-header">2.학력 <span class="desc">(최종학력 기입, 단, 석사이상 소지자는 학사학위부터 기재해 주십시오.)</span></div>                                
                    <table class="regist-table">
                        <tr>
                            <td class="size-k-2-1 regist-label">학교명</td>
                            <td class="size-k-2-2 regist-label">재학기간(년,월)</td>
                            <td class="size-k-2-3 regist-label">상태</td>
                            <td class="size-k-2-4 regist-label">전공/부전공</td>
                            <td class="size-k-2-5 regist-label">소재국가</td>                                                    
                        </tr>
                        <tr>
                           <td><input class="w100" name="education_school"/></td>
                           <td><input class="w4" name="education_period_start"/>&nbsp;-&nbsp;<input class="w4" name="education_period_end"/></td>
                           <td><select class="state" name="education_state">
                                <option value="0">졸업</option>
                           </select></td>
                           <td><input class="w100" name="education_major"/></td>
                           <td><input class="w100" name="education_national"/></td>
                        </tr>
                        <tr>
                           <td><input class="w100" name="education_school"/></td>
                           <td><input class="w4" name="education_period_start"/>&nbsp;-&nbsp;<input class="w4" name="education_period_end"/></td>
                           <td><select class="state" name="education_state">
                                <option value="0">졸업</option>
                           </select></td>
                           <td><input class="w100" name="education_major"/></td>
                           <td><input class="w100" name="education_national"/></td>
                        </tr>
                        <tr>
                           <td><input class="w100" name="education_school"/></td>
                           <td><input class="w4" name="education_period_start"/>&nbsp;-&nbsp;<input class="w4" name="education_period_end"/></td>
                           <td><select class="state" name="education_state">
                                <option value="0">졸업</option>
                           </select></td>
                           <td><input class="w100" name="education_major"/></td>
                           <td><input class="w100" name="education_national"/></td>
                        </tr>
                    </table>
                </div>
                
                <div class="regist-item">
                    <div class="regist-header">3.경력</div>                                
                    <table class="regist-table">
                        <tr>
                            <td class="size-k-3-1 regist-label">근무지(회사명)</td>
                            <td class="size-k-3-2 regist-label">재직기간(년,월)</td>
                            <td class="size-k-3-3 regist-label">직종</td>
                            <td class="size-k-3-4 regist-label">직책 및 근무내역</td>                                             
                        </tr>
                        <tr>
                           <td><input class="w100" name="career_company"/></td>
                           <td><input class="w4" name="career_period_start"/>&nbsp;-&nbsp;<input class="w4" name="career_period_end"/></td>
                           <td><input class="w100" name="career_department"/></td>
                           <td><input class="w100" name="career_detail"/></td>
                        </tr>
                        <tr>
                           <td><input class="w100" name="career_company"/></td>
                           <td><input class="w4" name="career_period_start"/>&nbsp;-&nbsp;<input class="w4" name="career_period_end"/></td>
                           <td><input class="w100" name="career_department"/></td>
                           <td><input class="w100" name="career_detail"/></td>
                        </tr>
                        <tr>
                           <td><input class="w100" name="career_company"/></td>
                           <td><input class="w4" name="career_period_start"/>&nbsp;-&nbsp;<input class="w4" name="career_period_end"/></td>
                           <td><input class="w100" name="career_department"/></td>
                           <td><input class="w100" name="career_detail"/></td>
                        </tr>
                    </table>
                </div>
                
                <div class="regist-item">
                    <div class="regist-header">4.외국어</div>                                
                    <table class="regist-table">
                        <tr>
                            <td class="size-k-4-1 regist-label">언어구분</td>
                            <td class="size-k-4-2 regist-label">시험명 or (실제 수준 기술)</td>
                            <td class="size-k-4-3 regist-label">시험점수/등급</td>
                            <td class="size-k-4-4 regist-label">회화</td>                                             
                        </tr>
                        <tr>
                           <td><input class="w100" name="language_type"/></td>                                              
                           <td><input class="w100" name="language_testname"/></td>
                           <td><input class="w100" name="language_score"/></td>
                           <td>
                                <table>
                                    <tr>
                                        <td>
                                            <input id="languageLevel-1" type="radio" class="radio" name="language_level_1" value="1"/>
                                        </td>
                                        <td>
                                            <label for="languageLevel-1">고급</label>
                                        </td>
                                        <td>
                                            <input id="languageLevel-2" type="radio" class="radio" name="language_level_1" value="2"/>
                                        </td>
                                        <td>
                                            <label for="languageLevel-2">중급</label>
                                        </td>
                                        <td>
                                            <input id="languageLevel-3" type="radio" class="radio" name="language_level_1" value="3"/>
                                        </td>
                                        <td>
                                            <label for="languageLevel-3">초급</label>
                                        </td>
                                    </tr>
                                </table>
                           </td>
                        </tr>
                        <tr>
                           <td><input class="w100" name="language_type"/></td>                                              
                           <td><input class="w100" name="language_testname"/></td>
                           <td><input class="w100" name="language_score"/></td>
                           <td>
                                <table>
                                    <tr>
                                        <td>
                                            <input id="Radio1" type="radio" class="radio" name="language_level_2" value="1"/>
                                        </td>
                                        <td>
                                            <label for="languageLevel-1">고급</label>
                                        </td>
                                        <td>
                                            <input id="Radio2" type="radio" class="radio" name="language_level_2" value="2"/>
                                        </td>
                                        <td>
                                            <label for="languageLevel-2">중급</label>
                                        </td>
                                        <td>
                                            <input id="Radio3" type="radio" class="radio" name="language_level_2" value="3"/>
                                        </td>
                                        <td>
                                            <label for="languageLevel-3">초급</label>
                                        </td>
                                    </tr>
                                </table>
                           </td>
                        </tr>
                        <tr>
                           <td><input class="w100" name="language_type"/></td>                                              
                           <td><input class="w100" name="language_testname"/></td>
                           <td><input class="w100" name="language_score"/></td>
                           <td>
                                <table>
                                    <tr>
                                        <td>
                                            <input id="Radio4" type="radio" class="radio" name="language_level_3" value="1"/>
                                        </td>
                                        <td>
                                            <label for="languageLevel-1">고급</label>
                                        </td>
                                        <td>
                                            <input id="Radio5" type="radio" class="radio" name="language_level_3" value="2"/>
                                        </td>
                                        <td>
                                            <label for="languageLevel-2">중급</label>
                                        </td>
                                        <td>
                                            <input id="Radio6" type="radio" class="radio" name="language_level_3" value="3"/>
                                        </td>
                                        <td>
                                            <label for="languageLevel-3">초급</label>
                                        </td>
                                    </tr>
                                </table>
                           </td>
                        </tr>
                    </table>
                </div>
                
                <div class="regist-item">
                    <div class="regist-header">5.자격/면허</div>                                
                    <table class="regist-table">
                        <tr>
                            <td class="size-k-4-1 regist-label">발행년월</td>
                            <td class="size-k-4-2 regist-label">자격/면허명</td>
                            <td class="size-k-4-3 regist-label">발급기관</td>                                         
                        </tr>
                        <tr>
                            <td><input class="w100" name="licence_year"/></td>                                              
                            <td><input class="w100" name="licence_title"/></td>
                            <td><input class="w100" name="licence_institution"/></td>
                        </tr>
                        <tr>
                            <td><input class="w100" name="licence_year"/></td>                                              
                            <td><input class="w100" name="licence_title"/></td>
                            <td><input class="w100" name="licence_institution"/></td>
                        </tr>
                        <tr>
                            <td><input class="w100" name="licence_year"/></td>                                              
                            <td><input class="w100" name="licence_title"/></td>
                            <td><input class="w100" name="licence_institution"/></td>
                        </tr>
                    </table>
                </div>
                
                <div class="regist-item">
                    <div class="regist-header">6.보유기술 및 특기사항 <span class="desc">(해외어학연수경험, 컴퓨터능력, 훈련과정 수료사항 등 이력서에 추가할 내용을 기재하십시오.)</span></div>                                
                    <textarea class="w100" rows="20" name="award_text"></textarea>
                </div>
                
                <div class="regist-item">
                    <div class="regist-header">7.자기소개서</div>                                
                    <textarea class="w100" rows="20" name="introduce"></textarea>
                </div>
                
                <div class="regist-item">
                    <div class="regist-tool">
                        <span class="agree">
                            <input class="checkbox" id="agree" name="agree" type="checkbox" />
                            <label for="agree">취업을 희망하여 동 이력서를 작성하였으며 해외취업을 목적으로 한국산업인력공단 월드잡사이트 등록 및 해외 구인기업체에게 제공되는 것에 동의합니다.</label>
                            </span>
                        <br />
                        <br />
                        <br />
                        <br />
                        <a class="icon icon-human-regist-btn" href="javascript:$.onWrite();"></a>
                    </div>
                </div>
            </div>
        </div>
    </div>
				

<script language="javascript" type="text/javascript">
jQuery(function()
{
    jQuery.CreateInit();
});

(function($){
    $.extend({
        CreateInit:function()
        {
        },        
        onWrite : function()
        {
            /* resume detail */
            var 
            ssn1,
            ssn2,
            age,
            korean_age,
            inchina_year,
            inchina_month,
            army,
            isCareer,
            address,
            agree,
            award_text,
            introduce;
            
            ssn1=$("input[name=ssn1]").val();
            ssn2=$("input[name=ssn2]").val();
            age=$("input[name=age]").val();
            korean_age=$("input[name=korean_age]").val();
            inchina_year=$("select[name=inchina_year]").val();
            inchina_month=$("select[name=inchina_month]").val();
            army=$("input[name=army]:checked").val();
            isCareer=$("input[name=isCareer]:checked").val();
            address=$("input[name=address]").val();
            agree=$("input[name=agree]:checked").val();
            award_text=$("textarea[name=award_text]").val();
            introduce=$("textarea[name=introduce]").val();
                        
            if(ssn1==""){ alert("주민등록번호를 입력해주세요.");return;  }
            if(ssn2==""){ alert("주민등록번호를 입력해주세요.");return;  }
            if(age==""){ alert("만 나이를 입력해 주세요.");return;  }
            if(korean_age==""){ alert("나이를 입력해 주세요.");return;  }
            if(address==""){ alert("주소를 입력해 주세요.");return;  }
            if(award_text==""){ alert("보유기술 및 특기사항을 입력해 주세요.");return;  }
            if(introduce==""){ alert("자기소개서를 입력해 주세요.");return;  }
            if(!army){ alert("병역을 확인해주세요.");return;  }
            if(!isCareer){ alert("경력여부를 확인해주세요.");return;  }
            if(!agree){ alert("등록동의여부를 확인해주세요.");return;  }
            
            var education_school_count = 0;
            $("input[name=education_school]").each(function(){if($(this).val()!="")education_school_count++});
            if(education_school_count == 0){alert("학력을 하나이상 입력해 주세요"); return;}
            
            var language_type_count = 0;
            $("input[name=language_type]").each(function(){if($(this).val()!="")language_type_count++});
            if(language_type_count == 0){alert("외국어를 하나이상 입력해 주세요"); return;}
            
            $("form:eq(0)").submit();
        }
    });
})(jQuery);
</script>          

</asp:Content>
<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/UserMaster.master" AutoEventWireup="true" CodeFile="human_regist_detail_cn.aspx.cs" Inherits="KR_User_human_regist_detail_cn" Title="제목 없음" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/kr/Css/human.css" />
<script language="javascript" type="text/javascript" src="human_regist_detail.js"></script>
<script language="javascript" type="text/javascript">
(function($)
{
	$.translateHelper.getText = function(transCode) {
		return $.translateHelper.getTextCore(<%= (byte)CountryCode %>, transCode);
	}
})(jQuery);

var countryCode = <%= (byte)CountryCode %>;

var academicAbilities = <%= GetAcademicAbilityJson() %>;
var careers = <%= GetCareerJson() %>;
var languages = <%= GetLanguageJson() %>;
var licenses = <%= GetLicensesJson() %>;

var ssn1 = '<%= GetDetailValue("SSN1") %>';
var ssn2 = '<%= GetDetailValue("SSN2") %>';
var koreanAge = '<%= GetDetailValue("KoreanAge") %>';
var age = '<%= GetDetailValue("Age") %>';
var chinaExpChunk = '<%= GetDetailValue("ChinaExp") %>';
var chinaExp = chinaExpChunk.split("-");
var military = '<%= GetDetailValue("Military") %>';
var isCareer = '<%= GetDetailValue("IsCareer") %>';
var address = '<%= GetDetailValue("Address") %>';
var description = '<%= GetDetailValue("Description") %>';
var aboutMe = '<%= GetDetailValue("AboutMe") %>';
var lasteastEducation = '<%= GetDetailValue("LastestEducation") %>';
var graduationYear = '<%= GetDetailValue("GraduationYear") %>';
var militaryService = '<%= GetDetailValue("MilitaryService") %>';
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
    <div class="title">
        <div class="human-title-regist"></div>
    </div>
    <div class="tab-content">
    <div class="contents">
        <div class="tab">
            <ul>
	            <li class="icon icon-folder-middle-off">
		            <div><span style="font-family:tahoma;color:#007be3">STEP1 </span>기본정보</div>
	            </li>
	            <li class="icon icon-folder-middle-off">
		            <div><span style="font-family:tahoma;color:#007be3">STEP2 </span>한국어</div>
	            </li>	
	            <li class="select icon icon-folder-middle-on">
		            <div><span style="font-family:tahoma;color:#007be3">STEP3 </span>中文</div>
	            </li>
	            <li class="last icon icon-folder-middle-off">
		            <div><span style="font-family:tahoma;color:#007be3">STEP4 </span>English</div>
	            </li>												
            </ul>						
        </div>
        <div class="tab-content">
            <div class="regist">
                <div class="regist-item">
                    <div class="regist-header">本人槪况</div>                                
                    <table class="regist-table">
                        <tr>
                            <td class="regist-label">姓名</td>
                            <td><%=UserInfo.CNName%></td>
                            <td class="regist-label">性別</td>
                            <td><%=UserInfo.Gender==1?"男":"女" %></td>                                                    
                        </tr>
                        <tr>
                            <td class="regist-label">出生年月</td>
                            <td><%=UserInfo.Birthday.ToString("yyyy年 MM月 dd日") %></td>
                            <td class="regist-label">工作年限 <span class="require">*</span></td>
                            <td>
                                <table>
                                    <tr>
                                        <td>
                                            <input id="isCareer1" type="radio" class="radio" name="isCareer" value="1"/>
                                        </td>
                                        <td>
                                            <label for="isCareer1">新入职</label>
                                        </td>
                                        <td>
                                            <input id="isCareer2" type="radio" class="radio" name="isCareer" value="2"/>
                                        </td>
                                        <td>
                                            <label for="isCareer2">经验</label>
                                        </td>
                                    </tr>
                                </table>
                            </td>                                                                                                    
                        </tr>
                        <tr>
                            <td class="regist-label">最高学历(学位) <span class="require">*</span></td>
                            <td><input class="w100" type="text" name="lastestEducation"/></td>
                            <td class="regist-label">毕业学校 <span class="require">*</span></td>
                            <td><input class="w100" type="text" name="education_school"/></td>                                                                                                    
                        </tr>
                        <tr>
                            <td class="regist-label">专业 <span class="require">*</span></td>
                            <td><input class="w100" type="text" name="education_major"/></td>
                            <td class="regist-label">毕业时间 <span class="require">*</span></td>
                            <td><input class="w100" type="text" name="graduationYear"/></td>                                                                                                    
                        </tr>                                            
                        <tr>
                            <td class="regist-label">现详细居住地址 <span class="require">*</span></td>
                            <td colspan="3"><input name="address" class="w100" type="text"/></td>                                 
                        </tr>
						<tr>
                            <td class="regist-label">手机</td>
                            <td><%=UserInfo.CNPhoneNo%></td>
                            <td class="regist-label">电子邮件</td>
                            <td><%=UserInfo.Email%></td>                                                                                                    
                        </tr>
                    </table>
                </div>
                
                <div class="regist-item">
                    <div class="regist-header">工作/实习经历 </div>                                
                    <table class="regist-table">
                        <tr>
                            <td class="regist-label" style="width:174px;">起止时间</td>
                            <td class="regist-label" style="width:143px;">工作单位</td>
                            <td class="regist-label" style="width:122px;">工作部门</td>
                            <td class="regist-label" style="width:130px;">岗位/职务</td>
                            <td class="regist-label" >单位性质</td>                                                    
                        </tr>
                        <tr>
                           <td>
								<input class="w4" name="career_period_start"/>&nbsp;-&nbsp;<input class="w4" name="career_period_end"/>
						   </td>
                           <td><input class="w100" type="text" name="career_company"/></td>
                           <td><input class="w100" type="text" name="career_department"/></td>
                           <td><input class="w100" type="text" name="career_detail"/></td>
                           <td><input class="w100" type="text" name="career_location"/></td>
                        </tr>
						<tr>
                           <td>
								<input class="w4" name="career_period_start"/>&nbsp;-&nbsp;<input class="w4" name="career_period_end"/>
						   </td>
                           <td><input class="w100" type="text" name="career_company"/></td>
                           <td><input class="w100" type="text" name="career_department"/></td>
                           <td><input class="w100" type="text" name="career_detail"/></td>
                           <td><input class="w100" type="text" name="career_location"/></td>
                        </tr>
						<tr>
                           <td>
								<input class="w4" name="career_period_start"/>&nbsp;-&nbsp;<input class="w4" name="career_period_end"/>
						   </td>
                           <td><input class="w100" type="text" name="career_company"/></td>
                           <td><input class="w100" type="text" name="career_department"/></td>
                           <td><input class="w100" type="text" name="career_detail"/></td>
                           <td><input class="w100" type="text" name="career_location"/></td>
                        </tr>
                    </table>
                </div>
                
                <div class="regist-item">
                    <div class="regist-header">语言水平</div>                                
                    <table class="regist-table">
                        <tr>
                            <td class="regist-label" style="width:141px">语言</td>
                            <td class="regist-label" style="width:258px">考试名称</td>
                            <td class="regist-label" style="width:182px">分数</td>
                            <td class="regist-label" style="width:143px">会话</td>                                             
                        </tr>
                        <tr>
                           <td><input class="w100" type="text" name="language_type"/></td>
                           <td><input class="w100" type="text" name="language_testname"/></td>
                           <td><input class="w100" type="text" name="language_score"/></td>
                           <td>
								<table>
                                    <tr>
                                        <td>
                                            <input id="level1-1" type="radio" class="radio" name="language_level_1" value="1"/>
                                        </td>
                                        <td>
                                            <label for="level1-1">上级</label>&nbsp;
                                        </td>
                                        <td>
                                            <input id="level1-2" type="radio" class="radio" name="language_level_1" value="2"/>
                                        </td>
                                        <td>
                                            <label for="level1-2">中级</label>&nbsp;
                                        </td>
                                        <td>
                                            <input id="level1-3" type="radio" class="radio" name="language_level_1" value="3"/>
                                        </td>
                                        <td>
                                            <label for="level1-3">下级</label>
                                        </td>
                                    </tr>
                                </table>
						   </td>
                        </tr>
						<tr>
                           <td><input class="w100" type="text" name="language_type"/></td>
                           <td><input class="w100" type="text" name="language_testname"/></td>
                           <td><input class="w100" type="text" name="language_score"/></td>
                           <td>
								<table>
                                    <tr>
                                        <td>
                                            <input id="level2-1" type="radio" class="radio" name="language_level_2" value="1"/>
                                        </td>
                                        <td>
                                            <label for="level2-1">上级</label>&nbsp;
                                        </td>
                                        <td>
                                            <input id="level2-2" type="radio" class="radio" name="language_level_2" value="2"/>
                                        </td>
                                        <td>
                                            <label for="level2-2">中级</label>&nbsp;
                                        </td>
                                        <td>
                                            <input id="level2-3" type="radio" class="radio" name="language_level_2" value="3"/>
                                        </td>
                                        <td>
                                            <label for="level2-3">下级</label>
                                        </td>
                                    </tr>
                                </table>
						   </td>
                        </tr>
						<tr>
                           <td><input class="w100" type="text" name="language_type"/></td>
                           <td><input class="w100" type="text" name="language_testname"/></td>
                           <td><input class="w100" type="text" name="language_score"/></td>
                           <td>
								<table>
                                    <tr>
                                        <td>
                                            <input id="level3-1" type="radio" class="radio" name="language_level_3" value="1"/>
                                        </td>
                                        <td>
                                            <label for="level3-1">上级</label>&nbsp;
                                        </td>
                                        <td>
                                            <input id="level3-2" type="radio" class="radio" name="language_level_3" value="2"/>
                                        </td>
                                        <td>
                                            <label for="level3-2">中级</label>&nbsp;
                                        </td>
                                        <td>
                                            <input id="level3-3" type="radio" class="radio" name="language_level_3" value="3"/>
                                        </td>
                                        <td>
                                            <label for="level3-3">下级</label>
                                        </td>
                                    </tr>
                                </table>
						   </td>
                        </tr>
                    </table>
                </div>
                                                    
                <div class="regist-item">
                    <div class="regist-header">自我评价（主要业绩，个人特长，电脑能力等）</div>                                
                    <textarea class="w100" rows="20" name="award_text"></textarea>
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
    </div>
</asp:Content>


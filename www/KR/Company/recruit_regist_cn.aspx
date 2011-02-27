<%@ Page Language="C#" MasterPageFile="~/KR/WebMaster/RecruitMaster.master" AutoEventWireup="true" CodeFile="recruit_regist_cn.aspx.cs" Inherits="KR_Company_recruit_regist_cn"%>
<%@ Import Namespace="Com.Library.DB.Category" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<link rel="stylesheet" type="text/css" href="/ImgSrv/kr/Css/recruit.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
<asp:ScriptManagerProxy ID="px" runat="server">
    <Services>
        <asp:ServiceReference Path="~/Soap/Category.asmx"></asp:ServiceReference>
    </Services>
</asp:ScriptManagerProxy>
<div class="recruit-title"></div>

<div class="tab-content">
    <input type="hidden" name="countryNo" value="1"/>
	<div class="korean">

			<table>
				<tr>
					<td class="label">참가여부<span class="require">*</span></td>
					<td class="input">
						<table>
							<tr class="radio">
								<td>
									<input class="radio" type="radio" name="join_type" value="1" id="join_type_1" <%=RecruitInfo.JoinType == 1 ? "checked" : ""%>/>

								</td>
								<td>
									<label for="join_type_1">참가</label>
								</td>											
								<td>
									<input class="radio" type="radio" name="join_type" value="0" id="join_type_2" <%=RecruitInfo.JoinType == 0 ? "checked" : ""%>/>
								</td>
								<td>
									<label for="join_type_2">불참</label>

								</td>																						
							</tr>
						</table>
					</td>
				</tr>
				<tr class="join hide">
					<td class="label">참가정보</td>
					<td class="input">
					    <input type="hidden" name="interviewers" value="<%=RecruitInfo.JobFairRecruiter %>" />

						<table>
							<tr class="radio">
								<td>
									<select name="join_count">
										<option value="0" <%=RecruitInfo.JobFairValue == 0 ? "selected" : ""%>>참가인원</option> 
										<option value="1" <%=RecruitInfo.JobFairValue == 1 ? "selected" : ""%>>1</option>
										<option value="2" <%=RecruitInfo.JobFairValue == 2 ? "selected" : ""%>>2</option>
										<option value="3" <%=RecruitInfo.JobFairValue == 3 ? "selected" : ""%>>3</option>
										<option value="4" <%=RecruitInfo.JobFairValue == 4 ? "selected" : ""%>>4</option>
										<option value="5" <%=RecruitInfo.JobFairValue == 5 ? "selected" : ""%>>5</option>
										<option value="6" <%=RecruitInfo.JobFairValue == 6 ? "selected" : ""%>>6</option>
										<option value="7" <%=RecruitInfo.JobFairValue == 7 ? "selected" : ""%>>7</option>
										<option value="8" <%=RecruitInfo.JobFairValue == 8 ? "selected" : ""%>>8</option>
										<option value="9" <%=RecruitInfo.JobFairValue == 9 ? "selected" : ""%>>9</option>
										<option value="10" <%=RecruitInfo.JobFairValue == 10 ? "selected" : ""%>>10</option>
									</select>
								</td>
								<td>
									면접관명
								</td>											
								<td id="interviewer">
								</td>																					
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td class="label">구인직종<span class="require">*</span></td>

					<td class="input">
						<table>
							<tr class="radio">
								<td>
									<select class="w2 multi" name="jobType1" size=6>
									<% if (Category1List != null){ %>
                                            <% foreach (CategoryEntity item in Category1List)
                                               { %>
												    <option value="<%=item.CategoryNo %>" <%=item.CategoryNo == RecruitInfo.Category1No ? "selected='selected'" : "" %>><%=CategoryLangName(item)%></option>
                                            <% } %>
                                        <% } %>
									</select>
								</td>
								<td>
									<select class="w2 multi" name="jobType2" size=6>
									</select>
								</td>		
								<td class="vertical-top">
								    <input type="text" name="jobType_direct" value="<%=RecruitInfo.CategoryEtcValue %>"/>
								</td>																		
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td class="label">경력</td>
					<td class="input">

						<table>
							<tr class="radio">
								<td>
									<input class="radio" type="radio" name="career_year" value="0" id="career_year_type_0"  <%=RecruitInfo.Career == 0 ? "checked='checked'" : "" %>/>
								</td>
								<td>
									<label for="career_year_type_0" >무관</label>
								</td>											
								<td>

									<input class="radio" type="radio" name="career_year" value="1" id="career_year_type_1"  <%=RecruitInfo.Career == 1 ? "checked='checked'" : "" %>/>
								</td>
								<td>
									<label for="career_year_type_1">1년</label>
								</td>	
								<td>
									<input class="radio" type="radio" name="career_year" value="2" id="career_year_type_2"  <%=RecruitInfo.Career == 2 ? "checked='checked'" : "" %>/>
								</td>
								<td>

									<label for="career_year_type_2">2년</label>
								</td>
								<td>
									<input class="radio" type="radio" name="career_year" value="3" id="career_year_type_3"  <%=RecruitInfo.Career == 3 ? "checked='checked'" : "" %>/>
								</td>
								<td>
									<label for="career_year_type_3">3년</label>
								</td>

								<td>
									<input class="radio" type="radio" name="career_year" value="4" id="career_year_type_4"  <%=RecruitInfo.Career == 4 ? "checked='checked'" : "" %>/>
								</td>
								<td>
									<label for="career_year_type_4">4년</label>
								</td>
								<td>
									<input class="radio" type="radio" name="career_year" value="5" id="career_year_type_5"  <%=RecruitInfo.Career == 5 ? "checked='checked'" : "" %>/>

								</td>
								<td>
									<label for="career_year_type_5">5년</label>
								</td>
								<td>
									<input class="radio" type="radio" name="career_year" value="10" id="career_year_type_6"  <%=RecruitInfo.Career == 10 ? "checked='checked'" : "" %>/>
								</td>
								<td>

									<label for="career_year_type_6">10년 이상</label>
								</td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td class="label">인원<span class="require">*</span></td>

					<td class="input">
						<table>
							<tr><td>
								<select class="w1" name="people_count">
								<% for (int i = 0; i <= 10; i++) { %>
										<option value="<%=i %>" <%=RecruitInfo.RecruitCount == i ? "selected='selected'" : "" %>><%=i %>명</option> 
							    <% } %>
								</select>																				
							</td></tr>
						</table>
					</td>
				</tr>
				<tr>
					<td class="label">성별<span class="require">*</span></td>

					<td class="input">
						<table>
							<tr>
								<td>
									<input class="radio" type="radio" name="gender" value="0" id="gender_0" <%=RecruitInfo.Gender == 0 ? "checked='checked'" : "" %>/>
								</td>
								<td>
									<label for="gender_0">무관</label>

								</td>
								<td>
									<input class="radio" type="radio" name="gender" value="1" id="gender_1" <%=RecruitInfo.Gender == 1 ? "checked='checked'" : "" %>/>
								</td>
								<td>
									<label for="gender_1">남</label>
								</td>
								<td>

									<input class="radio" type="radio" name="gender" value="2" id="gender_2" <%=RecruitInfo.Gender == 2 ? "checked='checked'" : "" %>/>
								</td>
								<td>
									<label for="gender_2">여</label>
								</td>														
							</tr>
						</table>
					</td>
				</tr>

				<tr>
					<td class="label">연령<span class="require">*</span></td>
					<td class="input">
						<table>
							<tr>
								<td>
									<input class="radio" type="radio" name="AgeType" value="0" id="age_0" <%=RecruitInfo.AgeType == 0 ? "checked='checked'" : "" %> />
								</td>

								<td>
									<label for="age_0">무관</label>
								</td>
								<td>
									<input class="radio" type="radio" name="AgeType" value="1" id="age_1" <%=RecruitInfo.AgeType != 0 ? "checked='checked'" : "" %>/>
								</td>
								<td>
									<label for="age_1">제한</label>
								</td>
								<td id="AgeCategory" class="hide">
									<select name="AgeCategory">
									    <option value="-1" <>선택하세요</option>
									    <% if (AgeCategoryList != null) { %>
                                            <% foreach (CategoryEntity item in AgeCategoryList)
                                               { %>
												    <option value="<%=item.CategoryNo %>" <%=RecruitInfo.AgeCategory == item.CategoryNo ? "selected='selected'":"" %>><%=CategoryLangName(item)%></option>
                                            <% } %>
                                        <% } %>
                                        <option value="0" <%=RecruitInfo.AgeCategory == 0 ? "selected='selected'":"" %>>직접입력</option>
									</select>	
								</td>
								<td id="AgeEtcValue" class="hide">
									<input class="w1" name="AgeEtcValue" <%=RecruitInfo.AgeEtcValue %>/>
								</td>														
							</tr>
						</table>
					</td>

				</tr>
				<tr>
					<td class="label">학력</td>
					<td class="input">
						<table>
							<tr>
								<td>
									<input class="radio" type="radio" name="education" value="139" id="education_0" <%=RecruitInfo.AcademicAbility == 139 ? "checked='checked'" : "" %>/>

								</td>
								<td>
									<label for="education_0">무관</label>
								</td>
								<td>
									<input class="radio" type="radio" name="education" value="140" id="education_1" <%=RecruitInfo.AcademicAbility == 140 ? "checked='checked'" : "" %>/>
								</td>
								<td>

									<label for="education_1">고졸이상</label>
								</td>
								<td>
									<input class="radio" type="radio" name="education" value="141" id="education_2" <%=RecruitInfo.AcademicAbility == 141 ? "checked='checked'" : "" %>/>
								</td>
								<td>
									<label for="education_2">전문대졸이상</label>
								</td>

								<td>
									<input class="radio" type="radio" name="education" value="142" id="education_3" <%=RecruitInfo.AcademicAbility == 142 ? "checked='checked'" : "" %>/>
								</td>
								<td>
									<label for="education_3">대졸이상</label>
								</td>
								<td>
									<input class="radio" type="radio" name="education" value="143" id="education_4" <%=RecruitInfo.AcademicAbility == 143 ? "checked='checked'" : "" %>/>

								</td>
								<td>
									<label for="education_4">대학원이상</label>
								</td>															
							</tr>
						</table>
					</td>
				</tr>
				<tr>

					<td class="label">전공</td>
					<td class="input">
						<table>
							<tr>
								<td>
									<input class="radio" type="radio" name="major" value="145" id="major_0" <%=RecruitInfo.Major == 145 ? "checked='checked'" : "" %>/>
								</td>
								<td>

									<label for="major_0">무관</label>
								</td>
								<td>
									<input class="radio" type="radio" name="major" value="146" id="major_1" <%=RecruitInfo.Major == 146 ? "checked='checked'" : "" %>/>
								</td>
								<td>
									<label for="major_1">인문계열</label>
								</td>

								<td>
									<input class="radio" type="radio" name="major" value="147" id="major_2"  <%=RecruitInfo.Major == 147 ? "checked='checked'" : "" %>/>
								</td>
								<td>
									<label for="major_2">법계열</label>
								</td>
								<td>
									<input class="radio" type="radio" name="major" value="148" id="major_3"  <%=RecruitInfo.Major == 148 ? "checked='checked'" : "" %>/>

								</td>
								<td>
									<label for="major_3">이공계열</label>
								</td>
								<td>
									<input class="radio" type="radio" name="major" value="149" id="major_4"  <%=RecruitInfo.Major == 149 ? "checked='checked'" : "" %>/>
								</td>
								<td>

									<label for="major_4">예술계열</label>
								</td>	
								<td>
									<input class="radio" type="radio" name="major" value="150" id="major_5" <%=RecruitInfo.Major == 150 ? "checked='checked'" : "" %> />
								</td>
								<td>
									<label for="major_5">직접입력</label>
								</td>

								<td>
									<input id="major_direct" type="text" class="w2 hide" name="major_direct" value="<%=RecruitInfo.MajorEtcValue %>"/>
								</td>															
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td class="label">중국어</td>

					<td class="input">
						<table>
							<tr>
								<td>
									<input class="radio" type="radio" name="china" value="151" id="china_0" <%=RecruitInfo.ChineseLevel == 151 ? "checked='checked'" : "" %>/>
								</td>
								<td>
									<label for="china_0">무관</label>

								</td>
								<td>
									<input class="radio" type="radio" name="china" value="152" id="china_1" <%=RecruitInfo.ChineseLevel == 152 ? "checked='checked'" : "" %>/>
								</td>
								<td>
									<label for="china_1">기본회화가능</label>
								</td>
								<td>

									<input class="radio" type="radio" name="china" value="153" id="china_2" <%=RecruitInfo.ChineseLevel == 153 ? "checked='checked'" : "" %>/>
								</td>
								<td>
									<label for="china_2">업무상 소통 가능</label>
								</td>
								<td>
									<input class="radio" type="radio" name="china" value="154" id="china_3" <%=RecruitInfo.ChineseLevel == 154 ? "checked='checked'" : "" %>/>
								</td>

								<td>
									<label for="china_3">현지인 수준</label>
								</td>													
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td class="label">영어</td>

					<td class="input">
						<table>
							<tr>
								<td>
									<input class="radio" type="radio" name="english" value="155" id="english_0"  <%=RecruitInfo.EnglishLevel == 155 ? "checked='checked'" : "" %>/>
								</td>
								<td>
									<label for="english_0">무관</label>

								</td>
								<td>
									<input class="radio" type="radio" name="english" value="156" id="english_1"  <%=RecruitInfo.EnglishLevel == 156 ? "checked='checked'" : "" %>/>
								</td>
								<td>
									<label for="english_1">기본회화가능</label>
								</td>
								<td>

									<input class="radio" type="radio" name="english" value="157" id="english_2"  <%=RecruitInfo.EnglishLevel == 157 ? "checked='checked'" : "" %>/>
								</td>
								<td>
									<label for="english_2">업무상 소통 가능</label>
								</td>
								<td>
									<input class="radio" type="radio" name="english" value="158" id="english_3"  <%=RecruitInfo.EnglishLevel == 158 ? "checked='checked'" : "" %>/>
								</td>

								<td>
									<label for="english_3">현지인 수준</label>
								</td>													
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td class="label">일본어</td>

					<td class="input">
						<table>
							<tr>
								<td>
									<input class="radio" type="radio" name="japanese" value="160" id="japanese_0" <%=RecruitInfo.JapanessLevel == 160 ? "checked='checked'" : "" %>/>
								</td>
								<td>
									<label for="japanese_0">무관</label>

								</td>
								<td>
									<input class="radio" type="radio" name="japanese" value="161" id="japanese_1" <%=RecruitInfo.JapanessLevel == 161 ? "checked='checked'" : "" %>/>
								</td>
								<td>
									<label for="japanese_1">기본회화가능</label>
								</td>
								<td>

									<input class="radio" type="radio" name="japanese" value="162" id="japanese_2" <%=RecruitInfo.JapanessLevel == 162 ? "checked='checked'" : "" %>/>
								</td>
								<td>
									<label for="japanese_2">업무상 소통 가능</label>
								</td>
								<td>
									<input class="radio" type="radio" name="japanese" value="163" id="japanese_3" <%=RecruitInfo.JapanessLevel == 163 ? "checked='checked'" : "" %>/>
								</td>

								<td>
									<label for="japanese_3">현지인 수준</label>
								</td>													
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td class="label">기타언어</td>

					<td class="input">
						<table>
							<tr>
								<td>
									<label for="japanese_0">언어</label>
								</td>
								<td>
									<input type="text" name="etc_lang" class="w2" value="<%=RecruitInfo.ETCLanguageName%>"/>

								</td>
								<td>
									<input class="radio" type="radio" name="etc_lang_level" value="164" id="etc_lang_level_1"  <%=RecruitInfo.ETCLanguageLevel == 164 ? "checked='checked'" : "" %>/>
								</td>
								<td>
									<label for="etc_lang_level_1">기본회화가능</label>
								</td>
								<td>

									<input class="radio" type="radio" name="etc_lang_level" value="165" id="etc_lang_level_2"  <%=RecruitInfo.ETCLanguageLevel == 165 ? "checked='checked'" : "" %>/>
								</td>
								<td>
									<label for="etc_lang_level_2">업무상 소통 가능</label>
								</td>
								<td>
									<input class="radio" type="radio" name="etc_lang_level" value="165" id="etc_lang_level_3"  <%=RecruitInfo.ETCLanguageLevel == 165 ? "checked='checked'" : "" %>/>
								</td>

								<td>
									<label for="etc_lang_level_3">현지인 수준</label>
								</td>													
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td class="label">주요업무<span class="require">*</span></td>

					<td class="input">
						<table>
							<tr>
								<td>
									<input type="text" name="main_task" class="w3" value="<%=RecruitInfo.MainWork%>"/>
								</td>										
							</tr>
						</table>
					</td>

				</tr>
				<tr>
					<td class="label">근무지역<span class="require">*</span></td>
					<td class="input">
						<table>
							<tr>
								<td>
									<select class="w5" name="address_1">
										<% if (CityCategoryList != null) { %>
                                            <% foreach (CategoryEntity item in CityCategoryList) { %>
												    <option value="<%=item.CategoryNo %>" <%=item.CategoryNo == RecruitInfo.CityCategory ? "selected='selected'" : ""%>><%=CategoryLangName(item)%></option>
                                            <% } %>
                                        <% } %>
									</select>	
								</td>
								<td>
									<select class="w5" name="address_2">
									</select>	
								</td>
								<td>
									상세주소
								</td>

								<td>
									<input type="text" name="address_3" class="w3" value="<%=RecruitInfo.RecruitAddressDetail %>"/>
								</td>										
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td class="label">채용예정시기<span class="require">*</span></td>

					<td class="input">
					    <input type="hidden" name="recruit_day" value="" />
						<table>
							<tr>
								<td>
									<select class="w1" name="recruit_day_1">
									<% for (int i = DateTime.Now.Year - 1; i < DateTime.Now.Year + 3; i++){ %>
										<option value="<%=i %>" <%=i == RecruitInfo.RecruitDate.Year ? "selected='selected'" : "" %>><%=i %>년</option>
									<% } %>
									</select>	
								</td>

								<td>
									<select class="w6" name="recruit_day_2">
									<%for ( int i = 1; i <= 12; i ++ ) { %>
										<option value="<%=i %>" <%=i == RecruitInfo.RecruitDate.Month ? "selected='selected'" : "" %>><%=i %>월</option> 
									 <% } %>
									</select>	
								</td>

								<td>
									<select class="w6" name="recruit_day_3">
										<%for ( int i = 1; i <= 31; i ++ ) { %>
										<option value="<%=i %>" <%=i == RecruitInfo.RecruitDate.Day ? "selected='selected'" : "" %>><%=i %>일</option> 
									 <% } %>
									</select>	
								</td>									
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td class="label">기타자격요건<br/></td>

					<td class="input">
						<table>
							<tr>
								<td><textarea cols="100" rows="8" name="etc_require"><%=RecruitInfo.EtcEligibilityRule %></textarea></td>
							</tr>
						</table>
					</td>
				</tr>

				<tr>
					<td class="label">급여<span class="require">*</span></td>
					<td class="input">
						<table>
							<tr>
								<td>
									<select class="w7" name="PayCategory">
                                        <% if (PayCategoryList != null) { %>
                                            <% foreach (CategoryEntity item in PayCategoryList){ %>
												    <option value="<%=item.CategoryNo %>" <%=item.CategoryNo == RecruitInfo.PayCategory ? "selected='selected'" : ""%> ><%=CategoryLangName(item)%></option>
                                            <% } %>
                                        <% } %>
									</select>	
								</td>

							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td class="label">계약기간<span class="require">*</span></td>
					<td class="input">
						<table>

							<tr>
								<td>
									<input class="radio" type="radio" name="contract" value="0" id="contract_0" <%=RecruitInfo.ContactPeriod == 0 ? "checked='checked'" : ""%>/>
								</td>
								<td>
									<label for="contract_0">협의</label>
								</td>
								<td>

									<input class="radio" type="radio" name="contract" value="1" id="contract_1" <%=RecruitInfo.ContactPeriod == 1 ? "checked='checked'" : ""%>/>
								</td>
								<td>
									<label for="contract_1">1년</label>
								</td>
								<td>
									<input class="radio" type="radio" name="contract" value="2" id="contract_2" <%=RecruitInfo.ContactPeriod == 2 ? "checked='checked'" : ""%>/>
								</td>

								<td>
									<label for="contract_2">2년</label>
								</td>
								<td>
									<input class="radio" type="radio" name="contract" value="3" id="contract_3" <%=RecruitInfo.ContactPeriod == 3 ? "checked='checked'" : ""%>/>
								</td>
								<td>
									<label for="contract_3">3년</label>

								</td>
								<td>
									<input class="radio" type="radio" name="contract" value="4" id="contract_4" <%=RecruitInfo.ContactPeriod == 4 ? "checked='checked'" : ""%>/>
								</td>
								<td>
									<label for="contract_4">4년</label>
								</td>	
								<td>
									<input class="radio" type="radio" name="contract" value="5" id="contract_5" <%=RecruitInfo.ContactPeriod == 5 ? "checked='checked'" : ""%>/>

								</td>
								<td>
									<label for="contract_5">5년</label>
								</td>		
								<td>
									<input class="radio" type="radio" name="contract" value="10" id="contract_6" <%=RecruitInfo.ContactPeriod == 10 ? "checked='checked'" : ""%>/>
								</td>
								<td>
									<label for="contract_6">10년</label>

								</td>														
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td class="label">근무시간</td>
					<td class="input">
						<table>

							<tr>
								<td>
									<input class="radio" type="radio" name="working_time_opt" value="0" id="working_time_0" <%=RecruitInfo.WorkingHours == "" ? "checked='checked'" : ""%>/>
								</td>
								<td>
									<label for="working_time_0">해당국가 노동법률 의거</label>
								</td>
								<td>

									<input class="radio" type="radio" name="working_time_opt" value="1" id="working_time_1" <%=RecruitInfo.WorkingHours != "" ? "checked='checked'" : ""%>/>
								</td>
								<td>
									<label for="working_time_1">직접입력</label>
								</td>
								<td>
									<input id="working_time_etc" type="text" class="w2 hide" name="working_time_etc" value="<%=RecruitInfo.WorkingHours %>" />
								</td>														
							</tr>

						</table>
					</td>
				</tr>
				<tr>
					<td class="label">후생복리</td>
					<td class="input">
						<table>
							<tr>

								<td>
									보험
								</td>
								<td>
									<input class="radio" type="radio" name="insurance" value="167" id="insurance_0" <%=RecruitInfo.BenefitsInsurance == 167 ? "checked='checked'" : ""%>/>
								</td>
								<td>
									<label for="insurance_0">제공</label>
								</td>

								<td>
									<input class="radio" type="radio" name="insurance" value="168" id="insurance_1" <%=RecruitInfo.BenefitsInsurance == 168 ? "checked='checked'" : ""%>/>
								</td>
								<td>
									<label for="insurance_1">미제공</label>
								</td>
								<td>
									<input class="radio" type="radio" name="insurance" value="169" id="insurance_2" <%=RecruitInfo.BenefitsInsurance == 169 ? "checked='checked'" : ""%>/>

								</td>
								<td>
									<label for="insurance_2">협의</label>
								</td>
								<td>
									<input class="radio" type="radio" name="insurance" value="0" id="insurance_3" <%=RecruitInfo.BenefitsInsurance == 170 ? "checked='checked'" : ""%>/>
								</td>
								<td>

									<label for="insurance_3">기타</label>
								</td>
								<td>
									<input id="insurance_etc" type="text" class="w1 hide" name="insurance_etc"  value="<%=RecruitInfo.BenefitsInsuranceEtcValue%>" />
								</td>														
							</tr>
						</table>
						<table>
							<tr>

								<td>
									숙식
								</td>
								<td>
									<input class="radio" type="radio" name="food" value="171" id="food_0" <%=RecruitInfo.BenefitsRoomAndBoard == 171 ? "checked='checked'" : ""%>/>
								</td>
								<td>
									<label for="food_0">제공</label>
								</td>

								<td>
									<input class="radio" type="radio" name="food" value="172" id="food_1" <%=RecruitInfo.BenefitsRoomAndBoard == 172 ? "checked='checked'" : ""%>/>
								</td>
								<td>
									<label for="food_1">미제공</label>
								</td>
								<td>
									<input class="radio" type="radio" name="food" value="173" id="food_2" <%=RecruitInfo.BenefitsRoomAndBoard == 173 ? "checked='checked'" : ""%>/>

								</td>
								<td>
									<label for="food_2">보조</label>
								</td>
								<td>
									<input class="radio" type="radio" name="food" value="174" id="food_3" <%=RecruitInfo.BenefitsRoomAndBoard == 174 ? "checked='checked'" : ""%>/>
								</td>
								<td>

									<label for="food_3">협의</label>
								</td>
								<td>
									<input class="radio" type="radio" name="food" value="0" id="food_4" <%=RecruitInfo.BenefitsRoomAndBoard == 175 ? "checked='checked'" : ""%>/>
								</td>
								<td>
									<label for="food_4">기타</label>
								</td>

								<td>
									<input type="text" class="w1 hide" name="food_etc" id="food_etc" value="<%=RecruitInfo.BenefitsRoomAndBoardEtcValue%>" >
								</td>														
							</tr>
						</table>
						<table>
							<tr>
								<td>
									퇴직금
								</td>

								<td>
									<input class="radio" type="radio" name="severance_pay" value="176" id="severance_pay_0" <%=RecruitInfo.BenefitsSeverancePay == 176 ? "checked='checked'" : ""%>/>
								</td>
								<td>
									<label for="severance_pay_0">유</label>
								</td>
								<td>
									<input class="radio" type="radio" name="severance_pay" value="177" id="severance_pay_1" <%=RecruitInfo.BenefitsSeverancePay == 177 ? "checked='checked'" : ""%>/>

								</td>
								<td>
									<label for="severance_pay_1">무</label>
								</td>
								<td>
									<input class="radio" type="radio" name="severance_pay" value="178" id="severance_pay_2" <%=RecruitInfo.BenefitsSeverancePay == 178 ? "checked='checked'" : ""%>/>
								</td>
								<td>

									<label for="severance_pay_2">협의</label>
								</td>
								<td>
									<input class="radio" type="radio" name="severance_pay" value="179" id="severance_pay_3" <%=RecruitInfo.BenefitsSeverancePay == 179 ? "checked='checked'" : ""%>/>
								</td>
								<td>
									<label for="severance_pay_3">회사내규</label>
								</td>

								<td>
									<input class="radio" type="radio" name="severance_pay" value="0" id="severance_pay_4" <%=RecruitInfo.BenefitsSeverancePay == 180 ? "checked='checked'" : ""%>/>
								</td>
								<td>
									<label for="severance_pay_4">기타</label>
								</td>
								<td>
									<input type="text" class="w1 hide" name="severance_etc" id="severance_etc" value="<%=RecruitInfo.BenefitsSeverancePayEtcValue%>">

								</td>														
							</tr>
						</table>
						<table>
							<tr>
								<td>
									휴가
								</td>
								<td>
									<input class="radio" type="radio" name="vacation" value="181" id="vacation_0" <%=RecruitInfo.BenefitsVacation == 181 ? "checked='checked'" : ""%>/>

								</td>
								<td>
									<label for="vacation_0">유</label>
								</td>
								<td>
									<input class="radio" type="radio" name="vacation" value="182" id="vacation_1" <%=RecruitInfo.BenefitsVacation == 182 ? "checked='checked'" : ""%>/>
								</td>
								<td>

									<label for="vacation_1">무</label>
								</td>
								<td>
									<input class="radio" type="radio" name="vacation" value="183" id="vacation_2" <%=RecruitInfo.BenefitsVacation == 183 ? "checked='checked'" : ""%>/>
								</td>
								<td>
									<label for="vacation_2">협의</label>
								</td>

								<td>
									<input class="radio" type="radio" name="vacation" value="184" id="vacation_3" <%=RecruitInfo.BenefitsVacation == 184 ? "checked='checked'" : ""%>/>
								</td>
								<td>
									<label for="vacation_3">회사내규</label>
								</td>
								<td>
									<input class="radio" type="radio" name="vacation" value="0" id="vacation_4" <%=RecruitInfo.BenefitsVacation == 185 ? "checked='checked'" : ""%>/>

								</td>
								<td>
									<label for="vacation_4">기타</label>
								</td>
								<td>
									<input type="text" class="w1 hide" name="vacation_etc" id="vacation_etc" value="<%=RecruitInfo.BenefitsVacationEtcValue%>" />
								</td>														
							</tr>
						</table>

						<table>
							<tr>
								<td>
									기타
								</td>	
								<td>
									<input type="text" class="w4" name="benefit_etc" value="<%=RecruitInfo.BenefitsETC%>"/>
								</td>														
							</tr>
						</table>

					</td>
				</tr>
			</table>
			<div class="agree">상기와 같이 구인요청 및 「2011 중국취업박람회」 참가를 신청합니다.</div>
			<div class="submit"><a href='#' onclick='jQuery.Submit(); return false;' class="icon icon-recruit-request"></a></div>
	</div>
</div>
<script language="javascript" type="text/javascript">
jQuery(function()
{
    jQuery.CreateInit();
});

(function($)
{
    var _PageLoad_Category = false;
    var _PageLoad_CityCategory = false;
    $.extend({
        CreateInit : function()
        {
            _PageLoad_Category = true;
            _PageLoad_CityCategory = true;
            $('input[name=join_type][value=0]').click(
                function(){
                    $(this).parents('tr').next().hide()
                })
            $('input[name=join_type][value=1]').click(
                function(){
                    $(this).parents('tr').next().show()
                })
                
            var interviewEl = $('<input type="text" class="w1 interviewer"/>');
            $("select[name=join_count]").change(function(){
                var selectCount = $(this).val();
                var arrInterview = $('input[name=interviewers]').val().split(',');
                $('#interviewer').html( "" );
                for(var i = 0; i < selectCount ; i++)
                {
                    var val = "";
                    if ( i < arrInterview.length )
                    {
                        val = arrInterview[ i ];
                    }
                    interviewEl.val(val);
                    $('#interviewer').append(interviewEl.clone());
                }
            });
            
            $("input[name=AgeType]").click(function(){
                if ( $(this).val() == 1 )
                {
                    $('#AgeCategory').show();
                    $('select[name=AgeCategory]').change();
                }
                else
                {
                    $('#AgeCategory').hide();
                    $('#AgeEtcValue').hide();
                }
            })

            $('select[name=AgeCategory]').change(function(){
                if ( $("input[name=AgeType][value=1]").attr("checked") )
                {
                    if($(this).val()==0)
                        $('#AgeEtcValue').show();
                    else
                        $('#AgeEtcValue').hide();
                }
            })
            
            $("input[name=major][value!=5]").click(function(){
                $('#major_direct').hide();
            })

            $("input[name=major][value=5]").click(function(){
                $('#major_direct').show();
            })
            
            $("input[name=working_time_opt][value!=1]").click(function(){
                $('#working_time_etc').hide();
            })

            $("input[name=working_time_opt][value=1]").click(function(){
                $('#working_time_etc').show();
            })
            
            $("#insurance_0").click(function(){
                $('#insurance_etc').hide();
            })
            $("#insurance_1").click(function(){
                $('#insurance_etc').hide();
            })
            $("#insurance_2").click(function(){
                $('#insurance_etc').hide();
            })

            $("#insurance_3").click(function(){
                $('#insurance_etc').show();
            })
            
            $("#food_0").click(function(){
                $('#food_etc').hide();
            })
            $("#food_1").click(function(){
                $('#food_etc').hide();
            })
            $("#food_2").click(function(){
                $('#food_etc').hide();
            })
            $("#food_3").click(function(){
                $('#food_etc').hide();
            })

            $("#food_4").click(function(){
                $('#food_etc').show();
            })
            
            $("#severance_pay_0").click(function(){
                $('#severance_etc').hide();
            })
            
            $("#severance_pay_1").click(function(){
                $('#severance_etc').hide();
            })
            
            $("#severance_pay_2").click(function(){
                $('#severance_etc').hide();
            })
            $("#severance_pay_3").click(function(){
                $('#severance_etc').hide();
            })

            $("#severance_pay_4").click(function(){
                $('#severance_etc').show();
            })
            
            $("#vacation_0").click(function(){
                $('#vacation_etc').hide();
            })
            $("#vacation_1").click(function(){
                $('#vacation_etc').hide();
            })
            $("#vacation_2").click(function(){
                $('#vacation_etc').hide();
            })
            $("#vacation_3").click(function(){
                $('#vacation_etc').hide();
            })

            $("#vacation_4").click(function(){
                $('#vacation_etc').show();
            })
            
            $("select[name=address_1]").change(function(){
                if($(this).val())                
                    $.FillCityArray($(this).val());
            })
            
            $("select[name=jobType1]").change(function(){
                if($(this).val())                
                    $.FillCategory2($(this).val());
                if($(this).text() != "기타")
                     $("input[name=jobType_direct]").hide();
            })
            
            $("select[name=jobType2]").change(function(){
                if($(this).text() == "직접입력")                
                    $("input[name=jobType_direct]").show();
                else
                    $("input[name=jobType_direct]").hide();
            })
            $("input[name=jobType_direct]").hide();
            
            $("input:checked").click()
            $("select").change() 
        },    
        FillCityArray : function(cityNo)
        {            
            $("select[name=address_2]").html('');
            Site.Web.Soap.Category.GetSubCategory(cityNo, 
            function(results, context, methodNames){
                $.each(results,function(i){
                    if ( _PageLoad_CityCategory )
                    {
                        $("select[name=address_2]").append($("<option value='"+this.SubCategoryNo+"'" + ( this.SubCategoryNo==<%=RecruitInfo.AreaCategory%> ? "selected='selected'" : "" ) + ">"+this.SubCategoryCNName+"</option>"));
                    }
                    else
                    { 
                        $("select[name=address_2]").append($("<option value='"+this.SubCategoryNo+"'>"+ this.SubCategoryCNName+"</option>"));
                    }
                    
                })
                
                _PageLoad_CityCategory = false;
            },
            function(results, context, methodNames){
                alert( results.get_message() );
            });
        },    
        FillCategory2 : function(category1No)
        {            
            $("select[name=jobType2]").html('');
            Site.Web.Soap.Category.GetSubCategory(category1No, 
            function(results, context, methodNames){
                $.each(results,function(i){
                    if ( _PageLoad_Category )
                    {
                        $("select[name=jobType2]").append($("<option value='"+this.SubCategoryNo+"'" + ( this.SubCategoryNo==<%=RecruitInfo.Category2No%> ? "selected='selected'" : "" ) + ">" + this.SubCategoryCNName + "</option>"));
                    }
                    else
                    { 
                        $("select[name=jobType2]").append($("<option value='"+this.SubCategoryNo+"'>"+ this.SubCategoryCNName +"</option>"));
                    }
                })
                
                _PageLoad_Category = false;
            },
            function(results, context, methodNames){
                alert( results.get_message() );
            });
        },
        Submit : function()
        {
            var values = 
                {
                    join_type : $("input[name=join_type]:checked").val(),
                    join_count: $("select[name=join_count]").val(),
                    //interviewers: $("input.interviewer"),
                    jobType1: $("select[name=jobType1]").val(),
                    jobType2: $("select[name=jobType2]").val(),
                    career_year: $("input[name=career_year]:checked").val(),
                    people_count: $("select[name=people_count]").val(),
                    gender: $("input[name=gender]:checked").val(),
                    age: $("input[name=AgeType]:checked").val(),
                    age_range: $("select[name=AgeCategory]").val(),
                    age_range_direct: $("input[name=AgeEtcValue]").val(),
                    education: $("input[name=education]:checked").val(),
                    major: $("input[name=major]:checked").val(),
                    major_direct : $("input[name=major_direct]").val(),
                    china: $("input[name=china]:checked").val(),
                    english: $("input[name=english]:checked").val(),
                    japanese: $("input[name=japanese]:checked").val(),
                    etc_lang : $("input[name=etc_lang]").val(),
                    etc_lang_level: $("input[name=etc_lang_level]:checked").val(),
                    main_task: $("input[name=main_task]").val(),
                    address_1: $("select[name=address_1]").val(),
                    address_2: $("select[name=address_2]").val(),
                    address_3: $("input[name=address_3]").val(),
                    recruit_day_1: $("select[name=recruit_day_1]").val(),
                    recruit_day_2: $("select[name=recruit_day_2]").val(),
                    recruit_day_3: $("select[name=recruit_day_3]").val(),
                    etc_require: $("textarea[name=etc_require]").val(),
                    pay: $("select[name=PayCategory]").val(),
                    contract: $("input[name=contract]:checked").val(),
                    working_time_opt: $("input[name=working_time_opt]:checked").val(),
                    working_time_etc: $("input[name=working_time_etc]").val(),
                    insurance: $("input[name=insurance]:checked").val(),
                    insurance_etc: $("input[name=insurance_etc]").val(),
                    food: $("input[name=food]:checked").val(),
                    food_etc: $("input[name=food_etc]").val(),
                    severance_pay: $("input[name=severance_pay]:checked").val(),
                    severance_etc: $("input[name=severance_etc]").val(),
                    vacation: $("input[name=vacation]:checked").val(),
                    vacation_etc: $("input[name=vacation_etc]").val(),
                    benefit_etc: $("input[name=benefit_etc]").val()
                };
                
            /*필수값 검사*/
            if(!values.join_type){alert("참가여부를 선택해 주세요.");return false;};                
            if(!values.jobType1 || !values.jobType2){alert("구인직종을 선택해 주세요.");return false;};                
            if(values.people_count==0){alert("인원을 선택해 주세요.");return false;};                
            if(!values.gender){alert("성별을 선택해 주세요.");return false;};                
            if(!values.age){alert("연령을 입력해 주세요.");return false;};                
            if(values.age==1 && values.age_range == 0 && values.age_range_direct==""){alert("연령을 입력해 주세요.");return false;};  
            if(values.main_task==""){alert("주요업무를 입력해 주세요.");return false;};                
            if(values.address_1 == 0 || values.address_2 == 0 || values.address_3==''){alert("근무지역을 선택해 주세요.");return false;};      
            if(!values.contract){alert("계약기간을 입력해주세요.");return false;};                
            if(values.working_time_opt!=0 && $.trim(values.working_time_etc)==""){alert("근무시간을 입력해주세요.");return false;}
            var interviewerStr = []
            $("input.interviewer").each(function(i){interviewerStr.push($(this).val())})            
            $('input[name=interviewers]').val(interviewerStr.join(","));    
            if(values.working_time_opt == 0)
                $('input[name=working_time_etc]').val('')   
            $("form:eq(0)").submit();
        }
    });
})(jQuery);

</script>


</asp:Content>


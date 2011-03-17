<%@ Page Language="C#" AutoEventWireup="true" CodeFile="resume_view.aspx.cs" Inherits="KR_User_resume_view" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<script type="text/javascript" src="/js/jquery-1.4.2.min.js"> </script>
	<script type="text/javascript" src="/js/link.js"></script>			
	<script type="text/javascript" src="/js/common.js"></script>			    
    <link rel="stylesheet" type="text/css" href="/imgsrv/kr/css/base.css" />
    <link rel="stylesheet" type="text/css" href="/imgsrv/kr/css/icon.css" />
    <link rel="stylesheet" type="text/css" href="/ImgSrv/kr/css/sidemenu.css" />
    <link rel="stylesheet" type="text/css" href="/ImgSrv/kr/Css/human.css" />
    <!--[if IE 6]>
		    <link rel="stylesheet" type="text/css" href="../imgsrv/css/base.ie6.css" />
		    <script src="/js/DD_belatedPNG.js"></script>
		    <script>
		      DD_belatedPNG.fix('.icon');		  
		    </script>
    <![endif]-->
  	<style>
  	.regist-class {
    	margin-top:30px;
    	margin-bottom:20px;
    	font-size:16px;
    	font-weight:bold;
    	color:#0091f7;
    	padding-bottom:8px;
    	border-bottom:1px #cccccc solid;
    }
  	</style>
</head>
<body>
    <form id="form1" runat="server">

		<div class="bg-top" style="background:url();">
			<div class="content">
        <div class="sidemenu-main">
					<div class="main">
          	<div class="tab-content">
          		
          		<!--Resume(S)//-->
              <div class="regist detail">
                        	
              	<div class="regist-class">
              		기본정보
              	</div>
              	
                  <div class="regist-item">
                      <div class="regist-header">1.희망지원 회사 코드 및 기타사항 </div>                                
                      <table class="regist-table">
                          <tr>
                              <td class="size33 regist-label">1지망<span class="require">*</span></td>
                              <td class="size33 regist-label">2지망<span class="require">*</span></td>
                              <td class="size33 regist-label">3지망<span class="require">*</span></td>
                          </tr>
                          <tr>
                              <td><%=GetCompanyName(1, resumeEntity.CompanyNo1)%>(<%=resumeEntity.CompanyNo1%>)</td>
                              <td><%=GetCompanyName(1, resumeEntity.CompanyNo2)%>(<%=resumeEntity.CompanyNo2%>)</td>
                              <td><%=GetCompanyName(1, resumeEntity.CompanyNo3)%>(<%=resumeEntity.CompanyNo3%>)</td>
                          </tr>
                          <tr>
                              <td class="regist-label">희망급여 (RMB/1개월)<span class="require">*</span></td>
                              <td colspan="2"><%=resumeEntity.HopeSalary%> <span class="label">RMB (세후금액)</span></td>                                            
                          </tr>
                          <tr>
                              <td class="regist-label" rowspan="2">희망지역<span class="require">*</span></td>
                              <td colspan="2">
                                  <table>
                                      <tr>
                                          <td><span class="label">1지망</span>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                          <td>
                                              <%=GetCategoryName(1, resumeEntity.CityNo1)%> > <%=GetSubCategoryName(1, resumeEntity.ArrayNo1)%>
                                          </td>
                                      </tr>
                                  </table>
                              </td>                                            
                          </tr>
                          <tr>
                              <td colspan="2">
                                  <table>
                                      <tr>
                                          <td><span class="label">2지망</span>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                          <td>
                                              <%=GetCategoryName(1, resumeEntity.CityNo2)%> > <%=GetSubCategoryName(1, resumeEntity.ArrayNo2)%>
                                          </td>
                                      </tr>
                                  </table>
                              </td>                                            
                          </tr>
                          <tr>
                              <td class="regist-label">취업희망시기<span class="require">*</span></td>
                              <td colspan="2"><%=resumeEntity.HopeRecruitDate.ToString("yyyy-MM-dd")%> <span class="label">이후</span></td>                                            
                          </tr>
                      </table>
                  </div>
                  
                   <div class="regist-item">
                      <div class="regist-header">2.희망/관심 업종 및 직종</div>                                
                      <table class="regist-table">
                          <tr>
                              <td class="size33 regist-label">희망/관심 업종<span class="require">*</span></td>
                              <td colspan="2"><%=GetCategoryName(1, resumeEntity.BusinessCategoryNo)%></td>                                            
                          </tr>
                          <tr>
                              <td class="regist-label">희망/관심 직종<span class="require">*</span></td>
                              <td colspan="2"><%=GetCategoryName(1, resumeEntity.Category1No)%> > <%=GetSubCategoryName(1, resumeEntity.Category2No)%></td>                                            
                          </tr>
                      </table>
                  </div>
                  
                  <div class="regist-item">
                      <div class="regist-header">3.면접참가 가능 여부</div>                                
                      <table class="regist-table">
                          <tr>
                              <td class="size33 regist-label">박람회 당일 면접참가여부<span class="require">*</span></td>
                              <td colspan="2"><%=resumeEntity.JoinType == 1 ? "가능" : "불가능"%></td>                                            
                          </tr>
                      </table>
                  </div>
                  
              	<div class="regist-class">
              		한국어
              	</div>
                  
                  <div class="regist-item">
                      <div class="regist-header">1.개인정보</div>                                
                      <table class="regist-table">
                          <tr>
                              <td rowspan="6" class="size-k-1-1">
                                  <img class="picture" width="104px" height="138px" src="<%=UserInfo.ImageUrl %>" />
                              </td>
                              <td class="size-k-1-2 regist-label">국문</td>
                              <td class="size-k-1-3"><%=UserInfo.KRName %></td>
                              <td class="size-k-1-4 regist-label">주민등록번호</td>
                              <td class="size-k-1-5">*************</td>                                                    
                          </tr>
                          <tr>
                              <td class="regist-label">중문</td>
                              <td><%=UserInfo.CNName %></td>
                              <td class="regist-label">연령</td>
                              <td><%=resumeDetail_KR.KoreanAge %>세 (만 <%=resumeDetail_KR.Age %>세)</td>                                                    
                          </tr>
                          <tr>
                              <td class="regist-label">영문</td>
                              <td><%=UserInfo.ENGName %></td>
                              <td class="regist-label">재중경험</td>
                              <td><%=resumeDetail_KR.ChinaExp.Replace("-", "년 ") %>개월</td>                                                                                                    
                          </tr>
                          <tr>
                              <td class="regist-label">한국연락처</td>
                              <td><%=UserInfo.KRPhoneNo %></td>
                              <td class="regist-label">중국연락처</td>
                              <td><%=UserInfo.CNPhoneNo %></td>                                                                                                    
                          </tr>
                          <tr>
                              <td class="regist-label">거주국가</td>
                              <td><%=UserInfo.ResidanceCountry == 1 ? "한국":"중국"%></td>
                              <td class="regist-label">병역</td>
                              <td><%=GetMilitaryInfo(resumeDetail_KR.Military)%></td>                                                                                                    
                          </tr>
                          <tr>
                              <td class="regist-label">이메일</td>
                              <td><%=UserInfo.Email%></td>
                              <td class="regist-label">경력여부</td>
                              <td><%=resumeDetail_KR.IsCareer == 1 ? "신입" : "경력"%></td>                                                                                                    
                          </tr>
                          <tr>
                              <td class="regist-label" colspan="2">주소(현재 실 거주지)</td>
                              <td colspan="3"><%=resumeDetail_KR.Address%></td>                                 
                          </tr>
                      </table>
                  </div>
                  
                  <div class="regist-item">
                      <div class="regist-header">2.학력</div>                                
                      <table class="regist-table">
                          <tr>
                              <td class="size-k-2-1 regist-label">학교명</td>
                              <td class="size-k-2-2 regist-label">재학기간(년,월)</td>
                              <td class="size-k-2-3 regist-label">상태</td>
                              <td class="size-k-2-4 regist-label">전공/부전공</td>
                              <td class="size-k-2-5 regist-label">소재국가</td>                                                    
                          </tr>
                          <tr>
                             <td>서울대학교</td>
                             <td>
                                 <table>
                                      <tr>
                                          <td class="size-sub-k-2-1">2008.2</td>
                                          <td class="size-sub-k-2-2">-</td>
                                          <td class="size-sub-k-2-3">2011.3</td>
                                      </tr>
                                 </table>
                             </td>
                             <td class="v-center">졸업</td>
                             <td>대외한어과</td>
                             <td>한국</td>
                          </tr>
                          <tr>
                             <td>서울대학교</td>
                             <td>
                                 <table>
                                      <tr>
                                          <td class="size-sub-k-2-1">2008.2</td>
                                          <td class="size-sub-k-2-2">-</td>
                                          <td class="size-sub-k-2-3">2011.3</td>
                                      </tr>
                                 </table>
                             </td>
                             <td class="v-center">졸업</td>
                             <td>대외한어과</td>
                             <td>한국</td>
                          </tr>
                          <tr>
                             <td>서울대학교</td>
                             <td>
                                 <table>
                                      <tr>
                                          <td class="size-sub-k-2-1">2008.2</td>
                                          <td class="size-sub-k-2-2">-</td>
                                          <td class="size-sub-k-2-3">2011.3</td>
                                      </tr>
                                 </table>
                             </td>
                                 <td class="v-center">졸업</td>
                             <td>대외한어과</td>
                             <td>한국</td>
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
                             <td>대한적십자</td>
                             <td>
                                 <table>
                                      <tr>
                                          <td class="size-sub-k-2-1">2008.6</td>
                                          <td class="size-sub-k-2-2">-</td>
                                          <td class="size-sub-k-2-3">2008.8</td>
                                      </tr>
                                 </table>
                             </td>
                             <td>정부기관</td>
                             <td>인턴,자원봉사</td>
                          </tr>
                          <tr>
                             <td>대한적십자</td>
                             <td>
                                 <table>
                                      <tr>
                                          <td class="size-sub-k-2-1">2008.6</td>
                                          <td class="size-sub-k-2-2">-</td>
                                          <td class="size-sub-k-2-3">2008.8</td>
                                      </tr>
                                 </table>
                             </td>
                             <td>정부기관</td>
                             <td>인턴,자원봉사</td>
                          </tr>
                          <tr>
                             <td>대한적십자</td>
                             <td>
                                 <table>
                                      <tr>
                                          <td class="size-sub-k-2-1">2008.6</td>
                                          <td class="size-sub-k-2-2">-</td>
                                          <td class="size-sub-k-2-3">2008.8</td>
                                      </tr>
                                 </table>
                             </td>
                             <td>정부기관</td>
                             <td>인턴,자원봉사</td>
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
                             <td>중국어</td>
                             <td>신HSK</td>
                             <td>5급</td>
                             <td>고급</td>
                          </tr>
                          <tr>
                             <td>중국어</td>
                             <td>신HSK</td>
                             <td>5급</td>
                             <td>고급</td>
                          </tr>
                          <tr>
                             <td>중국어</td>
                             <td>신HSK</td>
                             <td>5급</td>
                             <td>고급</td>
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
                              <td>2007.4</td>
                              <td>운전면허 보통1급</td>
                              <td>서울지방경찰청</td>
                          </tr>
                      </table>
                  </div>
                  
                  <div class="regist-item">
                      <div class="regist-header">6.보유기술 및 특기사항</div>                                
                      <textarea class="w100" rows="20" name="award-text"><%=resumeDetail_KR.Description %></textarea>
                  </div>
                  
                  <div class="regist-item">
                      <div class="regist-header">7.자기소개서</div>                                
                      <textarea class="w100" rows="20" name="introduce"><%=resumeDetail_KR.AboutMe %></textarea>
                  </div>
                  
              	<div class="regist-class">
              		中文
              	</div>
                  
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
                              <td class="regist-label">工作年限</td>
                              <td><%=resumeDetail_CN.IsCareer == 1 ? "新来" : "阅历"%></td>                                                                                                    
                          </tr>
                          <tr>
                              <td class="regist-label">最高学历(学位)</td>
                              <td><%=resumeDetail_CN.LastestEducation %></td>
                              <td class="regist-label">毕业学校</td>
                              <td></td>                                                                                                    
                          </tr>
                          <tr>
                              <td class="regist-label">专业</td>
                              <td>汉语</td>
                              <td class="regist-label">毕业时间</td>
                              <td>2010.5</td>                                                                                                    
                          </tr>                                            
                          <tr>
                              <td class="regist-label">现详细居住地址</td>
                              <td colspan="3"><%=resumeDetail_CN.Address %></td>                                 
                          </tr>
													<tr>
                              <td class="regist-label">手机</td>
                              <td><%=UserInfo.CNPhoneNo %></td>
                              <td class="regist-label">电子邮件</td>
                              <td><%=UserInfo.Email %></td>                                                                                                    
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
																<table>
                                      <tr>
                                          <td class="size-sub-k-2-1">2010.6</td>
                                          <td class="size-sub-k-2-2">-</td>
                                          <td class="size-sub-k-2-3">2010.8</td>
                                      </tr>
															</table>
													   </td>
                             <td>上网</td>
                             <td>门户网站部</td>
                             <td>经历</td>
                             <td>无</td>
                          </tr>
													<tr>
                             <td>
																<table>
                                      <tr>
                                          <td class="size-sub-k-2-1">2010.6</td>
                                          <td class="size-sub-k-2-2">-</td>
                                          <td class="size-sub-k-2-3">2010.8</td>
                                      </tr>
																	</table>
		   												</td>
                             <td>上网</td>
                             <td>门户网站部</td>
                             <td>经历</td>
                             <td>无</td>
                          </tr>
													<tr>
                             <td>
																<table>
                                      <tr>
                                          <td class="size-sub-k-2-1">2010.6</td>
                                          <td class="size-sub-k-2-2">-</td>
                                          <td class="size-sub-k-2-3">2010.8</td>
                                      </tr>
																</table>
													   </td>
                             <td>上网</td>
                             <td>门户网站部</td>
                             <td>经历</td>
                             <td>无</td>
                          </tr>
													<tr>
                             <td>
																<table>
                                      <tr>
                                          <td class="size-sub-k-2-1">2010.6</td>
                                          <td class="size-sub-k-2-2">-</td>
                                          <td class="size-sub-k-2-3">2010.8</td>
                                      </tr>
																</table>
													   </td>
                             <td>上网</td>
                             <td>门户网站部</td>
                             <td>经历</td>
                             <td>无</td>
                          </tr>
                      </table>
                  </div>
                  
                  <div class="regist-item">
                      <div class="regist-header">语言水平</div>                                
                      <table class="regist-table">
                          <tr>
                              <td class="regist-label" style="width:141px">语言</td>
                              <td class="regist-label" style="width:258px">>考试名称</td>
                              <td class="regist-label" style="width:182px">>分数</td>
                              <td class="regist-label" style="width:143px">>会话</td>                                             
                          </tr>
                          <tr>
                             <td>汉语</td>
                             <td>新HSK</td>
                             <td>五级</td>
                             <td>上级</td>
                          </tr>
													<tr>
                             <td>汉语</td>
                             <td>新HSK</td>
                             <td>五级</td>
                             <td>上级</td>
                          </tr>
													<tr>
                             <td>汉语</td>
                             <td>新HSK</td>
                             <td>五级</td>
                             <td>上级</td>
                          </tr>
                      </table>
                  </div>
                                                      
                  <div class="regist-item">
                      <div class="regist-header">自我评价（主要业绩，个人特长，电脑能力等）</div>                                
                      <textarea class="w100" rows="20">哈哈哈</textarea>
                  </div>
                  
              	<div class="regist-class">
              		English
              	</div>
                  
                  <div class="regist-item">
                      <div class="regist-header">Personal Information</div>                                
                      <table class="regist-table">                                            
                          <tr>
                              <td class="regist-label">Name</td>
                              <td>kim kim kim</td>
                              <td class="regist-label">Gender</td>
                              <td>Famle</td>                                                    
                          </tr>
                          <tr>
                              <td class="regist-label">Date of Birth</td>
                              <td>2011.8.23</td>
                              <td class="regist-label">Military service</td>
                              <td>done</td>                                                                                                    
                          </tr>
                          <tr>
                              <td class="regist-label">Phone</td>
                              <td>131-4443-2124</td>
                              <td class="regist-label">E-mail</td>
                              <td>kimkimkim@hotmail.com</td>                                                                                                    
                          </tr>
                          <tr>
                              <td class="regist-label">Address</td>
                              <td colspan="3">Room 12323, minhang-qu, Shanghai-city, China</td>                                 
                          </tr>
                      </table>
                  </div>
                  
                  <div class="regist-item">
                      <div class="regist-header">Education Background</div>                                
                      <table class="regist-table">
                          <tr>
                              <td class="regist-label" style="width:141px;">Name of Institute</td>
                              <td class="regist-label" style="width:248px;">Major</td>
                              <td class="regist-label" style="width:173px;">Period</td>
                              <td class="regist-label" style="width:159px;">Location</td>                                                 
                          </tr>
                          <tr>
                             <td>Seoul university</td>
                             <td>Chinese</td>
                             <td>
																<table>
                                      <tr>
                                          <td class="size-sub-k-2-1">2008.2</td>
                                          <td class="size-sub-k-2-2">-</td>
                                          <td class="size-sub-k-2-3">2011.3</td>
                                      </tr>
																</table>
													   </td>
                             <td>Korea</td>
                          </tr>
													<tr>
                             <td>Seoul university</td>
                             <td>Chinese</td>
                             <td>
																<table>
                                      <tr>
                                          <td class="size-sub-k-2-1">2008.2</td>
                                          <td class="size-sub-k-2-2">-</td>
                                          <td class="size-sub-k-2-3">2011.3</td>
                                      </tr>
																</table>
		   											</td>
                             <td>Korea</td>
                          </tr>
                      </table>
                  </div>
                  
                  <div class="regist-item">
                      <div class="regist-header">Career</div>                                
                      <table class="regist-table">
                          <tr>
                              <td class="regist-label" style="width:174px">Period</td>
                              <td class="regist-label" style="width:144px">Company Name</td>
                              <td class="regist-label" style="width:123px">Department</td>
                              <td class="regist-label" style="width:130px">Details of duties</td>                                             
															<td class="regist-label" style="width:143px">Location</td>
                          </tr>
                          <tr>
                             <td>
																<table>
                                      <tr>
                                          <td class="size-sub-k-2-1">2008.6</td>
                                          <td class="size-sub-k-2-2">-</td>
                                          <td class="size-sub-k-2-3">2008.8</td>
                                      </tr>
																</table>
		  											 </td>
                             <td>wise-ecommerce</td>
                             <td>online service</td>
                             <td>intern</td>
		   											 <td>Korea</td>
                          </tr>
													<tr>
                             <td>
																<table>
                                      <tr>
                                          <td class="size-sub-k-2-1">2008.6</td>
                                          <td class="size-sub-k-2-2">-</td>
                                          <td class="size-sub-k-2-3">2008.8</td>
                                      </tr>
																</table>
		   											 </td>
                             <td>wise-ecommerce</td>
                             <td>online service</td>
                             <td>intern</td>
		   											 <td>Korea</td>
                          </tr>
													<tr>
                             <td>
																<table>
                                      <tr>
                                          <td class="size-sub-k-2-1">2008.6</td>
                                          <td class="size-sub-k-2-2">-</td>
                                          <td class="size-sub-k-2-3">2008.8</td>
                                      </tr>
																</table>
		   											 </td>
                             <td>wise-ecommerce</td>
                             <td>online service</td>
                             <td>intern</td>
		  											 <td>Korea</td>
                          </tr>
                      </table>
                  </div>
                  
                  <div class="regist-item">
                      <div class="regist-header">Foreign Language Skill </div>                                
                      <table class="regist-table">
                          <tr>
                              <td class="regist-label" style="width:143px">Foreign Language Skill </td>
                              <td class="regist-label" style="width:134px">Level</td>
                              <td class="regist-label" style="width:310px">Score of Authenticated Language Test</td>
                              <td class="regist-label" style="width:142px">Score/Grade</td>                                             
                          </tr>
                          <tr>
                             <td>Chinese</td>
                             <td>level5</td>
                             <td>new HSK</td>
                             <td>5</td>
                          </tr>
													<tr>
                             <td>Chinese</td>
                             <td>level5</td>
                             <td>new HSK</td>
                             <td>5</td>
                          </tr>
												<tr>
                             <td>Chinese</td>
                             <td>level5</td>
                             <td>new HSK</td>
                             <td>5</td>
                          </tr>
                      </table>
                  </div>
                  
                  <div class="regist-item">
                      <div class="regist-header">Certification & Licenses</div>                                
                      <table class="regist-table">
                          <tr>
                              <td class="regist-label" style="width:170px">Title</td>
                              <td class="regist-label" style="width:340px">Issuing Institution</td>
                              <td class="regist-label" style="width:268px">Date of acquisition</td>                                         
                          </tr>
                          <tr>
                              <td>Make-up</td>
                              <td>Korea Make-up Association</td>
                              <td>2007.1</td>
                          </tr>
													<tr>
                              <td>Make-up</td>
                              <td>Korea Make-up Association</td>
                              <td>2007.1</td>
                          </tr>
                      </table>
                  </div>
                  
                  <div class="regist-item">
                      <div class="regist-header">Awards, O/A Ability, Professional Experience  Etc </div>                                
                      <textarea class="w100" rows="20" name="award-text">This is Kim so hyun.</textarea>
                  </div>
                                               
                  <!--btn//-->
                  <div class="regist-item">
                      <div class="regist-tool">
                          <span class="agree">                                                
                              <label for="agree">취업을 희망하여 동 이력서를 작성하였으며 해외취업을 목적으로 한국산업인력공단 월드잡사이트 등록 및 해외 구인기업체에게 제공되는 것에 동의합니다.</label>
                          </span>
                          <br><br><br>
                          <input type="button" value="인쇄" onClick="" style="width:100px;height:30px;font-size:9pt">
                      </div>
                  </div>
              	
              </div>
              <!--Resume(E)//-->
                      
          	</div>
					</div>
				</div>
      </div>
		</div>

    </form>
</body>
</html>

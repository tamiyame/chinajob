﻿(function($) {
	// type here your code
	
    // ready
    $(document).ready(function() {
		$("div.tab ul li").removeClass("icon-folder-middle-on").addClass("icon-folder-middle-off").removeClass("select");
		$("div.tab ul li:eq("+ countryCode +")").removeClass("icon-folder-middle-off").addClass("icon-folder-middle-on").addClass("select");
		
		$("td.ssn").text(ssn1+"-"+ssn2);
		$("td.age").text(koreanAge + "세 (만 " + age + "세)");
		$("td.inchina").text(chinaExp[0]+"년 " + chinaExp[1] + "개월");
		$("td.army").text(military==1?"필":military==2?"미필":military==3?"면제":military==4?"무관":"기타");
		$("td.isCareer").text(isCareer==1?$.translateHelper.getText("KR_recruit_human_detail.js_isCareer_no"):
								isCareer==2?$.translateHelper.getText("KR_recruit_human_detail.js_isCareer_yes"):
								$.translateHelper.getText("KR_recruit_human_detail.js_other"));
		$("td.address").text(address);
		$("textarea[name=award_text]").val(description);
		$("textarea[name=introduce]").val(aboutMe);

		$("td.lastestEducation").text(lasteastEducation);
		$("td.graduationYear").text(graduationYear);
		$("td.militaryService").text(militaryService);

		$.each(academicAbilities, function(idx, data) {
			$("td.education_school:eq("+idx+")").text(data.SchoolName);
			$("td.education_period_start:eq("+idx+")").text(data.SchoolStartDate);
			$("td.education_period_end:eq("+idx+")").text(data.SchoolEndDate);
			$("td.education_state:eq("+idx+")").text(data.SchoolStatus==1?"졸업":"-");
			$("td.education_major:eq("+idx+")").text(data.MajorMinor);
			$("td.education_national:eq("+idx+")").val(data.SchoolCountryName);
		});

		$.each(careers, function(idx, data) {
			$("td.career_company:eq("+idx+")").text(data.CareerCompanyName);
			$("td.career_period_start:eq("+idx+")").text(data.CareerStartDate);
			$("td.career_period_end:eq("+idx+")").text(data.CareerEndDate);
			$("td.career_department:eq("+idx+")").text(data.CareerJobs);
			$("td.career_detail:eq("+idx+")").text(data.CareerPosition);
			$("td.career_location:eq("+idx+")").text(data.CareerLocation);
		});

		$.each(languages, function(idx, data) {
			$("td.language_type:eq("+idx+")").text(data.LanguageName);
			$("td.language_testname:eq("+idx+")").text(data.TestDesc);
			$("td.language_score:eq("+idx+")").text(data.GradeDesc);
			$("td.language_level:eq("+idx+")").text(data.ConversationLevel==1?$.translateHelper.getText("KR_recruit_human_detail.js_languagelevel_high"):
												data.ConversationLevel==2?$.translateHelper.getText("KR_recruit_human_detail.js_languagelevel_middle"):
												data.ConversationLevel==3?$.translateHelper.getText("KR_recruit_human_detail.js_languagelevel_low"):
												data.ConversationLevel==4?"LEVEL4":
												data.ConversationLevel==5?"LEVEL5":
												$.translateHelper.getText("KR_recruit_human_detail.js_other"));
		});

		$.each(licenses, function(idx, data) {
			$("td.licence_year:eq("+idx+")").text(data.LicensedDate);
			$("td.licence_title:eq("+idx+")").text(data.LicenseName);
			$("td.licence_institution:eq("+idx+")").text(data.Organization);
		});
	    
	});
})(jQuery);
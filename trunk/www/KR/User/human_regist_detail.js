jQuery(function()
{
    jQuery.CreateInit();

	$("div.tab ul li").removeClass("icon-folder-middle-on").addClass("icon-folder-middle-off").removeClass("select");
	$("div.tab ul li:eq("+ countryCode +")").removeClass("icon-folder-middle-off").addClass("icon-folder-middle-on").addClass("select");
	$("div.tab ul li:eq(0)").click(function() { location.href=GetURL("/user/human_regist_basic.aspx"); });
	$("div.tab ul li:eq(1)").click(function() { location.href=GetURL("/user/human_regist_detail_kr.aspx"); });
	$("div.tab ul li:eq(2)").click(function() { location.href=GetURL("/user/human_regist_detail_cn.aspx"); });
	$("div.tab ul li:eq(3)").click(function() { location.href=GetURL("/user/human_regist_detail_en.aspx"); });

	$("input[name=ssn1]").val(ssn1);
	$("input[name=ssn2]").val(ssn2);
	$("input[name=korean_age]").val(koreanAge);
	$("input[name=age]").val(age);
	$("select[name=inchina_year]").val(chinaExp[0]);
	$("select[name=inchina_month]").val(chinaExp[1]);
	$("input[name=army]").each(function() {
		if( $(this).val() == military )
		{
			$(this).attr("checked", "checked");
		}
		else
		{
			$(this).attr("checked", "");
		}
	});
	$("input[name=isCareer]").each(function() {
		if( $(this).val() == isCareer )
		{
			$(this).attr("checked", "checked");
		}
		else
		{
			$(this).attr("checked", "");
		}
	});
	$("input[name=address]").val(address);
	$("textarea[name=award_text]").val(description);
	$("textarea[name=introduce]").val(aboutMe);
	
	$("input[name=lastestEducation]").val(lasteastEducation);
	$("input[name=graduationYear]").val(graduationYear);
	$("input[name=militaryService]").val(militaryService);

    $.each(academicAbilities, function(idx, data) {
        $("input[name=education_school]:eq("+idx+")").val(data.SchoolName);
        $("input[name=education_period_start]:eq("+idx+")").val(formatDateTime(data.SchoolStartDate));
        $("input[name=education_period_end]:eq("+idx+")").val(formatDateTime(data.SchoolEndDate));
        $("select[name=education_state]:eq("+idx+")").val(data.SchoolStatus);
        $("input[name=education_major]:eq("+idx+")").val(data.MajorMinor);
        $("input[name=education_national]:eq("+idx+")").val(data.SchoolCountryName);
    });

    $.each(careers, function(idx, data) {
        $("input[name=career_company]:eq("+idx+")").val(data.CareerCompanyName);
        $("input[name=career_period_start]:eq("+idx+")").val(formatDateTime(data.CareerStartDate));
        $("input[name=career_period_end]:eq("+idx+")").val(formatDateTime(data.CareerEndDate));
        $("input[name=career_department]:eq("+idx+")").val(data.CareerJobs);
        $("input[name=career_detail]:eq("+idx+")").val(data.CareerPosition);
        $("input[name=career_location]:eq("+idx+")").val(data.CareerLocation);
        
    });

    $.each(languages, function(idx, data) {
        $("input[name=language_type]:eq("+idx+")").val(data.LanguageName);
        $("input[name=language_testname]:eq("+idx+")").val(data.TestDesc);
        $("input[name=language_score]:eq("+idx+")").val(data.GradeDesc);
        $("input[name=language_level_"+(idx+1)+"]").each(function() {
            if( $(this).val() == data.ConversationLevel)
            {
                $(this).attr("checked", "checked");
            }
            else{
                $(this).attr("checked", "");
            }
        });
    });

    $.each(licenses, function(idx, data) {
        $("input[name=licence_year]:eq("+idx+")").val(formatDateTime(data.LicensedDate));
        $("input[name=licence_title]:eq("+idx+")").val(data.LicenseName);
        $("input[name=licence_institution]:eq("+idx+")").val(data.Organization);
    });
    
    function formatDateTime(date)
    {
		return date.getFullYear() + '-' + padLeft((date.getMonth()+1).toString(), 2, '0') + '-' + padLeft(date.getDate().toString(), 2, 0);
    }
    
    function padLeft(str, n, pad)
    {
		t = '';
		if(n>str.length){
			for(i=0;i < n-str.length;i++){
				t+=pad;
			}
		}
		return t+str;
    }
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
            if(countryCode==$.translateHelper.countryCode_kr && !army){ alert("병역을 확인해주세요.");return;  }
            if(countryCode!=$.translateHelper.countryCode_en && !isCareer){ alert("경력여부를 확인해주세요.");return;  }
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
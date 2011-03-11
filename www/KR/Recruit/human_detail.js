(function($) {
	// type here your code
	
    // ready
    $(document).ready(function() {
		$("div.tab ul li").removeClass("icon-folder-middle-on").addClass("icon-folder-middle-off").removeClass("select");
		$("div.tab ul li:eq("+ countryCode +")").removeClass("icon-folder-middle-off").addClass("icon-folder-middle-on").addClass("select");
		$("div.tab ul li:eq(0)").click(function() { location.href=GetURL("/Recruit/human_detail_basic.aspx?userno=" + userNo); });
		$("div.tab ul li:eq(1)").click(function() { location.href=GetURL("/Recruit/human_detail_korean.aspx?userno=" + userNo); });
		$("div.tab ul li:eq(2)").click(function() { location.href=GetURL("/Recruit/human_detail_china.aspx?userno=" + userNo); });
		$("div.tab ul li:eq(3)").click(function() { location.href=GetURL("/Recruit/human_detail_english.aspx?userno=" + userNo); });
    });
})(jQuery);
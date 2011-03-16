(function($) {
    // menu javascript;
    $(function() {
        $('.menu li').hover(function() {
            var submenu = $(this).find('ul');
            submenu.show();
        }, function() {
            $(this).find('ul').hide();
        });

        $('ul.pager li a').click(function(e) {
            e.preventDefault();
        })

        $('.banner').each(function(i) {
            $(this).find('img').each(function(i) {
                if (i == 0)
                    $(this).css({ 'opacity': 1.0 });
                else
                    $(this).css({ 'opacity': 0.0 });
            })
        });

        //$('.banner img').addClass('hide');
        $('ul.pager li').hover(function() {
            $(this).parent().addClass('hover');
            if ($(this).hasClass('select'))
                return;
            var self = $(this).text();
            var link = $(this).find('a').attr('href');
            var index = 0;
            $(this).parent().find('li').each(function(i) {
                if (self == $(this).text()) {
                    $(this).addClass('select');
                    index = i;
                }
                else
                    $(this).removeClass('select');
            })
            var bannerContainer = $(this).parents('.banner-container').find('.banner');
            bannerContainer.find('img').stop();
            bannerContainer.find('img').animate({ 'opacity': 0.0 });
            bannerContainer.find('img:eq(' + index + ')').stop().css({ 'opacity': 0.0 }).animate({ 'opacity': 1.0 });
            $(this).parents('.banner-container').find('.action').unbind().click(function() { location.href = link });
        }, function() { $(this).parent().removeClass('hover'); })
        $('ul.pager').each(function() { $(this).find('li:eq(0)').hover() });
        function intervalRefresh() {

            $('ul.pager').each(
	            function(i) {
	                if ($(this).hasClass('hover'))
	                    return;
	                var selectIndex = 0;
	                var pagerLength = $(this).find('li').length;
	                $(this).find('li').each(function(i) {
	                    if ($(this).hasClass('select'))
	                        selectIndex = i;
	                })
	                $(this).find('li:eq(' + ((++selectIndex) % pagerLength) + ')').hover();
	            })
        }
        setInterval(intervalRefresh, 4000);
        $('.expo-folder').click(function() { $(this).addClass('hide'); $('.expo-content').removeClass('hide'); });
    })

    $.extend({
        CategoryLangName: function(item) {
            if (CountryCode == 1)
                return item.CategoryKRName;
            if (CountryCode == 2)
                return item.CategoryCNName;
            if (CountryCode == 2)
                return item.CategoryENGName;
            return "";
        },

        SubCategoryLangName: function(item) {
            if (CountryCode == 1)
                return item.SubCategoryKRName;
            if (CountryCode == 2)
                return item.SubCategoryCNName;
            if (CountryCode == 2)
                return item.SubCategoryENGName;
            return "";
        },

        Action: function(url, html) {
            var $Frm = $("form:[name=frmAction]");
            $Frm.attr({ "method": "post", "action": url }).html(html);
            return $Frm;
        },

        Login: function(codetype, userid, userpwd, chk, redirect) {
            if (redirect == undefined)
                redirect = window.location.href;
            var $Frm = $.Action("/login/loginproc.aspx", "<input type='text' id='CodeType' name='CodeType' class='CodeType' /><input type='text' id='UserID' name='UserID' class='UserID' /><input type='text' id='UserPWD' name='UserPWD' class='UserPWD'/><input type='text' id='Redirect' name='Redirect' class='Redirect'/>");

            $Frm.find("input:[name=UserID]").val(userid);
            $Frm.find("input:[name=UserPWD]").val(userpwd);
            $Frm.find("input:[name=CodeType]").val(codetype);
            $Frm.find("input:[name=Redirect]").val(encodeURIComponent(redirect));
            //$.Cookie("CKID", chk==true?userid:"", chk==true?7:0 );

            $Frm.submit();
        },

        Logout: function(redirect) {
            if (redirect == undefined)
                redirect = window.location.href;
            var $Frm = $.Action("/login/logoutproc.aspx", "<input type='text' id='Redirect' name='Redirect' class='Redirect'/>");
            if (redirect != undefined) {
                $Frm.find("input:[name=Redirect]").val(encodeURIComponent(redirect));
            }
            $Frm.submit();
        },

        Cookie: function(key, value, options) {
            if (arguments.length > 1) {
                var o = $.extend({}, { expires: 7, path: "/" }, options);
                if (value === null || value === undefined) {
                    value = '';
                    o.expires = -1;
                }
                if (o.expires.constructor != Date) {
                    var today = new Date();
                    today.setDate(today.getDate() + o.expires);
                    o.expires = today;
                }
                document.cookie = key + '=' + value + '; expires=' + o.expires.toUTCString() +
                '; path=/' +
                '; domain=chinajobgo.com';
            } else {
                if (result = new RegExp(key + "=(.*?)(?:;|$)").exec(document.cookie))
                    return decodeURIComponent(result[1]);
                return false;
            }
        }
    });
})(jQuery);
﻿$(function () {

    var getPage = function() {
        var $a = $(this);

        var options = {
            url: $a.attr("href"),
            type: "get"
        };

        $.ajax(options).done(function(data) {
            var target = $a.parents("div.pagedLsit").attr("data-otf-target");
            $(target).replaceWith(data);
        });
        return false;
    };

    $("main-content").on("click", ".pagedList a", getPage);
});

$(function () {

    $("#returnToTop").hide();

    $(function () {
        $(window).scroll(function () {
            if ($(this).scrollTop() > 100) {
                $('#returnToTop').fadeIn(300);
            } else {
                $('#returnToTop').fadeOut(300);
            }
        });

        $('#returnToTop a').click(function () {
            $('body,html').animate({
                scrollTop: 0
            }, 500);
            return false;
        });
    });

});
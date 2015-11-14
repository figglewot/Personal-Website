$(function () {

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

    // hide #back-top first
    $("#return-to-top").hide();

    // fade in #back-top
    $(function () {
        $(window).scroll(function () {
            if ($(this).scrollTop() > 100) {
                $('#return-to-top').fadeIn(300);
            } else {
                $('#return-to-top').fadeOut(300);
            }
        });

        // scroll body to 0px on click
        $('#return-to-top i').click(function () {
            $('body,html').animate({
                scrollTop: 0
            }, 500);
            return false;
        });
    });

});
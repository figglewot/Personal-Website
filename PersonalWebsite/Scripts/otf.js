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
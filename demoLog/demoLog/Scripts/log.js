var logArray = [];
//This is working to write out to console... but not staying there :(
//$(document).ready(function () {
//    $("a").click(function () {
//        var urlValue = $(this).attr("href");
//        var link = location.href;
//        console.log(urlValue);
//        console.log(link);
//    })
//});
//console.log(logArray);

(function ($) {
    $.fn.logActivity = function () {
        var urlValue
        $(this).click(urlValue = location.href);
        (console.log(urlValue));
    };
}(jQuery));

$("a").logActivity();


//$(document).ready(function () {
//    $("p").click(function () {
//        $(this).fadeOut();
//    });
//});

//Not working at all!
//$(document).ready(function () {
//    var objReWrite = {
//        test: function () {
//            $(console.log("testing actionLink()"));
//        }
//    };
//    $("a").click($.proxy(objReWrite, "test"));
//});
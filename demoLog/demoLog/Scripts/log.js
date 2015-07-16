var logArray = [];
i = 0;
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
        logArray[i++] = urlValue;
        //console.log(urlValue);
        //for (var j in logArray) {
        //    console.log(logArray[j]);
        //}
    };
}(jQuery));
$("a").logActivity();

(function ($) {
    $.fn.runArray = function () {
        for (var j in logArray) {
            console.log(logArray[j]);
        }
    };
}(jQuery));
$(document).runArray();

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
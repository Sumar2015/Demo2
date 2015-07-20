;
var logArray = [];
var i = 0;
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
        var urlValue;
        $(this).click(urlValue = location.href);
        //logArray[i] = urlValue;
        $.each(urlValue, function (href) { logArray.push(href);})
        //for (var i in logArray) {
        //    logArray[i] = urlValue;
        //}
    };
}(jQuery));
$("a").logActivity();

$.each(logArray, function (index, href) {
    console.log(index + ": " + href);
})

//(function ($) {
//    $.fn.runArray = function () {
//        $.each(logArray, function (index, href) {
//            console.log(index + ": " + href);
//        })
//        //for (var j in logArray) {
//        //    console.log(logArray[j]);
//        //}
//    };
//}(jQuery));
//$("div").runArray();

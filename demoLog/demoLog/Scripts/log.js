;
var logArray = [];
var index = 0;

(function ($) {
    $.fn.logActivity = function () {
        var urlValue;
        var stopper = 20;
        for (var j = 0; stopper > j; j++) {
            $(this).click(urlValue = location.href);
            logArray[index] = urlValue;
            index++;
        }
    };
}(jQuery));
$("a").logActivity();

$.each(logArray, function (index, href) {
    console.log(index + ": " + href);
})

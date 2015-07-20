;
var logArray = [];
var urlStorage;
var index = 0;

(function ($) {
    $.fn.logActivity = function () {
        $(this).click(urlStorage = location.href);
        logArray.push(urlStorage);
        
    };
}(jQuery));
$("a").logActivity();

console.log(urlStorage);
console.log(logArray);

//$.each(logArray, function (index, href) {
//    console.log(index + ": " + href);
//})

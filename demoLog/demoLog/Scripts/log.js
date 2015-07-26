;
var logArray = [];
var urlStorage;
var index = 0;

(function ($) {
    $.fn.extend({
        logPlugin: function () {

            //getting href
            $(this).click(urlStorage = location.href);
            //console.log("Link: " + urlStorage);

            //add to localStorage
            var counter = localStorage.length;
            localStorage.setItem(counter, urlStorage);
            
            //clear localStorage
            if (localStorage.length > 20) {
                localStorage.clear();
            }

            //showing reasult
            $.each(localStorage, function (index, link) {
                console.log(index + ": " + link);
            })

        }
    });
    //$.fn.logActivity = function () {
    //    $(this).click(urlStorage = location.href);
    //    logArray.push(urlStorage);
        
    //};
}(jQuery));
//$("a").logActivity();
$("a").logPlugin();

//$.each(localStorage, function (index, link) {
//    console.log(index + ": " + link);
//});
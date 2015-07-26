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
            var counter = 0;
            localStorage.setItem(counter, urlStorage);
            alert(localStorage.getItem);

            //clear localStorage
            if (localStorage.lengt > 20){
                localStorage.clear();
            }

            //showing reasult
            $.each(localStorage, function (index, link) {
                console.log(index + ": " + link);
            })

            //test that didn't work
            //for (var i = 0; i < 20; i++) {
            //    var counter = i;
            //    localStorage.setItem(counter, urlStorage);
            //    break;
            //}

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
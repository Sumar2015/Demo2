;
var logArray = [];
var urlStorage;
var index = 0;

(function ($) {
    $.fn.extend({
        logPlugin: function () {
            return this.each(function(){
                //this.click(alert(location.href))
                console.log(location.href);
                logArray.push(location.href)
            
            });
        }
    });
    //$.fn.logActivity = function () {
    //    $(this).click(urlStorage = location.href);
    //    logArray.push(urlStorage);
        
    //};
}(jQuery));
//$("a").logActivity();
$("a").logPlugin();

//console.log(urlStorage);
//logArray.push(urlStorage);
console.log(logArray);

$.each(logArray, function (index, href) {
    console.log(index + ": " + href);
})

;
var logArray = [];
var urlStorage;
var index = 0;
var test;
var type1;
var button;

(function ($) {
    $.fn.extend({
        logPlugin: function () {

            //onClickHref function that gets information about link clicked on
            (function onClickHref(element) {
                $(this).click(urlStorage = location.href, type1 = this.target);
                test = Date();
                console.log("url: " + urlStorage + "\n"
                    + "time: " + test + "\n"
                    + "type: " + type1 + "\n");
            })()
        }
    }); 
}(jQuery));

$("*").logPlugin();
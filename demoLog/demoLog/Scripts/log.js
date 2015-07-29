;
var logArray = [];
var urlStorage;
var index = 0;
var test;
var type1;

(function ($) {
    $.fn.extend({
        logPlugin: function () {

            //onClickHref function that gets information about link clicked on
            (function onClickHref (event) { 
                $(event).click(urlStorage = location.href);
                test = Date();
                type1 = $(event).type;
                console.log("url: " + urlStorage + "\n"
                    + "time: " + test + "\n"
                    + "type: " + $.event.type);
            })()

            //showing reasult
            //$.each(localStorage, function (index, link) {
            //    console.log(index + ": " + link);
            //})

        }
    });
   
}(jQuery));

$("*").logPlugin();
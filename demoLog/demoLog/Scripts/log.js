;
var logArray = [];
var urlStorage;
var index = 0;
var date;
var tag;
var xCor, yCor;

(function ($) {
    $.fn.logPlugin = function () {

        //onClickHref function that gets information about link clicked on
        (function onClickHref() {
            var event;
            $('a').click(function (event) {
                logArray = {
                    urlStorage : location.href,
                    date : Date(),
                    /*tag : this.event.target.tagName,
                    xCor : this.event.pageX,
                    yCor : this.event.pageY,*/
                }
                console.log(logArray);
            }())
        })()
        //todo:
        //function for button, input including keydown
    
    };
}(jQuery));

$("*").logPlugin();
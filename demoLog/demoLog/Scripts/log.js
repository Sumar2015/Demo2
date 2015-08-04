$(function () {
    $("a").click(function (event) {
        alert("1 "+event);
        var tag = event.target.tagName.toLowerCase();
        var date = Date();
        var xCor = event.pageX;
        var yCor = event.pageY;
        alert("outside main function :(" + "\n" +
            "tag: " + tag + "\n" +
            "date: " + date + "\n" +
            "url: " + url + "\n" +
            "xCor: " + xCor + "\n" +
            "yCor: " + yCor);
    });
});
$("a").click(function () {
    logPugin(event);
});

(function ($) {
    $.fn.logPlugin = function () {
        var logArray = [];
        //inisialize logArray if not inisialized before
        if(localStorage.getItem("logArr") === null){
           logArray = {
                urlStorage: "",
                date: "",
                tag: "",
                xCor: "",
                yCor: ""
            }
        };
        
        //onClickHref function that gets information about link clicked on
        (function onClickHref() {
            $("a").click(function () {
                var tag = this;
                alert("2 "+tag);
                logArray = {
                    urlStorage: location.href,
                    date: Date(),
                    //tag : (event.target.tagName).toLowerCase(),
                    //xCor : (this.event.pageX),
                    //yCor : event.pageY
                }
                console.log(logArray);
            }())
        })()
        //todo:
        //setItem into localStorage
        //function for button, input including keydown
    
    };
}(jQuery));

$("*").logPlugin();
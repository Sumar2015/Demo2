console.log("Testing this log.js")
console.log("And it worked :)")

var logArray = ["test"];
//This is working to write out to console... but not like it should be :(
$(document).ready(function () {
    $("a").click(function(){
        logArray = this.URL;
        (console.log("Testing ActionLink"));
    })
});
console.log(logArray);

//$(document).ready(function () {
//    $("p").click(function () {
//        $(this).fadeOut();
//    });
//});

//Not working at all!
//$(document).ready(function () {
//    var objReWrite = {
//        test: function () {
//            $(console.log("testing actionLink()"));
//        }
//    };
//    $("a").click($.proxy(objReWrite, "test"));
//});
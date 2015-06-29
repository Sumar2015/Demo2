console.log("Testing this log.js")
console.log("And it worked :)")
//This is working to write out to console... but not like it should be :(
$(document).ready(function () {
    $("a").click(console.log("Testing ActionLink"));
});
//Not working at all!
//$(document).ready(function () {
//    var objReWrite = {
//        test: function () {
//            $(console.log("testing actionLink()"));
//        }
//    };
//    $("a").click($.proxy(objReWrite, "test"));
//});
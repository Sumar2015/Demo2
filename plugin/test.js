;
var logArray = [];
var urlStorage;
var index = 0;

(function ($) {
    $.fn.extend({
        logPlugin: function () {

            //getting href
            $(this).click(urlStorage = location.href);

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
   
}(jQuery));

$("a").logPlugin();
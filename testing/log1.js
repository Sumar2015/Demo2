;
$.yourlibrary().setMaxItems(20);

jQuery.fn.logPlugin = function () {
    var logArray = [];
    var currEvent = [];

    //inisialize logArray if not inisialized before
    if (localStorage.getItem("logArr") === null) {
        currEvent = {
            urlStorage: "",
            date: "",
            tag: "",
            id: "",
            name: "",
            class: "",
            event: "",
            xCor: "",
            yCor: ""
            
        }
    };//todo: else condition to get old logArray from LS

    //onClick function getting information when clicking
    $(function onClick() {
        $("a, button, input, textarea, span, select").click(function (event) {
            dataInstall(event);
           console.log(currEvent);
        });
    });

    $(function onKeyPress() {
        $("a, button, input, textarea, span, select").keypress(function (event) {
            if (event.which == 9 || event.keycode == 9) {
                dataInstall(event);
                console.log(currEvent);
            }
        });
    });
    
    //installing data into currArray
    function dataInstall(ev) {
        currEvent = {
            urlStorage: location.href,
            date: Date(),
            tag: event.target.tagName.toLowerCase(),
            id: event.target.id,
            name: event.target.name,
            class: event.target.className,
            event: event.type,
            xCor: event.pageX,
            yCor: event.pageY
        };
        dataArray(currEvent);
    };

    //setting currArray into logArray
    function dataArray(array) {
        var counter = logArray.length;
        logArray[counter] = array;
    };

    //setting logArray into locationStorage
    
};

$("*").logPlugin();
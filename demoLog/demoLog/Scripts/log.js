jQuery.fn.logPlugin = function () {
    var logArray = [];
    var currEvent = [];

    //inisialize logArray if not inisialized before
    if (localStorage.getItem("logArr") == null) {
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
    } else {
        logArray = JSON.parse(localStorage.getItem("logArr"));//not right move here...
        console.log("else condition: " + JSON.stringify(logArray));
    };
    
    //onClick function getting information when clicked with mouse
    $(function onClick() {
        $("a, button, input, textarea, span, select").mousedown(function (event) {
            dataInstall(event);    
        });
    });
    
    //onKeyPress function getting information when pressing the key enter 
    $(function onKeyPress() {
        $("a, button, input, textarea, span, select").keypress(function (event) {
            if (event.which === 13 || event.keycode === 13) {
                dataInstall(event);
            }
        });
    });
    
    //installing data into currEvent
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
        //console.log(currEvent);
    };

    //installing currEvent into logArray and in that process copy logArray
    //into localStorage
    function dataArray(array) {
        if (logArray.length > 3) {
            //logArray[0] = JSON.stringify(array);
            logArray.length = 0;
        } else {
            logArray.push(JSON.stringify(array));
        };
        for (var i = 0; i < logArray.length; i++) {
            console.log("logArray inside dataArray: " + i + " = " + logArray[i]);
        };
        localStorage.setItem("logArr", JSON.stringify(logArray));
        //localStorage.clear();
    };
};

$("*").logPlugin();
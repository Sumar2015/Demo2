jQuery.fn.logPlugin = function () {
    var logArray = [];
    var currArray = [];

    //inisialize logArray if not inisialized before
    if (localStorage.getItem("logArr") === null) {
        currArray = {
            urlStorage: "",
            date: "",
            tag: "",
            id: "",
            name: "",
            class: "",
            xCor: "",
            yCor: ""
            
        }
    };//todo: else condition to get old logArray from LS

    //onClick function getting information when clicking
    $(function onClick () {
        $("a, button, input, textarea, span, select").click(function (event) {
            dataInstall(event);
           console.log(currArray);
        });
    });
    
    //installing data into currArray
    function dataInstall(ev) {
        currArray = {
            urlStorage: "",
            date: Date(),
            tag: event.target.tagName.toLowerCase(),
            id: event.target.id,
            name: event.target.name,
            class: event.target.className,
            xCor: event.pageX,
            yCor: event.pageY
        };
        dataArray(currArray);
    };

    //setting currArray into logArray
    function dataArray(array) {
        var counter = logArray.length;
        logArray[counter] = array;
    };

    //setting logArray into locationStorage
    
};

$("*").logPlugin();
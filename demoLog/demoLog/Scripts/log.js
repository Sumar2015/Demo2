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
            xCor: "",
            yCor: ""
            
        }
    };
    //onClickHref function getting information when clicking link
    $(function onClickHref () {
        $("a").click(function (event) {
           currArray = {
                urlStorage: location.href,
                date: Date(),
                tag: event.target.tagName.toLowerCase(),
                id: event.target.id,
                name: event.target.name,
                xCor: event.pageX,
                yCor: event.pageY
            };
           dataArray(currArray);
           console.log(currArray);
        });
    });
    
    //onClickButton function getting information when clicking a button
    $(function onClickButton() {
        $("button").click(function (event) {
            currArray = {
                urlStorage: "",
                date: Date(),
                tag: event.target.tagName.toLowerCase(),
                id: event.target.id,
                name: event.target.name,
                xCor: event.pageX,
                yCor: event.pageY
            };
            dataArray(currArray);
            console.log(currArray);
        });
    });

    //setting currArray into logArray
    function dataArray(array) {
        var counter = logArray.length;
        logArray[counter] = array;
    };

    //setting logArray into locationStorage
    
};

$("*").logPlugin();
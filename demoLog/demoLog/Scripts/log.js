jQuery.fn.logPlugin = function () {
    var logArray = [];
    //inisialize logArray if not inisialized before
    if (localStorage.getItem("logArr") === null) {
        logArray = {
            urlStorage: "",
            date: "",
            tag: "",
            xCor: "",
            yCor: "",
            id: "",
            name: ""
        }
    };
    //onClickHref function getting information when clicking link
    $(function onClickHref () {
        $("a").click(function (event) {
            logArray = {
                urlStorage: location.href,
                date: Date(),
                tag: event.target.tagName.toLowerCase(),
                xCor: event.pageX,
                yCor: event.pageY
            };
            console.log(logArray);
        });
    });
    //setting logArray into locationStorage

    //onClickButton function getting information when clicking a button
    $(function onClickButton() {
        $("button").click(function (event) {
            logArray = {
                name: event.target.name,
                id: event.target.id,
                date: Date(),
                tag: event.target.tagName.toLowerCase(),
                xCor: event.pageX,
                yCor: event.pageY
            };
            console.log(logArray);
        });
    });
    //setting logArray into locationStorage
    
};

$("*").logPlugin();
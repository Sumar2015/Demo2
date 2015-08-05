jQuery.fn.logPlugin = function () {
    var logArray = [];
    var currArray = [];
    //inisialize logArray if not inisialized before
    if (localStorage.getItem("logArr") === null) {
        currArray = {
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
           currArray = {
                urlStorage: location.href,
                date: Date(),
                tag: event.target.tagName.toLowerCase(),
                xCor: event.pageX,
                yCor: event.pageY
            };
            console.log(currArray);
        });
    });
    //setting currArray into logArray

    //onClickButton function getting information when clicking a button
    $(function onClickButton() {
        $("button").click(function (event) {
            currArray = {
                name: event.target.name,
                id: event.target.id,
                date: Date(),
                tag: event.target.tagName.toLowerCase(),
                xCor: event.pageX,
                yCor: event.pageY
            };
            console.log(currArray);
        });
    });
    //setting logArray into locationStorage
    
};

$("*").logPlugin();
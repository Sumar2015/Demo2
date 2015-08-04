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
    
};

$("*").logPlugin();
;
var arr = [];
var loc;
function log() {
        $(this).click(loc = location.href);
    //console.log("Link: " + urlStorage);
        return (loc);
};
for(var i = 0; i < 5; i++)
{
    arr[i] = log();
}

for (var t = 0; t < 5; t++)
{
    console.log("Link: " + (arr[t]));
}

/*
function multiply(x, y) {
    var samt = x * y;
    return (samt);
}

var arr = [];
var a = 0;
var b = 0;

for (var i = 0; i < 10; i++)
{
    arr[i] = multiply(a, b);
    a++;
    b++;
};

for (var t = 0; t < 10; t++)
{
    console.log(arr[t]);
};
console.log(multiply(2, 2));
console.log(multiply(4, 4));
*/
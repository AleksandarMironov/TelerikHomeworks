function solve(args) {
    var a = +args[0],
        b = +args[1];
    if (a>b){
        var c = a;
        a=b;
        b=c;
    }
    console.log(a + " " + b);


}

solve();
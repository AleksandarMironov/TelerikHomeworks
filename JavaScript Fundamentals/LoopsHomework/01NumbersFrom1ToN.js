function solve(args) {
    var num = +args[0],
        outputString = "";
    for (var i = 1; i<=num; i++){
        outputString += i + " ";
    }
    console.log(outputString);

}

solve();
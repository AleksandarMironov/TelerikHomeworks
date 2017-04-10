function solve(args) {
    var n = +args[0],  // we do not need this!?
        output = args[1]
            .split(' ')
            .map(Number)
            .sort(function (x ,y){
                return x - y;})
            .join(' ');

    console.log(output)
}

solve();
function solve(args) {
    var number = +args[0];

    var b = (number >>> 3).toString(2) + "";
    console.log(b[b.length - 1]);
}

solve();

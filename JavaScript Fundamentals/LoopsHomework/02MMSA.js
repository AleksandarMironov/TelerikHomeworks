function solve(args) {
    var min= Number.POSITIVE_INFINITY,
        max=Number.NEGATIVE_INFINITY,
        sum=0,
        avg=0;
        i=0;
    for (;i<args.length; i++){
        min = Math.min(min, +args[i]);
        max = Math.max(max, +args[i]);
        sum += +args[i];
    }
    console.log("min=" + min.toFixed(2));
    console.log("max=" + max.toFixed(2));
    console.log("sum=" + sum.toFixed(2));
    console.log("avg=" + (sum/args.length).toFixed(2));


}

solve();
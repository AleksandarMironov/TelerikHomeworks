function solve(args) {
    var a = +args[0],
        b = +args[1],
        c = +args[2],
        product = a*b*c;
    if(product===0){
        console.log(0);
    } else if (product <= 0){
        console.log("-");
    }else{
        console.log("+");
    }
}

solve();
function solve(args) {
    var number = +(args[0].toString()[args[0].length-3]);
    if(number==7){
        console.log('true');
    }
    else if (args[0].length<3){
        console.log('false 0');
    }
    else{
        console.log('false ' + number);
    }


}

solve();
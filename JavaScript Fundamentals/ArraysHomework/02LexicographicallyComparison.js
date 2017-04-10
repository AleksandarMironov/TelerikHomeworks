function solve(args) {
    var firstWord = args[0].split("\n")[0];
    var secondWord = args[0].split("\n")[1];

    if(firstWord>secondWord){
        console.log(">");
    }
    else if(firstWord===secondWord){
        console.log("=");
    }
    else if(firstWord<secondWord){
        console.log("<");
    }


}

solve();
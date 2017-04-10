function solve(args) {
    var inputArr = args[0].split("\n"),
        maxSec= 1,
        tempSec = 1,
        i=1;

    for (i; i<+inputArr[0]; i++){
        if(inputArr[i] === inputArr[i+1]){
            tempSec++;
            if(tempSec>maxSec){
                maxSec=tempSec;
            }
        } else {
            tempSec = 1;
        }
    }

    console.log(maxSec);

}

solve();
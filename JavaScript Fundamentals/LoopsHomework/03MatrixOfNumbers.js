function solve(args) {
    var matrixSize = +args[0],
        i=0,
        j= 0,
        output = "";
    for (i=0; i<matrixSize; i++) {
        output ="";
        for (j=i+1; j < matrixSize + i + 1; j++) {
            output += j + " ";
        }
        console.log(output);
    }

}

solve();
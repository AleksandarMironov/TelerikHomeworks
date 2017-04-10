function solve(args) {
    var number = +args[0],
        isPrime = false,
        i = 0,
        j = 0;

    for (i = number; i >= 2; i -= 1) {
        isPrime = true;
        for (j = 2; j <= Math.sqrt(number); j += 1) {
            if (i % j === 0) {
                isPrime = false;
                break;
            }
        }
        if (isPrime === true) {
            return i;
        }
    }
    console.log(-1);

}

solve();
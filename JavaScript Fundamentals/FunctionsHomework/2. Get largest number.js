function GetMax(args) {

    var numbers = args[0].split(' ').map(Number);

    return isBigger(numbers[0], isBigger(numbers[1], numbers[2]));

    function isBigger(a, b) {
        if (a >= b) {
            return a;
        }
        else if (b > a) {
            return b;
        }
    }
}

GetMax ();
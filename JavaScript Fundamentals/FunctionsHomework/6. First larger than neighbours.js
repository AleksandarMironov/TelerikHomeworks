function solve (arr){
    var n = +arr[0],
        mass = arr[1].split(' ').map(Number),
        i=0;

    if(mass.length<3){
        return -1;
    }

    for(i = 1; i < n - 1; i += 1) {
        if (mass[i] > mass[i - 1] && mass[i] > mass[i + 1]) {
            return i;
        }
    }

    return -1;
}

solve();
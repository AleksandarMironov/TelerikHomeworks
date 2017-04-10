function solve (arr){
    var n = +arr[0],
        mass = arr[1].split(' ').map(Number),
        count = 0,
        i=0;

    if(mass.length<3){
        return count;
    }

    for(i = 1; i < n - 1; i += 1) {
        if (mass[i] > mass[i - 1] && mass[i] > mass[i + 1]) {
            count += 1;
        }
    }

    return count;
}

solve();
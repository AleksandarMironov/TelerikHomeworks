function solve (nums){
    var numbers = nums[1].split(' ').map(Number),
        x = +nums[2],
        position = numbers.indexOf(x),
        appCount = 0,
        i = 0,
        len = numbers.length;

    for(i = 0; i < len; i += 1) {

        if (position >= 0) {
            appCount += 1;
        }
        else{
            return appCount;
        }
        position = numbers.indexOf(x ,position + 1);
    }
}

solve();
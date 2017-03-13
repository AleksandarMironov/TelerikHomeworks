function solve(args) {

    var x = +args[0];
    var y = +args[1];
    var output = "";
    var distance = Math.sqrt((x -1) * (x -1) + (y - 1) * (y - 1));

    if (distance <= 1.5) {
        output = "inside circle";
    }
    else{
        output = "outside circle";
    }

    if ((x >= -1 && x <= 5) && (y <= 1 && y >= -1)) {
        output += " inside rectangle";
    }
    else {
        output += " outside rectangle";
    }

    console.log(output);
}

solve();

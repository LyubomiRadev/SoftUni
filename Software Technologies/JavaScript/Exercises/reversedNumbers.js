function reverse(input) {
    var numbers = [];

    for(let i =0;i<input.length;i++){
        numbers.unshift(input[i]);
    }

    console.log(numbers.join("\n"));
}

reverse(['2','3','5','7', '9']);
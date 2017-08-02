function setValues(input) {
    let size = Number(input.shift());
    let result = new Array(size+1).join('0').split('');

    for (let i = 0; i < input.length; i++) {
        let str = input[i];
        let indexValue = str.split(" - ").map(Number);
        let index =indexValue[0];
        let value = indexValue[1];

        if(index >= 0){
            result[index] = value;
        }

    }

    result.forEach(function (el) {
        console.log(el);
    });
}

setValues([
    '5',
    '0 - 5',
    '3 - 6',
    '4 - 7'
])


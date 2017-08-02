function calculate(input){
    let numbers = input.map(Number);
    let num1 = numbers[0];
    let num2 = numbers[1];
    let result = 0;
    if(num1>num2){
        result = num1/num2;
    }
    else{
        result = num1*num2;
    }

    console.log(result);
}


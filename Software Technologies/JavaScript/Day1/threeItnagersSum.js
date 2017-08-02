function sum(input){
    let str = input[0];
    let numbersArr = str.split(" ").map(Number);
    let numOne= numbersArr[0];
    let numTwo= numbersArr[1];
    let numThree= numbersArr[2];

    /**console.log(numOne +" "+numTwo +" "+ numThree);*/

    if(numOne+numTwo === numThree){
        console.log(Math.min(numOne, numTwo) + " + " + Math.max(numOne, numTwo) + " = " + numThree);
    }
    else if(numOne+numThree === numTwo){
        console.log(Math.min(numOne, numThree) + " + " + Math.max(numOne, numThree) + " = " + numTwo);
    }
    else if(numTwo+numThree === numOne){
        console.log(Math.min(numTwo, numThree) + " + " + Math.max(numTwo, numThree) + " = " + numOne);
    }
    else{
        console.log("No");
    }
}

sum(1,2,3);
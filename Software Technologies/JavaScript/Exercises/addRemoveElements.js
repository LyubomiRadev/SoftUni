function manipulateArray(input) {
    let arr=[];
    for(let i = 0; i< input.length;i++){
        let str = input[i];
        let actionIndex = str.split(" ");
        let action = actionIndex[0];
        let indexNumber = Number(actionIndex[1]);
        if(action.toLowerCase() == "add"){
            arr.push(indexNumber);
        }
        else if(action.toLowerCase() == "remove"){
            arr.splice(indexNumber,1);
        }
    }

    console.log(arr.join("\n"));
}

manipulateArray([
    'add 3',
    'add 5',
    'remove 2',
    'remove 0',
    'add 7'
])
function outcome(input){
    if(input.includes('0')){
        console.log("Positive");
    }
    else{
        let numbers = input.map(Number);
        // let n1 = input[0];
        // let n2 = input[1];
        // let n3 = input[2];
        let count = 0;
        for (let i =0;i<numbers.length;i++){
            if(numbers[i]<0){
                count++;
            }
        }

        if(count%2==0){
            console.log("Positive");
        }
        else{
            console.log("Negative");
        }
    }

}

outcome(['2', '-3', '0']);
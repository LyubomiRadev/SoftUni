function KVP(input){
    function parsKeyValuePairs(str) {
        let tokens = str.split(' ');
        let result = {
            key : tokens[0],
            value : tokens[1]
        };

        return result;
    }

    let searchKey = input.slice(-1)[0];
    let keysAndValues = input.slice(0,-1).map(parsKeyValuePairs);

    let dict= {};

    keysAndValues.forEach(element =>{
        if(!dict[element.key]){
            dict[element.key] = "";
        }
        dict[element.key] = element.value;
    })

    if(dict[searchKey]){
        console.log(dict[searchKey]);
    }
    else{
        console.log("None");
    }
}

KVP([
    'key value',
    'key eulav',
    'test tset',
    'key'
]);
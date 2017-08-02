function townsPopulation(input) {
    let townPopulation = {};
    for(let json of input){
        let townStats = JSON.parse(json);

        if(!(townStats.town in townPopulation)){
            townsPopulation[townStats.town] = 0;
        }
        townsPopulation[townStats.town] = townStats.income;
    }

    for (let sortedTown of Object.keys(townsPopulation).sort((town1, town2) => town1.localeCompare(town2))){
     console.log(`${sortedTown} -> ${townPopulation[sortedTown]}`);
    }

}
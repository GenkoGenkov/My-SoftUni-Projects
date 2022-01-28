function solve(input) {
    let towns = {};

    for (const info of input) {
        let [town, populationText] = info.split(' <-> ');
        let population = Number(populationText);

        if (!towns[town]) {
            towns[town] = 0;
        }

        towns[town] += population;
    }

    for (const town in towns) {
        console.log(`${town} : ${towns[town]}`)
    }
}
function solve(area, vol, input) {

    let coordinates = JSON.parse(input);
    let result = [];

    for (const points of coordinates) {

        result.push({

            area: area.call(points),
            volume: vol.call(points),
        });       
    }

    return result;
}
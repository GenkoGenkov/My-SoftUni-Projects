function townsToJSON(array) {
    
    const towns = [];

    for(let j = 1; j < array.length; j++) {

        let arr = array[j].split('|').filter(n => n);

        towns.push({ Town: arr[0].trim(),
                     Latitude: Math.round((Number(arr[1]) + Number.EPSILON) * 100) / 100,
                     Longitude: Math.round((Number(arr[2]) + Number.EPSILON) * 100) / 100 });
    }

    return JSON.stringify(towns);    
}
function solve(array) {

    let biggestNumber = 0;
    let result = [];

    for (let i = 0; i < array.length; i++) {
        
        if (array[i] >= biggestNumber) {
            
            biggestNumber = array[i];
            result.push(array[i]);
        }
    }

    return result;
}
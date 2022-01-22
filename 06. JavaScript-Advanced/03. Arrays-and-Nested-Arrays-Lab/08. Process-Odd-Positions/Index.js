function solve(array) {

    let result = [];

    for (let i = 0; i < array.length; i++) {
        
        if(i % 2 !== 0) {

            result.push(array[i]);
        }
    }

    let newResult = [];

    for (let j = 0; j < result.length; j++) {
        
        newResult.push(result[j] * 2);
    }

    return newResult.reverse();
}
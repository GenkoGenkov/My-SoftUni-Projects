function solve(array, step) {

    let resultArr = [];

    for (let i = 0; i < array.length; i += step) {
        resultArr.push(array[i]);       
    }

    return resultArr;

}
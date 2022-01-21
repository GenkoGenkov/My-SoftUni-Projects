function solve(array) {

    let result = [];

    array = array.sort((a, b) => a - b);
    result = array.slice(array.length / 2 );

    return result;
}
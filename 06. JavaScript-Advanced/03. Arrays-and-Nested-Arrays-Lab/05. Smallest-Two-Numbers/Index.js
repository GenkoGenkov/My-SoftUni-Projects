function solve(array) {

    let result = [];

    array = array.sort((a, b) => a - b);
    result = array.slice(0, 2);

    console.log(result.join(' '));
}
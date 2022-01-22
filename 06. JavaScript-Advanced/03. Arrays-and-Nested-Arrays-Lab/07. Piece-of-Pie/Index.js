function solve(array, start, end) {

    let result = [];

    let beginning = array.indexOf(start);
    let ending = array.indexOf(end);

    result = array.slice(beginning, ending + 1);

    return result;
}
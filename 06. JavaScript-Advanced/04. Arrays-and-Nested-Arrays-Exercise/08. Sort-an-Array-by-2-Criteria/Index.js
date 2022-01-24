function solve(array) {

    let result = array.sort((a, b) => a.length - b.length || a.localeCompare(b));

    console.log(result.join('\n'));
}
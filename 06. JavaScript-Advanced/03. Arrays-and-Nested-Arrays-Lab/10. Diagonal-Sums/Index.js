function solve(input) {

    let matrix = [];

    while (input.length > 0) {
        matrix.push(input.shift());
    }

    let primaryDiagonal = 0;
    let secondaryDiagonal = 0;

    for (let i = 0; i < matrix.length; i++) {

        primaryDiagonal += matrix[i][i];
        secondaryDiagonal += matrix[i][matrix.length - 1 - i];
    }

    console.log(primaryDiagonal, secondaryDiagonal);
}
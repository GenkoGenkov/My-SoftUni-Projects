function equalNeighbours(matrix) {

    let pairsCount = 0;

    for(let i = 0; i < matrix.length; i++) {

        for(let j = 0; j < matrix[i].length; j++) {

            if (i === matrix.length - 1) {

                if (matrix[i][j] === matrix[i][j + 1]) {
                    pairsCount++;
                }
            } else {

                if (matrix[i][j] === matrix[i + 1][j]) {
                    pairsCount++;
                }

                if (matrix[i][j] === matrix[i][j + 1]) {
                    pairsCount++;
                }
            }
        }
    }

    return pairsCount;
}
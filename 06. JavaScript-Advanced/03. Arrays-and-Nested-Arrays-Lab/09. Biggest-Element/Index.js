function biggestElement(matrix) {

    let biggestEl = matrix[0][0];

    for(let row of matrix) {

        if(Math.max(...row) > biggestEl) {
            
            biggestEl = Math.max(...row);
        }
    }

    return biggestEl;
}
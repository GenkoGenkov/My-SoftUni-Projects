function solve(n, k) {

    const sequence = [1];

    for(let i = 1; i < n; i++) {

        let tempArray = sequence.slice(-k);
        let sum = 0;

        for(let num of tempArray) {
            sum += num;
        }

        sequence.push(sum);
    }

    return sequence;
}
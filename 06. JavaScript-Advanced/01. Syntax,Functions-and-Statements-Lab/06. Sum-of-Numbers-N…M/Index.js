function solve(n, m){

    let result = 0;

    let num1 = Number(n);
    let num2 = Number(m);

    for (let index = num1; index <= num2; index++) {
        result += index;
    }

    console.log(result);
}
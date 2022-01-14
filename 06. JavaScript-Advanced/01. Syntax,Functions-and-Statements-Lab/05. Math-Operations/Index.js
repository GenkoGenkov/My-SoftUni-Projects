function solve(numOne, numTwo, operator) {
    let result;

    switch (operator) {
        case '+':
            result = numOne + numTwo;
            break;
        case '-':
            result = numOne - numTwo;
            break;
        case '/':
            result = numOne / numTwo;
            break;
        case '*':
            result = numOne * numTwo;
            break;
        case '%':
            result = numOne % numTwo;
            break;
        case '**':
            result = numOne ** numTwo;
            break;
        default:
            break;
    }

    console.log(result);
}

function solve(numOne, numTwo, numThree) {
    let result;

    if (numOne > numTwo && numOne > numThree) {
        result = numOne;
        
    } else if (numTwo > numOne && numTwo > numThree){
        result = numTwo
    } else if (numThree > numOne && numThree > numTwo) {
        result = numThree
    }

    console.log( `The largest number is ${result}.`);
}
function demo(input) {

    let inputNumber = input.toString();
    let isSame = true;
    let sumOfDigits = 0;
    let digitToCompare = inputNumber[0];
    const numberL = inputNumber.length;

    for (let index = 0; index < numberL; index++) {
        
        sumOfDigits += Number(inputNumber[index]);

        if (Number(inputNumber[index]) != digitToCompare) {
            
            isSame = false;
        }
    }

    console.log(isSame);
    console.log(sumOfDigits);

}
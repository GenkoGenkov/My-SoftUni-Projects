function solve(arr){

    var sum = arr.reduce(function(a, b){
        return a + b;
    }, 0);

    let concatNumbers = arr.join('');

    let sumReverse = 0.0;
    for (let i = 0; i < arr.length; i++) {
        sumReverse += 1/arr[i];
    }

    console.log(sum);
    console.log(sumReverse);
    console.log(concatNumbers);
    
}
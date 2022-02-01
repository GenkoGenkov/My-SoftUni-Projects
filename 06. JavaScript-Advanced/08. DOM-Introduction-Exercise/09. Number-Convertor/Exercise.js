function solve() {

    let binaryOption = document.createElement('option');
    binaryOption.value = 'binary';
    binaryOption.textContent = 'Binary';

    let hexadecimalOption = document.createElement('option');
    hexadecimalOption.value = 'hexadecimal';
    hexadecimalOption.textContent = 'Hexadecimal';

    document.getElementById('selectMenuTo').appendChild(binaryOption);
    document.getElementById('selectMenuTo').appendChild(hexadecimalOption);

    function convert() {

        let numberToConvert = document.getElementById('input').value;
        let selectOption = document.getElementById('selectMenuTo').value;
        let result = '';
    
        switch(selectOption) {
            case 'binary':
                result = Number(numberToConvert).toString(2);
                break;
            case 'hexadecimal':
                result = Number(numberToConvert).toString(16).toUpperCase();
                break;
        }
    
        document.getElementById('result').value = result;
    
    }

    let btn = document.querySelector('button');
    btn.onclick = convert;
}
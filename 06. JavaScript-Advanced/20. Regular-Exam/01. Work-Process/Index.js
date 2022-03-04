function solve() {
 
    const [fName, lName, email, birth, position, salary] = Array.from(document.querySelectorAll('form input'));
    const saveTableBody = document.querySelector('#tbody');
    const addButton = document.querySelector('form button');
    const totalSumEl = document.querySelector('#sum');
    let sum = 0;
 
    addButton.addEventListener('click', toAdd);
    //==========toAdd function==========
    function toAdd(ev) {
        ev.preventDefault();
        if ([fName, lName, email, birth, position, salary].every(el => el.value)) {
 
            let mainTr = createAnElement('tr', '', '', '');
            const fNameEl = createAnElement('td', `${fName.value}`, '', mainTr);
            const lNameEl = createAnElement('td', `${lName.value}`, '', mainTr);
            const emailEl = createAnElement('td', `${email.value}`, '', mainTr);
            const birthEl = createAnElement('td', `${birth.value}`, '', mainTr);
            const positionEl = createAnElement('td', `${position.value}`, '', mainTr);
            const salaryEl = createAnElement('td', `${salary.value}`, '', mainTr);
            //Buttons=======================
            const buttonTd = createAnElement('td', '', '', '');
 
            const firedBtn = createAnElement('button', 'Fired', 'fired', buttonTd);
            firedBtn.addEventListener('click', toFire);
 
            const editBtn = createAnElement('button', 'Edit', 'edit', buttonTd);
            editBtn.addEventListener('click', toEdit);
            //==============================
            mainTr.appendChild(buttonTd);
            saveTableBody.appendChild(mainTr);
 
            sum += Number(salary.value);
            totalSumEl.textContent = Number(sum).toFixed(2);
 
            [fName, lName, email, birth, position, salary].map(el => el.value = "");
        }
    }
    //==========toEdit function==========
    function toEdit(ev) {
        let currSalary = ev.target.parentElement.parentElement.querySelector(':nth-child(6n)').textContent;
 
        let currentTd = ev.target.parentElement.parentElement;
 
        currentTd.removeChild(ev.target.parentElement);
        let arr = Array.from(currentTd.querySelectorAll('td'));
 
        [fName, lName, email, birth, position, salary].forEach((el1, index1) => {
            arr.forEach((el2, index2) => {
                if (index1 === index2) {
                    el1.value = el2.textContent;
                };
            });
        });
 
        sum -= Number(currSalary)
        totalSumEl.textContent = Number(sum).toFixed(2);
        currentTd.remove();
    }
    //==========toFire function==========
    function toFire(ev) {
 
        let currSalary = ev.target.parentElement.parentElement.querySelector(':nth-child(6n)').textContent;
        ev.target.parentElement.parentElement.remove();
        sum -= Number(currSalary);
        totalSumEl.textContent = Number(sum).toFixed(2);
    }
 
    function createAnElement(type, content, attribute, appender) {
        const el = document.createElement(type);
        if (attribute) {
            el.setAttribute('class', attribute);
            el.textContent = content;
        } else if (content) {
            el.textContent = content;
        }
        if (appender) {
            appender.appendChild(el);
        }
        return el;
    }
}
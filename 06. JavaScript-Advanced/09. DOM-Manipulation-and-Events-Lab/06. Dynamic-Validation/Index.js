function validate() {

    let emailElement = document.getElementById('email');
    emailElement.addEventListener('change', error);

    function error(ev) {

        if(!(/[a-z]@[a-z].[a-z]/.test(emailElement.value))) {
            ev.target.classList.add('error');
        } else {
            ev.target.classList.remove('error');
        }
    }
}
import { logout } from './api/api.js';
import { page, render } from './lib.js';
import { getUserData } from './util.js';
import { homePage } from './views/home.js';
import { catalogPage } from './views/catalog.js';
import { loginPage } from './views/login.js';
import { registerPage } from './views/register.js';
import { createPage } from './views/create.js';
import { detailsPage } from './views/details.js';
import { editPage } from './views/edit.js';


const root = document.getElementById('content');
document.getElementById('logoutBtn').addEventListener('click', onLogout);



page(decorateContext);

page('/', homePage);
page('/pets', catalogPage);
page('/login', loginPage);
page('/register', registerPage);
page('/create', createPage);
page('/details/:id', detailsPage);
page('/edit/:id', editPage);
// page('/profile', profilePage);


//updateUserNav();
page.start();

function decorateContext(ctx, next) {

    ctx.render = (content) => render(content, root);
    ctx.updateUserNav = updateUserNav;

    next();
}

function onLogout() {

    logout();
    //updateUserNav();
    page.redirect('/');
}

function updateUserNav() {

    const userData = getUserData();

    if (userData) {

        document.getElementById('userOne').style.display = 'block';
        document.getElementById('userTwo').style.display = 'block';
        document.getElementById('guestOne').style.display = 'none';
        document.getElementById('guestTwo').style.display = 'none';


    } else {

        document.getElementById('userOne').style.display = 'none';
        document.getElementById('userTwo').style.display = 'none';
        document.getElementById('guestOne').style.display = 'block';
        document.getElementById('guestTwo').style.display = 'block';
    }
}
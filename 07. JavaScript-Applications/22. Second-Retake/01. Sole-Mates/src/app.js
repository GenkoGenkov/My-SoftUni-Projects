import { render } from '../node_modules/lit-html/lit-html.js';
import page from '../node_modules/page/page.mjs';
import { getUserData } from './util.js';
import {logout} from './api/data.js';

import { dashboardPage } from './views/dashboard.js';
import { homePage } from './views/home.js';
import { loginPage } from './views/login.js';
import { registerPage } from './views/register.js';
import { createPage } from './views/create.js';
import { detailsPage } from './views/details.js';
import { editPage } from './views/edit.js';
import { searchPage } from './views/search.js';

page(decoreateContext);

page('/', homePage);
page('/dashboard', dashboardPage)
page('/login', loginPage)
page('/register', registerPage)
page('/logout', onLogout);
page('/create', createPage);
page('/details/:id', detailsPage);
page('/edit/:id', editPage);
page("/search", searchPage)


updateNav();
page.start();

const root = document.getElementById('home');

function decoreateContext(ctx, next) {
    ctx.render = (content) => render(content, root);
    ctx.updateNav = updateNav;
    next();
}

function updateNav() {
    const userId = getUserData();
    if (userId != null) {
      document.querySelector(".user").style.display = "inline-block";
      document.querySelector(".guest").style.display = "none";
    } else {
      document.querySelector(".user").style.display = "none";
      document.querySelector(".guest").style.display = "inline-block";
    }
  }

function onLogout(ctx) {

    logout();
    updateNav();
    ctx.page.redirect('/dashboard');
}
import decorateContent, { updateUserNav } from './middlewears/decorateContext.js';
import { page } from './lib.js';

import { homePage } from './views/home.js';
import { loginPage } from './views/login.js';
import { registerPage } from './views/register.js';
import { createPage } from './views/create.js';
import { detailsPage } from './views/details.js';
import { editPage } from './views/edit.js';
import { myPostPage } from './views/my-posts.js';




page(decorateContent);

page('/', homePage);
page('/login', loginPage);
page('/register', registerPage);
page('/create', createPage);
page('/details/:id', detailsPage);
page('/edit/:id', editPage);
page('/my-posts', myPostPage);

updateUserNav();
page.start();


import { register } from '../api/data.js';
import { html } from '../../node_modules/lit-html/lit-html.js';

const registerTemplate = (onSubmit) => html`
<section id="register">
  <div class="form">
    <h2>Register</h2>
    <form @submit=${onSubmit} class="login-form">
      <input type="text" name="email" id="register-email" placeholder="email" />
      <input type="password" name="password" id="register-password" placeholder="password" />
      <input type="password" name="re-password" id="repeat-password" placeholder="repeat password" />
      <button type="submit">login</button>
      <p class="message">Already registered? <a href="/login">Login</a></p>
    </form>
  </div>
</section>`;

export async function registerPage(ctx) {


  ctx.render(registerTemplate(onSubmit));

  async function onSubmit(event) {

    event.preventDefault();

    const formData = new FormData(event.target);

    const email = formData.get('email').trim();
    const password = formData.get('password').trim();
    const repeatPassword = formData.get('re-password').trim();

    if (email == '' || password == '' || repeatPassword == '') {
      return alert('Please fill all fields!');
    }

    if (password != repeatPassword) {

      return alert('Passwords don\'t match!');
    }

    await register(email, password);
    ctx.updateNav();
    ctx.page.redirect('/dashboard');
  }
}



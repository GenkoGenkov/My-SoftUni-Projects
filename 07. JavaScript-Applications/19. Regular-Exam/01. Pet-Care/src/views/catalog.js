import { html } from '../lib.js';
import { getAllPets } from '../api/data.js';

const catalogTemplate = (pets) => html`
    <section id="dashboard">
        <h2 class="dashboard-title">Services for every animal</h2>
        <div class="animals-dashboard">
    
            ${pets.length ? pets.map(petView) : html`<p class="no-pets">No pets in dashboard</p>`}
    
        </div>
    </section>`;

const petView = (pet) => html`
<div class="animals-board">
    <article class="service-img">
        <img class="animal-image-cover" src=${pet.image}>
    </article>
    <h2 class="name">${pet.name}</h2>
    <h3 class="breed">${pet.breed}</h3>
    <div class="action">
        <a class="btn" href="${'/details/${pet._id}'}">Details</a>
    </div>
</div>`;

export async function catalogPage(ctx) {

    const pets = await getAllPets();

    ctx.render(catalogTemplate(pets));

}
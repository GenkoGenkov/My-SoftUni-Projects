import { html } from '../lib.js';
import { getPetById, deleteById } from '../api/data.js';

const detailsTemplate = (pet, isOwner, onDelete) => html`
<section id="detailsPage">
<div class="details">
    <div class="animalPic">
        <img src="./images/Shiba-Inu.png">
    </div>
    <div>
        <div class="animalInfo">
            <h1>Name: ${pet.name}</h1>
            <h3>Breed: ${pet.breed}</h3>
            <h4>Age: ${pet.age}</h4>
            <h4>Weight: ${pet.weight}</h4>
            <h4 class="donation">Donation: 0$</h4>
        </div>
        ${isOwner
                 ? html`<div class="actionBtn">
            <!-- Only for registered user and creator of the pets-->
            <a href="/edit/${pet._id}" class="edit">Edit</a>
            <a @click=${onDelete} href="/" class="remove">Delete</a>
            <!--(Bonus Part) Only for no creator and user-->
            <a href="#" class="donate">Donate</a>
        </div>`: null}

    </div>
</div>
</section>`;

export async function detailsPage(context) {
    const userId = sessionStorage.getItem('userId');
    const pet = await getPetById(context.params.id);
    const isOwner = userId && userId == pet._ownerId;
    
    context.render(detailsTemplate(pet, isOwner, onDelete));

    async function onDelete() {
        const confirmed = confirm('Are you sure you want to delete this pet?');
        if (confirmed) {

            await deleteById(pet._id);
            context.page.redirect('/');
        }
    }
}
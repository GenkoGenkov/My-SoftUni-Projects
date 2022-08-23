import { html } from '../../node_modules/lit-html/lit-html.js';
import { getShoeById, deleteShoe } from '../api/data.js';
import { getUserData } from '../util.js';


const detailsTemplate = (shoe, isOwner, onDel) => html`
<section id="details">
          <div id="details-wrapper">
            <p id="details-title">Shoe Details</p>
            <div id="img-wrapper">
              <img src="${shoe.imageUrl}" alt="example1" />
            </div>
            <div id="info-wrapper">
              <p>Brand: <span id="details-brand">${shoe.brand}</span></p>
              <p>
                Model: <span id="details-model">${shoe.model}</span>
              </p>
              <p>Release date: <span id="details-release">${shoe.release}</span></p>
              <p>Designer: <span id="details-designer">${shoe.designer}</span></p>
              <p>Value: <span id="details-value">${shoe.value}</span></p>
            </div>

            ${detailsControlsTemplate(shoe, isOwner, onDel)}
            
          </div>
        </section>
`;

const detailsControlsTemplate = (shoe, isOwner, onDel) => {

    if (isOwner) {
        return html`
        <div id="action-buttons">
              <a href="/edit/${shoe._id}" id="edit-btn">Edit</a>
              <a @click=${onDel} href="javascript:void(0)" id="delete-btn">Delete</a>
            </div>`;
    } else {
        return null;
    }
}

export async function detailsPage(ctx) {

    const shoe = await getShoeById(ctx.params.id);

    const userData = getUserData();
    const isOwner = userData && userData.id == shoe._ownerId;

    ctx.render(detailsTemplate(shoe, isOwner, onDel));

    async function onDel() {

        const confirmed = confirm("Are you sure you want to delete this?");

        if (confirmed) {
            await deleteShoe(shoe._id);
            ctx.page.redirect("/dashboard");
        }
    }
}

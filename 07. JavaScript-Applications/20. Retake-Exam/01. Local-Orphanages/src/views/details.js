import { deletePostById, getPostById } from '../api/data.js';
import { html } from '../lib.js';
import { getUserData } from '../util.js';

const detailsTemplate = (post, isOwner, onDelete) => html`
        <section id="details-page">
            <h1 class="title">${post.title}</h1>

            <div id="container">
                <div id="details">
                    <div class="image-wrapper">
                        <img src=${post.imageUrl} alt="Material Image" class="post-image">
                    </div>
                    <div class="info">
                        <h2 class="title post-title">Clothes</h2>
                        <p class="post-description">Description: ${post.description}</p>
                        <p class="post-address">Address: ${post.address}</p>
                        <p class="post-number">Phone number: ${post.phone}</p>
                        <p class="donate-Item">Donate Materials: 0</p>

                        <!--Edit and Delete are only for creator-->
                        <div class="btns">
                        ${postControlsTemplate(post, isOwner, onDelete)}
                        </div>

                    </div>
                </div>
            </div>
        </section>
`;

const postControlsTemplate = (post, isOwner, onDelete) => {

    if (isOwner) {

        return html`
                        <div class="btns">
                            <a href="/edit/${post._id}" class="edit-btn btn">Edit</a>
                            <a @click=${onDelete} href="javascript:void(0)" class="delete-btn btn">Delete</a>

                            <!--Bonus - Only for logged-in users ( not authors )-->
                            <a href="#" class="donate-btn btn">Donate</a>
                        </div>
        `;
    } else {
        return null;
    }
};

export async function detailsPage(ctx) {

    const post = await getPostById(ctx.params.id);

    const userData = getUserData();
    const isOwner = userData && userData.id == post._ownerId;

    ctx.render(detailsTemplate(post, isOwner, onDelete));

    async function onDelete() {

        const choice = confirm(`Are you sure you want to delete ${post.title}`);

        if (choice) {
            
            await deletePostById(ctx.params.id);
            ctx.page.redirect('/');
        }
    }
}

import { html, nothing } from '../../node_modules/lit-html/lit-html.js';
import * as gameService from '../api/data.js';
import { getUserData } from '../util.js';
import { commentFormView } from './commentForm.js';
import { commentsView } from './comments.js';

const detailsTemplate = (game, isOwner, commentsSection, commentFormSection, onDelete) => html`
<section id="game-details">
    <h1>Game Details</h1>
    <div class="info-section">
        <div class="game-header">
            <img class="game-img" src=${game.imageUrl} />
            <h1>${game.title}</h1>
            <span class="levels">MaxLevel: ${game.maxLevel}</span>
            <p class="type">${game.category}</p>
        </div>
        <p class="text">${game.summary}</p>

        ${commentsSection}
        
        ${gameControlsTemplate(game, isOwner, onDelete)}

    </div>

    ${commentFormSection}

</section>`

const gameControlsTemplate = (game, isOwner, onDelete) => {

    if (isOwner) {
        return html`
        <div class="buttons">
            <a href="/edit/${game._id}" class="button">Edit</a>
            <a @click=${onDelete} href="javascript:void(0)" class="button">Delete</a>
        </div>`;
    } else {
        return null;
    }
}

export async function detailsPage(ctx) {

    const game = await gameService.getGameById(ctx.params.id);

    const [gameForComments, commentsSection] = await Promise.all([
        gameService.getGameById(ctx.params.id),
        commentsView(ctx.params.id)
    ]);

    const userData = getUserData();
    const isOwner = userData && userData.id == game._ownerId;

    const commentFormSection = commentFormView(ctx, game.isOwner);

    ctx.render(detailsTemplate(game, isOwner, commentsSection, commentFormSection, onDelete));

    async function onDelete() {
        const choice = confirm(`Are you sure you want to delete?`);

        if (choice) {
            await gameService.deleteGame(ctx.params.id);
            ctx.page.redirect('/');
        }
    }
}
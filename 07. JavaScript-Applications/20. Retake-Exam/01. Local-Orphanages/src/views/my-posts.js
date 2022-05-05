import { getMyPosts } from '../api/data.js';
import {html} from '../lib.js';
import { getUserData } from '../util.js';

const myPostsTemplate = (posts) => html`
        <section id="my-posts-page">
            <h1 class="title">My Posts</h1>

            <!-- Display a div with information about every post (if any)-->
            ${posts.length == 0
                ? html`<h1 class="title no-posts-title">You have no posts yet!</h1>`
                : posts.map(postPreview)
            }

            <!-- Display an h1 if there are no posts -->
            
        </section>
`;

const postPreview = (post) => html`
                <div class="post">
                    <h2 class="post-title">${post.title}</h2>
                    <img class="post-image" src=${post.imageUrl} alt="Material Image">
                    <div class="btn-wrapper">
                        <a href="/details/${post._id}" class="details-btn btn">Details</a>
                    </div>
                </div>
`;

export async function myPostPage(ctx) {

    const userData = getUserData();
    const posts = await getMyPosts(userData.id);
    ctx.render(myPostsTemplate(posts));
}
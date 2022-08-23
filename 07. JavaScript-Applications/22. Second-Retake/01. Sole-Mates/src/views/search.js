import { html } from "../../node_modules/lit-html/lit-html.js";
import { search } from "../api/data.js";

const searchTemplate = (shoe, onSearch, year) => html`
<section id="search">
    <h2>Search by Brand</h2>

    <form class="search-wrapper cf">
        <input id="#search-input" type="text" name="search" placeholder="Search here..." required />
        <button type="submit">Search</button>
    </form>

    <h3>Results:</h3>

    <div id="search-container">
        <ul class="card-wrapper">
            <!-- Display a li with information about every post (if any)-->
            <li class="card">
                <img src="./images/travis.jpg" alt="travis" />
                <p>
                    <strong>Brand: </strong><span class="brand">Air Jordan</span>
                </p>
                <p>
                    <strong>Model: </strong><span class="model">1 Retro High TRAVIS SCOTT</span>
                </p>
                <p><strong>Value:</strong><span class="value">2000</span>$</p>
                <a class="details-btn" href="">Details</a>
            </li>
        </ul>

        <!-- Display an h2 if there are no posts -->
        <!-- <h2>There are no results found.</h2> -->
    </div>
</section>
`;

// const carTemplate = (car) => html`
// <div class="listing">
//     <div class="preview">
//         <img src=${car.imageUrl} />
//     </div>
//     <h2>${car.brand} ${car.model}</h2>
//     <div class="info">
//         <div class="data-info">
//             <h3>Year: ${car.year}</h3>
//             <h3>Price: ${car.price} $</h3>
//         </div>
//         <div class="data-buttons">
//             <a href="/details/${car._id}" class="button-carDetails">Details</a>
//         </div>
//     </div>
// </div>
// `;

export async function searchPage(ctx) {
    const brand = Number(ctx.querystring.split("=")[1])
    const shoes = Number.isNaN(brand) ? [] : await search(brand)
    ctx.render(searchTemplate(shoes, onSearch, brand));

    function onSearch() {
        const query = Number(document.getElementById("search").value)
        ctx.page.redirect("/search?query=" + query)
    }
}

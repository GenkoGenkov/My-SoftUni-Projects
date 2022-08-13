import * as api from './api.js';

export async function getGameById(gameId) {

    return api.get(`/data/comments?where=gameId%3D%22${gameId}%22`)
}

export async function postComment(comment) {

    return api.post('/data/comments', comment);
}
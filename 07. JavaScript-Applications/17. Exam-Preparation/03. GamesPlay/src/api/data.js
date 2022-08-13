import * as api from './api.js';

export const login = api.login;
export const register = api.register;
export const logout = api.logout;

const endpoints = {
    recent: '/data/games?sortBy=_createdOn%20desc&distinct=category',
    games: '/data/games?sortBy=_createdOn%20desc',
    create: '/data/games',
    byId: '/data/games/',
    delete: '/data/games/',
    edit: '/data/games/'
}

export async function getRecent() {

    return api.get(endpoints.recent);
}

export async function getAll() {

    return api.get(endpoints.games);
}

export async function getGameById(id) {

    return await api.get(endpoints.byId + id)
}

export async function create(data) {

    return api.post(endpoints.create, data);
}

export async function editGame(id, game) {

    return api.put(endpoints.edit + id, game);
}

export async function deleteGame(id) {

    return api.del(endpoints.delete + id);
}


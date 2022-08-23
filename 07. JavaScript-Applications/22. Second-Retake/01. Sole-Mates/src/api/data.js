import * as api from './api.js';

const host = "http://localhost:3030";

export const login = api.login;
export const register = api.register;
export const logout = api.logout;

export async function getAllShoes() {

    return api.get('/data/shoes?sortBy=_createdOn%20desc');
}

export async function getShoeById(id) {

    return await api.get('/data/shoes/' + id)
}

export async function createShoe(shoe) {

    return api.post('/data/shoes', shoe);
}

export async function editShoe(id, shoe) {

    return api.put('/data/shoes/' + id, shoe);
}

export async function deleteShoe(id) {

    return api.del('/data/shoes/' + id);
}

export async function search(query) {
    return await api.get(host + `/data/shoes?where=brand%20LIKE%20%22${query}%22`)
  }




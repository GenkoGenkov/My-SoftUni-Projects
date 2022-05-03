import * as api from './api.js';

export const login = api.login;
export const register = api.register;
export const logout = api.logout;

export async function getAllPets() {

    return api.get('/data/pets?sortBy=_createdOn%20desc&distinct=name');
}

export async function getPetById(id) {

    return api.get('/data/pets/' + id);
}

// export async function getMyMemes(userId) {

//     return api.get(`/data/memes?where=_ownerId%3D%22${userId}%22&sortBy=_createdOn%20desc`)
// }

export async function createPet(pet) {

    return api.post('/data/pets', pet);
}

export async function editPet(id, pet) {

    return api.put('/data/pets/' + id, pet);
}

export async function deleteById(id) {

    return api.del('/data/pets/' + id);
}
import { getUserData, setUserData, clearUserData } from '../util.js';

const hostName = 'http://localhost:3030';

async function request(url, options) {

    try {

        const responce = await fetch(hostName + url, options);

        if (responce.ok == false) {

            const error = await responce.json();
            throw new Error(error);
        }

        try {

            return await responce.json();
            
        } catch (error) {
            return responce;
        }
        
    } catch (err) {
        alert(err.message);
        throw err;
    }
}

function createOptiions(method = 'get', data) {

    const options = {
        method,
        headers: {}
    };

    if (data != undefined) {

        options.headers['Content-Type'] = 'application/json';
        options.body = JSON.stringify(data);
    }

    const userData = getUserData();

    if (userData) {
        
        options.headers['X-Authorization'] = userData.token;
    }

    return options;
}

export async function get(url) {

    return request(url, createOptiions());
}

export async function post(url, data) {

    return request(url, createOptiions('post', data));
}

export async function put(url, data) {

    return request(url, createOptiions('put', data));
}

export async function del(url) {

    return request(url, createOptiions('delete'));
}

export async function login(email, password) {

    const result = await post('/users/login', { email, password });

    const userData = {
        
        email: result.email,
        id: result._id,
        
        token: result.accessToken
    };

    setUserData(userData);

    return result;
}

export async function register(email, password) {

    const result = await post('/users/register', { email, password });

    const userData = {
        
        email: result.email,
        id: result._id,
        
        token: result.accessToken
    };

    setUserData(userData);

    return result;
}

export async function logout() {

    await get('/users/logout');
    clearUserData();
}
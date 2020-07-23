import axios from 'axios';

const api = axios.create({
    baseURL: 'https://localhost:44386/api/'
});

export default api;
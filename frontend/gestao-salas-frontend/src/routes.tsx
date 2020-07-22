import { Route, BrowserRouter } from 'react-router-dom';
import React from 'react';

import Home from './pages/Home';
import Sala from './pages/Sala';

const Routes = () => {
    return (
        <BrowserRouter>
        <Route component={Home} path="/" exact />
        <Route component={Sala} path="/sala" />
        </BrowserRouter>
    );
}

export default Routes;
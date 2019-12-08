import App from './Ap';
import { Router } from './routing';
import * as serviceWorker from './serviceWorker';
import * as React from 'react';
import * as ReactDOM from 'react-dom';
import { AppContainer } from 'react-hot-loader';

// Publish dev utils in browser console

const render = () => {
    ReactDOM.render(
        <AppContainer>
            <Router>
                <App />
            </Router>
        </AppContainer>,
        document.getElementById('root'),
    );
};

// If you want your app to work offline and load faster, you can change
// unregister() to register() below. Note this comes with some pitfalls.
// Learn more about service workers: http://bit.ly/CRA-PWA
serviceWorker.unregister();

// Render once
render();

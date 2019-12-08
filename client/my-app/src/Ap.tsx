import Appl from './app';
import { Router } from './routing';
import * as React from 'react';

interface Props {}
interface State {}

export default class App extends React.Component<Props, State> {

    public render() {
        return (
            <Router>
                <Appl />
            </Router>
        );
    }
}

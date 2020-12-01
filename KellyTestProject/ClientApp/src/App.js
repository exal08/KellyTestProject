import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { TopSections } from './components/TopSections';
import { TopUsers } from './components/TopUsers';

import './custom.css'

export default class App extends Component {
    static displayName = App.name;

    render() {
        return (
            <Layout>
                <Route exact path='/' component={Home} />
                <Route exact path='/TopSections' component={TopSections} />
                <Route exact path='/TopUsers' component={TopUsers} />
            </Layout>
        );
    }
}

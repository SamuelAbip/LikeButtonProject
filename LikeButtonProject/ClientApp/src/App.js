import React, { Component } from 'react';
import ArticleHandler from "./components/ArticleHandler/ArticleHandler";
import './custom.css'


export default class App extends Component {
    static displayName = App.name;

    render() {
        return (
            <ArticleHandler />
        );
    }
}

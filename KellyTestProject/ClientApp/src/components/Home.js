import React, { Component } from 'react';

export class Home extends Component {
    static displayName = 'Разделы';

    constructor(props) {
        super(props);
        this.state = { Sections: [], loading: true };
    }

    componentDidMount() {
        this.loadSections();
    }

    static renderSectionsTable(Sections) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Название раздела</th>

                    </tr>
                </thead>
                <tbody>
                    {Sections.map(forecast =>
                        <tr key={forecast.id}>
                            <td>{forecast.id}</td>
                            <td>{forecast.name}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let content = this.state.loading ? <p>Загрузка...</p> : Home.renderSectionsTable(this.state.Sections);
        return (
            <div>
                <h1>Список разделов</h1>
                { content }
            </div>
        );
    }

    async loadSections() {
        const response = await fetch('api/Section');
        const data = await response.json();
        this.setState({ Sections: data, loading: false });
    }
}

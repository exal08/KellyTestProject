import React, { Component } from 'react';

export class TopUsers extends Component {
    static displayName = TopUsers.name;

    constructor(props) {
        super(props);
        this.state = { TopUsers: [], loading: true };
    }

    componentDidMount() {
        this.populateWeatherData();
    }

    static renderForecastsTable(TopUsers) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Фамилия</th>
                        <th>Имя</th>
                        <th>Отчество</th>
                        <th>Топ раздел</th>
                    </tr>
                </thead>
                <tbody>
                    {TopUsers.map(TopUsers =>
                        <tr>
                            <td>{TopUsers.surname}</td>
                            <td>{TopUsers.name}</td>
                            <td>{TopUsers.patronymic}</td>
                            <td>{TopUsers.section}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : TopUsers.renderForecastsTable(this.state.TopUsers);

        return (
            <div>
                <h1 id="tabelLabel" >Топ 10 пользователей</h1>
                {contents}
            </div>
        );
    }

    async populateWeatherData() {
        const response = await fetch('api/GetTpoTenUsers');
        const data = await response.json();
        this.setState({ TopUsers: data, loading: false });
    }
}

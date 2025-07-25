import React from 'react';
import './App.css';

class CountPeople extends React.Component {
  constructor() {
    super();
    this.state = {
      entrycount: 0,
      exitcount: 0
    };
  }

  updateEntry = () => {
    this.setState((prevState) => ({
      entrycount: prevState.entrycount + 1
    }));
  };

  updateExit = () => {
    this.setState((prevState) => ({
      exitcount: prevState.exitcount + 1
    }));
  };

  render() {
    return (
      <div className="App">
        <h2>React App</h2>
        <button onClick={this.updateEntry} style={{ backgroundColor: 'lightgreen', margin: '10px' }}>
          Login
        </button>
        <span style={{ padding: '10px' }}>
          {this.state.entrycount} People Entered!!!
        </span>
        <br />
        <button onClick={this.updateExit} style={{ backgroundColor: 'lightgreen', margin: '10px' }}>
          Exit
        </button>
        <span style={{ padding: '10px' }}>
          {this.state.exitcount} People Left!!!
        </span>
      </div>
    );
  }
}

export default CountPeople;

// src/App.js
import './App.css';
import Home from './Components/Home';
import About from './Components/About';
import Contacts from './Components/Contacts';

function App() {
  return (
    <div className="container">
      <Home />
      <About />
      <Contacts />
    </div>
  );
}

export default App;

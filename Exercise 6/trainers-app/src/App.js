// App.js
import React from 'react';
import { BrowserRouter, Routes, Route, Link } from 'react-router-dom';
import Home from './Home';
import TrainersList from './TrainerList';
import TrainerDetail from './TrainerDetails';
import trainer from './trainer';

const trainerData = [
  new trainer(
    1,
    'Syed(.NET)',
    'syed@cognizant.com',
    '976765162',
    '.NET',
    ['C#', 'SQL Server', 'React', '.NET Core']
  ),
  new trainer(
    2,
    'Jojo ',
    'jojo@cognizant.com',
    '9123456780',
    'Java',
    ['Java', 'Spring Boot', 'Hibernate']
  ),
  new trainer(
    3,
    'Jones',
    'Jones@cognizant.com',
    '9876543210',
    'Frontend',
    ['HTML', 'CSS', 'JavaScript']
  )
];

function App() {
  return (
    <BrowserRouter>
      <div style={{ border: '1px solid black', padding: '20px' }}>
        <h1>My Academy Trainers App</h1>
        <nav>
          <Link to="/">Home</Link> | <Link to="/trainers">Show Trainers</Link>
        </nav>

        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/trainers" element={<TrainersList trainers={trainerData} />} />
          <Route path="/trainers/:id" element={<TrainerDetail trainers={trainerData} />} />
        </Routes>
      </div>
    </BrowserRouter>
  );
}

export default App;

import React, { useState } from 'react';
import './App.css';

// Greeting Components
function UserGreeting() {
  return <h1>Welcome back</h1>;
}

function GuestGreeting() {
  return <h1>Please sign up.</h1>;
}

function Greeting(props) {
  const isLoggedIn = props.isLoggedIn;
  if (isLoggedIn) {
    return <UserGreeting />;
  }
  return <GuestGreeting />;
}

// Buttons
function LoginButton(props) {
  return <button onClick={props.onClick}>Login</button>;
}

function LogoutButton(props) {
  return <button onClick={props.onClick}>Logout</button>;
}

// Main App Component
function App() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  const handleLoginClick = () => {
    setIsLoggedIn(true);
  };

  const handleLogoutClick = () => {
    setIsLoggedIn(false);
  };

  return (
    <div className="App">
      <Greeting isLoggedIn={isLoggedIn} />

      {isLoggedIn ? (
        <LogoutButton onClick={handleLogoutClick} />
      ) : (
        <LoginButton onClick={handleLoginClick} />
      )}

      <hr />
{/* 
      Flight details always visible
      <h2>Flight Details</h2>
      <p>Flight: AI-2025</p>
      <p>From: Mumbai</p>
      <p>To: Delhi</p>
      <p>Date: 15-Aug-2025</p>

      {isLoggedIn && (
        <>
          <h2>Book your Ticket</h2>
          <button>Book Now</button>
        </>
      )} */}
    </div>
  );
}

export default App;

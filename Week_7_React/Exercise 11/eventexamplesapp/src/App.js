import React, { useState } from 'react';
import './App.css';

function App() {
  const [counter, setCounter] = useState(0);
  const [amount, setAmount] = useState('');
  const [euro, setEuro] = useState('');

  const handleIncrement = () => {
    setCounter(counter + 1);
  };


  const handleDecrement = () => {
    setCounter(counter - 1);
  };

  const sayWelcome = () => {
    alert("Welcome");
  };
 
  const clickOnMe = () => {
    alert("I am clicked!");
  };

  const handleSubmit = (e) => {
    e.preventDefault();

    const conversionRate = 90; // 1 Euro = 90 Rupees
    const convertedEuro = amount * conversionRate;

    setEuro(convertedEuro.toFixed(2)); // set euro state

    alert(`Converted Amount in Euro: € ${convertedEuro.toFixed(2)}`);
  };

  return (
    <div style={{ padding: '10px' }}>
      <h2>{counter}</h2>
      <button onClick={handleIncrement}>Increment</button>{' '}
      <button onClick={handleDecrement}>Decrement</button>{' '}
      <button onClick={sayWelcome}>Say welcome</button>{' '}
      <button onClick={clickOnMe}>Click on me</button>

      <h1 style={{ color: 'green' }}>Currency Convertor!!!</h1>

      <form onSubmit={handleSubmit}>
        <div>
          <label>Amount in Rupees: </label>
          
          <input
            type="text"
            value={amount}
            onChange={(e) => setAmount(e.target.value)}
          />
        </div>
        <br />
        <button type="submit">Convert</button>
      </form>
    </div>
  );
}

export default App;

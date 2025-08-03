import React from 'react';
import './App.css';

function App() {
  let colors = [];

  const ItemName = { Name: "Cognizant", Rent: 50000, Address: 'Denver' };

  if (ItemName.Rent <= 60000) {
    colors.push('textRed');
  } else {
    colors.push('textGreen');
  }

  const element = "Office Space";
  const sr = "/cognizant-accelerator-offices-denver-3-1200x800.jpg";
  const jsxatt = <img src={sr} width="25%" height="25%" alt="Office Space" />;

  return (
    <div style={{ padding: '20px' }}>
      <h1>{element} , At Affordable Range </h1>
      {jsxatt}
      <h1>Name: {ItemName.Name}</h1>
      <h3 className={colors.join(' ')}>Rent: $ {ItemName.Rent}</h3>
      <h3>Address: {ItemName.Address}</h3>
    </div>
  );
}

export default App;

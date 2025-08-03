import React from "react";
import ListOfPlayers from "./ListOfPlayers";
import IndianPlayers from "./IndianPlayers";

function App() {
  const flag = false; // Toggle between true and false

  return (
    <div className="App">
      {flag ? <ListOfPlayers /> : <IndianPlayers />}
    </div>
  );
}

export default App;

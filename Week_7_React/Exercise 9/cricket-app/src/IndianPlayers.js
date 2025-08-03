import React from "react";

const IndianPlayers = () => {
  const T20Players = ["Sachin1", "Dhoni2", "Virat3"];
  const RanjiPlayers = ["Rohit4", "Yuvraj5", "Raina6"];

  const merged = [...T20Players, ...RanjiPlayers];

  const oddPlayers = merged.filter((_, i) => i % 2 === 0);
  const evenPlayers = merged.filter((_, i) => i % 2 === 1);

  return (
    <div>
      <h2>Odd Players</h2>
      <ul>
        {oddPlayers.map((player, index) => (
          <li key={index}>
            {["First", "Third", "Fifth"][index]} : {player}
          </li>
        ))}
      </ul>

      <h2>Even Players</h2>
      <ul>
        {evenPlayers.map((player, index) => (
          <li key={index}>
            {["Second", "Fourth", "Sixth"][index]} : {player}
          </li>
        ))}
      </ul>

      <h2>List of Indian Players Merged:</h2>
      <ul>
        {merged.map((player, index) => (
          <li key={index}>Mr. {["First", "Second", "Third", "Fourth", "Fifth", "Sixth"][index]} Player</li>
        ))}
      </ul>
    </div>
  );
};

export default IndianPlayers;

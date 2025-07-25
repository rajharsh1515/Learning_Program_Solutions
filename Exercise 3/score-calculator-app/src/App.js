import logo from './logo.svg';
import './App.css';

import { CalculateScore } from './Components/CalculateScore';

function App() {
  return (
    <div>
      <CalculateScore
        Name="Harsh Raj"
        School="Litera Valley School"
        total={294}
        goal={300}
      />
    </div>
  );
}

export default App;
import './App.css';
import CohortDetails from './Components/CohortDetails';

function App() {
  const cohortData = [
    {
      name: "INTADMDF10 -.NET FSD",
      startDate: "22-Feb-2022",
      status: "Scheduled",
      coach: "Aathma",
      trainer: "Jojo Jose"
    },
    {
      name: "ADM21JF014 -Java FSD",
      startDate: "10-Sep-2021",
      status: "Ongoing",
      coach: "Apoorv",
      trainer: "Elisa Smith"
    },
    {
      name: "CDBJF21025 -Java FSD",
      startDate: "24-Dec-2021",
      status: "Ongoing",
      coach: "Aathma",
      trainer: "John Doe"
    }
  ];

  return (
    <div className="App">
      <h2>Cohorts Details</h2>
      {cohortData.map((cohort, index) => (
        <CohortDetails key={index} cohort={cohort} />
      ))}
    </div>
  );
}

export default App;

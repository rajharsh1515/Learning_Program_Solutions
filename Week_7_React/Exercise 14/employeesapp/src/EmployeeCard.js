import Styles from './EmployeeCard.module.css';
import ThemeContext from './ThemeContext'; // a
import { useContext } from 'react'; // b

function EmployeeCard(props) {
  const theme = useContext(ThemeContext); // b

  return (
    <div className={Styles.Card}>
      <h3>{props.employee.name}</h3>
      <p>{props.employee.email}</p>
      <p>{props.employee.phone}</p>
      <p>
        <a href="#" className={theme}>Edit</a> {/* c */}
        <a href="#" className={theme}>Delete</a> {/* c */}
      </p>
    </div>
  );
}

export default EmployeeCard;

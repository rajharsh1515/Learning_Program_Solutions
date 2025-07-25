import React from 'react';
import styles from './CohortDetails.module.css';

function CohortDetails({ cohort }) {
  const { name, startDate, status, coach, trainer } = cohort;

  const headingClass = status === 'Ongoing' ? styles.greenHeading : styles.blueHeading;

  return (
    <div className={styles.box}>
      <h3 className={headingClass}>{name}</h3>
      <dl>
        <dt>Started On</dt>
        <dd>{startDate}</dd>
        <dt>Current Status</dt>
        <dd>{status}</dd>
        <dt>Coach</dt>
        <dd>{coach}</dd>
        <dt>Trainer</dt>
        <dd>{trainer}</dd>
      </dl>
    </div>
  );
}

export default CohortDetails;

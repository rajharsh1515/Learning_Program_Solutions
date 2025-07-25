// TrainerDetails.js
import React from 'react';
import { useParams } from 'react-router-dom';

function TrainerDetail({ trainers }) {
  const { id } = useParams();
  const trainer = trainers.find(t => t.trainerId.toString() === id);

  if (!trainer) {
    return <div>Trainer not found</div>;
  }

  return (
    <div style={{ border: '1px solid black', padding: '15px', maxWidth: '300px' }}>
      <h3>Trainers Details</h3>
      <strong>{trainer.name}</strong>
      <p>{trainer.email}</p>
      <p>{trainer.phone}</p>
      <ul>
        {trainer.skills.map((skill, index) => (
          <li key={index}>{skill}</li>
        ))}
      </ul>
    </div>
  );
}

export default TrainerDetail;


import React from 'react';

const CourseDetails = (props) => {
  return (
    <div className="mystyle1">
      <h1>Course Details</h1>
      {props.courses.length === 0 ? (   // Conditional Rendering using ternary operator
        <p>No courses available.</p>
      ) : (
        props.courses.map((course, index) => (
          <div key={index}>
            <h3>{course.name}</h3>
            <p>{course.date}</p>
          </div>
        ))
      )}
    </div>
  );
};

export default CourseDetails;

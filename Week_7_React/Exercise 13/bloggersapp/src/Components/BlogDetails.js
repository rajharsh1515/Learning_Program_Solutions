
import React from 'react';

const BlogDetails = (props) => {
  const showBlogs = props.blogs.length > 0;

  return (
    <div className="v1">
      <h1>Blog Details</h1>
      {showBlogs && props.blogs.map((blog, index) => (  // Conditional Rendering using `&&`
        <div key={index}>
          <h3>{blog.title}</h3>
          <p><b>{blog.author}</b></p>
          <p>{blog.desc}</p>
        </div>
      ))}
    </div>
  );
};

export default BlogDetails;

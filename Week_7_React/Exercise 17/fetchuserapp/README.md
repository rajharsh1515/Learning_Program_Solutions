### Consuming REST APIs from React Applications

Consuming REST APIs in React involves making HTTP requests to external servers to fetch or send data. React applications commonly use built-in `fetch()` API or third-party libraries like `axios` to interact with APIs.

---

### 1. Using the `fetch()` API

The `fetch()` method is built into modern browsers and returns a Promise. It’s often used within React lifecycle methods like `componentDidMount()` or React hooks such as `useEffect()`.

**Example with Class Component:**

```jsx
class UserList extends React.Component {
  state = { users: [], loading: true };

  async componentDidMount() {
    const response = await fetch('https://api.example.com/users');
    const data = await response.json();
    this.setState({ users: data, loading: false });
  }

  render() {
    return this.state.loading ? <p>Loading...</p> : (
      <ul>
        {this.state.users.map(user => <li key={user.id}>{user.name}</li>)}
      </ul>
    );
  }
}
```

**Example with Functional Component and `useEffect`:**

```jsx
import React, { useState, useEffect } from 'react';

function UserList() {
  const [users, setUsers] = useState([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    fetch('https://api.example.com/users')
      .then(res => res.json())
      .then(data => {
        setUsers(data);
        setLoading(false);
      });
  }, []);

  return loading ? <p>Loading...</p> : (
    <ul>
      {users.map(user => <li key={user.id}>{user.name}</li>)}
    </ul>
  );
}
```

---

### 2. Using Axios

Axios is a promise-based HTTP client that simplifies HTTP requests and provides additional features like request/response interceptors.

**Installation:**

```bash
npm install axios
```

**Example:**

```jsx
import axios from 'axios';

useEffect(() => {
  axios.get('https://api.example.com/users')
    .then(response => setUsers(response.data))
    .catch(error => console.error('Error:', error));
}, []);
```

---

### 3. Handling Errors and Loading States

Always handle loading and error states to provide better UX:

```jsx
if (loading) return <p>Loading...</p>;
if (error) return <p>Something went wrong!</p>;
```

---

### 4. Submitting Data (POST Request)

```jsx
fetch('https://api.example.com/users', {
  method: 'POST',
  headers: { 'Content-Type': 'application/json' },
  body: JSON.stringify({ name: 'John Doe' })
})
  .then(res => res.json())
  .then(data => console.log(data));
```

---

### Summary

* Use `fetch()` or `axios` to make HTTP calls.
* Use `componentDidMount()` in class components or `useEffect()` in functional components.
* Handle loading and error states.
* Use appropriate HTTP methods: `GET`, `POST`, `PUT`, `DELETE`.
* Always parse JSON responses and update state accordingly.

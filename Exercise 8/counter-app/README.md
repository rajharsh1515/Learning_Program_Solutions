## 📘 Understanding React State

### What is React State?

In React, **state** is a built-in object that allows components to manage and respond to dynamic data. It helps control the behavior and rendering of components based on user interactions or other events.

---

### Why Use State?

State is used for:

* Tracking user input (like form values)
* Counting clicks or events
* Displaying/hiding elements
* Managing application flow within components

Unlike props, which are passed down from a parent component and are read-only, **state is local and mutable**.

---

### React State in Class Components

In class components, state is initialized in the constructor and updated with `this.setState()`:

```js
class CountPeople extends React.Component {
  constructor() {
    super();
    this.state = {
      entrycount: 0,
      exitcount: 0
    };
  }

  updateEntry = () => {
    this.setState((prevState) => ({
      entrycount: prevState.entrycount + 1
    }));
  };

  updateExit = () => {
    this.setState((prevState) => ({
      exitcount: prevState.exitcount + 1
    }));
  };

  render() {
    return (
      <div>
        <button onClick={this.updateEntry}>Login</button>
        <p>{this.state.entrycount} People Entered!!!</p>

        <button onClick={this.updateExit}>Exit</button>
        <p>{this.state.exitcount} People Left!!!</p>
      </div>
    );
  }
}
```

---

### React State in Functional Components (Hooks)

With Hooks (introduced in React 16.8), you can use state in functional components using `useState`:

```js
import React, { useState } from 'react';

function CountPeople() {
  const [entryCount, setEntryCount] = useState(0);
  const [exitCount, setExitCount] = useState(0);

  const updateEntry = () => setEntryCount(entryCount + 1);
  const updateExit = () => setExitCount(exitCount + 1);

  return (
    <div>
      <button onClick={updateEntry}>Login</button>
      <p>{entryCount} People Entered!!!</p>

      <button onClick={updateExit}>Exit</button>
      <p>{exitCount} People Left!!!</p>
    </div>
  );
}
```

---

### Summary

* State enables dynamic UI updates.
* Use `this.state` and `this.setState()` in class components.
* Use `useState` in functional components.
* State updates re-render the component to reflect changes.

## 📘 React Concepts Overview

### 🔹 1. **Props in React**

**Props** (short for "properties") are used to **pass data from one component to another**.

#### ✅ Example:

```jsx
function Greeting(props) {
  return <h1>Hello, {props.name}!</h1>;
}

// Usage:
<Greeting name="John" />
```

---

### 🔹 2. **Default Props**

**Default props** define fallback values if props are not passed.

#### ✅ Example:

```jsx
function Greeting(props) {
  return <h1>Hello, {props.name}!</h1>;
}

Greeting.defaultProps = {
  name: 'Guest'
};

// Usage:
<Greeting />  // Output: Hello, Guest!
```

---

### 🔹 3. **State vs Props**

| Feature        | **Props**                        | **State**                  |
| -------------- | -------------------------------- | -------------------------- |
| Read/Write     | Read-only                        | Read and write             |
| Mutability     | Immutable                        | Mutable                    |
| Usage          | Passed from parent               | Local to the component     |
| Purpose        | Communication between components | Component's own data       |
| Change Trigger | Can't be changed by child        | Updated using `setState()` |

#### ✅ Example of State:

```jsx
class Counter extends React.Component {
  constructor() {
    super();
    this.state = { count: 0 };
  }

  increment = () => {
    this.setState({ count: this.state.count + 1 });
  }

  render() {
    return (
      <div>
        <h2>Count: {this.state.count}</h2>
        <button onClick={this.increment}>Increment</button>
      </div>
    );
  }
}
```

---

### 🔹 4. **ReactDOM.render()**

`ReactDOM.render()` is used to render a React component into the DOM.

#### ✅ Syntax:

```jsx
ReactDOM.render(<App />, document.getElementById('root'));
```

#### 🧠 Example with HTML:

```html
<!DOCTYPE html>
<html>
  <body>
    <div id="root"></div>

    <script src="https://unpkg.com/react@17/umd/react.development.js"></script>
    <script src="https://unpkg.com/react-dom@17/umd/react-dom.development.js"></script>
    <script src="https://unpkg.com/babel-standalone@6/babel.min.js"></script>

    <script type="text/babel">
      function App() {
        return <h1>Hello from React!</h1>;
      }

      ReactDOM.render(<App />, document.getElementById('root'));
    </script>
  </body>
</html>
```

---

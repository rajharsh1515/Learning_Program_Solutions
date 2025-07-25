# React Components Overview

## 1. What are React Components?

React components are the fundamental building blocks of a React application. They are self-contained, reusable pieces of UI that define how a part of the interface should appear and behave. Components can manage their own state, accept inputs (props), and return React elements for rendering.

---

## 2. Differences Between Components and JavaScript Functions

| Feature              | JavaScript Function         | React Component          |
| -------------------- | --------------------------- | ------------------------ |
| Purpose              | General-purpose logic       | UI rendering             |
| Return Value         | Primitive values or objects | JSX (UI markup)          |
| Invocation           | `myFunction()`              | `<MyComponent />`        |
| React-Specific Props | Not used                    | Accepts and uses `props` |

---

## 3. Types of Components

* **Class Components**
* **Function Components**

---

## 4. Class Component

Class components use ES6 class syntax and extend from `React.Component`. They support state and lifecycle methods.

```jsx
class Welcome extends React.Component {
  render() {
    return <h1>Hello, {this.props.name}</h1>;
  }
}
```

---

## 5. Function Component

Function components are simpler and are defined as JavaScript functions. With React Hooks, they can now handle state and side effects.

```jsx
function Welcome(props) {
  return <h1>Hello, {props.name}</h1>;
}
```

---

## 6. Component Constructor

In class components, the `constructor()` method is used to initialize state and bind methods.

```jsx
class Welcome extends React.Component {
  constructor(props) {
    super(props);
    this.state = { message: "Welcome!" };
  }
  render() {
    return <h1>{this.state.message}</h1>;
  }
}
```

---

## 7. render() Function

The `render()` method is required in class components. It returns JSX that React renders to the DOM.

```jsx
render() {
  return <div>Hello World</div>;
}
```

---

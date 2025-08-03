### React Events

React Events are the way to handle user interactions in a React application. They are very similar to DOM events, like `onclick`, `onchange`, etc., but React wraps them in a special way to make them consistent across different browsers.

React provides its own wrapper around the browser's native events called **Synthetic Events** to make sure they work identically across all browsers.

### Event Handlers

An **event handler** is a function that is called when a particular event happens. For example, when a user clicks a button, submits a form, hovers over an element, etc.

In React, we attach event handlers to JSX elements using props. For example:

```jsx
<button onClick={handleClick}>Click Me</button>
```

Here, `handleClick` is an event handler function.

Example of defining `handleClick`:

```jsx
function handleClick() {
  alert('Button was clicked!');
}
```

### Synthetic Event

A **Synthetic Event** is React's cross-browser wrapper around the browser's native event. It combines the behavior of different browsers to provide a consistent interface for handling events in React.

* React creates SyntheticEvent instances from native events.
* SyntheticEvent has the same interface as the native event.
* It works identically across all browsers.

Example:

```jsx
function handleClick(event) {
  console.log(event); // SyntheticEvent object
  console.log(event.type); // 'click'
}

<button onClick={handleClick}>Click Me</button>
```

### React Event Naming Convention

React event names:

* Use **camelCase** instead of lowercase.
* Example: `onClick`, `onMouseEnter`, `onChange`, `onSubmit`, etc.

Native DOM:

```html
<button onclick="doSomething()">Click</button>
```

React:

```jsx
<button onClick={doSomething}>Click</button>
```

Summary of Naming:

| Native DOM Event | React Event |
| ---------------- | ----------- |
| onclick          | onClick     |
| onchange         | onChange    |
| onsubmit         | onSubmit    |
| onmouseover      | onMouseOver |

This ensures consistency and makes it easy to follow React conventions.

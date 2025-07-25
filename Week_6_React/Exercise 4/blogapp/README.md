# React Component Lifecycle

## 1. Need and Benefits of Component Lifecycle

React component lifecycle provides methods that allow developers to control the behavior of components during their creation, update, and destruction phases. Understanding the lifecycle helps in:

* Managing side effects (like API calls, timers)
* Improving performance through controlled rendering
* Cleaning up resources before component removal
* Executing code at specific points during a component's life

---

## 2. Lifecycle Hook Methods in Class Components

### Mounting Phase (when the component is being inserted into the DOM):

* `constructor()` – Initializes state and bindings
* `static getDerivedStateFromProps()` – Syncs state with props
* `render()` – Returns JSX to render UI
* `componentDidMount()` – Called once after initial render; ideal for API calls

### Updating Phase (when props or state changes):

* `static getDerivedStateFromProps()` – Called before every re-render
* `shouldComponentUpdate()` – Allows skipping re-render if not needed
* `render()` – Renders updated JSX
* `getSnapshotBeforeUpdate()` – Captures info (e.g., scroll position) before DOM changes
* `componentDidUpdate()` – Runs after DOM updates; useful for reacting to prop/state changes

### Unmounting Phase (when component is being removed from DOM):

* `componentWillUnmount()` – Cleanup tasks like clearing timers or canceling subscriptions

### Error Handling Phase:

* `static getDerivedStateFromError()` – Updates state to display fallback UI
* `componentDidCatch()` – Logs error info for debugging

---

## 3. Sequence of Steps in Rendering a Component

### Initial Mount:

1. `constructor()`
2. `getDerivedStateFromProps()`
3. `render()`
4. `componentDidMount()`

### Update:

1. `getDerivedStateFromProps()`
2. `shouldComponentUpdate()`
3. `render()`
4. `getSnapshotBeforeUpdate()`
5. `componentDidUpdate()`

### Unmount:

* `componentWillUnmount()`

---

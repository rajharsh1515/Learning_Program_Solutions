### 1. Various Ways of Conditional Rendering

Conditional rendering is the technique in React where components are rendered based on certain conditions.

**a) Using if/else statement:**

```jsx
if (isLoggedIn) {
  return <Dashboard />;
} else {
  return <LoginPage />;
}
```

**b) Using && operator (short-circuit evaluation):**

```jsx
{isLoggedIn && <Dashboard />}
```

**c) Using ternary operator:**

```jsx
{isLoggedIn ? <Dashboard /> : <LoginPage />}
```

**d) Using switch statement:**

```jsx
switch (status) {
  case 'loading':
    return <Loading />;
  case 'error':
    return <Error />;
  default:
    return <Content />;
}
```

**e) Using function inside component:**

```jsx
function renderContent() {
  if (isLoggedIn) {
    return <Dashboard />;
  }
  return <LoginPage />;
}

return <div>{renderContent()}</div>;
```

---

### 2. How to Render Multiple Components

In React, multiple components can be rendered together by placing them inside a common parent component.

**Example:**

```jsx
return (
  <div>
    <Header />
    <Sidebar />
    <Content />
    <Footer />
  </div>
);
```

**Using React Fragments:**

```jsx
return (
  <>
    <Header />
    <Content />
    <Footer />
  </>
);
```

---

### 3. Define List Component

A List Component is used to render a list of similar items using the `map()` function.

**Example:**

```jsx
const NameList = ({ names }) => (
  <ul>
    {names.map((name, index) => (
      <li key={index}>{name}</li>
    ))}
  </ul>
);
```

---

### 4. Keys in React Applications

* Keys are unique identifiers assigned to elements in a list.
* They help React efficiently update and render list items.
* Without keys, React will re-render the entire list, which affects performance.

**Example:**

```jsx
<ul>
  {items.map(item => (
    <li key={item.id}>{item.name}</li>
  ))}
</ul>
```

---

### 5. How to Extract Components with Keys

When extracting list items into their own components, the `key` should remain on the component in the list.

**Example:**

```jsx
const ListItem = ({ item }) => <li>{item.name}</li>;

const ItemList = ({ items }) => (
  <ul>
    {items.map(item => (
      <ListItem key={item.id} item={item} />
    ))}
  </ul>
);
```

**Note:** The `key` prop is used by React and is not passed down to the child component.

---

### 6. React Map, map() Function

* The `map()` function is a JavaScript array method.
* In React, it is commonly used to render lists.

**Syntax:**

```jsx
array.map((item, index) => {
  // return JSX for each item
});
```

**Example:**

```jsx
const numbers = [1, 2, 3];

return (
  <ul>
    {numbers.map((num, index) => (
      <li key={index}>{num}</li>
    ))}
  </ul>
);
```

**Why are we using map()?**

* To transform data arrays into lists of React elements.
* It makes rendering dynamic lists simple and efficient.

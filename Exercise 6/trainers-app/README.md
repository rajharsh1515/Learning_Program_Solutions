## 📘 React Router Overview

### ✅ Need and Benefits of React Router

React Router is a popular routing library used with React to handle navigation between views in a single-page application (SPA). It allows developers to define multiple routes and link them to React components without reloading the page.

**Key Benefits:**

* Enables seamless page transitions without full-page reloads
* Keeps the URL in sync with the application state
* Supports nested and dynamic routing
* Encourages modular architecture
* Works well with browser navigation (Back/Forward buttons)

---

### 🧹 Core Components in React Router

React Router provides several components and hooks:

* `<BrowserRouter>`: Wraps the app to enable routing using HTML5 history API.
* `<Routes>`: Container for route definitions.
* `<Route>`: Maps a URL path to a specific component.
* `<Link>`: Used for navigation between routes (like anchor tags but without reload).
* `<NavLink>`: Like `<Link>`, but adds styling for the active route.
* `<Outlet>`: Used to render child/nested routes.
* `<Navigate>`: Programmatic navigation or redirection.
* `useParams()`: Accesses URL parameters.
* `useNavigate()`: Navigates programmatically (e.g., after a form submit).
* `useLocation()`: Accesses the current location (URL + state).

---

### 📂 Types of Router Components

React Router offers different router types based on your platform or requirements:

| Router Type     | Description                                                        |
| --------------- | ------------------------------------------------------------------ |
| `BrowserRouter` | Uses HTML5 history API. Recommended for modern web apps.           |
| `HashRouter`    | Uses hash-based URLs (e.g., `/#/home`). Useful for static hosting. |
| `MemoryRouter`  | Stores history in memory. Best for tests or non-browser apps.      |
| `StaticRouter`  | Used for server-side rendering (SSR).                              |

---

### 🔗 Parameter Passing via URL

React Router makes it easy to define and use dynamic route parameters.

**Route Declaration Example:**

```jsx
<Route path="/user/:id" element={<User />} />
```

**Link Navigation:**

```jsx
<Link to="/user/101">View User 101</Link>
```

**Accessing Parameters in Component:**

```jsx
import { useParams } from 'react-router-dom';

function User() {
  const { id } = useParams();
  return <p>User ID: {id}</p>;
}
```

---

Happy Routing! 🎉

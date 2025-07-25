# 🎨 Styling React Components

This document explains **why styling is important in React**, and how to apply styles using **CSS Modules** and **inline styles**.

---

## ✅ Why Style React Components?

In modern web applications, **styling is essential** to:

- Improve **user experience** and **usability**
- Match the design of the brand or product
- Make the app responsive and visually appealing
- Highlight interactions like hover, focus, and active states

React allows multiple ways to style components, including:

- CSS files (global or component-scoped)
- CSS Modules
- Inline styles
- Styled-components / Tailwind / frameworks

---

## 🧩 CSS Modules in React

**CSS Modules** help scope styles to a specific component, avoiding class name conflicts across the app.

### 📁 File structure:

# React Styling: Understanding the Need and Approaches

## ✨ Why Do We Need to Style React Components?

Styling in React is essential to:

* Improve **user experience** through a clean and consistent UI
* Ensure **readability** and better **layout management**
* Visually differentiate components based on their **status**, **purpose**, or **hierarchy**
* Maintain **component-level scope** and avoid global CSS conflicts

React allows multiple styling methods. In this project, we focus on:

* **CSS Modules** (for scoped and reusable styles)
* **Inline Styling** (for quick, conditional styles)

---

## 📄 CSS Modules in React

### What are CSS Modules?

CSS Modules provide **scoped** styling to components so that styles don’t leak globally.

### Steps to Use CSS Modules:

1. **Create a CSS module file** with `.module.css` extension.
   Example: `CohortDetails.module.css`

2. **Define styles** in the module:

```css
/* CohortDetails.module.css */
.box {
  width: 300px;
  display: inline-block;
  margin: 10px;
  padding: 10px 20px;
  border: 1px solid black;
  border-radius: 10px;
}

dt {
  font-weight: 500;
}
```

3. **Import and apply the styles** in your component:

```jsx
import styles from './CohortDetails.module.css';

function CohortCard() {
  return (
    <div className={styles.box}>
      {/* content */}
    </div>
  );
}
```

---

## 🖌️ Inline Styles in React

### What are Inline Styles?

Inline styles are directly written inside a component using the `style={{ }}` syntax. Best for **dynamic conditional styling**.

### Example:

```jsx
const headingStyle = {
  color: cohort.status === 'Ongoing' ? 'green' : 'blue'
};

<h3 style={headingStyle}>{cohort.name}</h3>
```

---

## 🔍 Summary

| Styling Method | Scope     | Use Case                                |
| -------------- | --------- | --------------------------------------- |
| CSS Modules    | Local     | Component-level consistent styling      |
| Inline Styling | Component | Quick, dynamic, and conditional styling |

Both methods work well together to create scalable and maintainable React UIs.

---

##

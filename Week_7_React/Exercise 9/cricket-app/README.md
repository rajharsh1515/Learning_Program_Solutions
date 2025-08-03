## ES6 Features and Concepts

### 1. Features of ES6 (ECMAScript 2015)

* **let and const** for block-scoped variable declarations.
* **Arrow functions** for concise function syntax.
* **Template literals** for easier string interpolation.
* **Default parameters** in functions.
* **Rest and Spread operators** for handling function arguments and array manipulation.
* **Destructuring** for unpacking values from arrays or objects.
* **Modules** for importing and exporting code across files.
* **Classes and inheritance** using class syntax.
* **Promises** for better asynchronous code management.
* **Enhanced object literals** for easier object creation.
* **Set and Map** collections for unique values and key-value pairs.

### 2. JavaScript `let`

The `let` keyword allows you to declare block-scoped variables. It prevents variable hoisting and re-declaration within the same scope.

```javascript
let count = 10;
if (true) {
  let count = 20;
  console.log(count); // 20
}
console.log(count); // 10
```

### 3. Differences Between `var` and `let`

| Feature            | var                            | let                       |
| ------------------ | ------------------------------ | ------------------------- |
| Scope              | Function scoped                | Block scoped              |
| Hoisting           | Yes (initialized as undefined) | Yes (but not initialized) |
| Re-declaration     | Allowed                        | Not allowed               |
| Temporal Dead Zone | No                             | Yes                       |

### 4. JavaScript `const`

The `const` keyword declares block-scoped constants. Once assigned, the variable cannot be reassigned. However, object properties can still be changed.

```javascript
const PI = 3.14;
const user = { name: "Alice" };
user.name = "Bob"; // Allowed
PI = 3.1416; // Error
```

### 5. ES6 Class Fundamentals

ES6 introduced class syntax as a more structured way to create objects and handle inheritance.

```javascript
class Person {
  constructor(name) {
    this.name = name;
  }
  greet() {
    console.log(`Hello, ${this.name}`);
  }
}
const p = new Person("Alice");
p.greet();
```

### 6. ES6 Class Inheritance

Classes can inherit from other classes using the `extends` keyword.

```javascript
class Student extends Person {
  constructor(name, grade) {
    super(name);
    this.grade = grade;
  }
  study() {
    console.log(`${this.name} is studying in grade ${this.grade}`);
  }
}
const s = new Student("Bob", 10);
s.greet();
s.study();
```

### 7. ES6 Arrow Functions

Arrow functions provide a shorter syntax and do not bind their own `this`.

```javascript
const add = (a, b) => a + b;
console.log(add(2, 3)); // 5
```

### 8. `Set()` and `Map()` in ES6

* **Set**: A collection of unique values.

```javascript
const uniqueNums = new Set([1, 2, 3, 3]);
console.log(uniqueNums); // Set {1, 2, 3}
```

* **Map**: A key-value pair collection with ordered entries.

```javascript
const userMap = new Map();
userMap.set("name", "Alice");
userMap.set("age", 25);
console.log(userMap.get("name")); // Alice
```

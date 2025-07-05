# Lab 1: Understanding ORM and EF Core

## 1. What is ORM?

ORM (Object-Relational Mapping) is a programming technique that allows developers to interact with relational databases using object-oriented languages like C#. ORM frameworks map C# classes to database tables and their properties to table columns, enabling seamless data operations without writing raw SQL queries.

### How ORM Maps C# Classes to Database Tables

- Each C# class corresponds to a database table.
- Each property in a class corresponds to a column in that table.
- Relationships between classes (like one-to-many) correspond to foreign keys in the database.

### Benefits of ORM

- **Productivity:** Work with objects instead of writing SQL manually.
- **Maintainability:** Easily update database schema via migrations as models change.
- **Abstraction:** ORM abstracts database-specific SQL, allowing switching databases without much code change.

---

## 2. EF Core vs EF Framework

- **EF Core**

  - Cross-platform and lightweight.
  - Supports modern features like LINQ, asynchronous queries, and compiled queries.

- **EF Framework (EF6)**

  - Windows-only and more mature.
  - Less flexible and limited to older .NET Frameworks.

---

## 3. EF Core 8.0 Features

- JSON column mapping support.
- Improved performance with compiled models.
- Interceptors and enhanced bulk operations.

---

## 4. How to Create It?

Follow these steps to set up your EF Core console project:

### ✅ Step 1: Create a .NET Console App

```bash
dotnet new console -n RetailInventory
cd RetailInventory
```

### ✅ Step 2: Install EF Core Packages

```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
```

### ✅ Step 3: Create Model Classes

Inside the `Models/` folder, create your C# classes like `Product.cs` and `Category.cs`:

```csharp
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; }
}
```

### ✅ Step 4: Create AppDbContext

```csharp
public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Your_Connection_String");
    }
}
```

### ✅ Step 5: Add Migration and Update Database

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

---

With these steps, your EF Core console app is ready to perform database operations using LINQ and C# models.


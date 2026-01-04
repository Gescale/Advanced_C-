# Learning Advanced C# 

<p align="center">
  <img src="https://skillicons.dev/icons?i=cs,dotnet,visualstudio,git,github" />
</p>

---

## Overview
Welcome to my learning repository! This project documents my journey through **Mosh Hamedani's "C# Advanced Topics"** course. My goal is to move beyond basic syntax and master the powerful, underlying features of the .NET ecosystem.

> "Your journey to becoming a pro developer starts here." — Mosh

---

## Tech Stack
![C#](https://img.shields.io/badge/Language-C%23-blueviolet?style=for-the-badge&logo=csharp)
![.NET 9](https://img.shields.io/badge/Platform-.NET%209-512bd4?style=for-the-badge&logo=dotnet)
![Status](https://img.shields.io/badge/Status-In%20Progress-green?style=for-the-badge)

---

## Roadmap & Topics Covered

Here is the breakdown of the advanced concepts I am mastering:

### 1. Generics
- [x] Understanding why we use Generics (Type Safety vs Performance).
- [x] Creating Generic Classes and Methods.
- [x] Generic Constraints (`where T : class`, `new()`, etc.).

### 2. Delegates & Events
- [x] Custom Delegates vs `Action` and `Func`.
- [x] Mastering the Publisher/Subscriber pattern.
- [x] Handling Event Arguments.

### 3. Lambda Expressions
- [x] Anonymous Methods.
- [x] Blablabla 
- [x] The power of the `=>` operator.
- [x] Writing cleaner, more readable code.

### 4. LINQ (Language Integrated Query)
- [x] Extension Methods vs Query Syntax.
- [x] Filtering, Ordering, and Projecting data.
- [x] Working with `IEnumerable` and `IQueryable`.

### 5. Exception Handling
- [x] Proper `try/catch` blocks.
- [x] Custom Exception classes.
- [x] The `finally` block and Resource management.

### 6. Asynchronous Programming
- [ ] The `async` and `await` keywords.
- [ ] Non-blocking I/O operations.
- [ ] Task handling and Exceptions in Async.

---

## Lessons Learned
* **Decoupling:** Using Events and Delegates taught me how to keep my code "loose" so that changing one class doesn't break another.
* **Performance:** Generics aren't just for neat code; they prevent "boxing/unboxing" which speeds up the app.
* **Readability:** LINQ turned 10 lines of `foreach` loops into a single, beautiful line of code.

---

## How to Run Locally

1. **Clone the repo:**
   ```bash
   git clone https://github.com/Gescale/Advanced_C-.git

2. **Navigate to the folder
   ```bash
   cd Advanced_C#

3. **Run a specific excesice
   ```bash
   dotnet run --project Advanced_C#

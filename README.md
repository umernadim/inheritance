# 🧠 C# Inheritance, Method Overriding & Interface Practice

## 📘 Project Overview

This project is a **C# console application** built to demonstrate important **Object-Oriented Programming (OOP)** concepts — including **Inheritance**, **Method Overriding**, **Abstraction**, and **Interfaces**.

It includes multiple **real-world-inspired examples** to make learning these concepts simple and practical — such as **animals, students, geometric shapes, and payment systems**.

## 🧩 Topics Covered

This project explores the following OOP principles in C#:

* 🧬 **Single Inheritance** — One class inherits from another.
* 🏗️ **Multi-level Inheritance** — Building deeper inheritance hierarchies.
* ⚙️ **Method Overriding** — Redefining base class methods in derived classes.
* 🔒 **Abstraction** — Using abstract classes to define a common structure.
* 🔗 **Interfaces** — Implementing multiple contracts in different classes.

## 🧠 Concepts Demonstrated

### 🐶 1. Single Inheritance Example

**Classes:** `Animal`, `Dog`, `Cat`

* `Animal` defines shared properties (`name`, `age`) and the method `Eat()`.
* `Dog` and `Cat` inherit from `Animal` and introduce `Bark()` and `Meow()`.

### 🐱 2. Multi-level Inheritance Example

**Classes:** `Cat → SpanishCat`

* `SpanishCat` extends `Cat` and introduces `SpeakSpanish()`.
* Demonstrates chained inheritance and method reusability.

### 🎓 3. Person & Student Example

**Classes:** `Person`, `Student`

* `Student` inherits from `Person` and adds `rollNo`.
* Shows how base class properties and methods can be extended in subclasses.

### 🕊️ 4. Method Overriding with Birds

**Classes:** `Birds`, `Parrot`

* `Birds` is an **abstract class** with common behaviors (`Eat()`, `Fly()`).
* `Parrot` **overrides** the `Fly()` method and adds a `talk()` behavior.

### 🔵 5. Shapes Area Calculator

**Classes:** `Shape`, `Circle`, `Square`, `Rectangle`

* `Shape` is an **abstract base class** with the abstract method `Area()`.
* Derived classes override `Area()` to compute the area of each shape type.
* Demonstrates **polymorphism** — the same method behaves differently depending on the class.

### 🚗 6. Vehicle Speed Analyzer

**Classes:** `Vehicle`, `Bike`, `Car`, `Truck`

* Calculates the **average speed** for each vehicle.
* Determines the **fastest vehicle** and computes the **total average speed**.
* Illustrates abstraction, overriding, and dynamic class behavior.

### 🧩 7. Interface Example — Animal Behavior

**Interfaces & Classes:** `IAnimal`, `Dog`, `Cat`

* `IAnimal` defines two methods: `Speak()` and `Eat()`.
* Both `Dog` and `Cat` implement the interface, providing their own behaviors.

#### Example Output:

```
Woof!
Dog is eating.
Meow!
Cat is eating.
```

### 💳 8. Interface Example — Payment System

**Interfaces & Classes:** `IPayment`, `CreditCardPayment`, `PayPalPayment`, `BankTransferPayment`

* `IPayment` defines a method `ProcessPayment()`.
* Each class implements it differently to simulate different payment methods.

#### Example Output:

```
Processing Credit Card payment of 100 USD...
Processing Paypal payment of 295.4 USD...
Processing Bank Transfer payment of 500 USD...
```

## ⚙️ How to Run the Project

1. Open the project in **Visual Studio** or **VS Code**.
2. Ensure that the **.NET SDK** is installed on your system.
3. Uncomment the section you want to test.
4. Run the program using:

   ```bash
   dotnet run
   ```
5. View the results directly in the console.

## 🧾 Summary

This project is perfect for **C# beginners and intermediate learners** looking to practice:

* Inheritance Hierarchies
* Abstract Classes
* Virtual & Overridden Methods
* Interface Implementation
* Real-world OOP Modeling

By working through these examples, you’ll gain a deeper understanding of how to design flexible and scalable C# applications using core OOP concepts.

## 💡 Author

**Muhammad Umer**

> A passionate learner and developer exploring C# and software design principles through practical coding examples.

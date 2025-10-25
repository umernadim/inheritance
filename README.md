# 🐾 C# Inheritance and Method Overriding Practice

## 📘 Project Overview

This project is a comprehensive **C# console application** designed to demonstrate key **Object-Oriented Programming (OOP)** concepts, including **Inheritance**, **Method Overriding**, and **Abstraction**.
It contains multiple real-world inspired examples that make understanding inheritance easy and practical — from animals and students to vehicles and geometric shapes.

## 🧩 Topics Covered

The project focuses on the following **OOP principles**:

1. **Single Inheritance** — Understanding how one class inherits from another.
2. **Multi-level Inheritance** — Demonstrating deeper inheritance chains.
3. **Method Overriding** — Using `abstract` and `virtual` methods for customized behavior.
4. **Abstraction** — Implementing abstract classes to enforce structure in derived classes.

## 🧠 Concepts Demonstrated

### 🐶 1. Single Inheritance Example

Classes: `Animal`, `Dog`, `Cat`

* `Animal` serves as the base class with shared properties (`name`, `age`) and a method `Eat()`.
* `Dog` and `Cat` inherit from `Animal` and add their own unique behaviors like `Bark()` and `Meow()`.

### 🐱 2. Multi-level Inheritance Example

Classes: `Cat → SpanishCat`

* `SpanishCat` inherits from `Cat` and adds a new behavior `SpeakSpanish()`.
* Demonstrates chaining of inherited methods across multiple levels.

### 🎓 3. Person & Student Example

Classes: `Person`, `Student`

* `Student` inherits from `Person` and introduces a `rollNo` property.
* Demonstrates how base class methods can be reused and extended in child classes.

### 🕊️ 4. Method Overriding with Birds

Classes: `Birds`, `Parrot`

* `Birds` is an abstract class with `Eat()` and `Fly()` methods.
* `Parrot` overrides the `Fly()` method and adds a `talk()` behavior.

### 🔵 5. Shapes Area Calculator

Classes: `Shape`, `Circle`, `Square`, `Rectangle`

* `Shape` is an abstract base class with an abstract method `Area()`.
* Each derived class (`Circle`, `Square`, `Rectangle`) overrides `Area()` to calculate the shape’s area differently.
* Demonstrates **polymorphism** — same method name, different implementations.

### 🚗 6. Vehicle Speed Analyzer

Classes: `Vehicle`, `Bike`, `Car`, `Truck`

* Calculates the **average speed** for each vehicle.
* Finds the **fastest vehicle** and computes the **total average speed**.
* Showcases abstraction and overriding with real-world data.

## ⚙️ How to Run the Project

1. Open the project in **Visual Studio** or **VS Code**.
2. Ensure the `.NET SDK` is installed on your system.
3. Uncomment the section of the example you want to test.
4. Run the program using:
5. Observe the output in the console.

## 🧩 Example Output (Vehicle Analyzer)

```
The average speed of yamaha is 50 km/h
The average speed of Toyota is 62.5 km/h
The average speed of Volvo is 40 km/h

Total Average Speed: 50.83 km/h
Fastest Vehicle: Toyota (62.5 km/h)
```

## 🧾 Summary

This project is ideal for **C# beginners and intermediate learners** who want hands-on practice with:

* Inheritance Hierarchies
* Abstract and Virtual Methods
* Method Overriding
* Polymorphism
* Real-world problem modeling

## 💡 Author

**Muhammad Umer**
A passionate learner and developer exploring C# and software design principles through practical coding examples.

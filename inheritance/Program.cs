// See https://aka.ms/new-console-template for more information

// ******************************
//          Inheritance  
// ******************************


// Example of Single Inheritance

//Dog dog1 = new Dog();
//dog1.name = "Pluto";
//dog1.age = 3;
//dog1.breed = "Beagle";
//dog1.Eat();
//dog1.Bark();

//Cat cat1 = new Cat()
//{
//    name = "Whiskers",
//    age = 2,
//    color = "white"
//};
//cat1.Eat();
//cat1.Meow();

//SpanishCat spanishCat = new()
//{
//    name = "Gato",
//    age = 4,
//    color = "black"
//};
//spanishCat.Eat();
//spanishCat.Meow();
//spanishCat.SpeakSpanish();


//class Animal
//{
//    public string name;
//    public int age;
//    public void Eat()
//    {
//        Console.WriteLine($"{name} is eating.");
//    }
//}

//class Dog : Animal
//{
//    public string breed;
//    public void Bark()
//    {
//        Console.WriteLine($"{name} is barking.");
//    }
//}

//class Cat : Animal
//{
//    public string color;
//    public void Meow()
//    {
//         Console.WriteLine($"{name} is meowing.");
//    }
//}


// Multi-level Inheritance
//class SpanishCat : Cat
//{
//    public void SpeakSpanish()
//    {
//        Console.WriteLine($"{name} is dice miau.");
//    }
//}



// 2nd Example of inheritance

//Student student1 = new()
//{
//    name = "Umer",
//    age = 23,
//    rollNo = 101
//};
//student1.intro();
//student1.rolNo();

//class Person
//{
//    public string name;
//    public int age;
//    public void intro()
//    {
//        Console.WriteLine($"Hello, my name is {name} and i'm {age} years old.");
//    }
//}

//class Student : Person
//{
//    public int rollNo;
//    public void rolNo()
//    {
//        Console.WriteLine($"My roll number is {rollNo}.");
//    }
//}



// ****************************
//      Method Overriding
// ****************************
//Parrot parrot1 = new()
//{
//    name = "Mithoo", 
//    age = 2,
//    breed = "African Grey"
//};
//parrot1.Eat();
//parrot1.talk(); 
//parrot1.Fly();

//abstract class Birds
//{
//    public string name;
//    public int age;
//    public void Eat()
//    {
//        Console.WriteLine($"{name} is eating.");
//    }
//    public virtual void Fly(){}
//}

//class Parrot : Birds
//{
//    public string breed;
//    public void talk()
//    {
//       Console.WriteLine($"{name} is talking.");
//    }
//    public override void Fly()
//    {
//        Console.WriteLine($"{name} is flying!");
//    }
//}



// 2nd Example of method overriding
//List<Shape> shapes = new()
//{
//    new Circle { radius = 5.0 },
//    new Square { side = 4.0 },
//    new Rectangle { length = 6.0 ,width = 3.0 },
//};

//foreach(var shape in shapes)
//{
//    shape.Area();
//}
//abstract class Shape
//{
//    public abstract void Area();
//}

//class Circle : Shape
//{
//    public double radius;
//    public override void Area()
//    {
//        double area = Math.PI * radius * radius;
//        Console.WriteLine($"The area of the circle is {area}");
//    }
//}

//class Square : Shape
//{
//    public double side;
//    public override void Area()
//    {
//        double area = side * side;
//        Console.WriteLine($"The area of the square is {area}");
//    }
//}

//class Rectangle : Shape
//{
//    public double length;
//    public double width;
//    public override void Area()
//    {
//        double area = length * width;
//        Console.WriteLine($"The area of the rectangle is {area}");
//    }
//}




//Vehicle Speed Analyzer 

//List<Vehicle> vehicles = new()
//{
//    new Bike {name = "yamaha", distance = 150, time = 3 },
//    new Car {name = "Toyota", distance = 250, time = 4 },
//    new Truck {name = "Volvo", distance = 200, time = 5 }
//};

//double totalSpeed = 0;
//double highestSpeed = 0;
//Vehicle fastestVehicle = null;

//foreach (var vehicle in vehicles) {
//    double speed = vehicle.AvgSpeed();
//    Console.WriteLine($"The average speed of {vehicle.name} is {speed} km/h");

//    totalSpeed += speed;

//    if(speed > highestSpeed)
//    {
//        highestSpeed = speed;
//        fastestVehicle = vehicle;
//    }
//}

//Console.WriteLine($"\nTotal Average Speed: {totalSpeed / vehicles.Count} km/h");
//Console.WriteLine($"Fastest Vehicle: {fastestVehicle.name} ({highestSpeed} km/h)");

//abstract class Vehicle
//{
//    public string name;
//    public int distance;
//    public int time;
//    public abstract double AvgSpeed();
//}

//class Bike : Vehicle
//{
//    public override double AvgSpeed()
//    {
//        return  distance / time;
//    }
//}
//class Car : Vehicle
//{
//    public override double AvgSpeed()
//    {
//        return distance / time;
//    }
//}
//class Truck : Vehicle
//{
//    public override double AvgSpeed()
//    {
//        return distance / time;
//    }
//}

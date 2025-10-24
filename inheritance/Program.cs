// See https://aka.ms/new-console-template for more information

// ******************************
//          Inheritance  
// ******************************

Dog dog1 = new Dog();
dog1.name = "Pluto";
dog1.age = 3;
dog1.breed = "Beagle";
dog1.Eat();
dog1.Bark();

Cat cat1 = new Cat()
{
    name = "Whiskers",
    age = 2,
    color = "white"
};
cat1.Eat();
cat1.Meow();


class Animal
{
    public string name;
    public int age;
    public void Eat()
    {
        Console.WriteLine($"{name} is eating.");
    }
}

class Dog : Animal
{
    public string breed;
    public void Bark()
    {
        Console.WriteLine($"{name} is barking.");
    }
}

class Cat : Animal
{
    public string color;
    public void Meow()
    {
               Console.WriteLine($"{name} is meowing.");
    }
}
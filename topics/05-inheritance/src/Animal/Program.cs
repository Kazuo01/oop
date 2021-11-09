using System;

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal();
        animal.Speak();
        Animal dog = new Dog();
        dog.Speak();
        Animal cat = new Cat();
        cat.Speak();
        Console.WriteLine("Total animals: " + Animal.Quantity);
        Console.WriteLine("Number of cats: " + Cat.Quantity);
        Console.WriteLine("Number of dogs: " + Dog.Quantity);

    }
}

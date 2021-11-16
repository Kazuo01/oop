using System;

class Program
{
    static void Main(string[] args)
    {
        // Tạo mới 1 động vật tổng quát:
        Animal animal = new Animal();
        animal.Speak();

        // Tạo mới 1 động vật là chó
        Animal dog = new Dog();
        dog.Speak();

        // Tạo mới 2 động vật là mèo
        Animal cat1 = new Cat();
        Animal cat2 = new Cat();
        cat1.Speak();
        cat2.Speak();

        // Stats
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Total animals: " + Animal.Quantity);
        Console.WriteLine("Number of cats: " + Cat.Quantity);
        Console.WriteLine("Number of dogs: " + Dog.Quantity);

    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        // Tạo 1 đối tượng Animal
        Animal animal = new Animal();
        animal.Speak();
        // Tạo 1 đối tượng Dog
        Dog dog = new Dog();
        dog.Speak();
        // Tạo 1 đối tượng Animal là Dog
        Animal dog2 = new Dog();
        dog2.Speak();
    }
}

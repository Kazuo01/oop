/*
Animal class
*/

using System;

class Animal
{
    private static int _quantity=0;
    public static int Quantity{get => _quantity;}

    public Animal()
    {
        _quantity++;
    }
 
    public virtual void Speak()
    {
        Console.WriteLine("Halo, I'm an animal.");
    }
}

class Dog:Animal
{
    private static int _quantity=0;
    public static int Quantity{get => _quantity;}
    public Dog()
    {
        _quantity++;
    }
    public override void Speak()
    {
        Console.WriteLine("Gow gow! I'm a dog");
    }
}

class Cat:Animal
{
    private static int _quantity=0;
    public static int Quantity{get => _quantity;}
    public Cat()
    {
        _quantity++;
    }
    public override void Speak()
    {
        Console.WriteLine("Meow! I'm a cat");
    }
}

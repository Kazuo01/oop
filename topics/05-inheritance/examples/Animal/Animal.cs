/*
Xây dựng lớp Animal
*/

using System;

class Animal
{
    public virtual string Name{get; set;}

    public Animal()
    {
        Name = "Animal";
    }
    public virtual void Speak()
    {
        Console.WriteLine("I'm a/an" + Name);
    }

}

// Lớp Dog kế thừa lớp Animal
class Dog:Animal
{
    public override string Name{get;set;}
    public Dog()
    {
        Name = "Dog";
    }
    public override void Speak()
    {
        Console.WriteLine("I'm a/an " + Name);
    }
}

// Lớp Cat kế thừa lớp Animal
class Cat:Animal
{
       public override void Speak()
       {
           Console.WriteLine("Meow, I'm a cat!");
       }
}
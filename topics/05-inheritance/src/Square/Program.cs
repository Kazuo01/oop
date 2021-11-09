// Main program
using System;

class Program
{
    static void Main(string[] args)
    {
        Square sq = new Square(5);
        Console.WriteLine("Dien tich hinh vuong: " + sq.Area().ToString());
    }
}

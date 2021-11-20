// Main program
using System;

class Program
{
    static void Main(string[] args)
    {
        // Tạo đối tượng hình chữ nhật
        Rectangle r = new Rectangle(3,7);
        Console.WriteLine("Dien tich hinh chu nhat: " + r.Area().ToString());

        // Tạo đối tượng hình vuông
        Square sq = new Square(5);
        Console.WriteLine("Dien tich hinh vuong: " + sq.Area().ToString());
    }
}

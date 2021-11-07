/*
Cài đặt lớp Point mô tả các điểm trong mặt phẳng.
*/
using System;
class Point
{
    // Auto-implemented properties
    public double X{get;set;}
    public double Y{get;set;}
    
    // Constructor
    public Point(double x=0, double y=0)
    {
        X = x;
        Y = y;
    }

    // copy constructor
    public Point(Point p)
    {
        X = p.X;
        Y = p.Y;
    }
    // Nhap
    public void Nhap()
    {
        Console.Write("Nhap hoanh do X: ");
        X = double.Parse(Console.ReadLine());
        Console.Write("Nhap tung do Y: ");
        Y = double.Parse(Console.ReadLine());
    }

    public void Xuat()
    {
        Console.WriteLine("({0},{1})", X, Y);
    }
    // Move the point by (dx,dy)
    public void Move(double dx, double dy)
    {
        X += dx;
        Y += dy;
    }


    // Hàm tính khoảng cách từ điểm đến gốc tọa độ
    public double Distance()
    {
        return Math.Sqrt(X*X + Y*Y);
    }

    // ToString() hàm trả về chuỗi biểu diễn đối tượng
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}
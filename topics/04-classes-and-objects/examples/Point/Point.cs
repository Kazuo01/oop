/*
Cài đặt lớp điểm (Point) trong mặt phẳng.
- Các thuộc tính: tọa độ x,y.
- Các phương thức:
+ Nhập 
+ Xuất
+ Dịch chuyển
*/
using System;

// Khai báo lớp Point
class Point
{

// Auto-implemented properties        
    public double X{get;set;}
    public double Y{get;set;}

    // Các phương thức
    // Phương thức thiết lập (constructor)
    public Point(double x=0, double y=0)
    {
        X = x;
        Y = y;
    }
    // Phương thức thiết lập sao chép (copy constructor)
    public Point(Point p)
    {
        Y = p._x;
        Y = p._y;
    }

    // Nhập tọa độ điểm từ bàn phím
    public void Nhap()
    {
        Console.Write("Nhap hoanh do: ");
        X = double.Parse(Console.ReadLine());
        Console.Write("Nhap tung do: ");
        Y = double.Parse(Console.ReadLine());
    }

    // In tọa độ điểm lên màn hình
    public void Xuat()
    {
        Console.WriteLine("({0}, {1})", X, Y);
    }

    // Di chuyển điểm sang vị trí mới
    public void Move(double dx, double dy)
    {
        X += dx;
        Y += dy;
    }
}

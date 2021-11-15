/*
Cài đặt lớp điểm (Point) trong mặt phẳng.
- Các thuộc tính: tọa độ x,y.
- Các phương thức:
+ Nhập 
+ Xuất
+ Di chuyển
*/
using System;

namespace Point
{
    // Khai báo lớp Point
    class Point
    {
        private double _x;  // hoành độ
        private double _y;  // tung độ
        
        public double X{
            get{return _x;} // phương get{return _x} cho phép đọc giá trị biến _x từ bên ngoài
            set{_x = value;} // phương set{_x = value} cho phép thay đổi giá trị biến _x từ bên ngoài
        }
        public double Y{
            get{return _y;} // phương get{return _y} cho phép đọc giá trị biến _y từ bên ngoài
        }

        // Các phương thức
        // Phương thức thiết lập (constructor)
        public Point(double x=0, double y=0)
        {
            _x = x;
            _y = y;
        }
        // Phương thức thiết lập sao chép (copy constructor)
        public Point(Point p)
        {
            _x = p._x;
            _y = p._y;
        }
        // Phương thức hủy (destructor)
        ~Point()
        {
            Console.WriteLine("Destroyed.");
        }
        // Nhập tọa độ điểm từ bàn phím
        public void Nhap()
        {
            Console.Write("Nhap hoanh do: ");
            _x = double.Parse(Console.ReadLine());
            Console.Write("Nhap tung do: ");
            _y = double.Parse(Console.ReadLine());
        }

        // In tọa độ điểm lên màn hình
        public void Xuat()
        {
            Console.WriteLine("({0}, {1})", _x, _y);
        }

        // Di chuyển điểm sang vị trí mới
        public void Move(double dx, double dy)
        {
            _x += dx;
            _y += dy;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Khai báo đối tượng điểm p của lớp Point
            Point p = new Point();
            // Gọi phương thức nhập tọa độ
            p.Nhap();
            // Gọi phương thức xuất tọa độ
            p.Xuat();
            //p.X = 10; // Thay đổi hoành độ của điểm p, thực hiện được vì X cho phép đọc+ ghi
            //p.Y = 20; // Thay đổi tung độ của điểm p, không thực hiện được vì Y chỉ cho phép đọc
            // Dịch chuyển điểm p một khoảng (dx, dy)
            p.Move(2, -3);  // Hoành độ tăng 2, tung độ giảm 3
            // In ra tọa độ sau khi dịch chuyển
            Console.WriteLine("Toa do moi:");
            p.Xuat();
            // Tạo đối tượng mới sử dụng hàm thiết lập:
            Point p2 = new Point(10,20);
            Console.WriteLine("Toa do cua diem p2:");
            p2.Xuat();
            // Sử dụng hàm thiết lập sao chép (tạo một đối tượng mới bằng cách sao chép 1 đối tượng đã có)
            Point p3 = new Point(p2);
            Console.WriteLine("Toa do cua diem p3:");
            p3.Xuat();

        }
    }
}

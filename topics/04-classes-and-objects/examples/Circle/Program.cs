using System;

namespace Circle
{
    // Khai báo lớp tĩnh chứa các hằng số
    public static class Constants{
        public const double PI = 3.1416;
    }
    // Khai báo lớp hình tròn
    class Circle
    {
        private double _r; // bán kính

        public double R{
            get => _r;
            set{value = _r;}
        }
        public Circle(double r) // constructor
        {
            _r = r;
        }
        
        // Hàm thiết lập sao chép - copy constructor
        public Circle(Circle c) 
        {
            _r = c._r; //   Sao chép thuộc tính của đối tượng c sang đối tượng đang xét
        }
        ~Circle()
        {
            Console.WriteLine("The destructor was called.");
        }
        // Phương thức tính diện tích hình tròn
        public double Area()
        {
            // Vì Constants là lớp tĩnh -> truy xuất tới thành viên của lớp
            // theo cú pháp <tên lớp>.<tên biến/hàm thành viên>
            return _r *_r * Constants.PI;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo 1 đối tượng hình tròn
            Circle c = new Circle(5);
            Console.WriteLine("Circle's area = {0}", c.Area());
            Circle c1 = new Circle(c); // Gọi hàm thiết lập sao chép
            // In ra bán kính c1
            Console.WriteLine("Circle's radius = {0}", c.R);
            c.R = 20;
        }
    }
}

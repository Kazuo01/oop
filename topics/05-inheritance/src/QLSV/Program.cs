using System;

namespace QLSV
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng thuộc lớp Người
            /*
            Nguoi n1 = new Nguoi();
            n1.Nhap();
            n1.Xuat();
            */
            // Tạo đối tượng thuộc lớp Sinh viên
            SinhVien sv1 = new SinhVien("Le Van Hoang", false, new DateTime(2001, 08, 15), "62131234", 8.75);
            //sv1.Nhap();
            Console.WriteLine("\nThong tin sinh vien thu 1:");
            sv1.Xuat();
            // Tạo đối tượng sv2 sao chép sv1, sử dụng hàm thiết lập sao chép
            SinhVien sv2 = new SinhVien(sv1);
            Console.WriteLine("\nThong tin sinh vien thu 2:");
            sv1.Xuat();
        }
    }
}

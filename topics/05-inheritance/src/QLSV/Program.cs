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
            SinhVien sv1 = new SinhVien("Le Van Hoang", false, "21/08/2001", "62131234", 8.75);
            //sv1.Nhap();
            sv1.Xuat();
        }
    }
}

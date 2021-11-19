using System;

class Program
{
    static void Main(string[] args)
    {
        // Tạo đối tượng lớp Hình vẽ tổng quát
        HinhVe hv0 = new HinhVe();
        Console.WriteLine("Dien tich = " + hv0.DienTich().ToString());

        // Tạo đối tượng hình vẽ là hình chữ nhật
        HinhVe hv1 = new HinhChuNhat(3,4);
        Console.WriteLine("Hinh ve la {0}", hv1.GetType());
        // Phương thức hv1.DienTich() sẽ được ghi đè (overriden) bởi phương thức HinhChuNhat.DienTich()
        Console.WriteLine("Dien tich = " + hv1.DienTich().ToString());

        // Tạo đối tượng hình vẽ là hình tròn
        HinhVe hv2 = new HinhTron(1);
        Console.WriteLine("Hinh ve la {0}", hv2.GetType());
        // Phương thức hv2.DienTich() sẽ được ghi đè bởi phương thức HinhTron.DienTich()
        Console.WriteLine("Dien tich = " + hv2.DienTich().ToString());
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        // Tạo đối tượng lớp Hình vẽ tổng quát
        HinhVe h = new HinhVe();
        Console.WriteLine("Dien tich = " + h.DienTich().ToString());

        // Tạo đối tượng hình chữ nhật
        HinhVe hChuNhat = new HinhChuNhat(3,4);
        Console.WriteLine("Dien tich = " + hChuNhat.DienTich().ToString());

        // Tạo đối tượng hình tròn
        HinhVe hinhTron = new HinhTron(1);
        Console.WriteLine("Dien tich = " + hinhTron.DienTich().ToString());
    }
}

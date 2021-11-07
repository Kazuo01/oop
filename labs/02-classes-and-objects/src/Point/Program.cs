using System;

class Program
{
    static void Main(string[] args)
    {
        // Tạo mảng 5 điểm
        Points ps = new Points(5);
        ps.Nhap();
        Console.WriteLine("Danh sach cac diem: ");
        ps.Xuat();
        // Tìm điểm xa gốc tọa độ nhất
        Point farestPoint = ps.DiemXaNhat();
        Console.WriteLine("Diem xa goc toa do nhat la: " + farestPoint.ToString());
    }
}


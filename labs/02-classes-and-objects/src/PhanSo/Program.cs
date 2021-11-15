/*
Chương trình xử lý lớp phân số
Program.cs: Chương trình chính
PhanSo.cs: Cài đặt lớp phân số
DSPhanSo.cs: Cài đặt lớp mảng phân số
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        // Create an object
        PhanSo p = new PhanSo(-8,4);
        Console.WriteLine("Phan so ban dau:");
        p.Xuat();   // Gọi hàm Xuat()
        // Toi gian phan so
        p.ToiGian();    // Gọi hàm tối giản
        Console.WriteLine("Phan so toi gian: ");
        Console.WriteLine(p);   // Hàm ToString() trả về chuỗi biểu diễn phân số
                                // vì thế có thể in ra như một chuỗi
        */

        // Tạo mảng các phân số
        DSPhanSo dsPS = new DSPhanSo();
        dsPS.Nhap();
        dsPS.Xuat();

        // Tìm phân số lớn nhất
        PhanSo max = dsPS.Max();
        Console.WriteLine("Phan so lon nhat la: " + max.ToString());

        // Sắp xếp tăng dần
        dsPS.SapXep();
        // Display the sorted array
        Console.WriteLine("Mang sap xep tang dan: ");
        dsPS.Xuat();
        
        // Truy xuất phân số thứ i trong mảng
        int i=1;
        dsPS.DSPS[i].Xuat();

    }
}


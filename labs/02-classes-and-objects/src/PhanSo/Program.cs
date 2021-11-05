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

        // Create an array of Fractions
        DSPhanSo dsPS = new DSPhanSo();
        dsPS.Nhap();
        dsPS.Xuat();
        // Sort the array ascending
        dsPS.SapXep();
        // Display the sorted array
        Console.WriteLine("Mang sap xep tang dan: ");
        dsPS.Xuat();
    }
}


/*
Khai báo lớp người
*/

using System;

class Nguoi
{
    string _hoTen;
    DateTime _ngaySinh;
    bool _gioiTinh;
    
    
    // Constructor
    public Nguoi()
    {

    }
    public Nguoi(string hoTen="", bool gt=false, DateTime ngaySinh=default(DateTime))
    {
        _hoTen = hoTen;
        _gioiTinh = gt;
        _ngaySinh = ngaySinh;
    }

    // copy constructor
    public Nguoi(Nguoi ng)
    {
        _hoTen = ng._hoTen;
        _gioiTinh = ng._gioiTinh;
        _ngaySinh = ng._ngaySinh;
    }

    // Hàm nhập
    public void Nhap()
    {
        Console.Write("Ho ten: ");
        _hoTen = Console.ReadLine();
        
        try{
            Console.Write("Ngay sinh: ");
            _ngaySinh = DateTime.Parse(Console.ReadLine());
        }
        catch{
            Console.WriteLine("Invalid datetime format (year/month/day)");
        }
        
        Console.Write("Gioi tinh (nam 0, nu 1): ");
        _gioiTinh = Convert.ToBoolean(Console.ReadLine());
    }

    // Hàm xuất
    public void Xuat()
    {
        Console.WriteLine("{0}, {1}, {2}", String.Format("{0, -30}", _hoTen), _ngaySinh.ToString("d"), _gioiTinh ? "Nu":"Nam");
    }

}
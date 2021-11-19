using System;

// Cài đặt lớp xe
class Xe
{
    // Các trường (fields)
    protected string _bienSo;
    protected int _namSX;
    protected double _gia;

    // Hàm thiết lập
    public Xe()
    {}
    public Xe(string bienSo, int namSX, double gia)
    {
        _bienSo = bienSo;
        _namSX = namSX;
        _gia = gia;
    }

    // Hàm nhập thông tin của xe
    public void Nhap()
    {
        Console.Write("Bien so: ");
        _bienSo = Console.ReadLine();
        Console.Write("Nam san xuat: ");
        _namSX = int.Parse(Console.ReadLine());
        Console.Write("Gia: ");
        _gia = int.Parse(Console.ReadLine());        
    }

    // Hàm xuất thông tin của xe
    public void Xuat()
    {
        Console.WriteLine("Bien so: {0}\tNam san xuat: {1}\tGia: {2}", _bienSo, _namSX, _gia);
    }
}

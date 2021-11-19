/*
Xây dựng lớp Xe gồm các thuộc tính: Biển số (vd: 79A-12345), năm sản xuất (vd: 2019), giá (đơn vị tính: triệu đồng).
Xây dựng lớp XeCon kế thừa lớp Xe và có thêm thuộc tính: số chỗ ngồi, loại xe (sedal/SUV/bán tải).
Yêu cầu:
a) Cài đặt các lớp với các phương thức sau:
- Phương thức thiết lập có tham số và không có tham số.
- Phương thức Nhap() để nhập thông tin xe.
- Phương thức Xuat() để in thông tin xe.
b) Nhập danh sách n xe con (0 < n < 50)
- In ra danh sách xe và thông số kèm theo.
- Tìm xe có giá thấp nhất, cao nhất.
- Nhập 2 chữ số đầu biển số (ví dụ 79), in ra tất cả xe thuộc tỉnh có biển số đó.
- Sắp xếp danh sách xe theo thứ tự tăng dần của năm sản xuất, in ra danh sách sau sắp xếp.
*/

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

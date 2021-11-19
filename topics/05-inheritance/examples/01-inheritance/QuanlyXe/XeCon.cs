using System;
class XeCon:Xe
{
    private int _soChoNgoi;
    private string _loaiXe;

    // constructors
    public XeCon():base()
    {

    }
    public XeCon(string bienSo, int namSX, double gia, int soChoNgoi, string loaiXe):base(bienSo, namSX, gia)
    {
        _loaiXe = loaiXe;
        _soChoNgoi = soChoNgoi;
    }

    // Hàm nhập thông tin xe con
    public new void Nhap()
    {
        base.Nhap(); // Gọi phương thức nhập của lớp cơ sở
        // Nhập thông tin bổ sung của xe con
        Console.Write("Loai xe (sedan/SUV/Pickup...):");
        _loaiXe = Console.ReadLine();
        Console.Write("So cho ngoi: ");
        _soChoNgoi = int.Parse(Console.ReadLine());
    }

    // Hàm xuất thông tin xe con
    public new void Xuat()
    {
         Console.WriteLine("Bien so: {0}\tNam san xuat: {1}\tGia: {2}\tLoai xe: {3}\tSo cho ngoi: {4}", _bienSo, _namSX, _gia, _loaiXe, _soChoNgoi);
    }
}
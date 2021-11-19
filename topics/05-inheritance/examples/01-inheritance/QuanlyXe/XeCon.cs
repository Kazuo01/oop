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
        Console.WriteLine("Loai xe (sedan/SUV/Pickup...):");
        _loaiXe = Console.ReadLine();
        Console.WriteLine("So cho ngoi: ");
        _soChoNgoi = int.Parse(Console.ReadLine());
    }

    // Hàm xuất thông tin xe con
    public new void Xuat()
    {
        base.Xuat(); // Gọi phương thức nhập của lớ
        // In thông tin bổ sung của xe con
        Console.WriteLine("Loai xe: " + _loaiXe); 
        Console.WriteLine("So cho ngoi: {0}", _soChoNgoi);
    }
}
using System;
//Khai báo lớp Phân số
public class PhanSo
{
    private int _tuSo=0, _mauSo=1; // Đây là dữ liệu riêng (private), không cho phép truy xuất từ bên ngoài lớp

    public int TuSo{        // Thuộc tính (property)
        get{return _tuSo;}  // Đọc giá trị của trường _tuSo từ ngoài lớp
        // get => _tuSo;
        set{_tuSo = value;} // Thay đổi giá trị của trường _tuSo từ ngoài lớp
        // set => _tuSo = value;
    }
    
    public int MauSo{   
        get => _mauSo; // Đọc giá trị của trường _mauSo
                       // Không có phương thức set -> không thay đổi được từ bên ngoài lớp
    }

    // Hàm thiết lập (constructor)
    public PhanSo(int tuSo=0, int mauSo=1)
    {
        // Mẫu số phải khác 0
        if(mauSo == 0)
            throw new ArgumentException("Mau so phai khac 0.", nameof(mauSo));   
        this._tuSo = tuSo;
        this._mauSo = mauSo;
    }

    // Hàm thiết lập sao chép
    public PhanSo(PhanSo p)
    {
        _tuSo = p._tuSo;
        _mauSo = p._mauSo;
    }
    public void Nhap()
    {
        Console.Write("Tu so = ");
        _tuSo = Convert.ToInt32(Console.ReadLine());
        do{
            Console.Write("Mau so = ");
            _mauSo = Convert.ToInt32(Console.ReadLine());
            if(_mauSo == 0) Console.WriteLine("Mau so phai != 0");
        }while(_mauSo == 0);
    }   

    public void Xuat()
    {
        Console.WriteLine("{0}/{1}", _tuSo, _mauSo);
    }
  
    // Tối giản phân số
    public void ToiGian()
    {
        int ucln=1;
        for(int i=Math.Min(Math.Abs(_tuSo), Math.Abs(_mauSo)); i > 1; i--)
            if(_mauSo % i == 0 && _tuSo % i == 0) 
            {
                ucln = i;
                break;
            }
        _tuSo /= ucln;
        _mauSo /= ucln;
    }
    
    // Hàm trả về giá trị của phân số (lấy ts/ms)
    public double GiaTri()
    {
        return Convert.ToDouble(_tuSo)/_mauSo;
    }
    
    // Hàm cộng phân số với một phân số khác
    // = _tuSo/_mauSo + p._tuSo/p._mauSo
    public void Cong(PhanSo p)
    {
        _tuSo = _tuSo * p._mauSo + _mauSo * p._tuSo;
        _mauSo = _mauSo * p._mauSo;
    }


} // End of class PhanSo
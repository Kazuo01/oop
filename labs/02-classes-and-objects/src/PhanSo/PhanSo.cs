/*
Định nghĩa lớp phân số.
*/

using System;
class PhanSo
{
    private int _tuSo, _mauSo;

    public int TuSo{
        get => _tuSo;
        set => _tuSo = value;
    }

    public int MauSo{
        get => _mauSo;
    }

    // Constructor
    public PhanSo(int t=0, int m=1)
    {
        if(m == 0) 
            throw new ArgumentException("Mau so phai khac 0.", nameof(m));
        _tuSo = t;
        _mauSo = m;
    }

    // Copy constructor
    public PhanSo(PhanSo p)
    {
        _tuSo = p._tuSo;
        _mauSo = p._mauSo;
    }

    public void Nhap()
    {
        Console.Write("Tu so = ");
        _tuSo = int.Parse(Console.ReadLine());
        do{
            Console.Write("Mau so = ");
            _mauSo = int.Parse(Console.ReadLine());
        }while(_mauSo == 0);
    }

    public void Xuat()
    {
        Console.WriteLine("{0}/{1}", _tuSo, _mauSo);
    }

    public override string ToString()
    {
        return $"{_tuSo}/{_mauSo}";
    }

    /*
    Phân số được gọi là tối giản khi ước số chung lớn nhất (ucln) của tử số và mẫu số là 1.
    */
    public void ToiGian()
    {
        // Tìm ucln của tử số và mẫu số
        int ucln=1;
        for(int i=Math.Min(Math.Abs(_tuSo), Math.Abs(_mauSo)); i > 1; i--)
            if(_tuSo % i == 0 && _mauSo % i == 0)
            {
                ucln = i;
                break;
            }
        // Chia cả tử số và mẫu số cho ucln -> phân số tối giản
        _tuSo /= ucln;
        _mauSo /= ucln;
    }

    // Tính giá trị phân số
    public double GiaTri{
        get => Convert.ToDouble(_tuSo) / _mauSo;
    }
    
}
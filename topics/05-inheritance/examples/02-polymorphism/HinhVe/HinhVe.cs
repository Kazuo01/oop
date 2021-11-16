/*
Xây dựng lớp hình vẽ
*/

using System;

class HinhVe
{
    public string Ten{get; set;}
    
    public virtual double DienTich()
    {
        return 0;
    }
       
}

// Lớp HinhChuNhat kế thừa lớp hình vẽ
class HinhChuNhat: HinhVe
{
    private double _dai, _rong;
    // constructor
    public HinhChuNhat(double d=0, double r=0)
    {
        _dai = d;
        _rong = r;
    }
    public override double DienTich()
    {
        return _dai * _rong;
    }
}

// Lớp HinhTron kế thừa lớp hình vẽ

class HinhTron:HinhVe
{
    private double _banKinh;

    // constructor
    public HinhTron(double r=0)
    {
        if(r < 0)
            throw new ArgumentOutOfRangeException("Ban kinh phai >=0.", nameof(r));
        _banKinh = r;
    }

    public override double DienTich()
    {
        return _banKinh * _banKinh * 3.1416;    
    }
}
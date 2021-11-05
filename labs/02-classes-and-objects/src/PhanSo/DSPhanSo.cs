/*
Lớp mảng đối tượng phân số.
*/
using System;

class DSPhanSo
{
    private PhanSo[] _dsPS;
    private int _size;

    public void Nhap()
    {
        Console.Write("So luong phan so: ");
        _size = int.Parse(Console.ReadLine());
        _dsPS = new PhanSo[_size];
        for(int i=0; i < _size; i++)
        {
            Console.WriteLine("Nhap phan so thu " + (i+1));
            _dsPS[i] = new PhanSo();
            _dsPS[i].Nhap();
        }        
    }

    public void Xuat()
    {
        for(int i=0; i < _size; i++)
            _dsPS[i].Xuat();
    }

    public void SapXep()
    {
        // Sort ascending
        for(int i=0; i < _size-1; i++)
            for(int j=i+1; j < _size; j++)
                if(_dsPS[i].GiaTri > _dsPS[j].GiaTri)
                {
                    PhanSo tmp = new PhanSo(_dsPS[i]);
                    _dsPS[i] = _dsPS[j];
                    _dsPS[j] = tmp;
                }
    }
}


/*
Lớp mảng đối tượng phân số.
*/
using System;

class DSPhanSo
{
    // fields
    private PhanSo[] _dsPS; // Mảng các phân số, mỗi phần tử là 1 đối tượng của lớp Phân số
    private int _size;  // Số lượng phân số

    public PhanSo[] DSPS
    {
        get => _dsPS;
    }

    // Hàm nhập danh sách phân số
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

    // Hàm xuất danh sách phân số
    public void Xuat()
    {
        for(int i=0; i < _size; i++)
            _dsPS[i].Xuat();
    }

    // Sắp xếp danh sách phân số tăng dần
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

    // Hàm trả về phân số lớn nhất
    public PhanSo Max()
    {
        // Tạo 1 phân số & gán bằng phân số đầu tiên
        PhanSo max = new PhanSo(_dsPS[0]);
        // So sánh với các phân số còn lại & gán
        for(int i=1; i < _size; i++)
            if(_dsPS[i].GiaTri > max.GiaTri) max = _dsPS[i];
        return max;
    }
}


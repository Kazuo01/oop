/*
Lớp Points mô tả các điểm trong mặt phẳng.
*/

using System;
class Points
{
    // Fields
    private Point[] _points;
    private int _nPoints;

    //Constructor: khởi tạo mảng các điểm
    public Points(int nPoints)
    {
        _nPoints = nPoints;
        _points = new Point[nPoints];
    }

    // Hàm nhập: Nhập các điểm từ bàn phím
    public void Nhap()
    {
        for(int i=0; i < _nPoints; i++)
        {
            Console.WriteLine("Nhap diem thu {0}", i+1);
            _points[i] = new Point();
            _points[i].Nhap();
        }       
    }

    // Xuất danh sách các điểm
    public void Xuat()
    {
        for(int i=0; i < _nPoints; i++)
            _points[i].Xuat();
    }

    // Hàm trả về điểm xa gốc tọa độ nhất
    public Point DiemXaNhat()
    {
        // So sánh khoảng cách mỗi điểm đến gốc tọa độ, 
        // điểm nào khoảng cách lớn nhất <-> xa nhất
        Point p = new Point(_points[0]);
        for(int i=1; i < _nPoints; i++)
            if(p.Distance() < _points[i].Distance())
                p = _points[i];
        return p;
    }
}
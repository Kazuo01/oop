/*
Chương trình xử lý lớp phân số
*/

using System;

// Main program 
class Program
{
    static void Main(string[] args)
    {
      /*
      Thao tác với đối tượng đơn lẻ
      */
        PhanSo p1 = new PhanSo(); // Tạo đối tượng phân số
        p1.Nhap();   // Gọi phương thức Nhap()
        p1.Xuat();   // Gọi phương thức Xuat()
        Console.WriteLine("Tu so = {0}", p1.TuSo);   // Thực hiện được vì thuộc tính TuSo cho phép đọc {get;} giá trị _tuSo
        Console.WriteLine("Mau so = {0}", p1.MauSo); // Thực hiện được vì thuộc tính MauSo cho phép đọc {get;} giá trị _mauSo       
        //p1.TuSo = 10;                              // Thực hiện được vì thuộc tính TuSo cho phép thay đổi {set;} giá trị _tuSo
        Console.WriteLine("Tu so = {0}", p1.TuSo);       
        // p.MauSo = 10;                             // Không thực hiện được vì thuộc tính MauSo không cho thay đổi {set;} giá trị _mauSo
        // Tối giản phân số
        p1.ToiGian();
        // In ra phân số tối giản:
        Console.WriteLine("Phan so toi gian:");
        p1.Xuat();
        // Tạo phân số sử dụng hàm thiết lập
        PhanSo p2 = new PhanSo(21,49);
        p2.Xuat();
        p2.ToiGian();
        p2.Xuat();
        // p1 = p1 + p2
        p1.Cong(p2);
        // In ra p1 sau khi cộng thêm p2
        Console.WriteLine("Tong 2 phan so:");
        p1.ToiGian();
        p1.Xuat();
        // Tính tổng 2 phân số, sử dụng toán tử nạp chồng +
        PhanSo p3 = p1 + p2;
        p3.ToiGian();
        Console.WriteLine("Tong 2 phan so: " + p3.ToString());
        
      /*
      Thao tác với mảng các đối tượng
      */
        // Tạo một mảng phân số
        Console.Write("Nhap so luong phan so: ");
        int numberOfElements = int.Parse(Console.ReadLine());
        PhanSo[] psList = new PhanSo[numberOfElements];
        
        // Nhập mảng phân số từ bàn phím
        for(int i=0; i < numberOfElements; i++)
        {
          psList[i] = new PhanSo();
          psList[i].Nhap();
        }

        // In ra mảng phân số
        Console.WriteLine("Cac phan so vua nhap: ");
        for(int i=0; i < numberOfElements; i++)
          psList[i].Xuat();

        // Tìm phân số lớn nhất
        PhanSo psMax = new PhanSo(psList[0]); // psMax = psList[0]  (gọi hàm thiết lập sao chép)
        for(int i=1; i < numberOfElements; i++)
          if(psMax.GiaTri() < psList[i].GiaTri()) psMax = psList[i];
        Console.WriteLine("Phan so lon nhat la: ");
        psMax.Xuat();

        // Sắp xếp danh sách phân số tăng dần
        for(int i=0; i < numberOfElements - 1; i++)
          for(int j=i+1; j < numberOfElements; j++)
            if(psList[i].GiaTri() > psList[j].GiaTri())
            {
              PhanSo tmp = new PhanSo(psList[i]);
              psList[i] = psList[j];
              psList[j] = tmp;
            }

        // In ra mảng phân số đã sắp xếp
        Console.WriteLine("Cac phan so theo thu tu tang dan: ");
        for(int i=0; i < numberOfElements; i++)
          psList[i].Xuat();
    }
}
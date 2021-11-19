using System;

class Program
{
    static void Main(string[] args)
    {
        // Tạo đối tượng lớp Xe
        Xe x1 = new Xe("79A-00123", 2015, 400);
        x1.Xuat();

        // Tạo đối tượng lớp xe con
        XeCon xc1 = new XeCon("80B-12345", 2018, 800, 5, "Sedan");
        xc1.Xuat();

        // Tạo danh sách xe con
        int soLuongXe;
        do{
            Console.Write("Nhap so luong xe con: ");
            soLuongXe = int.Parse(Console.ReadLine());
        }while(soLuongXe <= 0 || soLuongXe > 100);

        XeCon[] dsXeCon = new XeCon[soLuongXe];
        // Nhập thông tin cho từng xe
        for(int i=0; i < soLuongXe; i++)
        {
            Console.WriteLine("Nhap xe thu {0}:", i+1);
            dsXeCon[i] = new XeCon();
            dsXeCon[i].Nhap();
        }

        // Xuất thông tin danh sách xe con
        Console.WriteLine("Danh sach xe con:");
        for(int i=0; i < soLuongXe; i++)
            dsXeCon[i].Xuat();
    }
}


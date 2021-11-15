/*
Minh họa xử lý ngoại lệ (exception handling)
*/
using System;

namespace Circle
{
    class Program
    {
        const double PI=3.1416;
        static void Main(string[] args)
        {
            double r=0, s=0;
            do
            {
                Console.Write("Nhap ban kinh r = ");
                try
                {
                    r = double.Parse(Console.ReadLine());
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Vui long nhap gia tri so!");
                    //Console.WriteLine(ex.Message);
                }
            }while(r <= 0);

            s = r*r*PI;
            Console.WriteLine("Dien tich hinh tron = {0}", s);
        }
    }
}

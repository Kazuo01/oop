using System;

namespace ExceptionHandle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0;
            Console.Write("Nhap n = ");
            try{
                n = int.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine("Gia tri vua nhap khong hop le.");
            }
            finally
            {
                Console.WriteLine("So vua nhap la: {0}", n);
            }
        }
    }
}

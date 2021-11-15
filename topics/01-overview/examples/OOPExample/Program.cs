/*
Minh họa lập trình hướng đối tượng
Input: Mảng các số nguyên
Output: Mảng sắp xếp tăng dần
*/
using System;

// Khai báo lớp Array chứa mảng số nguyên và các xử lý trên mảng
public class Array{
    private int[] numbers; // Dữ liệu/biến thành viên

    // Phương thức (hàm) thiết lập (constructor)
    // Tạo một dãy n phần tử có giá trị ngẫu nhiên trong đoạn [Min, Max]
    public Array(int n, int min=0, int max=50)
    {
        numbers = new int[n];
        Random randNum = new Random();
        for(int i=0; i < numbers.Length; i++)
            numbers[i] = randNum.Next(min, max);
    }

    // Phương thức/Hàm thành viên
    public void Print()
    {
        Console.WriteLine("{0}", string.Join(", ", numbers));
    }

    // Sắp xếp tăng dần
    public void Sort()
    {   
        for(int i=0; i < numbers.Length - 1; i++)
            for(int j=i+1; j < numbers.Length; j++)
                if(numbers[i] > numbers[j])
                {
                    int t = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = t;
                }
    }
}

// Chương trình chính    
class Program
{
    static void Main(string[] args)
    {
        // Gọi phương thức thiết lập (constructor)
        // tạo mảng ngẫu nhiên các số nguyên trong khoảng [0, 30]
        Array myNumbers = new Array(6, 0, 30);
        
        // In mảng - gọi phương thức Print()
        Console.WriteLine("Random numbers:");
        myNumbers.Print();

        // Sắp xếp tăng dần - gọi phương thức Sort()
        myNumbers.Sort();

        // In mảng sau sắp xếp - gọi phương thức Print()
        Console.WriteLine("The numbers in ascending order:");
        myNumbers.Print();
    }
}

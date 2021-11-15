/*
Minh họa lập trình cấu trúc với C#
Input: Dãy số nguyên
Output: Dãy số được sắp xếp tăng dần
*/

using System;

// Chương trình chính
    // Khởi tạo một mảng số nguyên
    int n=6;
    int[] numbers = new int[] {3,8,2,1,6,5};
    
    // Sắp xếp tăng dần - giải thuật đổi chỗ trực tiếp
    SapXepTD(numbers, n);
    
    // In ra danh sách đã sắp xếp
    InMang(numbers, n);

// Hàm sắp xếp mảng tăng dần
static void SapXepTD(int[] a, int n)
{
for(int i=0; i < n-1; i++)
    for(int j=i+1; j < n; j++)
        if(a[i] > a[j])
        {
            int t = a[i];
            a[i] = a[j];
            a[j] = t;
        }
}

// Hàm in mảng
static void InMang(int[] a, int n)
{
    for(int i=0; i < n; i++)
        Console.Write("{0} ", a[i]);
}
/*
Minh họa quan hệ thừa kế & đa hình.
Lớp cơ sở:
Animal, mô tả động vật tổng quát.
Các lớp dẫn xuất từ lớp Animal:
Dog, mô tả loài chó.
Cat, mô tả loài mèo.
*/

using System;

class Animal
{
    private static int _quantity=0; // Số lượng động vật
    public static int Quantity{get => _quantity;}

    // constructor
    public Animal()
    {   // Mỗi khi có 1 đối tượng Animal được tạo mới, tăng số lượng lên 1
        _quantity++;
    }

    // Hàm ảo, hàm này sẽ được ghi đè bởi phương thức cùng tên của lớp con
       public virtual void Speak()
    {
        Console.WriteLine("Halo, I'm an animal.");
    }
}

class Dog:Animal
{
    private static int _quantity=0; // Số lượng chó
    public static new int Quantity{get => _quantity;}
    
    // constructor
    public Dog():base()
    {
        _quantity++;
    }

    // Hàm ghi đè (override)
    public override void Speak()
    {
        Console.WriteLine("Gow gow! I'm a dog");
    }
}

class Cat:Animal
{
    private static int _quantity=0; // Số lượng mèo
    public static new int Quantity{get => _quantity;}
    public Cat():base()
    {
        _quantity++;
    }
    public override void Speak()
    {
        Console.WriteLine("Meow! I'm a cat");
    }
}
<h2 align="center"> 
Thừa kế và Đa hình
</h2>

<div class="header">
    <h3><a href="concepts">Tổng quát hóa và đặc biệt hóa</a></h3>
    <h3><a href="inheritance">Thừa kế (Inheritance)</a></h3>
    <h3><a href="polymorphism">Đa hình (Polymorphism)</a></h3>
</div>

 <h2><a name="concepts">Tổng quát hóa và đặc biệt hóa</a></h2>
 
### Khái niệm
Mối quan hệ tổng quát hóa - đặc biệt hóa (generalization - specialization) rất phổ biến trong thế giới thực. Có những lớp đối tượng là trường hợp đặc biệt của một lớp khác tổng quát hơn; khi đó lớp đặc biệt mang những thuộc tính và hành vi của lớp tổng quát, đồng thời có thêm những thành phần riêng của nó. Ví dụ, cả 3 loài chó, mèo, bò đều thuộc lớp động vật, nhưng mỗi loài lại có những đặc điểm, hành vi riêng (mèo bắt chuột, chó giữ nhà, bò ăn cỏ). Trong trường hợp này, chó, mèo và bò là các trường hợp đặc biệt của lớp động vật; ngược lại, động vật là lớp tổng quát của các loài chó, mèo và bò. Một lớp đặc biệt lại có thể là lớp tổng quát của những lớp khác, chẳng hạn, loài chó có nhiều giống: chó Phú Quốc, chó Shiba, chó Husky,...

Lập trình hướng đối tượng thể hiện mối quan hệ tổng quát hóa - đặc biệt hóa thông qua kỹ thuật thừa kế (inheritance).

### Thừa kế
Thừa kế là một đặc điểm quan trọng hàng đầu của phương pháp lập trình hướng đối tượng, cho phép xây dựng các lớp mới tái sử dụng các thành phần của các lớp khác, đồng thời bổ sung các thành phần mới. Kỹ thuật thừa kế xây dựng lớp cơ sở (base class) gồm các thuộc tính và phương thức cho phép các lớp dẫn xuất (derived classes) của nó sử dụng. 

-Ví dụ: Xét bài toán quản lý tài khoản ngân hàng, có nhiều loại tài khoản ngân hàng khác nhau như: tài khoản tiết kiệm (saving account), tài khoản thanh toán (checking account). Các loại tài khoản này có chung một số thuộc tính (như: số tài khoản, số dư) và phương thức (chẳng hạn, kiểm tra số dư). Vì thế, có thể tạo một lớp cơ sở (lớp tổng quát hóa) của 2 lớp này với các thành phần chung.

- Lớp cơ sở (base class) hay lớp cha (parent): Là lớp cấp quyền thừa kế.
- Lớp dẫn xuất (derived class) hay lớp con (child): Là lớp được hưởng thừa kế.
#### Thừa kế đơn (single inheritance)
- Một lớp chỉ được thừa kế từ một lớp cơ sở.
- Một số ngôn ngữ (như Java, C#) chỉ hỗ trợ thừa kế đơn. Tuy nhiên có thể cài đặt đa thừa kế thông qua lớp giao diện (interfaces).

- Có thể cài đặt thừa kế chuyển tiếp (transitive inheritance). Tức là, lớp C kế thừa lớp B và lớp B lại kế thừa lớp A; khi đó lớp C có thể có những thành phần được chia sẻ từ lớp A.

#### Đa thừa kế (multiple inheritance) 
- Một lớp có thể được thừa kế từ nhiều lớp cơ sở.
- Các ngôn ngữ thông dụng có hỗ trợ đa thừa kế: C++, Python.

## Cài đặt thừa kế trong C#
### Cú pháp

```csharp
[access modifier] class <DerivedClass> : <BaseClass>
{
    // Khai báo dữ liệu của lớp dẫn xuất
    // Khai báo các phương thức của lớp dẫn xuất
} 
```
- Thuộc tính truy cập (access modifier)
  - 
- Ví dụ
```csharp
/*
Lớp Rectangle biểu diễn hình chữ nhật.
Lớp Square biểu diễn hình vuông. Hình vuông là hình chữ nhật có 2 cạnh liên tiếp bằng nhau, do đó là trường hợp đặc biệt của hình chữ nhật.
*/
using System;
class Rectangle
{
    // fields
    protected double _width, _height;

    // constructor
    public Rectangle(double w, double h)
    {
        if(w <= 0 || h <=0)
            throw new ArgumentException("Invalid value.");
        _width = w;
        _height = h;
    }

    // Phương thức tính & trả về diện tích hình chữ nhật
    public double Area()
    {
        return _height * _width;
    }
}

// Lớp hình vuông kế thừa lớp hình chữ nhật
class Square : Rectangle
{
    public Square(double w): base(w, w)
    {
    }
}
```
### Các thành phần không được thừa kế

- Hàm thiết lập tĩnh (khởi tạo dữ liệu tĩnh cho lớp).
- Hàm thiết lập tạo mới đối tượng (instance constructor).
- Hàm hủy (destructor hay finalizer), được trình dọn rác (runtime’s garbage collector) gọi để hủy đối tượng.

### Lớp niêm phong (sealed class)
Còn gọi là lớp cuối cùng (final class), do lớp này không cho phép lớp khác sử dụng lại nó.
- Khi muốn một lớp không cho phép thừa kế, thêm từ khóa `sealed` trước khai báo tên lớp.
- Ví dụ:
```csharp
// Lớp SavingAccount kế thừa lớp Account và không có lớp nào được kế thừa nó.
sealed class SavingAccount : Account
{
    // Các thành phần dữ liệu của lớp SavingAccount
    // Các phương thức của lớp SavingAccount
}
```
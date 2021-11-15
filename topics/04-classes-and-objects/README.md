<h2 align="center"> 
Lớp và đối tượng
</h2>

<div class="header">
    <h3>Khái niệm</h3>
    <h3>Cài đặt lớp</h3>
    <h3>Thiết lập tính bao đóng (ecapsulation)</h3>
    <h3>Hàm thiết lập, hàm hủy (constructor/destructor)</h3>
    <h3>Thành phần tĩnh (static members)</h3>
    <h3>Định nghĩa toán tử trên lớp (operator overloading)</h3>
</div>

 <h2>Khái niệm</h2>
 Hai khái niệm cơ bản của cách tiếp cận hướng đối tượng (bao gồm cả lập trình) là lớp (class) và đối tượng (object).

 - Một lớp là tập hợp các đối tượng có đặc điểm, hành vi giống nhau.
 - Ở góc độ lập trình, lớp là kiểu dữ liệu do người dùng định nghĩa (user-defined type), gồm có dữ liệu (gọi là biến thành viên - member variables) và các phương thức xử lý xoay quanh dữ liệu (gọi là hàm thành viên - member variables).
 - Một đối tượng là một thực thể (instance) của lớp. Đối tượng được quyền truy xuất mọi thuộc tính và phương thức của lớp. 
 - Có thể khai báo đối tượng đơn lẻ, hoặc mảng (array) hay bộ sưu tập (collection) các đối tượng.
 
 <h2>Cài đặt lớp</h2>

```cs
[access modifier] class <ClassName>
{
    // Khai báo các thuộc tính (biến thành viên)
    // Khai báo các phương thức (hàm thành viên)
}
```
Trong đó:
- Phạm vi truy cập (access modifier) xác định mức độ

All types and type members have an accessibility level. The accessibility level controls whether they can be used from other code in your assembly or other assemblies. Use the following access modifiers to specify the accessibility of a type or member when you declare it:

public: The type or member can be accessed by any other code in the same assembly or another assembly that references it. The accessibility level of public members of a type is controlled by the accessibility level of the type itself.
private: The type or member can be accessed only by code in the same class or struct.
protected: The type or member can be accessed only by code in the same class, or in a class that is derived from that class.
internal: The type or member can be accessed by any code in the same assembly, but not from another assembly.
protected internal: The type or member can be accessed by any code in the assembly in which it's declared, or from within a derived class in another assembly.
private protected: The type or member can be accessed only within its declaring assembly, by code in the same class or in a type that is derived from that class.

 <h2>So sánh lớp và cấu trúc</h2>
- Ngôn ngữ C# cung cấp 2 kiểu dữ liệu do người dùng định nghĩa là lớp (class) và cấu trúc (struct).
- Lớp là kiểu dữ liệu tham chiếu (refernce type), một biến đối tượng tham chiếu đến địa chỉ của đối tượng trong vùng nhớ gọi là "managed heap". Nếu một biến đối tượng khác cùng lớp được gán bằng biến đối tượng trước đó, thì cả hai biến cùng tham chiếu đến cùng một đối tượng trong bộ nhớ.

### <a name="resources">Tài liệu tham khảo</a>

#### [Microsoft: .NET Framework documentation](https://docs.microsoft.com/en-us/dotnet/framework/)
#### [Microsoft: C# tutorial](https://docs.microsoft.com/en-us/dotnet/csharp/)
#### [Microsoft: .NET tutorial](https://dotnet.microsoft.com/learn/dotnet/in-browser-tutorial/)
#### [W3Schools.com: C# tutorial](https://www.w3schools.com/cs/index.php/)
#### [Visual Studio Code: Working with C#](https://code.visualstudio.com/docs/languages/csharp/)

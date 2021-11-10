### Quy cách đặt tên trong C# (naming conventions)
- Việc đặt tên theo quy cách nhằm mục đích tạo ra cách trình bày mã nguồn nhất quán, giúp dễ đọc dễ hiểu hơn.
- Các cách đặt tên phổ biến:
- Pascal Casing: Ký tự đầu của mỗi từ viết hoa (uppercase), còn lại là chữ thường (lowercase). Ví dụ: `AccountNumber`.
- Camel Casing: Từ đầu tiên viết thường, các từ tiếp theo dạng Pascal Case. Ví dụ: `namSanXuat`.

- Trong C#, khi một tên gồm nhiều từ, không nên sử dụng dấu gạch dưới `_`, thay vào đó sử dụng cách viết hoa để phân biệt các từ.

- Đặt tên theo `PascalCase` đối với:
    - Lớp (class), bản ghi (record) hay cấu trúc (struct).
    - Giao diện (interface). Đối với lớp đặc biệt này bổ sung ký tự `I` ở đầu, ví dụ: `IAnimal`.
    - Các thành viên có thuộc tính `public` của lớp (các trường, thuộc tính, phương thức...).
- Đặt tên theo `camelCase` đối với:
    - Các thành phần dữ liệu riêng (private) hoặc nội bộ (internal), thêm dấu `_` ở đầu. 
    
    - Ví dụ:
    ```csharp
    public class Car
    {
        private string _make;
        private int _manufacturerYear;
    }
    ``` 

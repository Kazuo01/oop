## Quy cách đặt tên trong C# (naming conventions)
### Mục đích của đặt tên có quy cách
- Việc đặt tên theo quy cách giúp trình bày mã nguồn nhất quán, dễ đọc dễ hiểu hơn.
- Các cách đặt tên phổ biến:
    - Pascal Casing: Ký tự đầu của mỗi từ viết hoa (uppercase), còn lại là chữ thường (lowercase). Ví dụ: `AccountNumber`.
    - Camel Casing: Từ đầu tiên viết thường, các từ tiếp theo dạng Pascal Case. Ví dụ: `namSanXuat`.

### Cách đặt tên trong C#
- Đặt tên kiểu `PascalCase` đối với:
    - Lớp (class), bản ghi (record) hay cấu trúc (struct).
    - Giao diện (interface). Đối với lớp đặc biệt này bổ sung ký tự `I` ở đầu, ví dụ: `IAnimal`.
    - Các thành viên có thuộc tính `public` của lớp (các trường, thuộc tính, phương thức...).
- Đặt tên kiểu `camelCase` đối với:
    - Tham số của hàm.
    - Các thành phần dữ liệu riêng (private) hoặc nội bộ (internal), thêm dấu `_` ở đầu. 
    - Ví dụ:
    ```csharp
    // Khai báo lớp xe hơi
    public class Car
    {
        // Fields
        private string _make;   // Hãng sản xuất
        private int _manufacturerYear;  // Năm sản xuất

        // Constructor
        public Car(string make, int manufacturerYear)
        {
            _make = make;
            _manufacturerYear = manufacturerYear;
        }
    }
    ``` 

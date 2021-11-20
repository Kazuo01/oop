using System;

/* Lớp hình vuông kế thừa lớp hình chữ nhật các thành phần:
- Chiều dài, rộng
- Phương thức tính diện tích
*/
class Square : Rectangle
{
    public Square(double w): base(w, w)
    {
    }
}
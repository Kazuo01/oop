/*
Tính tiền taxi dựa vào quãng đường đi và bảng giá
Bảng giá:
Số km <= 1: 15000 đ
Từ km thứ 2 đến km 5: 13500 đ/km
Từ km thứ 6 trở đi: 11000 đ/km
Nếu số km > 100 thì giảm 10% tổng số tiền phải trả.

Input: Quãng đường (km)
Output: Số tiền phải trả
*/
using System;

// Các mốc khoảng cách di chuyển và mức giá tương ứng
const double KhoangCach1=1, KhoangCach2=5, KhoangCach3=100;
const double Gia1=15000, Gia2=13500, Gia3=11000;
const double HSGiamGia=0.1; // Hệ số giảm giá (10%)
double quangDuong, soTien=0;
bool inputOK=false;

// Input
Console.WriteLine("Nhap quang duong di (km):");

/*
Kiểm soát việc nhập dữ liệu 
-> yêu cầu nhập lại cho đến khi thỏa mãn là giá trị số > 0
*/
do{
    // Hàm ReadLine() trả về chuỗi ký tự nhập từ bàn phím 
    // -> cần thực hiện chuyển chuỗi ký tự sang kiểu dữ liệu phù hợp
    inputOK = double.TryParse(Console.ReadLine(), out quangDuong);
    if(!inputOK || quangDuong <= 0) 
        Console.WriteLine("Quang duong phai la so > 0.");
} while(!(inputOK && quangDuong > 0));

// Process 
if(quangDuong <= KhoangCach1) 
    soTien = Gia1;
else    if(quangDuong <= KhoangCach2) 
            soTien = KhoangCach1 * Gia1 + (quangDuong - KhoangCach1) * Gia2;
        else    if(quangDuong <= KhoangCach3) 
                    soTien = KhoangCach1 * Gia1 + (KhoangCach2 - KhoangCach1) * Gia2 
                    + (quangDuong - KhoangCach2) * Gia3;
                else 
                    soTien = (KhoangCach1 * Gia1 + (KhoangCach2 - KhoangCach1) * Gia2 
                    + (quangDuong - KhoangCach2) * Gia3) * (1 - HSGiamGia);
// Output
Console.WriteLine("Quang duong: {0:0.00} (km), so tien: {1:C} (VND)", quangDuong, soTien);

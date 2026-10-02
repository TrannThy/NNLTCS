using System;
using System.Collections.Generic;
using System.Linq;
class Bai3_1
{
      // Bài 3.1. thống kê mảng số
public static void Run()
{
    int[] mangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };

    Console.WriteLine("BÀI 3.1");

    // câu a
    int tongSoPhanTu = mangSo.Count();
    int soChan = mangSo.Count(x => x % 2 == 0);
    int soLe = mangSo.Count(x => x % 2 != 0);

    Console.WriteLine("Câu a - Thống kê số phần tử:");
    Console.WriteLine("Tổng số phần tử: " + tongSoPhanTu);
    Console.WriteLine("Số phần tử chẵn: " + soChan);
    Console.WriteLine("Số phần tử lẻ: " + soLe);

    Console.WriteLine();

    // câu b
    int tongGiaTri = mangSo.Sum();
    int giaTriLonNhat = mangSo.Max();
    int giaTriNhoNhat = mangSo.Min();

    Console.WriteLine("Câu b - Thống kê giá trị:");
    Console.WriteLine("Tổng các giá trị: " + tongGiaTri);
    Console.WriteLine("Giá trị lớn nhất: " + giaTriLonNhat);
    Console.WriteLine("Giá trị nhỏ nhất: " + giaTriNhoNhat);

    Console.WriteLine();

    // câu c
    int soGiaTriKhacNhau = mangSo.Distinct().Count();

    Console.WriteLine("Câu c - Số giá trị khác nhau:");
    Console.WriteLine("Có " + soGiaTriKhacNhau + " giá trị khác nhau");

    Console.WriteLine();

    //câu d
    var cacNhom = mangSo.GroupBy(x => x % 5);

    Console.WriteLine("Câu d - Phân nhóm theo số dư khi chia cho 5:");

    foreach (var nhom in cacNhom)
    {
        Console.Write("Số dư " + nhom.Key + ": ");

        foreach (var x in nhom)
        {
            Console.Write(x + " ");
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}
}
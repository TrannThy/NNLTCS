using System;
using System.Collections.Generic;
using System.Linq;
class Bai3_2
{
     // Bài 3.2. thống kê mảng chuỗi
public static void Run()
{
    string[] monAn =
    {
        "Bún bò Huế",
        "Hủ tiếu heo",
        "Bánh canh",
        "Bánh mì",
        "Nước Cà phê",
        "Mì quảng",
        "Cơm tấm",
        "Nước Chanh dây",
        "Mì xào",
        "Bún riêu",
        "Bánh cuốn",
        "Mì gói",
        "Bún chả",
        "Hủ tiếu Nam vang"
    };

    Console.WriteLine("BÀI 3.2");


    // câu a
    int doDaiNhoNhat = monAn.Min(x => x.Length);
    int doDaiLonNhat = monAn.Max(x => x.Length);

    var nganNhat = monAn.Where(x => x.Length == doDaiNhoNhat);
    var daiNhat = monAn.Where(x => x.Length == doDaiLonNhat);

    Console.WriteLine("Câu a - Các món ăn có chiều dài ngắn nhất:");
    foreach (var x in nganNhat)
    {
        Console.WriteLine(x + " (" + x.Length + " ký tự)");
    }

    Console.WriteLine("Các món ăn có chiều dài dài nhất:");
    foreach (var x in daiNhat)
    {
        Console.WriteLine(x + " (" + x.Length + " ký tự)");
    }

    Console.WriteLine();


    // câu b
    var cacNhom = monAn.GroupBy(x => x.Split(' ')[0]);

    Console.WriteLine("Câu b - Phân nhóm theo từ đầu tiên:");

    foreach (var nhom in cacNhom)
    {
        Console.WriteLine("Nhóm " + nhom.Key + ":");

        foreach (var mon in nhom)
        {
            Console.WriteLine("- " + mon);
        }
    }

    Console.WriteLine();


    // câu c
    int soMonBanh = monAn.Count(x => x.StartsWith("Bánh"));

    Console.WriteLine("Câu c - Số món có từ đầu tiên là 'Bánh':");
    Console.WriteLine(soMonBanh);
}
}

using System;
using System.Collections.Generic;
using System.Linq;
class Bai2_1
{
     // bài 2.1.truy vấn mảng số nguyên
    public static void Run()
    {
        int[] mangSo = {50, 42, 16, 3, 9, 8, 12, 7, 24, 0};

        // câu a: liệt kê các phần tử chia hết cho 4 và 3
        var cauA = mangSo.Where(x=>x%4 == 0 && x%3 == 0);

        Console.WriteLine("BÀI 2.1");
        Console.WriteLine("Cau a - cac phan tu chia het cho 4 va 3:");
        foreach (var x in cauA)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();
        Console.WriteLine();


        // câu b: liệt kê các phần tử nhỏ hơn hoặc bằng 3
        var cauB = mangSo.Where(x=>x<=3);

        Console.WriteLine("Cau b - cac phan tu nho hon hoac bang 3:");
        foreach (var x in cauB)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();
        Console.WriteLine();

        // câu c: Số chẵn chia đôi, số lẻ giữ nguyên
        var cauC = mangSo.Select(x=>x %2 == 0?x/2 : x);

        Console.WriteLine("cau c - so chan chia doi, so le giu nguyen");
        foreach (var x in cauC)
        {
            Console.Write(x + " ");
        }

        Console.WriteLine();
    }
}
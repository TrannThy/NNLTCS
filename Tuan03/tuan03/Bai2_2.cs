using System;
using System.Collections.Generic;
using System.Linq;
class Bai2_2
{
         // Bài 2.2. truy vấn mảng chuỗi
    public static void Run()
    {
        string[] mangChuoi ={"đầu", "lòng", "hai", "ả", "tố", "nga","Thúy", "Kiều", "là", "chị", "em", "là","Thúy", "Vân"};
        // tâu a
        // lấy các phần tử có 4 ký tự
        // sau đó sắp xếp tăng dần theo ký tự đầu tiên
        var cauA = mangChuoi
            .Where(x => x.Length == 4)
            .OrderBy(x => x[0]);

        Console.WriteLine("BÀI 2.2:");

        Console.WriteLine("Câu a - Các phần tử có 4 ký tự, sắp xếp tăng dần theo ký tự đầu tiên:");

        foreach (var x in cauA)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
        // câu b
        // biến đổi thành: chữ thường - CHỮ HOA
        var cauB = mangChuoi
            .Select(x => x.ToLower() + " - " + x.ToUpper());

        Console.WriteLine("Câu b - Chữ thường - CHỮ HOA:");

        foreach (var x in cauB)
        {
            Console.WriteLine(x);
        }
        Console.WriteLine();
        // câu c
        // lấy các phần tử có chứa ký tự "u"
        var cauC = mangChuoi
            .Where(x => x.Contains("u"));

        Console.WriteLine("Câu c - Các phần tử có chứa ký tự 'u':");

        foreach (var x in cauC)
        {
            Console.Write(x + " ");
        }

        Console.WriteLine();
        Console.WriteLine();


        // câu d
        // chọn các phần tử bắt đầu bằng chữ in hoa
        var cauD = mangChuoi
            .Where(x => x.Length > 0 && char.IsUpper(x[0]));

        Console.WriteLine("Câu d - Các từ bắt đầu bằng chữ in hoa:");

        foreach (var x in cauD)
        {
            Console.Write(x + " ");
        }

        Console.WriteLine();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
class Bai4_1
{
    
    //câu 4
     public static void Run()
    {
        var ds = DuLieu.DS_Mon();

        Console.WriteLine("BÀI 4.1");
        Console.WriteLine("DANH SÁCH MÔN HỌC:");

        foreach (var mon in ds)
        {
            Console.WriteLine(
                mon.MaMon + " - " +
                mon.TenMon + " - " +
                mon.He + " - " +
                mon.SoTiet + " tiết"
            );
        }
    }
}
using System.Collections.Generic;
using System;
public class He
{
    public string MaHe { get; set; } = "";
    public string TenHe { get; set; } = "";
}
public class DuLieuHe
{
    public static List<He> DS_He()
    {
        List<He> ds = new List<He>
        {
            new He
            {
                MaHe = "KTV",
                TenHe = "Kỹ thuật viên"
            },

            new He
            {
                MaHe = "CD",
                TenHe = "Chuyên đề"
            },

            new He
            {
                MaHe = "QT",
                TenHe = "Chứng chỉ quốc tế"
            }
        };

        return ds;
    }
}
class Bai6_1
{
    public static void Run()
    {
        List<He> ds = DuLieuHe.DS_He();

        Console.WriteLine("BÀI 6.1 ");
        Console.WriteLine("DANH SÁCH HỆ:");

        foreach (var he in ds)
        {
            Console.WriteLine(
                he.MaHe + " - " + he.TenHe
            );
        }
    }
}
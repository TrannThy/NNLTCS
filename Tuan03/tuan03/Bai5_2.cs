using System;
using System.Collections.Generic;
using System.Linq;

public class Bai5_2
{
    public static void Run()
    {
        List<MonHoc> ds = DuLieu.DS_Mon();

        Console.WriteLine(" BÀI 5.2 ");

        // Câu a
        int tongSoMon = ds.Count();

        Console.WriteLine("Câu a - Tổng số môn hiện có:");
        Console.WriteLine(tongSoMon);

        Console.WriteLine();

        // Câu b
        int soMonLapTrinh = ds.Count(
            x => x.TenMon.StartsWith("Lập trình")
        );

        Console.WriteLine("Câu b - Số môn có tên bắt đầu bằng 'Lập trình':");
        Console.WriteLine(soMonLapTrinh);

        Console.WriteLine();

        // Câu c
        int tongTietKTV = ds
            .Where(x => x.He == "KTV")
            .Sum(x => x.SoTiet);

        Console.WriteLine("Câu c - Tổng số tiết của hệ KTV:");
        Console.WriteLine(tongTietKTV);

        Console.WriteLine();

        // Câu d
        var cauD = ds
            .GroupBy(x => x.He)
            .Select(nhom => new
            {
                He = nhom.Key,
                TongSoMon = nhom.Count()
            });

        Console.WriteLine("Câu d - Tổng số môn của mỗi hệ:");

        foreach (var nhom in cauD)
        {
            Console.WriteLine(
                "Hệ: " + nhom.He +
                " - Tổng số môn: " + nhom.TongSoMon
            );
        }

        Console.WriteLine();

        // Câu e
        var cauE = ds
            .GroupBy(x => x.SoTiet)
            .OrderByDescending(nhom => nhom.Key)
            .Select(nhom => new
            {
                SoTiet = nhom.Key,
                TongSoMon = nhom.Count()
            });

        Console.WriteLine("Câu e - Nhóm theo số tiết:");

        foreach (var nhom in cauE)
        {
            Console.WriteLine(
                "Số tiết: " + nhom.SoTiet +
                " - Tổng số môn: " + nhom.TongSoMon
            );
        }

        Console.WriteLine();

        // Câu f
        byte soTietCaoNhat = ds.Max(x => x.SoTiet);

        var cauF = ds.Where(x => x.SoTiet == soTietCaoNhat);

        Console.WriteLine("Câu f - Môn học có số tiết cao nhất:");

        foreach (var mon in cauF)
        {
            Console.WriteLine(
                mon.MaMon + " - " +
                mon.TenMon + " - " +
                mon.He + " - " +
                mon.SoTiet + " tiết"
            );
        }

        Console.WriteLine();

                // Câu g
        // Thống kê theo Hệ:
        // tổng số môn, tổng số tiết, số tiết cao nhất, số tiết thấp nhất
        var cauG = ds
            .GroupBy(x => x.He)
            .Select(nhom => new
            {
                He = nhom.Key,
                TongSoMon = nhom.Count(),
                TongSoTiet = nhom.Sum(x => x.SoTiet),
                SoTietCaoNhat = nhom.Max(x => x.SoTiet),
                SoTietThapNhat = nhom.Min(x => x.SoTiet)
            });

        Console.WriteLine("Câu g - Thống kê theo Hệ:");

        foreach (var nhom in cauG)
        {
            Console.WriteLine(
                "Hệ: " + nhom.He +
                " - Tổng số môn: " + nhom.TongSoMon +
                " - Tổng số tiết: " + nhom.TongSoTiet +
                " - Cao nhất: " + nhom.SoTietCaoNhat +
                " - Thấp nhất: " + nhom.SoTietThapNhat
            );
        }

        Console.WriteLine();


        // Câu h
        // Liệt kê các môn học được phân nhóm theo Hệ
        var cauH = ds
            .GroupBy(x => x.He);

        Console.WriteLine("Câu h - Các môn học phân nhóm theo Hệ:");

        foreach (var nhom in cauH)
        {
            Console.WriteLine("Hệ: " + nhom.Key);

            foreach (var mon in nhom)
            {
                Console.WriteLine(
                    "- " + mon.MaMon +
                    " - " + mon.TenMon +
                    " - " + mon.SoTiet + " tiết"
                );
            }
        }

        Console.WriteLine();


        // Câu i
        // Phân nhóm theo Số tiết
        // Sắp xếp tăng dần theo Số tiết
        var cauI = ds
            .GroupBy(x => x.SoTiet)
            .OrderBy(nhom => nhom.Key);

        Console.WriteLine("Câu i - Các môn học phân nhóm theo Số tiết:");

        foreach (var nhom in cauI)
        {
            Console.WriteLine("Số tiết: " + nhom.Key);

            foreach (var mon in nhom)
            {
                Console.WriteLine(
                    "- " + mon.MaMon +
                    " - " + mon.TenMon
                );
            }
        }

        Console.WriteLine();


        // Câu j
        // Với hệ KTV, phân nhóm theo học phần HP2, HP3, HP4, HP5
        // Sắp xếp theo Mã môn
        var cauJ = ds
            .Where(x => x.He == "KTV")
            .GroupBy(x => x.MaMon.Substring(0, 3))
            .OrderBy(nhom => nhom.Key);

        Console.WriteLine("Câu j - Hệ KTV phân nhóm theo học phần:");

        foreach (var nhom in cauJ)
        {
            Console.WriteLine("Học phần: " + nhom.Key);

            foreach (var mon in nhom.OrderBy(x => x.MaMon))
            {
                Console.WriteLine(
                    "- " + mon.MaMon +
                    " - " + mon.TenMon
                );
            }
        }

        Console.WriteLine();


        // Câu k
        // Phân nhóm theo Hệ
        // Chỉ lấy các môn có Số tiết > 40
        // Trong mỗi nhóm sắp xếp theo Mã môn
        var cauK = ds
            .Where(x => x.SoTiet > 40)
            .GroupBy(x => x.He);

        Console.WriteLine("Câu k - Phân nhóm theo Hệ, Số tiết > 40:");

        foreach (var nhom in cauK)
        {
            Console.WriteLine("Hệ: " + nhom.Key);

            foreach (var mon in nhom.OrderBy(x => x.MaMon))
            {
                Console.WriteLine(
                    "- " + mon.MaMon +
                    " - " + mon.TenMon +
                    " - " + mon.SoTiet + " tiết"
                );
            }
        }

        Console.WriteLine();
    }

}
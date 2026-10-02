using System;
using System.Collections.Generic;
using System.Linq;

class Bai6_2
{
    public static void Run()
    {
        List<MonHoc> dsMon = DuLieu.DS_Mon();
        List<He> dsHe = DuLieuHe.DS_He();

        Console.WriteLine(" BÀI 6.2 - JOIN VÀ CÁC TOÁN TỬ TẬP HỢP ");
        Console.WriteLine();

        // CÂU a
        // Dùng join để liệt kê:
        // Tên hệ, Mã môn, Tên môn

        var cauA =
            from he in dsHe
            join mon in dsMon
            on he.MaHe equals mon.He
            select new
            {
                TenHe = he.TenHe,
                MaMon = mon.MaMon,
                TenMon = mon.TenMon
            };

        Console.WriteLine("Câu a - Dùng JOIN: Tên hệ, Mã môn, Tên môn:");

        foreach (var x in cauA)
        {
            Console.WriteLine(
                "- " + x.TenHe +
                " | " + x.MaMon +
                " | " + x.TenMon
            );
        }

        Console.WriteLine();

        // CÂU b
        // Liệt kê cả những hệ chưa có môn học
        // LEFT OUTER JOIN


        var cauB =
            from he in dsHe
            join mon in dsMon
            on he.MaHe equals mon.He
            into nhomMon
            from mon in nhomMon.DefaultIfEmpty()
            select new
            {
                MaHe = he.MaHe,
                TenHe = he.TenHe,
                MaMon = mon == null ? "" : mon.MaMon,
                TenMon = mon == null ? "" : mon.TenMon
            };

        Console.WriteLine("Câu b - LEFT OUTER JOIN, bao gồm cả hệ chưa có môn:");

        foreach (var x in cauB)
        {
            Console.WriteLine(
                "Hệ: " + x.MaHe +
                " - " + x.TenHe +
                " | Môn: " + x.MaMon +
                " - " + x.TenMon
            );
        }

        Console.WriteLine();



        // CÂU c
        // Liệt kê cả:
        // - Hệ chưa có môn học
        // - Môn học chưa khai báo hệ

        var cauC_He =
            from he in dsHe
            join mon in dsMon
            on he.MaHe equals mon.He
            into nhomMon
            where !nhomMon.Any()
            select he;

        var cauC_Mon =
            from mon in dsMon
            join he in dsHe
            on mon.He equals he.MaHe
            into nhomHe
            where !nhomHe.Any()
            select mon;

        Console.WriteLine("Câu c - Hệ chưa có môn học:");

        foreach (var he in cauC_He)
        {
            Console.WriteLine(
                "- " + he.MaHe +
                " | " + he.TenHe
            );
        }

        Console.WriteLine("Câu c - Môn học chưa khai báo hệ:");

        foreach (var mon in cauC_Mon)
        {
            Console.WriteLine(
                "- " + mon.MaMon +
                " | " + mon.TenMon +
                " | Hệ: " + mon.He
            );
        }

        Console.WriteLine();



        // CÂU d
        // Chỉ liệt kê những:
        // - Hệ chưa có môn học
        // - Môn học chưa khai báo hệ


        var cauD_He =
            from he in dsHe
            join mon in dsMon
            on he.MaHe equals mon.He
            into nhomMon
            where !nhomMon.Any()
            select he;

        var cauD_Mon =
            from mon in dsMon
            join he in dsHe
            on mon.He equals he.MaHe
            into nhomHe
            where !nhomHe.Any()
            select mon;

        Console.WriteLine("Câu d - Chỉ lấy các hệ chưa có môn học:");

        foreach (var he in cauD_He)
        {
            Console.WriteLine(
                "- " + he.MaHe +
                " | " + he.TenHe
            );
        }

        Console.WriteLine("Câu d - Chỉ lấy các môn học chưa khai báo hệ:");

        foreach (var mon in cauD_Mon)
        {
            Console.WriteLine(
                "- " + mon.MaMon +
                " | " + mon.TenMon +
                " | Hệ: " + mon.He
            );
        }

        Console.WriteLine();


        // CÂU e
        // Lấy 5 môn học đầu tiên có số tiết giảm dần
        // Hiển thị:
        // Tên hệ, Mã môn, Tên môn, Số tiết


        var cauE =
            (from mon in dsMon
             join he in dsHe
             on mon.He equals he.MaHe
             orderby mon.SoTiet descending
             select new
             {
                 TenHe = he.TenHe,
                 MaMon = mon.MaMon,
                 TenMon = mon.TenMon,
                 SoTiet = mon.SoTiet
             })
            .Take(5);

        Console.WriteLine("Câu e - 5 môn học có số tiết giảm dần:");

        foreach (var x in cauE)
        {
            Console.WriteLine(
                "- " + x.TenHe +
                " | " + x.MaMon +
                " | " + x.TenMon +
                " | " + x.SoTiet + " tiết"
            );
        }

        Console.WriteLine();


        // CÂU f
        // Tổng số môn học của mỗi hệ:
        // Mã hệ, Tên hệ, Tổng số môn


        var cauF =
            from he in dsHe
            join mon in dsMon
            on he.MaHe equals mon.He
            into nhomMon
            select new
            {
                MaHe = he.MaHe,
                TenHe = he.TenHe,
                TongSoMon = nhomMon.Count()
            };

        Console.WriteLine("Câu f - Tổng số môn học của mỗi hệ:");

        foreach (var x in cauF)
        {
            Console.WriteLine(
                "- " + x.MaHe +
                " | " + x.TenHe +
                " | Tổng số môn: " + x.TongSoMon
            );
        }

        Console.WriteLine();


        // CÂU g
        // Có bao nhiêu loại Số tiết khác nhau?


        int cauG = dsMon
            .Select(x => x.SoTiet)
            .Distinct()
            .Count();

        Console.WriteLine("Câu g - Số loại Số tiết khác nhau:");

        Console.WriteLine(
            "Có " + cauG + " loại số tiết khác nhau."
        );

        Console.WriteLine();


        // CÂU h
        // Tìm môn học đầu tiên có tên bắt đầu bằng "Lập trình"


        var cauH = dsMon
            .FirstOrDefault(x => x.TenMon.StartsWith("Lập trình"));

        Console.WriteLine(
            "Câu h - Môn học đầu tiên có tên bắt đầu bằng 'Lập trình':"
        );

        if (cauH != null)
        {
            Console.WriteLine(
                "- " + cauH.MaMon +
                " | " + cauH.TenMon +
                " | Hệ: " + cauH.He +
                " | " + cauH.SoTiet + " tiết"
            );
        }
        else
        {
            Console.WriteLine("Không tìm thấy môn học.");
        }

        Console.WriteLine();


        // CÂU i
        // Liệt kê các môn theo từng hệ,
        // đánh số thứ tự trong mỗi nhóm


        var cauI =
            dsMon
                .GroupBy(x => x.He)
                .OrderBy(nhom => nhom.Key)
                .Select(nhom => new
                {
                    He = nhom.Key,
                    MonHoc = nhom
                        .OrderBy(x => x.MaMon)
                        .Select((mon, index) => new
                        {
                            STT = index + 1,
                            MaMon = mon.MaMon,
                            TenMon = mon.TenMon,
                            SoTiet = mon.SoTiet
                        })
                });

        Console.WriteLine("Câu i - Các môn học phân nhóm theo Hệ:");

        foreach (var nhom in cauI)
        {
            Console.WriteLine("Hệ: " + nhom.He);

            foreach (var mon in nhom.MonHoc)
            {
                Console.WriteLine(
                    "  " + mon.STT + ". " +
                    mon.MaMon +
                    " | " + mon.TenMon +
                    " | " + mon.SoTiet + " tiết"
                );
            }

            Console.WriteLine();
        }
    }
}

class Bai5_1
{
            // Bài 5.1. truy vấn cơ bản
    public static void Run()
    {
        List<MonHoc> ds = DuLieu.DS_Mon();

        Console.WriteLine(" BÀI 5.1 ");


        // câu a
        // liệt kê tên các môn học bắt đầu bằng "Lập trình"
        var cauA = ds
            .Where(x => x.TenMon.StartsWith("Lập trình"))
            .Select(x => x.TenMon);

        Console.WriteLine("Câu a - Các môn học bắt đầu bằng 'Lập trình':");

        foreach (var tenMon in cauA)
        {
            Console.WriteLine(tenMon);
        }

        Console.WriteLine();


        // câu b
        // môn thuộc hệ CD
        // sắp xếp số tiết giảm dần
        // nếu cùng số tiết thì mã môn tăng dần
        var cauB = ds
            .Where(x => x.He == "CD")
            .OrderByDescending(x => x.SoTiet)
            .ThenBy(x => x.MaMon);

        Console.WriteLine("Câu b - Các môn thuộc hệ CD:");

        foreach (var mon in cauB)
        {
            Console.WriteLine(
                mon.MaMon + " - " +
                mon.TenMon + " - " +
                mon.SoTiet + " tiết"
            );
        }

        Console.WriteLine();


        // Câu c
        // Tên môn có chứa từ "web"
        // Không phân biệt chữ hoa/chữ thường
        var cauC = ds
            .Where(x => x.TenMon.ToLower().Contains("web"))
            .Select(x => new
            {
                x.TenMon,
                x.He
            });

        Console.WriteLine("Câu c - Các môn có tên chứa từ 'web':");

        foreach (var mon in cauC)
        {
            Console.WriteLine(
                mon.TenMon + " - " +
                mon.He
            );
        }

        Console.WriteLine();


        // Câu d
        // Các môn thuộc hệ KTV
        // Sắp xếp tăng dần theo mã môn
        var cauD = ds
            .Where(x => x.He == "KTV")
            .OrderBy(x => x.MaMon);

        Console.WriteLine("Câu d - Các môn thuộc hệ KTV:");

        foreach (var mon in cauD)
        {
            Console.WriteLine(
                mon.MaMon + " - " +
                mon.TenMon
            );
        }

        Console.WriteLine();
    }
}
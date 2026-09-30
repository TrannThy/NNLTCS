using System;

// LỚP CHA
class NhanVien1
{
    // FIELD
    protected string maNV;
    protected string hoTen;

    // CONSTRUCTOR
    public NhanVien1(string maNV, string hoTen)
    {
        this.maNV = maNV;
        this.hoTen = hoTen;
    }

    // METHOD
    public virtual double TinhLuong()
    {
        return 0;
    }

    // METHOD
    public virtual void Output()
    {
        Console.WriteLine("Ma NV: " + maNV);
        Console.WriteLine("Ho ten: " + hoTen);
    }
}

// LỚP CON: NHÂN VIÊN KINH DOANH
class NhanVienKinhDoanh : NhanVien1
{
    // FIELD
    private double luongCoBan;
    private int soHopDong;

    // CONSTRUCTOR
    public NhanVienKinhDoanh(
        string maNV,
        string hoTen,
        double luongCoBan,
        int soHopDong) : base(maNV, hoTen)
    {
        this.luongCoBan = luongCoBan;
        this.soHopDong = soHopDong;
    }

    // METHOD
    public override double TinhLuong()
    {
        return luongCoBan + soHopDong * 500000;
    }

    // METHOD
    public override void Output()
    {
        base.Output();

        Console.WriteLine("Luong co ban: " + luongCoBan);
        Console.WriteLine("So hop dong: " + soHopDong);
        Console.WriteLine("Luong: " + TinhLuong());
    }
}

// LỚP CON: NHÂN VIÊN SẢN XUẤT
class NhanVienSanXuat : NhanVien1
{
    // FIELD
    private int soSanPham;

    // CONSTRUCTOR
    public NhanVienSanXuat(
        string maNV,
        string hoTen,
        int soSanPham) : base(maNV, hoTen)
    {
        this.soSanPham = soSanPham;
    }

    // METHOD
    public override double TinhLuong()
    {
        double luong = soSanPham * 1000;

        if (soSanPham > 3000)
        {
            luong = luong * 1.05;
        }

        return luong;
    }

    // METHOD
    public override void Output()
    {
        base.Output();

        Console.WriteLine("So san pham: " + soSanPham);
        Console.WriteLine("Luong: " + TinhLuong());
    }
}

class Bai3_5
{
    static void Main()
    {
        NhanVienKinhDoanh nv1 =
            new NhanVienKinhDoanh("KD01", "Nguyen Van An", 8000000, 5);

        NhanVienSanXuat nv2 =
            new NhanVienSanXuat("SX01", "Tran Van Binh", 3500);

        Console.WriteLine("NHAN VIEN KINH DOANH");
        nv1.Output();

        Console.WriteLine();

        Console.WriteLine("NHAN VIEN SAN XUAT");
        nv2.Output();
    }
}
using System;

class NhanVien
{
    private string hoTen;
    private double mucLuong;
    private int soNgayVang;

    public NhanVien()
    {
        hoTen = "";
        mucLuong = 0;
        soNgayVang = 0;
    }

    public void Input()
    {
        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine()!;

        Console.Write("Nhap muc luong: ");
        mucLuong = double.Parse(Console.ReadLine()!);

        Console.Write("Nhap so ngay vang: ");
        soNgayVang = int.Parse(Console.ReadLine()!);
    }

    public double TinhLuong()
    {
        return mucLuong - soNgayVang * 100000;
    }
}

class PhongBan
{
    // FIELD
    private NhanVien[] dsNhanVien;

    // CONSTRUCTOR
    public PhongBan(int n)
    {
        dsNhanVien = new NhanVien[n];

        for (int i = 0; i < n; i++)
        {
            dsNhanVien[i] = new NhanVien();
        }
    }

    // INDEXER
    public NhanVien this[int i]
    {
        get { return dsNhanVien[i]; }
        set { dsNhanVien[i] = value; }
    }

    // NHẬP
    public void Input()
    {
        for (int i = 0; i < dsNhanVien.Length; i++)
        {
            Console.WriteLine("\nNhan vien thu " + (i + 1));
            dsNhanVien[i].Input();
        }
    }

    // TÍNH TỔNG LƯƠNG
    public double TinhTongLuong()
    {
        double tong = 0;

        for (int i = 0; i < dsNhanVien.Length; i++)
        {
            tong += dsNhanVien[i].TinhLuong();
        }

        return tong;
    }
}

class Bai2_7
{
    static void Main()
    {
        Console.Write("Nhap so nhan vien: ");
        int n = int.Parse(Console.ReadLine()!);

        PhongBan p = new PhongBan(n);

        p.Input();

        Console.WriteLine("\nTong luong cua phong ban: "
            + p.TinhTongLuong() + " VNĐ");
    }
}
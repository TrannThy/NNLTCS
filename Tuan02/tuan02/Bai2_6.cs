using System;

class PhanSo
{
    private int tu;
    private int mau;

    public PhanSo()
    {
        tu = 0;
        mau = 1;
    }

    public PhanSo(int tu, int mau)
    {
        this.tu = tu;
        this.mau = mau;
    }

    public void Input()
    {
        Console.Write("Nhap tu so: ");
        tu = int.Parse(Console.ReadLine()!);

        Console.Write("Nhap mau so: ");
        mau = int.Parse(Console.ReadLine()!);
    }

    public void Output()
    {
        Console.Write(tu + "/" + mau);
    }

    public PhanSo Cong(PhanSo p)
    {
        return new PhanSo(
            tu * p.mau + p.tu * mau,
            mau * p.mau
        );
    }
}

class DayPhanSo
{
    // FIELD
    private PhanSo[] a;

    // CONSTRUCTOR
    public DayPhanSo(int n)
    {
        a = new PhanSo[n];

        for (int i = 0; i < n; i++)
        {
            a[i] = new PhanSo();
        }
    }

    // INDEXER
    public PhanSo this[int i]
    {
        get { return a[i]; }
        set { a[i] = value; }
    }

    // NHẬP
    public void Input()
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine("Nhap phan so thu " + (i + 1) + ":");
            a[i].Input();
        }
    }

    // TÍNH TỔNG
    public PhanSo TinhTong()
    {
        PhanSo tong = new PhanSo();

        for (int i = 0; i < a.Length; i++)
        {
            tong = tong.Cong(a[i]);
        }

        return tong;
    }
}

class Bai2_6
{
    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine()!);

        DayPhanSo d = new DayPhanSo(n);

        d.Input();

        PhanSo tong = d.TinhTong();

        Console.Write("Tong cac phan so: ");
        tong.Output();
    }
}
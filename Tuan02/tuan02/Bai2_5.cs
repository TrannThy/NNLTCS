using System;

class DonThuc
{
    private double a;
    private int n;

    public DonThuc()
    {
        a = 0;
        n = 0;
    }

    public DonThuc(double a, int n)
    {
        this.a = a;
        this.n = n;
    }

    public DonThuc(DonThuc d)
    {
        a = d.a;
        n = d.n;
    }

    public double TinhGiaTri(double x)
    {
        return a * Math.Pow(x, n);
    }

    public override string ToString()
    {
        return a + "x^" + n;
    }
}

class DaThuc
{
    // FIELD
    private DonThuc[] a;

    // DEFAULT CONSTRUCTOR
    public DaThuc()
    {
        a = new DonThuc[0];
    }

    // CONSTRUCTOR CÓ THAM SỐ
    public DaThuc(int n)
    {
        a = new DonThuc[n + 1];

        for (int i = 0; i <= n; i++)
        {
            a[i] = new DonThuc(0, i);
        }
    }

    // COPY CONSTRUCTOR
    public DaThuc(DaThuc d)
    {
        a = new DonThuc[d.a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = new DonThuc(d.a[i]);
        }
    }

    // INDEXER
    public DonThuc this[int i]
    {
        get { return a[i]; }
        set { a[i] = value; }
    }

    // NHẬP
    public void Input()
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write("Nhap he so a" + i + ": ");
            double heSo = double.Parse(Console.ReadLine()!);

            a[i] = new DonThuc(heSo, i);
        }
    }

    // XUẤT
    public void Output()
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (i > 0 && a[i].TinhGiaTri(1) >= 0)
                Console.Write("+");

            Console.Write(a[i]);
        }

        Console.WriteLine();
    }

    // TÍNH GIÁ TRỊ ĐA THỨC
    public double TinhGiaTri(double x)
    {
        double tong = 0;

        for (int i = 0; i < a.Length; i++)
        {
            tong += a[i].TinhGiaTri(x);
        }

        return tong;
    }
}

class Bai2_5
{
    static void Main()
    {
        Console.Write("Nhap bac cua da thuc n: ");
        int n = int.Parse(Console.ReadLine()!);

        DaThuc p = new DaThuc(n);

        p.Input();

        Console.Write("Da thuc: ");
        p.Output();

        Console.Write("Nhap x: ");
        double x = double.Parse(Console.ReadLine()!);

        Console.WriteLine("P(" + x + ") = " + p.TinhGiaTri(x));
    }
}
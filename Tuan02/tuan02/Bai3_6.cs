using System;

// LỚP CHA
class ThiSinh1
{
    // FIELD
    protected string sbd;
    protected string hoTen;
    protected double bai1;
    protected double bai2;
    protected double bai3;

    // CONSTRUCTOR
    public ThiSinh1(
        string sbd,
        string hoTen,
        double bai1,
        double bai2,
        double bai3)
    {
        this.sbd = sbd;
        this.hoTen = hoTen;
        this.bai1 = bai1;
        this.bai2 = bai2;
        this.bai3 = bai3;
    }

    // METHOD
    public virtual double TinhTongDiem()
    {
        return bai1 + bai2 + bai3;
    }

    // METHOD
    public virtual void Output()
    {
        Console.WriteLine("SBD: " + sbd);
        Console.WriteLine("Ho ten: " + hoTen);
        Console.WriteLine("Tong diem: " + TinhTongDiem());
    }
}

// LỚP CON: CHUYÊN
class Chuyen : ThiSinh1
{
    // FIELD
    private double tiengAnh;

    // CONSTRUCTOR
    public Chuyen(
        string sbd,
        string hoTen,
        double bai1,
        double bai2,
        double bai3,
        double tiengAnh)
        : base(sbd, hoTen, bai1, bai2, bai3)
    {
        this.tiengAnh = tiengAnh;
    }

    // METHOD
    public override double TinhTongDiem()
    {
        double tong = bai1 + bai2 + bai3;

        if (tiengAnh >= 7 && tiengAnh <= 8)
        {
            tong = tong + 1;
        }
        else if (tiengAnh >= 9 && tiengAnh <= 10)
        {
            tong = tong + 2;
        }

        return tong;
    }

    // METHOD
    public override void Output()
    {
        Console.WriteLine("Thi sinh Chuyen");
        base.Output();
        Console.WriteLine("Diem tieng Anh: " + tiengAnh);
    }
}

// LỚP CON: SIÊU CÚP
class SieuCup : ThiSinh1
{
    // FIELD
    private double csdl;

    // CONSTRUCTOR
    public SieuCup(
        string sbd,
        string hoTen,
        double bai1,
        double bai2,
        double bai3,
        double csdl)
        : base(sbd, hoTen, bai1, bai2, bai3)
    {
        this.csdl = csdl;
    }

    // METHOD
    public override double TinhTongDiem()
    {
        return bai1 + bai2 + bai3 + csdl;
    }

    // METHOD
    public override void Output()
    {
        Console.WriteLine("Thi sinh Sieu cup");
        base.Output();
        Console.WriteLine("Diem CSDL: " + csdl);
    }
}

class Bai3_6
{
    static void Main()
    {
        Console.Write("Nhap so thi sinh: ");
        int n = int.Parse(Console.ReadLine()!);

        ThiSinh1[] ds = new ThiSinh1[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nThi sinh thu " + (i + 1));

            Console.Write("Nhap loai thi sinh (1-Chuyen, 2-Sieu cup): ");
            int loai = int.Parse(Console.ReadLine()!);

            Console.Write("Nhap SBD: ");
            string sbd = Console.ReadLine()!;

            Console.Write("Nhap ho ten: ");
            string hoTen = Console.ReadLine()!;

            Console.Write("Nhap diem bai 1: ");
            double bai1 = double.Parse(Console.ReadLine()!);

            Console.Write("Nhap diem bai 2: ");
            double bai2 = double.Parse(Console.ReadLine()!);

            Console.Write("Nhap diem bai 3: ");
            double bai3 = double.Parse(Console.ReadLine()!);

            if (loai == 1)
            {
                Console.Write("Nhap diem tieng Anh: ");
                double tiengAnh = double.Parse(Console.ReadLine()!);

                ds[i] = new Chuyen(
                    sbd, hoTen, bai1, bai2, bai3, tiengAnh);
            }
            else
            {
                Console.Write("Nhap diem CSDL: ");
                double csdl = double.Parse(Console.ReadLine()!);

                ds[i] = new SieuCup(
                    sbd, hoTen, bai1, bai2, bai3, csdl);
            }
        }

        Console.WriteLine("\n KET QUA ");

        for (int i = 0; i < n; i++)
        {
            ds[i].Output();
            Console.WriteLine();
        }
    }
}
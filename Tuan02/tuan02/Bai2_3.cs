using System;

class DaySo
{
    // FIELD
    private int[] a;

    // DEFAULT CONSTRUCTOR
    public DaySo()
    {
        a = new int[0];
    }

    // CONSTRUCTOR CÓ THAM SỐ
    public DaySo(int n)
    {
        a = new int[n];
    }

    // COPY CONSTRUCTOR
    public DaySo(DaySo d)
    {
        a = new int[d.a.Length];

        for (int i = 0; i < d.a.Length; i++)
        {
            a[i] = d.a[i];
        }
    }

    // INDEXER
    public int this[int i]
    {
        get { return a[i]; }
        set { a[i] = value; }
    }

    // NHẬP DÃY
    public void Input()
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write("Nhap a[" + i + "]: ");
            a[i] = int.Parse(Console.ReadLine()!);
        }
    }

    // XUẤT DÃY
    public void Output()
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + " ");
        }

        Console.WriteLine();
    }

    // TÌM CÁC SỐ CHẴN
    public void TimSoChan()
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] % 2 == 0)
            {
                Console.Write(a[i] + " ");
            }
        }

        Console.WriteLine();
    }
}

class Bai2_3
{
    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine()!);

        DaySo d = new DaySo(n);

        d.Input();

        Console.WriteLine("Day so:");
        d.Output();

        Console.WriteLine("Cac so chan:");
        d.TimSoChan();
    }
}
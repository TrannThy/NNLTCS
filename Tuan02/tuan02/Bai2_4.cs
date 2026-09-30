using System;

class Mang2Chieu
{
    // FIELD
    private int[,] a;

    // DEFAULT CONSTRUCTOR
    public Mang2Chieu()
    {
        a = new int[0, 0];
    }

    // CONSTRUCTOR CÓ THAM SỐ
    public Mang2Chieu(int n, int m)
    {
        a = new int[n, m];
    }

    // COPY CONSTRUCTOR
    public Mang2Chieu(Mang2Chieu b)
    {
        int n = b.a.GetLength(0);
        int m = b.a.GetLength(1);

        a = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                a[i, j] = b.a[i, j];
            }
        }
    }

    // INDEXER
    public int this[int i, int j]
    {
        get { return a[i, j]; }
        set { a[i, j] = value; }
    }

    // NHẬP
    public void Input()
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write("Nhap a[" + i + "," + j + "]: ");
                a[i, j] = int.Parse(Console.ReadLine()!);
            }
        }
    }

    // XUẤT
    public void Output()
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write(a[i, j] + "\t");
            }

            Console.WriteLine();
        }
    }

    // KIỂM TRA SỐ NGUYÊN TỐ
    private bool LaSoNguyenTo(int n)
    {
        if (n < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    // TÌM CÁC SỐ NGUYÊN TỐ
    public void TimSoNguyenTo()
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (LaSoNguyenTo(a[i, j]))
                {
                    Console.Write(a[i, j] + " ");
                }
            }
        }

        Console.WriteLine();
    }
}

class Bai2_4
{
    static void Main()
    {
        Console.Write("Nhap so dong n: ");
        int n = int.Parse(Console.ReadLine()!);

        Console.Write("Nhap so cot m: ");
        int m = int.Parse(Console.ReadLine()!);

        Mang2Chieu a = new Mang2Chieu(n, m);

        a.Input();

        Console.WriteLine("\nMang 2 chieu:");
        a.Output();

        Console.WriteLine("\nCac so nguyen to:");
        a.TimSoNguyenTo();
    }
}
using System;

class Donthuc
{
    // field
    private double a;
    private int n;

    // constructor mặc nhiên
    public Donthuc()
    {
        a= 0;
        n= 0;
    }

    // constructor co tham so
    public Donthuc(double a, int n)
    {
        this.a= a;
        this.n= n;
    }

    // property
    public double A
    {
        get {return a;}
        set {a= value;}
    }

    public int N
    {
        get {return n;}
        set {n= value;}
    }

    // tinh giá trị đơn thức P(x) = a*x^n
    public double Tinhgiatri(double x)
    {
        return a*Math.Pow(x,n);
    }

    // tính đạo hàm P'(x) = a*n*x^(n-1)
    public Donthuc Daoham()
    {
        if (n == 0)
        {
            return new Donthuc(0, 0);
        }

        return new Donthuc(a*n,n-1);
    }

    // xuất đơn thức
    public override string ToString()
    {
        return a+"x^"+n;
    }
}

class Bai1_5
{
    static void Main()
    {
        double a= 3;
        int n= 4;
        double x= 3;

        Donthuc p= new Donthuc(a,n);

        Console.WriteLine("don thuc: "+p);
        Console.WriteLine("gia tri P("+x+ ")= "+p.Tinhgiatri(x));

        Donthuc q = p.Daoham();

        Console.WriteLine("dao ham: "+q);
    }
    
}
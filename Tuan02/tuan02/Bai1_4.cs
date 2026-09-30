
using System;

class Phanso
{
    // field
    private int tu;
    private int mau;
    //constructor mặc nhiên
    public Phanso()
    {
        tu=0;
        mau=1;
    }

    //constructor có tham số
    public Phanso(int tu, int mau)
    {
        this.tu= tu;
        this.mau=mau;
    }

    //constructor sao chép
    public Phanso(Phanso p)
    {
        this.tu = p.tu;
        this.mau = p.mau;
    }

    //property
    public int Tu
    {
        get{return tu;}
        set{tu=value;}
    }

    public int Mau
    {
        get{return mau;}
        set{mau=value;}
    }

    //override Tostring()
    public override string ToString()
    {
        return tu+"/"+mau;
    }

    // toan tu mot ngoi +
    public static Phanso operator +(Phanso p)
    {
        return new Phanso(p.tu, p.mau);
    }

    // toan tu mot ngoi -
    public static Phanso operator -(Phanso p)
    {
        return new Phanso(-p.tu, p.mau);
    }

    // toan tu hai ngoi +
    public static Phanso operator +(Phanso p1, Phanso p2)
    {
        return new Phanso(
            p1.tu * p2.mau + p2.tu * p1.mau,
            p1.mau * p2.mau
        );
    }

    // toan tu hai ngoi -
    public static Phanso operator -(Phanso p1, Phanso p2)
    {
        return new Phanso(
            p1.tu * p2.mau - p2.tu * p1.mau,
            p1.mau * p2.mau
        );
    }

    // toan tu *
    public static Phanso operator *(Phanso p1, Phanso p2)
    {
        return new Phanso(
            p1.tu * p2.tu,
            p1.mau * p2.mau
        );
    }

    // toan tu /
    public static Phanso operator /(Phanso p1, Phanso p2)
    {
        return new Phanso(
            p1.tu * p2.mau,
            p1.mau * p2.tu
        );
    }

    // toan tu>
    public static bool operator > (Phanso p1, Phanso p2)
    {
        return p1.tu * p2.mau > p2.tu * p1.mau;
    }

    //toan tu <
    public static bool operator <(Phanso p1, Phanso p2)
    {
        return p1.tu * p2.mau < p2.tu * p1.mau;
    }

    //toan tu >=
    public static bool operator >=(Phanso p1, Phanso p2)
    {
        return p1.tu * p2.mau >= p2.tu * p1.mau;
    }

    // toan tu <=
    public static bool operator <=(Phanso p1, Phanso p2)
    {
        return p1.tu * p2.mau <= p2.tu * p1.mau;
    }

    //toan tu ==
    public static bool operator ==(Phanso p1, Phanso p2)
    {
        return p1.tu * p2.mau == p2.tu * p1.mau;
    }

    // toan tu !=
    public static bool operator !=(Phanso p1, Phanso p2)
    {
        return p1.tu * p2.mau != p2.tu * p1.mau;
    }
}

class Bai1_4
{
    static void Main()
    {
        Phanso p1 = new Phanso(1, 2);
        Phanso p2 = new Phanso(1, 3);

        Console.WriteLine("p1 = " + p1);
        Console.WriteLine("p2 = " + p2);

        Phanso p3 = p1 + p2;
        Console.WriteLine("p1 + p2 = " + p3);

        Phanso p4 = p1 - p2;
        Console.WriteLine("p1 - p2 = " + p4);

        Phanso p5 = p1 * p2;
        Console.WriteLine("p1 * p2 = " + p5);

        Phanso p6 = p1 / p2;
        Console.WriteLine("p1 / p2 = " + p6);

        Console.WriteLine("p1 > p2: " + (p1 > p2));
        Console.WriteLine("p1 < p2: " + (p1 < p2));
        Console.WriteLine("p1 == p2: " + (p1 == p2));

        Console.WriteLine("-p1 = " + (-p1));
    }
}
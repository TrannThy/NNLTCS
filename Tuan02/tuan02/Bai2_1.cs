using System;
using System.Collections;

class point
{
    private double x;
    private double y;

    public point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString()
    {
        return "(" + x + ", " + y + ")";
    }
}

class Arraypoint
{
    // field
    // Arraylist lưu các Point
    private ArrayList dsPoint;

    public Arraypoint()
    {
        dsPoint = new ArrayList();
    }

    // indexer
    // truy cập Point thứ i
    public point this[int i]
    {
        get { return (point)dsPoint[i]; }
        set { dsPoint[i] = value; }
    }

    // thêm Point vào ArrayList
    public void Them(point p)
    {
        dsPoint.Add(p);
    }
}

class Bai2_1
{
    static void Main()
    {
        Arraypoint a = new Arraypoint();

        a.Them(new point(1, 2));
        a.Them(new point(3, 4));
        a.Them(new point(5, 6));

        Console.WriteLine("Point thu 0: " + a[0]);
        Console.WriteLine("Point thu 1: " + a[1]);
        Console.WriteLine("Point thu 2: " + a[2]);
    }
}
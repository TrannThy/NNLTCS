using System;

class Point
{
    // field
    private double x;
    private double y;

    //constructor mac dinh
    public Point()
    {
        x = 0;
        y = 0;
    }

    // constructor co tham so
    public Point(double x, double y)
    {
        this.x=x;
        this.y=y;
    }

    // property
    public double X
    {
        get{return x;}
        set{x =value;}
    }

    public double Y
    {
        get { return y; }
        set { y = value; }
    }

    // method nhap
    public void Input()
    {
        Console.Write("nhap x: ");
        x = double.Parse(Console.ReadLine()!);

        Console.Write("nhap y: ");
        y = double.Parse(Console.ReadLine()!);
    }

    // method xuat
    public void Output()
    {
        Console.WriteLine("(" +x +","+y+")");
    }

    // override Tostring()
    public override string ToString()
    {
        return "("+x+","+y +")";
    }
    // phep cong 2 point
    public static Point operator +(Point A, Point B)//A(x,y)+B(x,y)
    {
        return new Point(A.x+B.x, A.y+B.y);
    }

    // phep tru 2 point
    public static Point operator -(Point A, Point B)
    {
        return new Point(A.x-B.x, A.y-B.y);
    }
     //lay âm point
    public static Point operator -(Point A)
    {
        return new Point(-A.x,-A.y);
    }

    //khoang cach giua 2 diem_ pt thanh vien
    public double KhoangCach(Point B)
    {
        double dx = x - B.x;//lay A tinh khoang cach voi B
        double dy = y - B.y;

        return Math.Sqrt(dx * dx + dy * dy); //căn (x2-x1)bình +(y2-y1)bình
    }

    // khoang cach giua 2 diem_ pt tĩnh
    public static double KhoangCach(Point A, Point B)
    {
        double dx = A.x - B.x;// lay ca A B tinh khoang cach 
        double dy = A.y - B.y;

        return Math.Sqrt(dx * dx + dy * dy);
    }

    // trung diem_ pt thanh vien
    public Point TrungDiem(Point B)
    {
        double xI = (x + B.x) / 2;// lay A tinh trung diem voi B
        double yI = (y + B.y) / 2;

        return new Point(xI, yI);
    }

    // trung diem_ pt tinh
    public static Point TrungDiem(Point A, Point B)
    {
        double xI = (A.x + B.x) / 2;// lay ca 2 A B tinh trung diem
        double yI = (A.y + B.y) / 2;

        return new Point(xI, yI);
    }

    
}
class Bai1_2
{
    static void Main()
    {
        // //tao 2 diem
        Point A = new Point();
        Point B = new Point();

        //nhap
        Console.WriteLine("nhap diem A:");
        A.Input();

        Console.WriteLine("nhap diem B:");
        B.Input();

        //xuat
        Console.WriteLine("diem A: "+A);
        Console.WriteLine("diem B: "+B);

        //khoang cach - phuong thuc thanh vien
        Console.WriteLine("khoang cach AB (thanh vien): " + A.KhoangCach(B));

        //khoang cach - phuong thuc tinh
        Console.WriteLine("khoang cach AB (tinh): " + Point.KhoangCach(A, B));

        //trung diem - phuong thuc thanh vien
        Point I1 = A.TrungDiem(B);
        Console.WriteLine("trung diem I (thanh vien): " + I1);

        //trung diem - phuong thuc tinh
        Point I2 = Point.TrungDiem(A, B);
        Console.WriteLine("trung diem I (tinh): " + I2);

        //phep cong
        Point C = A + B;//operator +(A,B)
        Console.WriteLine("A + B = " + C);

        //phep tru
        Point D = A - B;//operator -(A,B)
        Console.WriteLine("A - B = " + D);

        //lay am
        Point E = -A;//operator -(A)
        Point F = -B;//operator -(A)
        Console.WriteLine("-A = " + E);
        Console.WriteLine("-B = " + F);
    }
}
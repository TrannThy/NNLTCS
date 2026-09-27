using System;

class Bai1_1
{
    // field
    private string Hoten;
    private int Namsinh;

    //constructor mặc định
    public Bai1_1()
    {
        Hoten="";//gia tri ban đầu
        Namsinh =0;
    }

    // constructor co tham so
    public Bai1_1(string Hoten, int Namsinh)
    {
        this.Hoten=Hoten;
        this.Namsinh=Namsinh;
    }

    // property
    public string HoTen
    {
        get{ return Hoten; }//lay gia tri
        set{ Hoten=value; }//gan gia trị moi
    }

    public int NamSinh
    {
        get{ return Namsinh; }
        set{ Namsinh=value; }
    }

    // method tinh tuoi
    public int TinhTuoi()
    {
        return DateTime.Now.Year -Namsinh;//lay nam hien tại tru nam sinh
    }

    // method xuat thong tin
    public void Xuat()
    {
        Console.WriteLine("ho ten: " +Hoten);
        Console.WriteLine("nam sinh: "+ Namsinh);
        Console.WriteLine("tuoi: " + TinhTuoi());
    }
    public void Nhap()
    {
        Console.Write("nhap ho ten: ");
        Hoten = Console.ReadLine()!;

        Console.Write("nhap nam sinh: ");
        Namsinh = int.Parse(Console.ReadLine()!);
    }
        static void Main()
    {
        Bai1_1 bai1_1=new Bai1_1();

        bai1_1.Nhap();
        bai1_1.Xuat();
    }
}


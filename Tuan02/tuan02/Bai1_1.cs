using System;

class Thongtin
{
    // FIELD
    private string Hoten;
    private int Namsinh;

    // CONSTRUCTOR mặc định
    public Thongtin()
    {
        Hoten = "";
        Namsinh = 0;
    }

    // CONSTRUCTOR có tham số
    public Thongtin(string Hoten, int Namsinh)
    {
        this.Hoten = Hoten;
        this.Namsinh = Namsinh;
    }

    // PROPERTY
    public string HoTen
    {
        get { return Hoten; }
        set { Hoten = value; }
    }

    public int NamSinh
    {
        get { return Namsinh; }
        set { Namsinh = value; }
    }

    // METHOD tính tuổi
    public int TinhTuoi()
    {
        return DateTime.Now.Year - Namsinh;
    }

    // METHOD nhập thông tin
    public void Nhap()
    {
        Console.Write("nhap ho ten: ");
        Hoten = Console.ReadLine()!;

        Console.Write("nhap nam sinh: ");
        Namsinh = int.Parse(Console.ReadLine()!);
    }

    // METHOD xuất thông tin
    public void Xuat()
    {
        Console.WriteLine("ho ten: " + Hoten);
        Console.WriteLine("nam sinh: " + Namsinh);
        Console.WriteLine("tuoi: " + TinhTuoi());
    }
}

class Bai1_1
{
    public static void Main()
    {
        Thongtin thongtin = new Thongtin();

        thongtin.Nhap();
        thongtin.Xuat();
    }
}
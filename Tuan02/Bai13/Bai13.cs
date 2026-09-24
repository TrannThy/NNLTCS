//nhap xuat thong tin sinh vien

class Bai13
{
    public string Masv;//khai bao thuoc tinh
    public string Hoten;
    public string Diachi;
    public int Namhoc;
    public void Nhap()//nhap thong tin
    {
        Console.WriteLine("nhap ma sinh vien");
        Masv=Console.ReadLine()!;

        Console.WriteLine("nhap ho ten: ");
        Hoten=Console.ReadLine()!;

        Console.WriteLine("nhap dia chi: ");
        Diachi=Console.ReadLine()!;

        Console.WriteLine("nhap so nam hoc: ");
        Namhoc=int.Parse(Console.ReadLine()!);
    }
    public void Xuat()//xuat thong tin
    {
        Console.WriteLine("ma sinh vien: "+Masv);
        Console.WriteLine(Hoten);
        Console.WriteLine("dia chi: "+Diachi);
        Console.WriteLine("sinh vien nam: "+Namhoc);
    }
}
class Program()
{
    static void Main()
    {
        Bai13 bai13=new Bai13();
        bai13.Nhap();
        bai13.Xuat();
    }
}
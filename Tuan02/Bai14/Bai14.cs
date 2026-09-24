//tinh luong 1 nhan vien
class Bai14
{
    public string Hoten;//khai bao
    public int Mucluong;
    public int Songayvang;
    public void Nhap()//nhap thong tin
    {
        Console.WriteLine("nhap ho ten: ");
        Hoten=Console.ReadLine()!;

        Console.WriteLine("nhap muc luong: ");
        Mucluong=int.Parse(Console.ReadLine()!);

        Console.WriteLine("nhap so ngay vang: ");
        Songayvang=int.Parse(Console.ReadLine()!);
    }
    public int Tinhluong()
    {
        return Mucluong-Songayvang*100000;//tinh luong
    }
    public void Xuat()//xuat thong tin
    {
        Console.WriteLine(Hoten);
        Console.WriteLine("luong: "+Tinhluong());
    }
}
class Program
{
    static void Main()
    {
        Bai14 bai14=new Bai14();
        bai14.Nhap();
        bai14.Tinhluong();
        bai14.Xuat();
    }
}
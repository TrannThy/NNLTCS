//mảng
class Bai15
{
    public int[] a;
    //nhap mang
    public void Nhap()
    {
        Console.Write("nhap so phan tu n: ");
        int n=int.Parse(Console.ReadLine()!);
        a=new int[n];

        for (int i=0;i<n;i++)
        {
            Console.Write("nhap a["+i+"]: ");
            a[i]=int.Parse(Console.ReadLine()!);
        }
    }
    //xuat mang
    public void Xuat()
    {
        Console.Write("mang: ");

        for(int i=0;i<a.Length;i++)
        {
            Console.Write(a[i]+" ");
        }
        Console.WriteLine();
    }
    //tim ptu lon nhat va ptu be nhat
    public void Timmaxmin()
    {
        int max=a[0];
        int min=a[0];
        for (int i=1;i<a.Length;i++)
        {
            if (a[i]>max)
                max=a[i];
            if (a[i]<min)
                min=a[i];
        }
        Console.WriteLine("phan tu lon nhat: "+max);
        Console.WriteLine("phan tu nho nhat: "+min);
    }
    //tim so ngto
    public int[] Isprime()
    {
        int[] ketqua=new int[a.Length];
        int dem=0;

        for(int i=0;i<a.Length;i++)
        {
            bool Prime=true;//tao bien ban dau mac dinh true

            if (a[i] < 2)//neu ptu<2 thi khong phai so ngto
               Prime=false;

            for(int j=2;j<a[i];j++)
            {
                if (a[i]%j==0)
                {
                    Prime=false;
                    break;
                }
            }
            //dem so ngto
            if (Prime)
            {
                ketqua[dem]=a[i];
                dem++;
            }
        }
        
        int[] ketquacuoi=new int[dem];//tao mang mới
        for (int i=0;i<dem;i++)
        {
            ketquacuoi[i]=ketqua[i]; //in ra 1 mang chứa cac so ngto
        }
        return ketquacuoi;
    }
}

class Program
{
    static void Main()
    {
        Bai15 bai15=new Bai15();

        bai15.Nhap();
        bai15.Xuat();
        bai15.Timmaxmin();

        int[] prime=bai15.Isprime();
        Console.Write("Cac so nguyen to: ");
        for (int i=0;i<prime.Length;i++)
        {
            Console.Write(prime[i]+" ");
        }
    }
}
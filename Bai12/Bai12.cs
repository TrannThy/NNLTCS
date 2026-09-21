class Bai12
{
    public void Xulychuoi(string s)
    {
        //doi thanh chu thuong
        string Chuoithuong=s.ToLower();
        Console.WriteLine("chuoi thuong: " + Chuoithuong);

        // doi thanh chu hoa
        string Chuoihoa=s.ToUpper();
        Console.WriteLine("chuoi hoa: " +Chuoihoa);
        //dem so tu
        string[] tu=s.Split(' ');//chia chuoi thanh nhieu phan khi có dau cach
        int dem=0;

        for (int i=0;i<tu.Length;i++)
        {
            if (tu[i] !="")
            {
                dem++;
            }
        }
        Console.WriteLine("so tu: " + dem);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("nhap chuoi: ");
        string s = Console.ReadLine()!;
        Bai12 bai12 = new Bai12();
        bai12.Xulychuoi(s);
    }
}